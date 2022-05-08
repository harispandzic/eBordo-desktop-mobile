import 'dart:typed_data';
import 'package:badges/badges.dart';
import 'package:carousel_slider/carousel_slider.dart';
import 'package:collection/collection.dart';
import 'package:ebordo_mobile/models/izvjestaj.dart';
import 'package:ebordo_mobile/models/notifikacija.dart';
import 'package:ebordo_mobile/models/utakmica.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20izvje%C5%A1tajem/prikaz_izvjestaja.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_slidable/flutter_slidable.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import 'package:loading_overlay/loading_overlay.dart';
import 'package:modal_bottom_sheet/modal_bottom_sheet.dart';
import 'package:motion_toast/motion_toast.dart';
import 'package:motion_toast/resources/arrays.dart';
import 'package:rflutter_alert/rflutter_alert.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import '../../models/izvjestaj.dart';
import '../../models/trening.dart';
import '../../services/APIService.dart';
import '../Upravljanje igračima/detalji_igraca.dart';
import '../Upravljanje rasporedom/prikaz_rasporeda.dart';
import '../Upravljanje treningom/prikaz_treninga.dart';

List<Notifikacija> dobavljeneNotifikacije = [];

class Pocetna extends StatefulWidget {
  @override
  _PocetnaState createState() => _PocetnaState();
}

class _PocetnaState extends State<Pocetna> {
  bool isDataLoading = true;
  List<Notifikacija> _obavijestiState = [];
  List<Utakmica> _utakmice = [];
  List<Utakmica> _narednaUtakmica = [];
  List<Izvjestaj> _posljednjaUtakmica = [];
  List<Trening> _treninzi = [];
  int _currentUtakmica = 0;
  int _currentTrening = 0;
  final CarouselController _controllerUtakmica = CarouselController();
  final CarouselController _controllerTrening = CarouselController();
  int pobjede = 0, porazi = 0, nerjesene = 0;

  @override
  void initState() {
    super.initState();

    Future.delayed(const Duration(seconds: 0), GetNotifikacije);
    Future.delayed(const Duration(seconds: 0), GetPosljednjaUtakmica);
    Future.delayed(const Duration(seconds: 0), GetNarednaUtakmica);
    Future.delayed(const Duration(seconds: 0), GetStatistika);
    Future.delayed(const Duration(seconds: 0), GetUtakmice);
    Future.delayed(const Duration(seconds: 0), GetTreninzi);
  }

  late List<PieChartData> data_statistika = [
    PieChartData('POBJEDE', pobjede.toDouble(), HexColor("#28A731")),
    PieChartData('PORAZI', porazi.toDouble(), Colors.red[800]!),
    PieChartData('NERJEŠENE', nerjesene.toDouble(), Colors.grey),
  ];

  Future<List<Notifikacija>> GetNotifikacije() async {
    Map<String, String>? queryParams = null;
    queryParams = {'korisnikId': '${APIService.logovaniKorisnik!.korisnikId}'};

    var result = await APIService.Get("Notifikacija", queryParams) as List;

    List<Notifikacija> notifikacijeList =
        result.map((i) => Notifikacija.fromJson(i)).toList();

    dobavljeneNotifikacije = [];
    dobavljeneNotifikacije = notifikacijeList;

    setState(() {
      _obavijestiState = [];
      _obavijestiState = dobavljeneNotifikacije;
    });

    return notifikacijeList;
  }

  Future DeleteNotifikacija(int notifikacijaId) async {
    await APIService.DeleteById("Notifikacija", notifikacijaId);
    GetNotifikacije();
    MotionToast.success(
      titleStyle: TextStyle(fontWeight: FontWeight.bold),
      description: "Notifikacija pročitana!",
      descriptionStyle: TextStyle(fontSize: 12),
      position: MOTION_TOAST_POSITION.TOP,
      animationType: ANIMATION.FROM_TOP,
      height: 40,
    ).show(context);
  }

  Future<List<Utakmica>> GetUtakmice({tipUtakmice = ""}) async {
    Map<String, String>? queryParams = null;
    queryParams = {'isSearchTop3': 'true'};

    var result = await APIService.Get("Utakmica", queryParams) as List;

    List<Utakmica> utakmiceList =
        result.map((i) => Utakmica.fromJson(i)).toList();

    setState(() {
      _utakmice = utakmiceList;
    });

    return utakmiceList;
  }

  Future<List<Utakmica>> GetNarednaUtakmica({tipUtakmice = ""}) async {
    Map<String, String>? queryParams = null;
    queryParams = {'isNarednaUtakmica': 'true'};

    var result = await APIService.Get("Utakmica", queryParams) as List;

    List<Utakmica> utakmiceList =
        result.map((i) => Utakmica.fromJson(i)).toList();

    setState(() {
      _narednaUtakmica = utakmiceList;
    });

    return utakmiceList;
  }

  Future<List<Izvjestaj>> GetPosljednjaUtakmica({tipUtakmice = ""}) async {
    Map<String, String>? queryParams = null;
    queryParams = {'isSearchZadnjaUtakmica': 'true'};

    var result = await APIService.Get("Izvještaj", queryParams) as List;

    List<Izvjestaj> utakmiceList =
        result.map((i) => Izvjestaj.fromJson(i)).toList();

    setState(() {
      _posljednjaUtakmica = utakmiceList;
    });

    return utakmiceList;
  }

  Future<List<Trening>> GetTreninzi(
      {lokacijaTreninga = "", bool isZavrsen = false}) async {
    Map<String, String>? queryParams = null;
    queryParams = {
      'isSearchTop3': 'true',
    };

    var result = await APIService.Get("Trening", queryParams) as List;

    List<Trening> treninziList =
        result.map((i) => Trening.fromJson(i)).toList();

    setState(() {
      _treninzi = treninziList;
      isDataLoading = false;
    });
    return treninziList;
  }

  Future<List<Izvjestaj>> GetStatistika() async {
    Map<String, String>? queryParams = null;
    queryParams = {'tipUtakmice': "", 'odigrana': "false"};

    var result = await APIService.Get("Izvještaj", queryParams) as List;

    List<Izvjestaj> utakmiceList =
        result.map((i) => Izvjestaj.fromJson(i)).toList();

    int tempPobjede = 0, tempPorazi = 0, tempNerjesene = 0;

    utakmiceList.forEach((element) {
      if (element.rezultat == 1) {
        tempPobjede++;
      } else if (element.rezultat == 2) {
        tempPorazi++;
      } else if (element.rezultat == 3) {
        tempNerjesene++;
      }
    });
    setState(() {
      pobjede = tempPobjede;
      porazi = tempPorazi;
      nerjesene = tempNerjesene;
      data_statistika = [
        PieChartData('POBJEDE', pobjede.toDouble(), HexColor("#28A731")),
        PieChartData('PORAZI', porazi.toDouble(), Colors.red[800]!),
        PieChartData('NERJEŠENE', nerjesene.toDouble(), Colors.grey),
      ];
    });

    return utakmiceList;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        titleSpacing: 0.0,
        title: Row(
          mainAxisAlignment: MainAxisAlignment.start,
          children: [
            Padding(
              padding: EdgeInsets.only(right: 8),
              child: Image.asset(
                'assets/fksarajevo-grb.png',
                fit: BoxFit.contain,
                height: 30,
              ),
            ),
            Text("eBORDO",
                style: GoogleFonts.oswald(
                    fontSize: 15,
                    color: Colors.white,
                    letterSpacing: 0,
                    fontWeight: FontWeight.bold)),
            SizedBox(width: 115),
            TextButton(
                child: Badge(
                  badgeColor: HexColor("#FFC107"),
                  position: BadgePosition.topEnd(top: -8, end: -5),
                  padding: EdgeInsets.all(3),
                  badgeContent: Container(
                    child: Text(_obavijestiState.length.toString(),
                        style: GoogleFonts.oswald(
                          fontSize: 11,
                          color: Colors.black,
                          letterSpacing: 0,
                        )),
                  ),
                  child: Icon(
                    Icons.notifications,
                    color: Colors.white,
                  ),
                ),
                onPressed: () => {
                      GetNotifikacije(),
                      showCupertinoModalBottomSheet(
                        context: context,
                        topRadius: Radius.circular(0),
                        builder: (context) => Container(
                          height: MediaQuery.of(context).size.height - 60,
                          child: Container(
                            child: Material(
                              child: Container(
                                decoration: BoxDecoration(
                                    borderRadius: BorderRadius.only(
                                        bottomRight: Radius.circular(0),
                                        bottomLeft: Radius.circular(0)),
                                    image: DecorationImage(
                                        fit: BoxFit.cover,
                                        image: AssetImage(
                                            'assets/login-background-slika.png'))),
                                child: Padding(
                                  padding: EdgeInsets.all(15),
                                  child: ListView(
                                    scrollDirection: Axis.vertical,
                                    shrinkWrap: true,
                                    children: [
                                      Row(
                                        children: [
                                          Text("OBAVJEŠTENJA",
                                              style: GoogleFonts.oswald(
                                                  fontSize: 20,
                                                  color: Colors.black,
                                                  letterSpacing: 0,
                                                  fontWeight: FontWeight.bold)),
                                          SizedBox(
                                            width: 185,
                                          ),
                                          Container(
                                            child: Align(
                                              alignment: Alignment(1, 1),
                                              child: InkWell(
                                                onTap: () {
                                                  Navigator.pop(context);
                                                },
                                                child: Container(
                                                  decoration: BoxDecoration(
                                                    color: Colors.grey[200],
                                                    borderRadius:
                                                        BorderRadius.circular(
                                                            12),
                                                  ),
                                                  child: Padding(
                                                    padding: EdgeInsets.all(5),
                                                    child: Icon(
                                                      Icons.close,
                                                      size: 13,
                                                      color: Colors.black,
                                                    ),
                                                  ),
                                                ),
                                              ),
                                            ),
                                          )
                                        ],
                                      ),
                                      SizedBox(
                                        height: 20,
                                      ),
                                      ListView(
                                        scrollDirection: Axis.vertical,
                                        shrinkWrap: true,
                                        children: _obavijestiState
                                            .mapIndexed((element, index) =>
                                                NotifikacijaKartica(
                                                    context,
                                                    index,
                                                    element,
                                                    DeleteNotifikacija))
                                            .toList(),
                                      )
                                    ],
                                  ),
                                ),
                              ),
                            ),
                          ),
                        ),
                      ),
                    })
          ],
        ),
        backgroundColor: HexColor("#400507"),
        actions: [
          Padding(
            padding: EdgeInsets.only(right: 10),
            child: CircleAvatar(
              radius: 16,
              backgroundColor: Colors.white,
              child: CircleAvatar(
                radius: 15.5,
                backgroundColor: Colors.white,
                child: ClipOval(
                  child: Image.memory(
                    Uint8List.fromList(APIService.logovaniKorisnik!.slika),
                    width: 30,
                    height: 30,
                    fit: BoxFit.cover,
                  ),
                ),
              ),
            ),
          ),
        ],
      ),
      drawer: Drawer(
        child: Container(
          decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(10),
              image: DecorationImage(
                  fit: BoxFit.cover,
                  image: AssetImage('assets/login-background-slika.png'))),
          child: ListView(
            children: <Widget>[
              UserAccountsDrawerHeader(
                  accountName: Text(
                      APIService.logovaniKorisnik!.ime +
                          " " +
                          APIService.logovaniKorisnik!.prezime,
                      style: GoogleFonts.oswald(
                        fontSize: 15,
                        color: Colors.white,
                        letterSpacing: 0,
                      )),
                  accountEmail: Text(APIService.logovaniKorisnik!.korisnickoIme,
                      style: GoogleFonts.oswald(
                        fontSize: 15,
                        color: Colors.white,
                        letterSpacing: 0,
                      )),
                  decoration: BoxDecoration(
                    color: Colors.black,
                    image: DecorationImage(
                      image: ExactAssetImage('assets/drawer-image.png'),
                      fit: BoxFit.cover,
                    ),
                  ),
                  currentAccountPicture: CircleAvatar(
                    backgroundColor: Colors.white,
                    child: ClipOval(
                      child: Image.memory(
                        Uint8List.fromList(APIService.logovaniKorisnik!.slika),
                        width: 70,
                        height: 70,
                        fit: BoxFit.cover,
                      ),
                    ),
                  )),
              ListTile(
                  leading: Icon(
                    Icons.home,
                    color: HexColor("#400507"),
                    size: 30,
                  ),
                  title: Text("Početna".toUpperCase(),
                      style: GoogleFonts.oswald(
                        fontSize: 16,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.w500,
                      )),
                  onTap: () {
                    Navigator.of(context).pushNamed('/pocetna');
                  }),
              ListTile(
                  leading: Icon(
                    Icons.directions_run,
                    color: HexColor("#400507"),
                    size: 30,
                  ),
                  title: Text("Igrači".toUpperCase(),
                      style: GoogleFonts.oswald(
                        fontSize: 16,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.w500,
                      )),
                  onTap: () {
                    Navigator.of(context).pushNamed('/prikaz_igraca');
                  }),
              ListTile(
                  leading: Icon(
                    Icons.account_circle,
                    color: HexColor("#400507"),
                    size: 30,
                  ),
                  title: Text("Treneri".toUpperCase(),
                      style: GoogleFonts.oswald(
                        fontSize: 16,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.w500,
                      )),
                  onTap: () {
                    Navigator.of(context).pushNamed('/prikaz_trenera');
                  }),
              ListTile(
                  leading: Icon(
                    Icons.calendar_month,
                    color: HexColor("#400507"),
                    size: 30,
                  ),
                  title: Text("Raspored utakmica".toUpperCase(),
                      style: GoogleFonts.oswald(
                        fontSize: 16,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.w500,
                      )),
                  onTap: () {
                    Navigator.of(context).pushNamed('/prikaz_rasporeda');
                  }),
              ListTile(
                  leading: Icon(
                    Icons.sports_soccer,
                    color: HexColor("#400507"),
                    size: 30,
                  ),
                  title: Text("Odigrane utakmice".toUpperCase(),
                      style: GoogleFonts.oswald(
                        fontSize: 16,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.w500,
                      )),
                  onTap: () {
                    Navigator.of(context).pushNamed('/prikaz_rezultata');
                  }),
              ListTile(
                  leading: Icon(
                    Icons.calendar_month,
                    color: HexColor("#400507"),
                    size: 30,
                  ),
                  title: Text("Raspored treninga".toUpperCase(),
                      style: GoogleFonts.oswald(
                        fontSize: 16,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.w500,
                      )),
                  onTap: () {
                    Navigator.of(context).pushNamed('/prikaz_treninga');
                  }),
              Divider(),
              ListTile(
                  leading: Icon(
                    Icons.info,
                    color: HexColor("#400507"),
                    size: 30,
                  ),
                  title: Text("O aplikaciji".toUpperCase(),
                      style: GoogleFonts.oswald(
                        fontSize: 16,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.w500,
                      )),
                  onTap: () {
                    AboutAplikacija(context);
                  }),
              ListTile(
                  leading: Icon(
                    Icons.logout,
                    color: HexColor("#400507"),
                    size: 30,
                  ),
                  title: Text("Odjava".toUpperCase(),
                      style: GoogleFonts.oswald(
                        fontSize: 16,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.w500,
                      )),
                  onTap: () {
                    Navigator.of(context).pushNamed('/login');
                  }),
            ],
          ),
        ),
      ),
      body: LoadingOverlay(
        child: Container(
          padding: EdgeInsets.all(10),
          height: MediaQuery.of(context).size.height,
          width: MediaQuery.of(context).size.width,
          decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(10),
              image: DecorationImage(
                  fit: BoxFit.cover,
                  image: AssetImage('assets/login-background-slika.png'))),
          child: ListView(
            children: [
              Row(
                children: [
                  CircleAvatar(
                    radius: 16,
                    backgroundColor: Colors.white,
                    child: CircleAvatar(
                      radius: 15.5,
                      backgroundColor: Colors.white,
                      child: ClipOval(
                        child: Image.memory(
                          Uint8List.fromList(
                              APIService.logovaniKorisnik!.slika),
                          width: 30,
                          height: 30,
                          fit: BoxFit.cover,
                        ),
                      ),
                    ),
                  ),
                  SizedBox(
                    width: 4,
                  ),
                  Text(
                      APIService.logovaniKorisnik!.ime +
                          " " +
                          APIService.logovaniKorisnik!.prezime +
                          ", dobrodošao na ",
                      style: GoogleFonts.oswald(
                          fontSize: 17,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.w400)),
                  Text("eBORDO!",
                      style: GoogleFonts.oswald(
                          fontSize: 17,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                ],
              ),
              SizedBox(
                height: 15,
              ),
              Padding(
                padding: EdgeInsets.only(left: 3),
                child: Row(
                  children: [
                    Icon(
                      Icons.sports_soccer,
                      color: Colors.black,
                      size: 18,
                    ),
                    SizedBox(
                      width: 5,
                    ),
                    Text("POSLJEDNJA UTAKMICA",
                        style: GoogleFonts.oswald(
                            fontSize: 17,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                  ],
                ),
              ),
              ListView(
                scrollDirection: Axis.vertical,
                shrinkWrap: true,
                children: _posljednjaUtakmica
                    .map((element) => IzvjestajKartica(context, element))
                    .toList(),
              ),
              SizedBox(
                height: 15,
              ),
              Padding(
                padding: EdgeInsets.only(left: 3),
                child: Row(
                  children: [
                    Icon(
                      Icons.calendar_month,
                      color: Colors.black,
                      size: 18,
                    ),
                    SizedBox(
                      width: 5,
                    ),
                    Text("NAREDNA UTAKMICA",
                        style: GoogleFonts.oswald(
                            fontSize: 17,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                  ],
                ),
              ),
              ListView(
                scrollDirection: Axis.vertical,
                shrinkWrap: true,
                children: _narednaUtakmica
                    .map((element) => UtakmicaKartica(context, element))
                    .toList(),
              ),
              SizedBox(
                height: 15,
              ),
              Padding(
                padding: EdgeInsets.only(left: 3),
                child: Row(
                  children: [
                    Icon(
                      Icons.ssid_chart,
                      color: Colors.black,
                      size: 18,
                    ),
                    SizedBox(
                      width: 5,
                    ),
                    Text("STATISTIKA",
                        style: GoogleFonts.oswald(
                            fontSize: 17,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                  ],
                ),
              ),
              SizedBox(
                height: 15,
              ),
              Container(
                height: 450,
                decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(15),
                  color: Color.fromARGB(255, 98, 105, 99).withOpacity(0.2),
                ),
                child: Padding(
                  padding: EdgeInsets.all(15),
                  child: Column(children: [
                    Row(
                      children: <Widget>[
                        new Expanded(
                          flex: 1,
                          child: Column(
                            children: <Widget>[
                              Icon(
                                Icons.check_circle,
                                color: HexColor("#28A731"),
                                size: 25,
                              ),
                              Text("POBJEDE",
                                  style: GoogleFonts.oswald(
                                      fontSize: 17,
                                      color: Colors.black,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.bold)),
                              Text(pobjede.toString(),
                                  style: GoogleFonts.oswald(
                                      fontSize: 30,
                                      color: Colors.black,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.bold)),
                            ],
                          ),
                        ),
                        new Expanded(
                          flex: 1,
                          child: Column(
                            children: <Widget>[
                              Icon(
                                CupertinoIcons.clear_circled_solid,
                                color: Colors.red[800]!,
                                size: 25,
                              ),
                              Text("PORAZI",
                                  style: GoogleFonts.oswald(
                                      fontSize: 17,
                                      color: Colors.black,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.bold)),
                              Text(porazi.toString(),
                                  style: GoogleFonts.oswald(
                                      fontSize: 30,
                                      color: Colors.black,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.bold)),
                            ],
                          ),
                        ),
                        new Expanded(
                          flex: 1,
                          child: Column(
                            children: <Widget>[
                              Icon(
                                Icons.do_disturb_on,
                                color: Colors.grey,
                                size: 25,
                              ),
                              Text("NERJEŠENE",
                                  style: GoogleFonts.oswald(
                                      fontSize: 17,
                                      color: Colors.black,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.bold)),
                              Text(nerjesene.toString(),
                                  style: GoogleFonts.oswald(
                                      fontSize: 30,
                                      color: Colors.black,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.bold)),
                            ],
                          ),
                        ),
                      ],
                    ),
                    Container(
                        child: SfCircularChart(series: <CircularSeries>[
                      PieSeries<PieChartData, String>(
                          dataSource: data_statistika,
                          pointColorMapper: (PieChartData data, _) =>
                              data.color,
                          xValueMapper: (PieChartData data, _) => data.x,
                          yValueMapper: (PieChartData data, _) => data.y)
                    ])),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: data_statistika
                          .map<Widget>((item) => opisGrafa(item.x, item.color))
                          .toList(),
                    ),
                  ]),
                ),
              ),
              SizedBox(
                height: 10,
              ),
              Padding(
                padding: EdgeInsets.only(left: 3),
                child: Row(
                  children: [
                    Icon(
                      Icons.calendar_month,
                      color: Colors.black,
                      size: 18,
                    ),
                    SizedBox(
                      width: 5,
                    ),
                    Text("NAREDNE 3 UTAKMICE",
                        style: GoogleFonts.oswald(
                            fontSize: 17,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                  ],
                ),
              ),
              CarouselSlider(
                items: _utakmice
                    .map((element) => UtakmicaKartica(context, element))
                    .toList(),
                carouselController: _controllerUtakmica,
                options: CarouselOptions(
                    autoPlayInterval: Duration(seconds: 8),
                    viewportFraction: 1,
                    enableInfiniteScroll: true,
                    initialPage: 1,
                    height: 300,
                    reverse: false,
                    autoPlay: true,
                    enlargeCenterPage: true,
                    aspectRatio: 0,
                    onPageChanged: (index, reason) {
                      setState(() {
                        _currentUtakmica = index;
                      });
                    }),
              ),
              Container(
                transform: Matrix4.translationValues(0.0, -12.0, 10.0),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: _utakmice.asMap().entries.map((entry) {
                    return GestureDetector(
                      onTap: () => _controllerUtakmica.animateToPage(entry.key),
                      child: Container(
                        width: 8.0,
                        height: 8.0,
                        margin: EdgeInsets.symmetric(horizontal: 4.0),
                        decoration: BoxDecoration(
                            shape: BoxShape.circle,
                            color: (Theme.of(context).brightness ==
                                        Brightness.dark
                                    ? Colors.white
                                    : HexColor("#400507"))
                                .withOpacity(
                                    _currentUtakmica == entry.key ? 0.9 : 0.4)),
                      ),
                    );
                  }).toList(),
                ),
              ),
              SizedBox(
                height: 10,
              ),
              Padding(
                padding: EdgeInsets.only(left: 3),
                child: Row(
                  children: [
                    Icon(
                      Icons.calendar_month,
                      color: Colors.black,
                      size: 18,
                    ),
                    SizedBox(
                      width: 5,
                    ),
                    Text("NAREDNA 3 TRENINGA",
                        style: GoogleFonts.oswald(
                            fontSize: 17,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                  ],
                ),
              ),
              CarouselSlider(
                items: _treninzi
                    .map((element) => TreningKartica(context, element))
                    .toList(),
                carouselController: _controllerTrening,
                options: CarouselOptions(
                    autoPlayInterval: Duration(seconds: 7),
                    viewportFraction: 1,
                    enableInfiniteScroll: true,
                    initialPage: 1,
                    height: 212,
                    reverse: false,
                    autoPlay: true,
                    enlargeCenterPage: true,
                    aspectRatio: 0,
                    onPageChanged: (index, reason) {
                      setState(() {
                        _currentTrening = index;
                      });
                    }),
              ),
              Container(
                transform: Matrix4.translationValues(0.0, -12.0, 10.0),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: _treninzi.asMap().entries.map((entry) {
                    return GestureDetector(
                      onTap: () => _controllerTrening.animateToPage(entry.key),
                      child: Container(
                        width: 8.0,
                        height: 8.0,
                        margin: EdgeInsets.symmetric(horizontal: 4.0),
                        decoration: BoxDecoration(
                            shape: BoxShape.circle,
                            color: (Theme.of(context).brightness ==
                                        Brightness.dark
                                    ? Colors.white
                                    : HexColor("#400507"))
                                .withOpacity(
                                    _currentTrening == entry.key ? 0.9 : 0.4)),
                      ),
                    );
                  }).toList(),
                ),
              )
            ],
          ),
        ),
        isLoading: isDataLoading,
        opacity: 0.8,
        color: Colors.white,
        progressIndicator: CircularProgressIndicator(
          color: HexColor("#400507"),
        ),
      ),
    );
  }
}

AboutAplikacija(context) {
  Alert(
      context: context,
      padding: EdgeInsets.only(top: 10, left: 15, right: 15),
      content: AboutAppContext(),
      buttons: []).show();
}

Icon getNotifikacijaTip(String tipNotifikacije) {
  Icon ikonica = Icon(
    Icons.info,
    color: HexColor("#17A2B8"),
    size: 35,
  );
  if (tipNotifikacije == "Upozorenje") {
    ikonica = Icon(
      Icons.error,
      color: HexColor("#FFC107"),
      size: 35,
    );
  } else if (tipNotifikacije == "Greška") {
    ikonica = Icon(
      CupertinoIcons.clear_circled_solid,
      color: HexColor("#DC3545"),
      size: 35,
    );
  } else if (tipNotifikacije == "Uspješno") {
    ikonica = Icon(
      Icons.check_circle,
      color: HexColor("#28A731"),
      size: 35,
    );
  }
  return ikonica;
}

Widget NotifikacijaKartica(
    context, Notifikacija notifikacija, index, DeleteNotifikacija) {
  return Container(
    margin: EdgeInsets.only(bottom: 7),
    child: Slidable(
      key: UniqueKey(),
      endActionPane: ActionPane(
        extentRatio: 0.85,
        dismissible: DismissiblePane(
          onDismissed: () async {
            DeleteNotifikacija(notifikacija.notifikacijaId);
          },
        ),
        motion: ScrollMotion(),
        children: <Widget>[
          Expanded(
            child: SizedBox.expand(
              child: Container(
                  margin: EdgeInsets.only(left: 3),
                  decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(9),
                    color: HexColor("#DC3545"),
                  ),
                  child: Align(
                    alignment: Alignment.center,
                    child: Column(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        Icon(
                          Icons.delete,
                          size: 18,
                          color: Colors.white,
                        ),
                        SizedBox(
                          height: 5,
                        ),
                        Text("Obriši",
                            style: GoogleFonts.ubuntu(
                                fontSize: 13,
                                color: Colors.white,
                                fontWeight: FontWeight.w400,
                                letterSpacing: 0)),
                      ],
                    ),
                  )),
            ),
          ),
        ],
      ),
      child: Container(
          child: Stack(
        children: [
          Container(
              height: 60,
              width: double.infinity,
              decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(9),
                color: HexColor("#DCDCDC"),
              ),
              child: Padding(
                padding: EdgeInsets.all(0),
                child: Row(
                  children: [
                    Container(
                      width: 60,
                      height: 180,
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.only(
                            topLeft: Radius.circular(10),
                            bottomLeft: Radius.circular(10)),
                      ),
                      child: Padding(
                        padding: EdgeInsets.only(left: 7),
                        child: Align(
                            alignment: Alignment.center,
                            child: getNotifikacijaTip(
                                notifikacija.tipNotifikacije)),
                      ),
                    ),
                    Container(
                      height: 180,
                      child: Column(
                        mainAxisAlignment: MainAxisAlignment.start,
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Container(
                            height: 42,
                            width: MediaQuery.of(context).size.width - 110,
                            child: Padding(
                              padding: EdgeInsets.only(top: 9, right: 10),
                              child: Text(notifikacija.tekstNotifikacije,
                                  style: GoogleFonts.ubuntu(
                                      fontSize: 11.5,
                                      color: Colors.black,
                                      fontWeight: FontWeight.w400,
                                      letterSpacing: 0)),
                            ),
                          ),
                          Container(
                            height: 18,
                            width: MediaQuery.of(context).size.width - 90,
                            child: Row(children: [
                              Icon(
                                Icons.calendar_month,
                                color: Colors.black,
                                size: 10,
                              ),
                              SizedBox(
                                width: 5,
                              ),
                              Text(
                                  DateFormat.yMMMd()
                                      .format(DateTime.parse(
                                          notifikacija.datumNotifikacije))
                                      .toString(),
                                  style: GoogleFonts.oswald(
                                    fontSize: 10,
                                    color: Colors.black,
                                    letterSpacing: 0,
                                  )),
                              SizedBox(
                                width: MediaQuery.of(context).size.width - 165,
                              ),
                              Icon(
                                Icons.swipe_left,
                                color: Colors.grey,
                                size: 11,
                              ),
                            ]),
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              ))
        ],
      )),
    ),
  );
}

Widget AboutAppContext() {
  return Column(
    mainAxisAlignment: MainAxisAlignment.center,
    crossAxisAlignment: CrossAxisAlignment.center,
    children: [
      Image.asset(
        'assets/fksarajevo-grb.png',
        fit: BoxFit.contain,
        height: 70,
      ),
      SizedBox(height: 10),
      Text("BORDO POZDRAV!",
          style: GoogleFonts.oswald(
              fontSize: 18,
              color: HexColor("#400507"),
              letterSpacing: 0,
              fontWeight: FontWeight.bold)),
      SizedBox(height: 8),
      Text("Poštovani korisniče, dobrodošao na eBordo!",
          textAlign: TextAlign.center,
          style: GoogleFonts.oswald(
              fontSize: 13,
              color: Colors.black,
              letterSpacing: 0,
              fontWeight: FontWeight.bold)),
      SizedBox(height: 8),
      Text(
          "eBordo je platforma koja treba da olakša Fudbalskom klubu Sarajevo, rukovođenje poslovnim procesima kluba. Motivisan sam, prije svega, velikom ljubavi prema Bordo klubu, ali i željom da pokažem da jedna ovakva aplikacija pomoći Fudbalskom klubu Sarajevo u vođenju poslovnih procesa i operacija, interne komunikacije i donošenju odluka te uspostavljanju efikasnog odjela za upravljanje ljudskim resursima po uzoru na sve veće svjetske klubove. Također vjerujem da bi ova aplikacija pomogla u ostvarenju boljih sportskih rezultata,a samim tim i da Bordo vitrina u budućnosti ima puno šampionskih trofeja!",
          textAlign: TextAlign.center,
          style: GoogleFonts.oswald(
              fontSize: 12,
              color: Colors.black,
              letterSpacing: 0,
              fontWeight: FontWeight.w400)),
      SizedBox(height: 8),
      Image.asset(
        'assets/loader.gif',
        fit: BoxFit.contain,
        height: 40,
      ),
      SizedBox(height: 8),
      Text("SAMO IZ LJUBAVI PREMA BORDO BOJI!",
          style: GoogleFonts.oswald(
              fontSize: 12,
              color: HexColor("#400507"),
              letterSpacing: 0,
              fontWeight: FontWeight.bold)),
      SizedBox(height: 8),
      Text("U nadi da će moja ideja zaživjeti, podržite moj rad!",
          textAlign: TextAlign.center,
          style: GoogleFonts.oswald(
              fontSize: 12,
              color: Colors.black,
              letterSpacing: 0,
              fontWeight: FontWeight.bold)),
      SizedBox(height: 8),
      Row(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Image.asset(
            'assets/github.png',
            fit: BoxFit.contain,
            height: 30,
          ),
          SizedBox(width: 7),
          Image.asset(
            'assets/linkedin.png',
            fit: BoxFit.contain,
            height: 30,
          ),
        ],
      ),
      SizedBox(height: 8),
      Text(
          "Sve pohvale, prijedloge i sugestije, pošaljite na e-mail adresu: pandzicharis@hotmail.com",
          textAlign: TextAlign.center,
          style: GoogleFonts.oswald(
              fontSize: 12.5,
              color: Colors.black,
              letterSpacing: 0,
              fontWeight: FontWeight.bold)),
      SizedBox(height: 8),
      Image.asset(
        'assets/outlook.png',
        fit: BoxFit.contain,
        height: 30,
      ),
      SizedBox(height: 10),
      Text("Copyright 2022 © Haris Pandžić. Sva prava pridržana.",
          style: GoogleFonts.ubuntu(
              fontSize: 8,
              color: Colors.black,
              fontWeight: FontWeight.bold,
              letterSpacing: 0)),
    ],
  );
}

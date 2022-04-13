// ignore_for_file: must_be_immutable
import 'dart:typed_data';
import 'package:ebordo_mobile/pages/Upravljanje%20trenerima/detalji_trenera.dart';
import 'package:expandable/expandable.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import 'package:motion_toast/motion_toast.dart';
import 'package:motion_toast/resources/arrays.dart';
import 'package:toggle_switch/toggle_switch.dart';
import '../../models/trener.dart';
import '../../services/APIService.dart';
import '../Shared/shared_app_bar.dart';

List<String> selectedStatusZaPretragu = [];

List<Trener> dobavljeniTreneri = [];
bool isTrenutniTreneri = true;

class PrikazTrenera extends StatefulWidget {
  @override
  _PrikazTreneraState createState() => _PrikazTreneraState();
}

class _PrikazTreneraState extends State<PrikazTrenera> {
  var _filterTreneraController = TextEditingController();
  List<Trener> _treneriState = [];
  bool isDataLoading = true;
  bool isPorukaPrikazana = false;

  @override
  void initState() {
    super.initState();
    Future.delayed(const Duration(seconds: 3), GetTrenere);
    GetTrenere();
    if (selectedStatusZaPretragu.length == 0) {
      GetStatusi();
    }
  }

  Future<List<Trener>> GetTrenere({isAktivan = true}) async {
    Map<String, String>? queryParams = null;
    queryParams = {'isAktivan': '${isAktivan}', 'ime': ""};

    isTrenutniTreneri = isAktivan;

    var result = await APIService.Get("Trener", queryParams) as List;

    setState(() {
      isDataLoading = false;
    });

    List<Trener> treneriList = result.map((i) => Trener.fromJson(i)).toList();

    dobavljeniTreneri = treneriList;

    FiltrirajTrenere();

    return treneriList;
  }

  void GetStatusi() {
    selectedStatusZaPretragu = [];
    selectedStatusZaPretragu.add("GLAVNI");
    selectedStatusZaPretragu.add("POMOĆNI");
  }

  VoidCallback? FiltrirajTrenere({String ime = ""}) {
    setState(() {
      _treneriState = dobavljeniTreneri;
    });

    _treneriState = _treneriState
        .where((element) =>
            selectedStatusZaPretragu.contains(element.ulogaTrenera))
        .toList();

    if (ime != "") {
      setState(() {
        _treneriState = _treneriState
            .where((element) =>
                element.korisnik.ime
                    .toLowerCase()
                    .startsWith(ime.toLowerCase()) ||
                element.korisnik.prezime
                    .toLowerCase()
                    .startsWith(ime.toLowerCase()))
            .toList();
      });
    }

    return null;
  }

  VoidCallback? OsvjeziFiltere({String ime = ""}) {
    GetTrenere(isAktivan: true);
    GetStatusi();

    setState(() {
      _treneriState = _treneriState;
    });

    MotionToast.success(
      title: "Pretraga je osvježena!",
      titleStyle: TextStyle(fontWeight: FontWeight.bold),
      description: "Za novu pretragu, koristite filtere.",
      descriptionStyle: TextStyle(fontSize: 12),
      position: MOTION_TOAST_POSITION.TOP,
      animationType: ANIMATION.FROM_TOP,
      height: 100,
    ).show(context);

    return null;
  }

  void PretragaStatusa(String status, bool isChecked) {
    bool found = selectedStatusZaPretragu.contains(status);
    if (isChecked) {
      if (found) return;
      selectedStatusZaPretragu.add(status);
    } else {
      if (found) selectedStatusZaPretragu.remove(status);
    }
  }

  bool isSelectedStatusiSadrzeStatus(String status) {
    return selectedStatusZaPretragu.contains(status);
  }

  Widget FilteriPrikazTreneraWidget() {
    return Padding(
      padding: EdgeInsets.only(left: 21, right: 21),
      child: ExpandablePanel(
        theme: ExpandableThemeData(
            inkWellBorderRadius: BorderRadius.all(Radius.circular(12))),
        header: Padding(
          padding: EdgeInsets.only(top: 5, left: 5),
          child: Row(
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              Icon(
                Icons.filter_list_outlined,
                color: HexColor("#400507"),
                size: 20,
              ),
              SizedBox(width: 5),
              Text("FILTERI",
                  style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold))
            ],
          ),
        ),
        collapsed: Text(""),
        expanded: ListView(shrinkWrap: true, children: [
          SizedBox(height: 5),
          Row(children: [
            Text("PRETRAGA TRENERA PO STATUSU",
                style: GoogleFonts.oswald(
                    fontSize: 15,
                    color: Colors.black,
                    letterSpacing: 0,
                    fontWeight: FontWeight.bold))
          ]),
          SizedBox(height: 5),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text("TRENUTNI/BIVŠI TRENERI",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
              ToggleSwitch(
                  minHeight: 22,
                  minWidth: 30.0,
                  cornerRadius: 20.0,
                  activeBgColors: [
                    [HexColor("#28A731")],
                    [Colors.red[800]!]
                  ],
                  icons: [Icons.done, Icons.close],
                  activeFgColor: Colors.white,
                  inactiveBgColor: Colors.grey,
                  inactiveFgColor: Colors.white,
                  initialLabelIndex: isTrenutniTreneri ? 0 : 1,
                  totalSwitches: 2,
                  labels: ['', ''],
                  radiusStyle: false,
                  onToggle: (index) {
                    if (index == 0) {
                      GetTrenere(isAktivan: true);
                    } else {
                      GetTrenere(isAktivan: false);
                    }
                  },
                  customTextStyles: [
                    GoogleFonts.oswald(
                        fontSize: 16,
                        color: Colors.white,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold),
                    GoogleFonts.oswald(
                        fontSize: 16,
                        color: Colors.white,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)
                  ])
            ],
          ),
          SizedBox(height: 5),
          Row(
            children: [
              Checkbox(
                activeColor: HexColor("#400507"),
                value: isSelectedStatusiSadrzeStatus("GLAVNI"),
                onChanged: (newValue) {
                  PretragaStatusa("GLAVNI", newValue!);
                  FiltrirajTrenere();
                },
              ),
              Text("GLAVNI TRENER",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
            ],
          ),
          Row(
            children: [
              Checkbox(
                activeColor: HexColor("#400507"),
                value: isSelectedStatusiSadrzeStatus("POMOĆNI"),
                onChanged: (newValue) {
                  PretragaStatusa("POMOĆNI", newValue!);
                  FiltrirajTrenere();
                },
              ),
              Text("POMOĆNI TRENER",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
            ],
          ),
          SizedBox(height: 3),
          Divider(),
          Row(
            children: [
              Text("PRETRAGA TRENERA PO IMENU I PREZIMENU",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold))
            ],
          ),
          SizedBox(
            height: 5,
          ),
          TextFormField(
            controller: _filterTreneraController,
            style: TextStyle(height: 1),
            onChanged: (text) {
              FiltrirajTrenere(ime: text);
            },
            decoration: InputDecoration(
              hintText: "ex. Musemić",
              enabledBorder: OutlineInputBorder(
                borderRadius: BorderRadius.circular(10.0),
                borderSide: BorderSide(color: HexColor("#D9D9D9"), width: 1),
              ),
              focusedBorder: OutlineInputBorder(
                borderRadius: BorderRadius.circular(10.0),
                borderSide: BorderSide(color: HexColor("#400507"), width: 1),
              ),
              labelStyle: TextStyle(color: HexColor("#400507")),
              prefixIcon: Icon(
                Icons.search,
                color: HexColor("#400507"),
              ),
              suffixIcon: IconButton(
                onPressed: _filterTreneraController.clear,
                icon: Icon(Icons.clear, color: HexColor("#7F7F7F")),
              ),
            ),
          ),
          SizedBox(
            height: 10,
          ),
          SizedBox(
            width: 200,
            height: 30,
            child: TextButton.icon(
              style: TextButton.styleFrom(
                textStyle: TextStyle(color: Colors.blue),
                backgroundColor: HexColor("#400507"),
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(9),
                ),
              ),
              onPressed: () => {OsvjeziFiltere()},
              icon: Icon(
                Icons.autorenew,
                color: Colors.white,
                size: 17,
              ),
              label: Text("OSVJEŽI FILTERE",
                  style: GoogleFonts.ubuntu(
                      fontSize: 14,
                      color: Colors.white,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
            ),
          ),
          SizedBox(height: 7),
          ExpandableButton(
            child: Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Icon(
                  Icons.close,
                  color: Colors.black,
                  size: 20,
                ),
                SizedBox(width: 3),
                Text("ZATVORI FILTERE",
                    style: GoogleFonts.oswald(
                        fontSize: 15,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold))
              ],
            ),
          ),
          SizedBox(height: 10)
        ]),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: SharedAppBar(),
        bottomNavigationBar: BottomNavigationBar(
          selectedItemColor: HexColor("#400507"),
          unselectedItemColor: HexColor("#400507"),
          selectedFontSize: 13,
          unselectedFontSize: 13,
          items: [
            BottomNavigationBarItem(
              icon: Icon(Icons.home),
              label: 'Početna',
            ),
            BottomNavigationBarItem(
              icon: Icon(Icons.calendar_month),
              label: 'Raspored',
            ),
            BottomNavigationBarItem(
              icon: Icon(Icons.sports_soccer),
              label: 'Rezultati',
            ),
          ],
        ),
        body: ListView(
          children: [
            SizedBox(height: 5),
            Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
              Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
                Padding(
                  padding: EdgeInsets.only(left: 21),
                  child: Text("PRIKAZ TRENERA",
                      style: GoogleFonts.oswald(
                          fontSize: 18,
                          color: HexColor("#400507"),
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                ),
                Padding(
                  padding: EdgeInsets.only(left: 21),
                  child:
                      Text("Ukupno trenera: " + _treneriState.length.toString(),
                          style: GoogleFonts.oswald(
                            fontSize: 11,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                ),
              ]),
              Padding(
                padding: EdgeInsets.only(right: 21),
                child: Image.asset(
                  'assets/grb-animacija.gif',
                  fit: BoxFit.contain,
                  height: 42,
                ),
              )
            ]),
            SizedBox(height: 15),
            FilteriPrikazTreneraWidget(),
            isDataLoading
                ? Padding(
                    padding: EdgeInsets.only(top: 120),
                    child: Center(
                        child: Column(
                      children: [
                        Image.asset("assets/loader.gif", height: 45.0),
                        SizedBox(height: 5),
                        Text("Učitavanje...",
                            style: GoogleFonts.oswald(
                                fontSize: 16,
                                color: Colors.black,
                                letterSpacing: 0,
                                fontWeight: FontWeight.bold))
                      ],
                    )),
                  )
                : (_treneriState.length == 0)
                    ? Padding(
                        padding: EdgeInsets.only(left: 21, right: 21),
                        child: Center(
                            child: Column(
                          mainAxisAlignment: MainAxisAlignment.center,
                          crossAxisAlignment: CrossAxisAlignment.center,
                          children: [
                            Image.asset("assets/nema-rezultata-pretrage.png",
                                height: 330.0),
                            Text("NEMA REZULTATA PRETRAGE!",
                                style: GoogleFonts.oswald(
                                    fontSize: 17,
                                    color: Colors.black,
                                    letterSpacing: 0,
                                    fontWeight: FontWeight.bold)),
                            Text(
                                "Baza podataka je pretražena i nisu pronađeni odgovarajući rezultati. Osvježite vašu pretragu!",
                                style: GoogleFonts.oswald(
                                  fontSize: 14.5,
                                  color: Colors.black,
                                  letterSpacing: 0,
                                ),
                                textAlign: TextAlign.center),
                          ],
                        )),
                      )
                    : Padding(
                        padding:
                            EdgeInsets.only(left: 21, right: 21, bottom: 20),
                        child: ListView(
                          scrollDirection: Axis.vertical,
                          shrinkWrap: true,
                          children: _treneriState
                              .map((element) => TrenerKartica(context, element))
                              .toList(),
                        ),
                      )
          ],
        ));
  }
}

Widget TrenerKartica(context, trener) {
  return Stack(
    children: [
      Padding(
        padding: EdgeInsets.only(top: 2, bottom: 2),
        child: Card(
          child: TextButton(
            style: TextButton.styleFrom(
                padding: EdgeInsets.zero,
                minimumSize: Size(50, 30),
                alignment: Alignment.centerLeft),
            onPressed: () {
              Navigator.push(
                  context,
                  MaterialPageRoute(
                      builder: (context) => DetaljiTrenera(
                            trener: trener,
                          )));
            },
            child: Container(
              height: 185,
              width: double.infinity,
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),
                  image: DecorationImage(
                      fit: BoxFit.cover,
                      image: AssetImage('assets/igrac-kartica-pozadina.png'))),
              child: Padding(
                padding: const EdgeInsets.all(0),
                child: Stack(
                  children: [
                    Container(
                        margin: EdgeInsets.fromLTRB(15, 0, 0, 0),
                        height: 300,
                        width: 100,
                        child: FittedBox(
                          child: Image.memory(
                              Uint8List.fromList(trener.slikaPanel)),
                          fit: BoxFit.cover,
                        )),
                    Padding(
                      padding: EdgeInsets.fromLTRB(125, 15, 0, 0),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Row(
                            children: [
                              trener.korisnik.isAktivan
                                  ? Icon(
                                      Icons.check_circle,
                                      color: HexColor("#28A731"),
                                      size: 19,
                                    )
                                  : Icon(
                                      CupertinoIcons.clear_circled_solid,
                                      color: Colors.red[800]!,
                                      size: 19,
                                    ),
                              SizedBox(width: 3),
                              Text(
                                  trener.korisnik.ime.toString().toUpperCase() +
                                      " " +
                                      trener.korisnik.prezime
                                          .toString()
                                          .toUpperCase(),
                                  style: GoogleFonts.oswald(
                                      fontSize: 17,
                                      color: Colors.white,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.w600)),
                            ],
                          ),
                          SizedBox(
                            height: 7,
                          ),
                          Row(children: [
                            Icon(
                              Icons.workspace_premium_sharp,
                              color: Colors.white,
                              size: 18,
                            ),
                            SizedBox(
                              width: 5,
                            ),
                            Text(trener.ulogaTrenera.toString() + " TRENER",
                                style: GoogleFonts.oswald(
                                  fontSize: 14,
                                  color: Colors.white,
                                  letterSpacing: 0,
                                )),
                          ]),
                          SizedBox(
                            height: 7,
                          ),
                          Row(children: [
                            Icon(
                              Icons.calendar_month,
                              color: Colors.white,
                              size: 18,
                            ),
                            SizedBox(
                              width: 5,
                            ),
                            Text(
                                DateFormat.yMMMd()
                                    .format(DateTime.parse(
                                        trener.korisnik.datumRodjenja))
                                    .toString(),
                                style: GoogleFonts.oswald(
                                  fontSize: 14,
                                  color: Colors.white,
                                  letterSpacing: 0,
                                ))
                          ]),
                          SizedBox(
                            height: 6,
                          ),
                          Row(children: [
                            CircleAvatar(
                              radius: 8,
                              backgroundColor: Colors.white,
                              child: CircleAvatar(
                                radius: 18,
                                backgroundColor: Colors.white,
                                child: ClipOval(
                                  child: Image.memory(
                                    Uint8List.fromList(
                                        trener.korisnik.drzavljanstvo.zastava),
                                    width: 17.5,
                                    height: 17.5,
                                    fit: BoxFit.cover,
                                  ),
                                ),
                              ),
                            ),
                            SizedBox(
                              width: 5,
                            ),
                            Text(trener.korisnik.drzavljanstvo.nazivDrzave,
                                style: GoogleFonts.oswald(
                                  fontSize: 14,
                                  color: Colors.white,
                                  letterSpacing: 0,
                                ))
                          ]),
                          SizedBox(
                            height: 7,
                          ),
                          Row(children: [
                            Icon(
                              Icons.verified_user,
                              color: Colors.white,
                              size: 18,
                            ),
                            SizedBox(
                              width: 5,
                            ),
                            Text(
                                trener.trenerskaLicenca.nazivLicence.toString(),
                                style: GoogleFonts.oswald(
                                  fontSize: 14,
                                  color: Colors.white,
                                  letterSpacing: 0,
                                )),
                          ]),
                          SizedBox(
                            height: 6,
                          ),
                          Row(
                            crossAxisAlignment: CrossAxisAlignment.center,
                            mainAxisAlignment: MainAxisAlignment.start,
                            children: [
                              Image.asset(
                                'assets/nastupi.png',
                                height: 18,
                              ),
                              SizedBox(
                                width: 5,
                              ),
                              Text(
                                  trener.trenerStatistika.brojUtakmica
                                      .toString(),
                                  style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: Colors.white,
                                    letterSpacing: 0,
                                  )),
                              SizedBox(
                                width: 7,
                              ),
                              Icon(
                                Icons.check_circle,
                                color: HexColor("#28A731"),
                                size: 18,
                              ),
                              SizedBox(
                                width: 5,
                              ),
                              Text(
                                  trener.trenerStatistika.brojPobjeda
                                      .toString(),
                                  style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: Colors.white,
                                    letterSpacing: 0,
                                  )),
                              SizedBox(
                                width: 7,
                              ),
                              Icon(
                                CupertinoIcons.clear_circled_solid,
                                color: Colors.red[800]!,
                                size: 18,
                              ),
                              SizedBox(
                                width: 5,
                              ),
                              Text(
                                  trener.trenerStatistika.brojPoraza.toString(),
                                  style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: Colors.white,
                                    letterSpacing: 0,
                                  )),
                              SizedBox(
                                width: 7,
                              ),
                              Icon(
                                Icons.do_disturb_on,
                                color: Colors.grey,
                                size: 18,
                              ),
                              SizedBox(
                                width: 5,
                              ),
                              Text(
                                  trener.trenerStatistika.brojNerjesenih
                                      .toString(),
                                  style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: Colors.white,
                                    letterSpacing: 0,
                                  ))
                            ],
                          ),
                          SizedBox(
                            height: 6,
                          ),
                        ],
                      ),
                    )
                  ],
                ),
              ),
            ),
          ),
        ),
      )
    ],
  );
}

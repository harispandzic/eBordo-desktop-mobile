// ignore_for_file: must_be_immutable
import 'dart:typed_data';
import 'package:carousel_slider/carousel_slider.dart';
import 'package:expandable/expandable.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import 'package:motion_toast/motion_toast.dart';
import 'package:motion_toast/resources/arrays.dart';
import 'package:toggle_switch/toggle_switch.dart';
import '../../models/igrac-pozicija.dart';
import '../../models/igrac.dart';
import '../../models/pozicija-podpozicija.dart';
import '../../models/pozicija.dart';
import '../../services/APIService.dart';
import '../Shared/shared_app_bar.dart';
import 'detalji_igraca.dart';

List<Igrac> dobavljeniIgraci = [];
List<Pozicija> dobavljenePozicije = [];
bool isTrenutniIgraci = true;

List<IgracPozicija> filtered_igraciPoPozicijama = [];
List<PozicijaPodpozicija> filtered_pozicijePodpozicije = [];
List<int> selectedPozicijeZaPretragu = [];

class PrikazIgraca extends StatefulWidget {
  @override
  _PrikazIgracaState createState() => _PrikazIgracaState();
}

class _PrikazIgracaState extends State<PrikazIgraca> {
  var _filterIgracaController = TextEditingController();
  List<Igrac> _igraciState = [];
  List<Pozicija> _pozicijeState = [];
  bool isDataLoading = true;
  bool isPorukaPrikazana = false;

  @override
  void initState() {
    super.initState();
    Future.delayed(const Duration(seconds: 3), GetIgrace);
    dobavljenePozicije.length == 0 ? GetPozicije() : "";
  }

  Future<List<Igrac>> GetIgrace({isAktivan = true}) async {
    Map<String, String>? queryParams = null;
    queryParams = {'pozicijaId': "-1", 'isAktivan': '${isAktivan}', 'ime': ""};

    isTrenutniIgraci = isAktivan;

    var result = await APIService.Get("Igrac", queryParams) as List;

    setState(() {
      isDataLoading = false;
    });

    List<Igrac> igraciList = result.map((i) => Igrac.fromJson(i)).toList();

    dobavljeniIgraci = igraciList;

    FiltirajIgrace();

    return igraciList;
  }

  Future<List<Pozicija>> GetPozicije() async {
    var result = await APIService.Get('Pozicija', null) as List;

    List<Pozicija> pozicijeList =
        result.map((i) => Pozicija.fromJson(i)).toList();

    setState(() {
      _pozicijeState = pozicijeList;
    });

    dobavljenePozicije = pozicijeList;

    OdaberiPozicijeZaFilter();

    return pozicijeList;
  }

  VoidCallback? FiltirajIgrace({String ime = ""}) {
    setState(() {
      _igraciState = dobavljeniIgraci;
    });

    _igraciState = _igraciState
        .where((element) =>
            selectedPozicijeZaPretragu.contains(element.pozicija.pozicijaId))
        .toList();

    if (ime != "") {
      setState(() {
        _igraciState = _igraciState
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

    OdaberiIgracePoPozicijama();

    return null;
  }

  VoidCallback? OsvjeziFiltere({String ime = ""}) {
    selectedPozicijeZaPretragu = [];
    filtered_igraciPoPozicijama = [];
    filtered_pozicijePodpozicije = [];

    GetIgrace(isAktivan: true);

    setState(() {
      _igraciState = dobavljeniIgraci;
    });

    OdaberiIgracePoPozicijama();

    OdaberiPozicijeZaFilter();

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

  void OdaberiIgracePoPozicijama() {
    filtered_igraciPoPozicijama = [];

    filtered_igraciPoPozicijama.add(IgracPozicija(
        nazivPozicije: "GOLMAN",
        igraci: _igraciState
            .where((element) => element.pozicija.pozicijaId == 1)
            .toList()));
    filtered_igraciPoPozicijama.add(IgracPozicija(
        nazivPozicije: "ODBRANA",
        igraci: _igraciState
            .where((element) =>
                element.pozicija.pozicijaId == 2 ||
                element.pozicija.pozicijaId == 3 ||
                element.pozicija.pozicijaId == 4)
            .toList()));
    filtered_igraciPoPozicijama.add(IgracPozicija(
        nazivPozicije: "VEZNI RED",
        igraci: _igraciState
            .where((element) =>
                element.pozicija.pozicijaId == 5 ||
                element.pozicija.pozicijaId == 6 ||
                element.pozicija.pozicijaId == 7 ||
                element.pozicija.pozicijaId == 8 ||
                element.pozicija.pozicijaId == 9)
            .toList()));
    filtered_igraciPoPozicijama.add(IgracPozicija(
        nazivPozicije: "KRILO",
        igraci: _igraciState
            .where((element) =>
                element.pozicija.pozicijaId == 10 ||
                element.pozicija.pozicijaId == 11)
            .toList()));
    filtered_igraciPoPozicijama.add(IgracPozicija(
        nazivPozicije: "NAPAD",
        igraci: _igraciState
            .where((element) => element.pozicija.pozicijaId == 12)
            .toList()));
  }

  void OdaberiPozicijeZaFilter() {
    setState(() {
      _pozicijeState = dobavljenePozicije;
    });

    _pozicijeState.forEach((element) {
      selectedPozicijeZaPretragu.add(element.pozicijaId);
    });

    filtered_pozicijePodpozicije.add(PozicijaPodpozicija(
        nazivPodpozicije: "GOLMAN",
        pozicije: _pozicijeState
            .where((element) => element.pozicijaId == 1)
            .toList()));
    filtered_pozicijePodpozicije.add(PozicijaPodpozicija(
        nazivPodpozicije: "ODBRANA",
        pozicije: _pozicijeState
            .where((element) =>
                element.pozicijaId == 2 ||
                element.pozicijaId == 3 ||
                element.pozicijaId == 4)
            .toList()));
    filtered_pozicijePodpozicije.add(PozicijaPodpozicija(
        nazivPodpozicije: "VEZNI RED",
        pozicije: _pozicijeState
            .where((element) =>
                element.pozicijaId == 5 ||
                element.pozicijaId == 6 ||
                element.pozicijaId == 7 ||
                element.pozicijaId == 8 ||
                element.pozicijaId == 9)
            .toList()));
    filtered_pozicijePodpozicije.add(PozicijaPodpozicija(
        nazivPodpozicije: "KRILO",
        pozicije: _pozicijeState
            .where((element) =>
                element.pozicijaId == 10 || element.pozicijaId == 11)
            .toList()));
    filtered_pozicijePodpozicije.add(PozicijaPodpozicija(
        nazivPodpozicije: "NAPAD",
        pozicije: _pozicijeState
            .where((element) => element.pozicijaId == 12)
            .toList()));
  }

  Widget FilteriPrikazIgracaWidget() {
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
            Text("PRETRAGA IGRAČA PO STATUSU",
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
              Text("TRENUTNI/BIVŠI FUDBALERI",
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
                  initialLabelIndex: isTrenutniIgraci ? 0 : 1,
                  totalSwitches: 2,
                  labels: ['', ''],
                  radiusStyle: false,
                  onToggle: (index) {
                    if (index == 0) {
                      GetIgrace(isAktivan: true);
                    } else {
                      GetIgrace(isAktivan: false);
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
          SizedBox(height: 3),
          Divider(),
          Row(
            children: [
              Text("PRETRAGA IGRAČA PO POZICIJI",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold))
            ],
          ),
          ListView(
            shrinkWrap: true,
            children: filtered_pozicijePodpozicije
                .map<Widget>((e) => FilteredPozicije(
                    podpozicija: e, filtirajIgrace: FiltirajIgrace))
                .toList(),
          ),
          SizedBox(height: 3),
          Divider(),
          Row(
            children: [
              Text("PRETRAGA IGRAČA PO IMENU I PREZIMENU",
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
            controller: _filterIgracaController,
            style: TextStyle(height: 1),
            onChanged: (text) {
              FiltirajIgrace(ime: text);
            },
            decoration: InputDecoration(
              hintText: "ex. Sušić",
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
                onPressed: _filterIgracaController.clear,
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
                  child: Text("IGRAČI",
                      style: GoogleFonts.oswald(
                          fontSize: 18,
                          color: HexColor("#400507"),
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                ),
                Padding(
                  padding: EdgeInsets.only(left: 21),
                  child:
                      Text("Ukupno igrača: " + _igraciState.length.toString(),
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
            FilteriPrikazIgracaWidget(),
            isDataLoading
                ? Padding(
                    padding: EdgeInsets.only(top: 120),
                    child: Center(
                        child: Column(
                      children: [
                        CircularProgressIndicator(
                          color: HexColor("#400507"),
                        ),
                        // Image.asset("assets/loader.gif", height: 45.0),
                        // SizedBox(height: 5),
                        // Text("Učitavanje...",
                        //     style: GoogleFonts.oswald(
                        //         fontSize: 16,
                        //         color: Colors.black,
                        //         letterSpacing: 0,
                        //         fontWeight: FontWeight.bold))
                      ],
                    )),
                  )
                : (_igraciState.length == 0)
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
                    : ListView(
                        scrollDirection: Axis.vertical,
                        shrinkWrap: true,
                        children: filtered_igraciPoPozicijama
                            .map<Widget>((element) => PozicijaIgraciState(
                                element.igraci, element.nazivPozicije))
                            .toList(),
                      )
          ],
        ));
  }
}

typedef void MyCallback({String ime});

class FilteredPozicije extends StatefulWidget {
  final PozicijaPodpozicija? podpozicija;
  final MyCallback? filtirajIgrace;

  const FilteredPozicije(
      {required this.podpozicija, required this.filtirajIgrace});

  @override
  _PozicijeState createState() => _PozicijeState();
}

List<int> getSelectedIds(PozicijaPodpozicija? podpozicija) {
  List<int> selectedIds = [];
  if (podpozicija!.nazivPodpozicije == "GOLMAN") {
    selectedIds.add(1);
  } else if (podpozicija.nazivPodpozicije == "ODBRANA") {
    selectedIds.addAll([2, 3, 4]);
  } else if (podpozicija.nazivPodpozicije == "VEZNI RED") {
    selectedIds.addAll([5, 6, 7, 8, 9]);
  } else if (podpozicija.nazivPodpozicije == "KRILO") {
    selectedIds.addAll([10, 11]);
  } else if (podpozicija.nazivPodpozicije == "NAPAD") {
    selectedIds.add(12);
  }

  return selectedIds;
}

void PretragaPozicije(PozicijaPodpozicija? podpozicija, bool isChecked) {
  List<int> selectedIds = getSelectedIds(podpozicija);
  if (isChecked) {
    bool found = selectedPozicijeZaPretragu.any((r) => selectedIds.contains(r));
    if (found) return;
    selectedPozicijeZaPretragu.addAll(selectedIds);
  } else {
    selectedIds.forEach((element) {
      if (selectedPozicijeZaPretragu.contains(element)) {
        selectedPozicijeZaPretragu.remove(element);
      }
    });
  }
}

bool isSelectedPozicijeSadrzePoziciju(PozicijaPodpozicija? podpozicija) {
  List<int> selectedIds = getSelectedIds(podpozicija);
  return selectedPozicijeZaPretragu.any((r) => selectedIds.contains(r));
}

class _PozicijeState extends State<FilteredPozicije> {
  @override
  Widget build(BuildContext context) {
    return Column(
      mainAxisAlignment: MainAxisAlignment.start,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        SizedBox(height: 5),
        Row(
          children: [
            Checkbox(
              activeColor: Colors.black,
              value: isSelectedPozicijeSadrzePoziciju(widget.podpozicija),
              onChanged: (newValue) {
                PretragaPozicije(widget.podpozicija, newValue!);
                widget.filtirajIgrace!();
              },
            ),
            Text(widget.podpozicija!.nazivPodpozicije.toString(),
                style: GoogleFonts.oswald(
                    fontSize: 15,
                    color: Colors.black,
                    letterSpacing: 0,
                    fontWeight: FontWeight.bold)),
          ],
        ),
        Padding(
          padding: EdgeInsets.only(left: 15),
          child: ListView(
            scrollDirection: Axis.vertical,
            shrinkWrap: true,
            children: widget.podpozicija!.pozicije
                .map<Widget>((element) => Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        Row(
                          children: [
                            Checkbox(
                              activeColor: HexColor("#400507"),
                              value: selectedPozicijeZaPretragu
                                  .contains(element.pozicijaId),
                              onChanged: (newValue) {
                                if (newValue!) {
                                  if (selectedPozicijeZaPretragu
                                      .contains(element.pozicijaId)) return;
                                  selectedPozicijeZaPretragu.insert(
                                      selectedPozicijeZaPretragu.length,
                                      element.pozicijaId);
                                } else {
                                  selectedPozicijeZaPretragu
                                      .remove(element.pozicijaId);
                                }
                                widget.filtirajIgrace!();
                              },
                            ),
                            Text(element.nazivPozicije.toString().toUpperCase(),
                                style: GoogleFonts.oswald(
                                    fontSize: 12,
                                    color: HexColor("#400507"),
                                    letterSpacing: 0,
                                    fontWeight: FontWeight.bold)),
                          ],
                        ),
                        Text(element.skracenica.toString().toUpperCase(),
                            style: GoogleFonts.oswald(
                                fontSize: 12,
                                color: HexColor("#400507"),
                                letterSpacing: 0,
                                fontWeight: FontWeight.bold))
                      ],
                    ))
                .toList(),
          ),
        )
      ],
    );
  }
}

class PozicijaIgraciState extends StatefulWidget {
  List<Igrac> _igraci = [];
  String _nazivPozicije = "";

  PozicijaIgraciState(List<Igrac> igraci, String nazivPozicije) {
    this._igraci = igraci;
    this._nazivPozicije = nazivPozicije;
  }

  @override
  _PozicijaIgrac createState() => _PozicijaIgrac();
}

class _PozicijaIgrac extends State<PozicijaIgraciState> {
  int _currentIgrac = 0;
  final CarouselController _controller = CarouselController();

  @override
  Widget build(BuildContext context) {
    return Container(
        child: ListView(
      scrollDirection: Axis.vertical,
      shrinkWrap: true,
      children: [
        if (widget._igraci.length > 0)
          Container(
            child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Padding(
                  padding: EdgeInsets.only(left: 21),
                  child: Text(widget._nazivPozicije,
                      style: GoogleFonts.oswald(
                          fontSize: 16,
                          color: HexColor("#400507"),
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                ),
                Padding(
                  padding: EdgeInsets.only(left: 21),
                  child:
                      Text("Broj igrača: " + widget._igraci.length.toString(),
                          style: GoogleFonts.oswald(
                            fontSize: 11,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                ),
                SizedBox(height: 5),
                CarouselSlider(
                  items: widget._igraci
                      .map((element) => IgracKartica(context, element))
                      .toList(),
                  carouselController: _controller,
                  options: CarouselOptions(
                      viewportFraction: 0.9,
                      enableInfiniteScroll: true,
                      initialPage: 1,
                      height: 220,
                      reverse: false,
                      autoPlay: false,
                      enlargeCenterPage: true,
                      aspectRatio: 2.0,
                      onPageChanged: (index, reason) {
                        setState(() {
                          _currentIgrac = index;
                        });
                      }),
                ),
                Container(
                  transform: Matrix4.translationValues(0.0, -12.0, 10.0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: widget._igraci.asMap().entries.map((entry) {
                      return GestureDetector(
                        onTap: () => _controller.animateToPage(entry.key),
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
                                      _currentIgrac == entry.key ? 0.9 : 0.4)),
                        ),
                      );
                    }).toList(),
                  ),
                )
              ],
            ),
          )
      ],
    ));
  }
}

Widget IgracKartica(context, igrac) {
  return Stack(
    children: [
      Card(
        child: TextButton(
          style: TextButton.styleFrom(
              padding: EdgeInsets.zero,
              minimumSize: Size(50, 30),
              alignment: Alignment.centerLeft),
          onPressed: () {
            Navigator.push(
                context,
                MaterialPageRoute(
                    builder: (context) => DetaljiIgraca(
                          igrac: igrac,
                        )));
          },
          child: Container(
            height: 180,
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
                  Positioned(
                    top: 10.0,
                    left: 15.0,
                    right: 0.0,
                    child: Text("#" + igrac.brojDresa.toString(),
                        style: GoogleFonts.oswald(
                          fontSize: 16,
                          color: Colors.white,
                          letterSpacing: 0,
                        )),
                  ),
                  Container(
                      margin: EdgeInsets.fromLTRB(15, 0, 0, 0),
                      height: 300,
                      width: 100,
                      child: FittedBox(
                        child:
                            Image.memory(Uint8List.fromList(igrac.slikaPanel)),
                        fit: BoxFit.cover,
                      )),
                  Padding(
                    padding: EdgeInsets.fromLTRB(125, 15, 0, 0),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Row(
                          children: [
                            igrac.korisnik.isAktivan
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
                                igrac.korisnik.ime.toString().toUpperCase() +
                                    " " +
                                    igrac.korisnik.prezime
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
                            Icons.fact_check_outlined,
                            color: Colors.white,
                            size: 18,
                          ),
                          SizedBox(
                            width: 5,
                          ),
                          Text(
                              igrac!.pozicija.skracenica +
                                  " - " +
                                  igrac!.pozicija.nazivPozicije
                                      .toString()
                                      .toUpperCase(),
                              style: GoogleFonts.oswald(
                                fontSize: 14,
                                color: Colors.white,
                                letterSpacing: 0,
                              )),
                        ]),
                        SizedBox(
                          height: 6,
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
                                      igrac.korisnik.datumRodjenja))
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
                                      igrac.korisnik.drzavljanstvo.zastava),
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
                          Text(igrac.korisnik.drzavljanstvo.nazivDrzave,
                              style: GoogleFonts.oswald(
                                fontSize: 14,
                                color: Colors.white,
                                letterSpacing: 0,
                              ))
                        ]),
                        SizedBox(
                          height: 8,
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
                            Text(igrac.igracStatistika.brojNastupa.toString(),
                                style: GoogleFonts.oswald(
                                  fontSize: 14,
                                  color: Colors.white,
                                  letterSpacing: 0,
                                )),
                            SizedBox(
                              width: 7,
                            ),
                            Image.asset(
                              'assets/golovi.png',
                              height: 18,
                            ),
                            SizedBox(
                              width: 5,
                            ),
                            Text(igrac.igracStatistika.golovi.toString(),
                                style: GoogleFonts.oswald(
                                  fontSize: 14,
                                  color: Colors.white,
                                  letterSpacing: 0,
                                )),
                            SizedBox(
                              width: 7,
                            ),
                            Image.asset(
                              'assets/asistencije.png',
                              height: 18,
                            ),
                            SizedBox(
                              width: 5,
                            ),
                            Text(igrac.igracStatistika.asistencije.toString(),
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
                        RatingBarIndicator(
                          rating:
                              igrac.igracStatistika.prosjecnaOcjena.toDouble(),
                          itemBuilder: (context, index) => Icon(
                            Icons.star,
                            color: Colors.amber,
                          ),
                          itemCount: 5,
                          itemSize: 20.0,
                          direction: Axis.horizontal,
                        )
                      ],
                    ),
                  )
                ],
              ),
            ),
          ),
        ),
      )
    ],
  );
}

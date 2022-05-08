// ignore_for_file: must_be_immutable
import 'dart:typed_data';
import 'package:ebordo_mobile/models/trening.dart';
import 'package:expandable/expandable.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import 'package:motion_toast/motion_toast.dart';
import 'package:motion_toast/resources/arrays.dart';
import '../../services/APIService.dart';
import '../Shared/shared_app_bar.dart';

List<Trening> dobavljeniTreninzi = [];
List<String> selectedLokacijeTreninga = [];
bool isZavrseniTreninzi = true;

class PrikazTreninga extends StatefulWidget {
  @override
  _PrikazTreningaState createState() => _PrikazTreningaState();
}

class _PrikazTreningaState extends State<PrikazTreninga> {
  List<Trening> _treninziState = [];
  bool isDataLoading = true;
  bool isPorukaPrikazana = false;

  @override
  void initState() {
    super.initState();
    Future.delayed(const Duration(seconds: 0), GetTreninzi);
    if (selectedLokacijeTreninga.length == 0) {
      GetLokacijeTreninga();
    }
  }

  void GetLokacijeTreninga() {
    selectedLokacijeTreninga = [];
    selectedLokacijeTreninga.add("Stadion");
    selectedLokacijeTreninga.add("Trening_centar");
  }

  Future<List<Trening>> GetTreninzi(
      {lokacijaTreninga = "", bool isZavrsen = false}) async {
    Map<String, String>? queryParams = null;
    queryParams = {
      'lokacijaTreninga': '${lokacijaTreninga}',
      'zavrsen': '${isZavrsen}'
    };
    isZavrseniTreninzi = isZavrsen;

    var result = await APIService.Get("Trening", queryParams) as List;

    setState(() {
      isDataLoading = false;
    });

    List<Trening> treninziList =
        result.map((i) => Trening.fromJson(i)).toList();

    dobavljeniTreninzi = treninziList;

    FiltrirajTreninge();

    return treninziList;
  }

  VoidCallback? FiltrirajTreninge() {
    setState(() {
      _treninziState = dobavljeniTreninzi;
    });

    _treninziState = _treninziState
        .where((element) => selectedLokacijeTreninga.contains(element.lokacija))
        .toList();

    return null;
  }

  VoidCallback? OsvjeziFiltere() {
    GetTreninzi();
    GetLokacijeTreninga();
    setState(() {
      _treninziState = _treninziState;
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

  void PretragaPoLokaciji(String lokacija, bool isChecked) {
    bool found = isSelectedLokacijeSadrzeLokaciju(lokacija);
    if (isChecked) {
      if (found) return;
      selectedLokacijeTreninga.add(lokacija);
    } else {
      if (found) selectedLokacijeTreninga.remove(lokacija);
    }
  }

  bool isSelectedLokacijeSadrzeLokaciju(String status) {
    return selectedLokacijeTreninga.contains(status);
  }

  Widget FilteriPrikazTreningaWidget() {
    return Padding(
      padding: EdgeInsets.only(left: 21, right: 21),
      child: Container(
        decoration: BoxDecoration(
            borderRadius: BorderRadius.circular(10),
            color: Color.fromARGB(255, 98, 105, 99).withOpacity(0.2)),
        padding: EdgeInsets.all(10),
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
          collapsed: Padding(
              padding: EdgeInsets.only(left: 5),
              child: Text("ZA PRETRAGU OTVORI FILTERE!",
                  style: GoogleFonts.oswald(
                      fontSize: 13,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.w500))),
          expanded: ListView(shrinkWrap: true, children: [
            SizedBox(height: 5),
            Row(children: [
              Text("PRETRAGA TRENINGA PO STATUSU",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold))
            ]),
            SizedBox(height: 5),
            Row(
              children: [
                Checkbox(
                  activeColor: HexColor("#400507"),
                  value: isZavrseniTreninzi,
                  onChanged: (newValue) {
                    if (newValue == true) {
                      GetTreninzi(isZavrsen: true);
                    } else {
                      GetTreninzi(isZavrsen: false);
                    }
                  },
                ),
                Text("ZAVRŠENI TRENINZI",
                    style: GoogleFonts.oswald(
                        fontSize: 15,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
              ],
            ),
            SizedBox(height: 3),
            Divider(),
            Row(children: [
              Text("PRETRAGA PO LOKACIJI",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold))
            ]),
            SizedBox(height: 5),
            Row(
              children: [
                Checkbox(
                  activeColor: HexColor("#400507"),
                  value: isSelectedLokacijeSadrzeLokaciju("Stadion"),
                  onChanged: (newValue) {
                    PretragaPoLokaciji("Stadion", newValue!);
                    FiltrirajTreninge();
                  },
                ),
                Icon(
                  Icons.stadium,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 5,
                ),
                Text("STADION",
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
                  value: isSelectedLokacijeSadrzeLokaciju("Trening_centar"),
                  onChanged: (newValue) {
                    PretragaPoLokaciji("Trening_centar", newValue!);
                    FiltrirajTreninge();
                  },
                ),
                Icon(
                  Icons.fitness_center,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 5,
                ),
                Text("TRENING CENTAR BUTMIR",
                    style: GoogleFonts.oswald(
                        fontSize: 15,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
              ],
            ),
            SizedBox(height: 5),
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
              icon: TextButton(
                  onPressed: () {
                    Navigator.of(context).pushNamed('/pocetna');
                  },
                  child: Icon(
                    Icons.home,
                    color: HexColor("#400507"),
                  )),
              label: 'Početna',
            ),
            BottomNavigationBarItem(
              icon: TextButton(
                  onPressed: () {
                    Navigator.of(context).pushNamed('/prikaz_rasporeda');
                  },
                  child: Icon(
                    Icons.calendar_month,
                    color: HexColor("#400507"),
                  )),
              label: 'Raspored',
            ),
            BottomNavigationBarItem(
              icon: TextButton(
                  onPressed: () {
                    Navigator.of(context).pushNamed('/prikaz_rezultata');
                  },
                  child: Icon(
                    Icons.sports_soccer,
                    color: HexColor("#400507"),
                  )),
              label: 'Rezultati',
            ),
          ],
        ),
        body: Container(
          decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(10),
              image: DecorationImage(
                  fit: BoxFit.cover,
                  image: AssetImage('assets/login-background-slika.png'))),
          child: ListView(
            children: [
              SizedBox(height: 5),
              Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
                Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
                  Padding(
                    padding: EdgeInsets.only(left: 21),
                    child: Text("RASPORED TRENINGA",
                        style: GoogleFonts.oswald(
                            fontSize: 18,
                            color: HexColor("#400507"),
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                  ),
                  Padding(
                    padding: EdgeInsets.only(left: 21),
                    child: Text(
                        "Ukupno treninga: " + _treninziState.length.toString(),
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
              FilteriPrikazTreningaWidget(),
              SizedBox(height: 5),
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
                  : (_treninziState.length == 0)
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
                            children: _treninziState
                                .map((element) =>
                                    TreningKartica(context, element))
                                .toList(),
                          ),
                        )
            ],
          ),
        ));
  }
}

int daysBetween(DateTime from, DateTime to) {
  from = DateTime(from.year, from.month, from.day);
  to = DateTime(to.year, to.month, to.day);
  return (to.difference(from).inHours / 24).round();
}

Widget TreningKartica(context, Trening trening) {
  return Stack(
    children: [
      Card(
          child: Container(
              height: 180,
              width: double.infinity,
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),
                  image: DecorationImage(
                      fit: BoxFit.cover,
                      image: AssetImage('assets/igrac-kartica-pozadina.png'))),
              child: Padding(
                padding: EdgeInsets.all(10),
                child: Column(
                  children: [
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
                              .format(DateTime.parse(trening.datumOdrzavanja))
                              .toString(),
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.white,
                            letterSpacing: 0,
                          )),
                      SizedBox(
                        width: 10,
                      ),
                      Container(
                        decoration: BoxDecoration(
                            color: HexColor("#FFC107"),
                            borderRadius: BorderRadius.all(Radius.circular(5))),
                        child: Padding(
                          padding: EdgeInsets.only(left: 7, right: 7),
                          child: Text(
                              daysBetween(
                                          DateTime.now(),
                                          DateTime.parse(
                                              trening.datumOdrzavanja)) <
                                      0
                                  ? "prije " +
                                      daysBetween(
                                        DateTime.parse(trening.datumOdrzavanja),
                                        DateTime.now(),
                                      ).toString() +
                                      " dana"
                                  : "za " +
                                      daysBetween(
                                              DateTime.now(),
                                              DateTime.parse(
                                                  trening.datumOdrzavanja))
                                          .toString() +
                                      " dana",
                              style: GoogleFonts.oswald(
                                  fontSize: 10,
                                  color: Colors.black,
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.w500)),
                        ),
                      )
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.access_alarm,
                        color: Colors.white,
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(trening.satnica + " h",
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
                      Icon(
                        Icons.timelapse,
                        color: Colors.white,
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(trening.trajanje.toString() + " h",
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
                      Icon(
                        trening.lokacija == "Stadion"
                            ? Icons.stadium
                            : Icons.fitness_center,
                        color: Colors.white,
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          trening.lokacija == "Stadion"
                              ? "STADION KOŠEVO"
                              : "TRENING CENTAR BUTMIR",
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.white,
                            letterSpacing: 0,
                          )),
                      SizedBox(
                        width: 5,
                      ),
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.info_outline,
                        color: Colors.white,
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(trening.fokusTreninga,
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
                                  trening.zabiljezio.korisnik.slika),
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
                      Text(
                          trening.zabiljezio.korisnik.ime +
                              " " +
                              trening.zabiljezio.korisnik.prezime.toUpperCase(),
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.white,
                            letterSpacing: 0,
                          ))
                    ]),
                  ],
                ),
              )))
    ],
  );
}

// ignore_for_file: must_be_immutable
import 'dart:typed_data';
import 'package:ebordo_mobile/models/takmicenje.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20rasporedom/detalji_utakmice.dart';
import 'package:expandable/expandable.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import 'package:motion_toast/motion_toast.dart';
import 'package:motion_toast/resources/arrays.dart';
import '../../models/utakmica.dart';
import '../../services/APIService.dart';
import '../Shared/shared_app_bar.dart';

List<String> selectedVrsteUtakmice = [];
List<int> selectedTakmicenja = [];
List<Utakmica> dobavljeneUtakmice = [];
List<Takmicenje> dobavljenaTakmicenja = [];

class PrikazRasporeda extends StatefulWidget {
  @override
  _PrikazRasporedaState createState() => _PrikazRasporedaState();
}

class _PrikazRasporedaState extends State<PrikazRasporeda> {
  List<Utakmica> _utakmiceState = [];
  List<Takmicenje> _takmicenjaState = [];
  bool isDataLoading = true;
  bool isPorukaPrikazana = false;

  @override
  void initState() {
    super.initState();
    Future.delayed(const Duration(seconds: 0), GetUtakmice);
    GetTakmicenja();
    if (selectedVrsteUtakmice.length == 0) {
      GetVrsteUtakmice();
    }
  }

  Future<List<Utakmica>> GetUtakmice({tipUtakmice = ""}) async {
    Map<String, String>? queryParams = null;
    queryParams = {'tipUtakmice': '${tipUtakmice}', 'odigrana': "false"};

    var result = await APIService.Get("Utakmica", queryParams) as List;

    setState(() {
      isDataLoading = false;
    });

    List<Utakmica> utakmiceList =
        result.map((i) => Utakmica.fromJson(i)).toList();

    dobavljeneUtakmice = utakmiceList;

    FiltrirajUtakmice();

    return utakmiceList;
  }

  void GetVrsteUtakmice() {
    selectedVrsteUtakmice = [];
    selectedVrsteUtakmice.add("DOMAĆA");
    selectedVrsteUtakmice.add("GOSTUJUĆA");
  }

  Future<List<Takmicenje>> GetTakmicenja() async {
    var result = await APIService.Get('Takmicenje', null) as List;

    List<Takmicenje> takmicenjeList =
        result.map((i) => Takmicenje.fromJson(i)).toList();

    setState(() {
      _takmicenjaState = takmicenjeList;
    });

    dobavljenaTakmicenja = takmicenjeList;

    OdaberiPozicijeZaFilter();

    return takmicenjeList;
  }

  void OdaberiPozicijeZaFilter() {
    setState(() {
      _takmicenjaState = dobavljenaTakmicenja;
    });

    _takmicenjaState.forEach((element) {
      selectedTakmicenja.add(element.takmicenjeId);
    });
  }

  VoidCallback? FiltrirajUtakmice() {
    setState(() {
      _utakmiceState = dobavljeneUtakmice;
    });

    _utakmiceState = _utakmiceState
        .where((element) =>
            selectedVrsteUtakmice.contains(element.vrstaUtakmice.toUpperCase()))
        .toList();

    _utakmiceState = _utakmiceState
        .where((element) =>
            selectedTakmicenja.contains(element.takmicenje.takmicenjeId))
        .toList();

    return null;
  }

  VoidCallback? OsvjeziFiltere() {
    GetUtakmice();
    GetVrsteUtakmice();

    setState(() {
      _utakmiceState = _utakmiceState;
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

  void PretragaPoVrsti(String status, bool isChecked) {
    bool found = isSelectedVrsteSadrzeVrstu(status);
    if (isChecked) {
      if (found) return;
      selectedVrsteUtakmice.add(status);
    } else {
      if (found) selectedVrsteUtakmice.remove(status);
    }
  }

  bool isSelectedVrsteSadrzeVrstu(String status) {
    return selectedVrsteUtakmice.contains(status);
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
            Text("PRETRAGA PO VRSTI UTAKMICE",
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
                value: isSelectedVrsteSadrzeVrstu("DOMAĆA"),
                onChanged: (newValue) {
                  PretragaPoVrsti("DOMAĆA", newValue!);
                  FiltrirajUtakmice();
                },
              ),
              Text("DOMAĆA UTAKMICA",
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
                value: isSelectedVrsteSadrzeVrstu("GOSTUJUĆA"),
                onChanged: (newValue) {
                  PretragaPoVrsti("GOSTUJUĆA", newValue!);
                  FiltrirajUtakmice();
                },
              ),
              Text("GOSTUJUĆA UTAKMICA",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
            ],
          ),
          SizedBox(height: 5),
          Divider(),
          Row(
            children: [
              Text("PRETRAGA PO TAKMIČENJU",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold))
            ],
          ),
          ListView(
            shrinkWrap: true,
            children: _takmicenjaState
                .map<Widget>((e) => FilteredTakmicenja(
                    takmicenje: e, filtirajUtakmice: FiltrirajUtakmice))
                .toList(),
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
              icon: Icon(Icons.directions_run),
              label: 'Igrači',
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
                  child: Text("RASPORED UTAKMICA",
                      style: GoogleFonts.oswald(
                          fontSize: 18,
                          color: HexColor("#400507"),
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                ),
                Padding(
                  padding: EdgeInsets.only(left: 21),
                  child: Text(
                      "Ukupno utakmica: " + _utakmiceState.length.toString(),
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
                : (_utakmiceState.length == 0)
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
                          children: _utakmiceState
                              .map((element) =>
                                  UtakmicaKartica(context, element))
                              .toList(),
                        ),
                      )
          ],
        ));
  }
}

typedef void MyCallback();

class FilteredTakmicenja extends StatefulWidget {
  final Takmicenje? takmicenje;
  final MyCallback? filtirajUtakmice;

  const FilteredTakmicenja(
      {required this.takmicenje, required this.filtirajUtakmice});

  @override
  _FilteredTakmicenjaState createState() => _FilteredTakmicenjaState();
}

void PretragaTakmicenja(int takmicenjeId, bool isChecked) {
  if (isChecked) {
    bool found = selectedTakmicenja.contains(takmicenjeId);
    if (found) return;
    selectedTakmicenja.add(takmicenjeId);
  } else {
    if (selectedTakmicenja.contains(takmicenjeId)) {
      selectedTakmicenja.remove(takmicenjeId);
    }
  }
}

bool isSelectedTakmicenjeSadrziTakmicenje(int takmicenjeId) {
  return selectedTakmicenja.contains(takmicenjeId);
}

class _FilteredTakmicenjaState extends State<FilteredTakmicenja> {
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
              activeColor: HexColor("#400507"),
              value: isSelectedTakmicenjeSadrziTakmicenje(
                  widget.takmicenje!.takmicenjeId),
              onChanged: (newValue) {
                PretragaTakmicenja(widget.takmicenje!.takmicenjeId, newValue!);
                widget.filtirajUtakmice!();
              },
            ),
            Container(
              child: Image.memory(
                Uint8List.fromList(widget.takmicenje!.logo),
                height: 20,
                width: 20,
              ),
            ),
            SizedBox(
              width: 5,
            ),
            Text(widget.takmicenje!.nazivTakmicenja.toString().toUpperCase(),
                style: GoogleFonts.oswald(
                    fontSize: 15,
                    color: Colors.black,
                    letterSpacing: 0,
                    fontWeight: FontWeight.bold)),
          ],
        ),
      ],
    );
  }
}

int daysBetween(DateTime from, DateTime to) {
  from = DateTime(from.year, from.month, from.day);
  to = DateTime(to.year, to.month, to.day);
  return (to.difference(from).inHours / 24).round();
}

Widget UtakmicaKartica(context, utakmica) {
  return Stack(
    children: [
      Padding(
        padding: EdgeInsets.only(top: 2, bottom: 2),
        child: Card(
          child: TextButton(
            style: TextButton.styleFrom(
                padding: EdgeInsets.zero,
                minimumSize: Size(60, 60),
                alignment: Alignment.centerLeft),
            onPressed: () {
              Navigator.push(
                  context,
                  MaterialPageRoute(
                      builder: (context) => DetaljiUtakmice(
                            utakmica: utakmica,
                          )));
            },
            child: Container(
              height: 255,
              width: double.infinity,
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),
                  image: DecorationImage(
                      fit: BoxFit.cover,
                      image: AssetImage('assets/igrac-kartica-pozadina.png'))),
              child: Padding(
                  padding: const EdgeInsets.only(
                      top: 15, left: 15, bottom: 0, right: 5),
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.start,
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      utakmica.vrstaUtakmice == "Domaća"
                          ? Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              crossAxisAlignment: CrossAxisAlignment.center,
                              children: [
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Container(
                                      child: Image.asset(
                                        'assets/fksarajevo-grb.png',
                                        fit: BoxFit.contain,
                                        height: 40,
                                        width: 40,
                                      ),
                                    ),
                                    SizedBox(width: 7),
                                    Text("SARAJEVO",
                                        style: GoogleFonts.oswald(
                                            fontSize: 19,
                                            color: Colors.white,
                                            letterSpacing: 0,
                                            fontWeight: FontWeight.w600)),
                                  ],
                                ),
                                Container(
                                  child: Image.memory(
                                    Uint8List.fromList(
                                        utakmica.takmicenje.logo),
                                    height: 40,
                                    width: 40,
                                  ),
                                )
                              ],
                            )
                          : Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              crossAxisAlignment: CrossAxisAlignment.center,
                              children: [
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Container(
                                      child: Image.memory(
                                        Uint8List.fromList(
                                            utakmica.protivnik.grb),
                                        height: 40,
                                        width: 40,
                                      ),
                                    ),
                                    SizedBox(width: 7),
                                    Text(
                                        utakmica.protivnik.nazivKluba
                                            .toString()
                                            .toUpperCase(),
                                        style: GoogleFonts.oswald(
                                            fontSize: 19,
                                            color: Colors.white,
                                            letterSpacing: 0,
                                            fontWeight: FontWeight.w600)),
                                  ],
                                ),
                                Container(
                                  child: Image.memory(
                                    Uint8List.fromList(
                                        utakmica.takmicenje.logo),
                                    height: 40,
                                    width: 40,
                                  ),
                                )
                              ],
                            ),
                      SizedBox(height: 10),
                      utakmica.vrstaUtakmice == "Gostujuća"
                          ? Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              crossAxisAlignment: CrossAxisAlignment.center,
                              children: [
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Container(
                                      child: Image.asset(
                                        'assets/fksarajevo-grb.png',
                                        fit: BoxFit.contain,
                                        height: 40,
                                        width: 40,
                                      ),
                                    ),
                                    SizedBox(width: 7),
                                    Text("SARAJEVO",
                                        style: GoogleFonts.oswald(
                                            fontSize: 19,
                                            color: Colors.white,
                                            letterSpacing: 0,
                                            fontWeight: FontWeight.w600)),
                                  ],
                                ),
                              ],
                            )
                          : Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              crossAxisAlignment: CrossAxisAlignment.center,
                              children: [
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Container(
                                      child: Image.memory(
                                        Uint8List.fromList(
                                            utakmica.protivnik.grb),
                                        height: 40,
                                        width: 40,
                                      ),
                                    ),
                                    SizedBox(width: 7),
                                    Text(
                                        utakmica.protivnik.nazivKluba
                                            .toString()
                                            .toUpperCase(),
                                        style: GoogleFonts.oswald(
                                            fontSize: 19,
                                            color: Colors.white,
                                            letterSpacing: 0,
                                            fontWeight: FontWeight.w600)),
                                  ],
                                ),
                              ],
                            ),
                      SizedBox(height: 10),
                      Row(children: [
                        Icon(
                          utakmica.vrstaUtakmice == "Domaća"
                              ? CupertinoIcons.airplane
                              : Icons.home,
                          color: Colors.white,
                          size: 18,
                        ),
                        SizedBox(
                          width: 5,
                        ),
                        Text(
                            utakmica.vrstaUtakmice == "Domaća"
                                ? "DOMAĆA UTAKMICA"
                                : "GOSTUJUĆA UTAKMICA",
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
                          Icons.emoji_events,
                          color: Colors.white,
                          size: 18,
                        ),
                        SizedBox(
                          width: 5,
                        ),
                        Text(utakmica.opisUtakmice.toString().toUpperCase(),
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
                                .format(
                                    DateTime.parse(utakmica.datumOdigravanja))
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
                              borderRadius:
                                  BorderRadius.all(Radius.circular(5))),
                          child: Padding(
                            padding: EdgeInsets.only(left: 7, right: 7),
                            child: Text(
                                "za " +
                                    daysBetween(
                                            DateTime.now(),
                                            DateTime.parse(
                                                utakmica.datumOdigravanja))
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
                        Text(utakmica.satnica + " h",
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
                          Icons.location_on,
                          color: Colors.white,
                          size: 18,
                        ),
                        SizedBox(
                          width: 5,
                        ),
                        Text(
                            "STADION " +
                                utakmica.stadion.nazivStadiona
                                    .toString()
                                    .toUpperCase() +
                                ", " +
                                utakmica.stadion.lokacijaStadiona.nazivGrada,
                            style: GoogleFonts.oswald(
                              fontSize: 14,
                              color: Colors.white,
                              letterSpacing: 0,
                            )),
                        SizedBox(
                          width: 5,
                        ),
                        CircleAvatar(
                          radius: 8,
                          backgroundColor: Colors.white,
                          child: CircleAvatar(
                            radius: 16,
                            backgroundColor: Colors.white,
                            child: ClipOval(
                              child: Image.memory(
                                Uint8List.fromList(utakmica
                                    .stadion.lokacijaStadiona.drzava.zastava),
                                width: 15.5,
                                height: 15.5,
                                fit: BoxFit.cover,
                              ),
                            ),
                          ),
                        )
                      ]),
                    ],
                  )),
            ),
          ),
        ),
      )
    ],
  );
}

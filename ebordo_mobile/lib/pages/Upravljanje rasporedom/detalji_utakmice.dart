import 'dart:typed_data';
import 'package:ebordo_mobile/models/utakmica-sastav.dart';
import 'package:ebordo_mobile/pages/Shared/shared_app_bar.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20igra%C4%8Dima/detalji_igraca.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import '../../models/utakmica.dart';

int daysBetween(DateTime from, DateTime to) {
  from = DateTime(from.year, from.month, from.day);
  to = DateTime(to.year, to.month, to.day);
  return (to.difference(from).inHours / 24).round();
}

List<UtakmicaSastav> prvaPostava = [];
List<UtakmicaSastav> klupa = [];
String garnituraDresaSlika = "";
String garnituraDresaNaziv = "";

class DetaljiUtakmice extends StatefulWidget {
  final Utakmica? utakmica;
  DetaljiUtakmice({Key? key, this.utakmica}) : super(key: key);

  @override
  _DetaljiUtakmiceState createState() => _DetaljiUtakmiceState();
}

class _DetaljiUtakmiceState extends State<DetaljiUtakmice> {
  @override
  // ignore: must_call_super
  void initState() {
    if (prvaPostava.length == 0) {
      GetSastav();
    }
    if (widget.utakmica!.tipGarniture == "Domaća") {
      garnituraDresaSlika = 'assets/domaci.png';
      garnituraDresaNaziv = "DOMAĆA GARNITURA";
    } else if (widget.utakmica!.tipGarniture == "Gostujuća") {
      garnituraDresaSlika = 'assets/gostujuci.png';
      garnituraDresaNaziv = "GOSTUJUĆA GARNITURA";
    } else {
      garnituraDresaSlika = 'assets/rezervni.png';
      garnituraDresaNaziv = "REZERVNA GARNITURA";
    }
  }

  void GetSastav() {
    widget.utakmica!.sastav.forEach((element) {
      if (element.uloga == "PRVA_POSTAVA") {
        prvaPostava.add(element);
      } else {
        klupa.add(element);
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: SharedAppBar(),
      body: ListView(
        children: [
          Container(
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.only(
                      bottomRight: Radius.circular(0),
                      bottomLeft: Radius.circular(0)),
                  image: DecorationImage(
                      fit: BoxFit.cover,
                      image: AssetImage('assets/login-background-slika.png'))),
              child: Padding(
                padding:
                    EdgeInsets.only(left: 13, top: 10, right: 13, bottom: 30),
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.start,
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        Text("DETALJI O UTAKMICI",
                            style: GoogleFonts.oswald(
                                fontSize: 18,
                                color: HexColor("#400507"),
                                letterSpacing: 0,
                                fontWeight: FontWeight.bold)),
                        Padding(
                          padding: EdgeInsets.only(right: 0),
                          child: Image.asset(
                            'assets/grb-animacija.gif',
                            fit: BoxFit.contain,
                            height: 35,
                          ),
                        ),
                      ],
                    ),
                    SizedBox(
                      height: 20,
                    ),
                    widget.utakmica!.vrstaUtakmice == "Domaća"
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
                                          color: Colors.black,
                                          letterSpacing: 0,
                                          fontWeight: FontWeight.w600)),
                                ],
                              ),
                              Container(
                                child: Image.memory(
                                  Uint8List.fromList(
                                      widget.utakmica!.takmicenje.logo),
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
                                          widget.utakmica!.protivnik.grb),
                                      height: 40,
                                      width: 40,
                                    ),
                                  ),
                                  SizedBox(width: 7),
                                  Text(
                                      widget.utakmica!.protivnik.nazivKluba
                                          .toString()
                                          .toUpperCase(),
                                      style: GoogleFonts.oswald(
                                          fontSize: 19,
                                          color: Colors.black,
                                          letterSpacing: 0,
                                          fontWeight: FontWeight.w600)),
                                ],
                              ),
                              Container(
                                child: Image.memory(
                                  Uint8List.fromList(
                                      widget.utakmica!.takmicenje.logo),
                                  height: 40,
                                  width: 40,
                                ),
                              )
                            ],
                          ),
                    SizedBox(height: 10),
                    widget.utakmica!.vrstaUtakmice == "Gostujuća"
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
                                          color: Colors.black,
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
                                          widget.utakmica!.protivnik.grb),
                                      height: 40,
                                      width: 40,
                                    ),
                                  ),
                                  SizedBox(width: 7),
                                  Text(
                                      widget.utakmica!.protivnik.nazivKluba
                                          .toString()
                                          .toUpperCase(),
                                      style: GoogleFonts.oswald(
                                          fontSize: 19,
                                          color: Colors.black,
                                          letterSpacing: 0,
                                          fontWeight: FontWeight.w600)),
                                ],
                              ),
                            ],
                          ),
                    SizedBox(height: 10),
                    Row(children: [
                      Icon(
                        widget.utakmica!.vrstaUtakmice == "Gostujuća"
                            ? CupertinoIcons.airplane
                            : Icons.home,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          widget.utakmica!.vrstaUtakmice == "Domaća"
                              ? "DOMAĆA UTAKMICA"
                              : "GOSTUJUĆA UTAKMICA",
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.emoji_events,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          widget.utakmica!.opisUtakmice
                              .toString()
                              .toUpperCase(),
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                      SizedBox(
                        width: 5,
                      ),
                      Image.memory(
                        Uint8List.fromList(widget.utakmica!.takmicenje.logo),
                        height: 18,
                        fit: BoxFit.cover,
                      )
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.calendar_month,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          DateFormat.yMMMd()
                              .format(DateTime.parse(
                                  widget.utakmica!.datumOdigravanja))
                              .toString(),
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
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
                              "za " +
                                  daysBetween(
                                          DateTime.now(),
                                          DateTime.parse(widget
                                              .utakmica!.datumOdigravanja))
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
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(widget.utakmica!.satnica + " h",
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          ))
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.location_on,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          "STADION " +
                              widget.utakmica!.stadion.nazivStadiona
                                  .toString()
                                  .toUpperCase() +
                              ", " +
                              widget.utakmica!.stadion.lokacijaStadiona
                                  .nazivGrada,
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
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
                              Uint8List.fromList(widget.utakmica!.stadion
                                  .lokacijaStadiona.drzava.zastava),
                              width: 15.5,
                              height: 15.5,
                              fit: BoxFit.cover,
                            ),
                          ),
                        ),
                      ),
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.sports,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(widget.utakmica!.sudija.toString().toUpperCase(),
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Image.asset(
                        garnituraDresaSlika,
                        fit: BoxFit.contain,
                        height: 18,
                        width: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(garnituraDresaNaziv,
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          ))
                    ]),
                    SizedBox(height: 6),
                    Text("KAPITEN",
                        style: GoogleFonts.oswald(
                            fontSize: 15,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                    SizedBox(height: 3),
                    Row(
                      children: [
                        CircleAvatar(
                          radius: 14,
                          backgroundColor: Colors.white,
                          child: CircleAvatar(
                            radius: 13.5,
                            backgroundColor: Colors.white,
                            child: ClipOval(
                              child: Image.memory(
                                Uint8List.fromList(
                                    widget.utakmica!.kapiten.korisnik.slika),
                                width: 50,
                                height: 50,
                                fit: BoxFit.cover,
                              ),
                            ),
                          ),
                        ),
                        SizedBox(width: 5),
                        Text(
                            widget.utakmica!.kapiten.korisnik.ime
                                    .toString()
                                    .toUpperCase() +
                                " " +
                                widget.utakmica!.kapiten.korisnik.prezime
                                    .toString()
                                    .toUpperCase(),
                            style: GoogleFonts.oswald(
                                fontSize: 15,
                                color: Colors.black,
                                letterSpacing: 0,
                                fontWeight: FontWeight.bold)),
                        SizedBox(
                          height: 20,
                        ),
                      ],
                    ),
                  ],
                ),
              )),
          SizedBox(
            height: 20,
          ),
          Padding(
            padding: EdgeInsets.only(left: 13, top: 10, right: 13, bottom: 30),
            child: Container(
                child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text("POČETNA POSTAVA",
                    style: GoogleFonts.oswald(
                        fontSize: 18,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  height: 10,
                ),
                ListView(
                  scrollDirection: Axis.vertical,
                  shrinkWrap: true,
                  children: prvaPostava
                      .map((element) => IgracNastupKartica(context, element))
                      .toList(),
                ),
                SizedBox(
                  height: 20,
                ),
                Text("KLUPA",
                    style: GoogleFonts.oswald(
                        fontSize: 18,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  height: 10,
                ),
                ListView(
                  scrollDirection: Axis.vertical,
                  shrinkWrap: true,
                  children: klupa
                      .map((element) => IgracNastupKartica(context, element))
                      .toList(),
                ),
                Divider(),
                Text("TRENER",
                    style: GoogleFonts.oswald(
                        fontSize: 15,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(height: 3),
                Row(
                  children: [
                    CircleAvatar(
                      radius: 14,
                      backgroundColor: Colors.white,
                      child: CircleAvatar(
                        radius: 13.5,
                        backgroundColor: Colors.white,
                        child: ClipOval(
                          child: Image.memory(
                            Uint8List.fromList(
                                widget.utakmica!.trener.korisnik.slika),
                            width: 30,
                            height: 30,
                            fit: BoxFit.cover,
                          ),
                        ),
                      ),
                    ),
                    SizedBox(width: 3),
                    Text(
                        widget.utakmica!.trener.korisnik.ime
                                .toString()
                                .toUpperCase() +
                            " " +
                            widget.utakmica!.trener.korisnik.prezime
                                .toString()
                                .toUpperCase(),
                        style: GoogleFonts.oswald(
                            fontSize: 15,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                  ],
                )
              ],
            )),
          ),
        ],
      ),
    );
  }
}

Widget IgracNastupKartica(BuildContext context, UtakmicaSastav element) {
  return TextButton(
    style: TextButton.styleFrom(
        padding: EdgeInsets.zero,
        minimumSize: Size(40, 40),
        alignment: Alignment.centerLeft),
    onPressed: () {
      Navigator.push(
          context,
          MaterialPageRoute(
              builder: (context) => DetaljiIgraca(
                    igrac: element.igrac,
                  )));
    },
    child: Container(
      margin: EdgeInsets.only(bottom: 5),
      height: 40,
      decoration: BoxDecoration(
        borderRadius: BorderRadius.circular(10),
        color: HexColor("#DCDCDC"),
      ),
      child: Row(
        children: [
          Container(
            width: 45,
            height: 40,
            decoration: BoxDecoration(
                borderRadius: BorderRadius.only(
                    topLeft: Radius.circular(10),
                    bottomLeft: Radius.circular(10)),
                color: HexColor("#400507")),
            child: Padding(
              padding: EdgeInsets.only(left: 7),
              child: Align(
                alignment: Alignment.centerLeft,
                child: Text(
                  "#" + element.igrac.brojDresa.toString(),
                  style: GoogleFonts.oswald(
                      fontSize: 17,
                      color: Colors.white,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center,
                ),
              ),
            ),
          ),
          Container(
            height: 40,
            child: Padding(
              padding: EdgeInsets.only(left: 7),
              child: Align(
                alignment: Alignment.centerLeft,
                child: CircleAvatar(
                  radius: 16,
                  backgroundColor: Colors.white,
                  child: CircleAvatar(
                    radius: 15.5,
                    backgroundColor: Colors.white,
                    child: ClipOval(
                      child: Image.memory(
                        Uint8List.fromList(element.igrac.korisnik.slika),
                        width: 30,
                        height: 30,
                        fit: BoxFit.cover,
                      ),
                    ),
                  ),
                ),
              ),
            ),
          ),
          Container(
            height: 40,
            width: 125,
            child: Padding(
              padding: EdgeInsets.only(left: 4),
              child: Align(
                alignment: Alignment.centerLeft,
                child: Text(
                  (element.igrac.korisnik.ime[0].toString() +
                          ". " +
                          element.igrac.korisnik.prezime)
                      .toString()
                      .toUpperCase(),
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center,
                ),
              ),
            ),
          ),
          Container(
            height: 40,
            width: 50,
            child: Padding(
              padding: EdgeInsets.only(left: 4),
              child: Align(
                alignment: Alignment.centerLeft,
                child: Text(
                  element.pozicija.skracenica.toString().toUpperCase(),
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center,
                ),
              ),
            ),
          ),
          Container(
            height: 40,
            child: Padding(
              padding: EdgeInsets.only(left: 4),
              child: Align(
                alignment: Alignment.centerLeft,
                child: RatingBarIndicator(
                  rating:
                      element.igrac.igracStatistika.prosjecnaOcjena.toDouble(),
                  itemBuilder: (context, index) => Icon(
                    Icons.star,
                    color: Colors.amber,
                  ),
                  itemCount: 5,
                  itemSize: 14.0,
                  direction: Axis.horizontal,
                ),
              ),
            ),
          ),
        ],
      ),
    ),
  );
}

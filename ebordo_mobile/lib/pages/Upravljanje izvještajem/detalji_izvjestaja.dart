import 'dart:typed_data';
import 'package:ebordo_mobile/models/izvjestaj.dart';
import 'package:ebordo_mobile/models/utakmica-nastup.dart';
import 'package:ebordo_mobile/pages/Shared/shared_app_bar.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20rasporedom/detalji_utakmice.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import 'package:modal_bottom_sheet/modal_bottom_sheet.dart';
import '../../models/utakmica-izmjena.dart';

int daysBetween(DateTime from, DateTime to) {
  from = DateTime(from.year, from.month, from.day);
  to = DateTime(to.year, to.month, to.day);
  return (to.difference(from).inHours / 24).round();
}

List<UtakmicaNastup> igraciSaUcinkom = [];

class DetaljiIzvjestaja extends StatefulWidget {
  final Izvjestaj? izvjestaj;
  DetaljiIzvjestaja({Key? key, this.izvjestaj}) : super(key: key);

  @override
  _DetaljiIzvjestajaState createState() => _DetaljiIzvjestajaState();
}

Widget getRezultat(izvjestaj) {
  Widget ikonica;
  String rezultat;
  if (izvjestaj.rezultat == 1) {
    ikonica = Icon(
      Icons.check_circle,
      color: HexColor("#28A731"),
      size: 18,
    );
  } else if (izvjestaj.rezultat == 2) {
    ikonica = Icon(
      CupertinoIcons.clear_circled_solid,
      color: Colors.red[800]!,
      size: 18,
    );
  } else {
    ikonica = Icon(
      Icons.do_disturb_on,
      color: Colors.grey,
      size: 18,
    );
  }
  ;
  rezultat = izvjestaj.utakmica.vrstaUtakmice == "Domaća"
      ? izvjestaj.goloviSarajevo.toString() +
          ":" +
          izvjestaj.goloviProtivnik.toString()
      : izvjestaj.goloviProtivnik.toString() +
          ":" +
          izvjestaj.goloviSarajevo.toString();

  return Row(children: [
    ikonica,
    SizedBox(
      width: 5,
    ),
    Text(rezultat,
        style: GoogleFonts.oswald(
          fontSize: 14,
          color: Colors.black,
          letterSpacing: 0,
        )),
  ]);
}

String getRazlogIzmjene(num enumNumber) {
  String razlogIzmjene = "OSTALO";

  if (enumNumber == 1) {
    razlogIzmjene = "POVREDA";
  }
  if (enumNumber == 2) {
    razlogIzmjene = "TAKTIČKI";
  }
  if (enumNumber == 3) {
    razlogIzmjene = "FORMA";
  }

  return razlogIzmjene;
}

Widget ocjene(String tekst, double rating) {
  return Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
    Row(
      children: [
        Icon(
          Icons.star_half,
          color: HexColor("#400507"),
          size: 16,
        ),
        SizedBox(
          width: 3,
        ),
        Text(tekst,
            style: GoogleFonts.oswald(
                fontSize: 12,
                color: HexColor("#400507"),
                letterSpacing: 0,
                fontWeight: FontWeight.w600)),
      ],
    ),
    RatingBarIndicator(
      rating: rating,
      itemBuilder: (context, index) => Icon(
        Icons.star,
        color: Colors.amber,
      ),
      itemCount: 5,
      itemSize: 18,
      direction: Axis.horizontal,
    )
  ]);
}

Widget getOcjeneZaIgraca(UtakmicaNastup nastup, context) {
  return Container(
    decoration: BoxDecoration(
        borderRadius: BorderRadius.only(
            bottomRight: Radius.circular(0), bottomLeft: Radius.circular(0)),
        image: DecorationImage(
            fit: BoxFit.cover,
            image: AssetImage('assets/login-background-slika.png'))),
    child: Padding(
      padding: EdgeInsets.all(15),
      child: Container(
        child: Column(
          children: <Widget>[
            Container(
              height: 180,
              width: double.infinity,
              child: Padding(
                padding: const EdgeInsets.all(0),
                child: Stack(
                  children: [
                    Positioned(
                      top: 10.0,
                      left: 15.0,
                      right: 0.0,
                      child: Text("#" + nastup.igrac.brojDresa.toString(),
                          style: GoogleFonts.oswald(
                            fontSize: 16,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                    ),
                    Align(
                      alignment: Alignment(1, -1.05),
                      child: InkWell(
                        onTap: () {
                          Navigator.pop(context);
                        },
                        child: Container(
                          decoration: BoxDecoration(
                            color: Colors.grey[200],
                            borderRadius: BorderRadius.circular(12),
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
                    Container(
                        margin: EdgeInsets.fromLTRB(15, 0, 0, 0),
                        height: 300,
                        width: 125,
                        child: FittedBox(
                          child: Image.memory(
                              Uint8List.fromList(nastup.igrac.slikaPanel)),
                          fit: BoxFit.cover,
                        )),
                    Padding(
                      padding: EdgeInsets.fromLTRB(145, 18, 0, 0),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Row(
                            children: [
                              Text(nastup.igrac.korisnik.ime,
                                  style: GoogleFonts.oswald(
                                      fontSize: 17,
                                      color: Colors.black,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.w300)),
                              SizedBox(
                                width: 3,
                              ),
                              Text(nastup.igrac.korisnik.prezime.toUpperCase(),
                                  style: GoogleFonts.oswald(
                                      fontSize: 17,
                                      color: Colors.black,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.bold)),
                              SizedBox(
                                width: 5,
                              ),
                              CircleAvatar(
                                radius: 8,
                                backgroundColor: Colors.black,
                                child: CircleAvatar(
                                  radius: 18,
                                  backgroundColor: Colors.black,
                                  child: ClipOval(
                                    child: Image.memory(
                                      Uint8List.fromList(nastup.igrac.korisnik
                                          .drzavljanstvo.zastava),
                                      width: 17.5,
                                      height: 17.5,
                                      fit: BoxFit.cover,
                                    ),
                                  ),
                                ),
                              ),
                            ],
                          ),
                          SizedBox(
                            height: 7,
                          ),
                          Row(children: [
                            Icon(
                              Icons.fact_check_outlined,
                              color: Colors.black,
                              size: 18,
                            ),
                            SizedBox(
                              width: 5,
                            ),
                            Text(
                                nastup.igrac.pozicija.skracenica +
                                    " - " +
                                    nastup.igrac.pozicija.nazivPozicije
                                        .toString()
                                        .toUpperCase(),
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
                              Icons.calendar_month,
                              color: Colors.black,
                              size: 18,
                            ),
                            SizedBox(
                              width: 5,
                            ),
                            Text(
                                (DateTime.now().year -
                                        DateTime.parse(nastup
                                                .igrac.korisnik.datumRodjenja)
                                            .year)
                                    .toString(),
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
                            Image.asset(
                              'assets/nastupi.png',
                              height: 18,
                            ),
                            SizedBox(
                              width: 5,
                            ),
                            Text(nastup.minute.toString() + "'".toString(),
                                style: GoogleFonts.oswald(
                                  fontSize: 14,
                                  color: Colors.black,
                                  letterSpacing: 0,
                                )),
                          ]),
                          SizedBox(
                            height: 8,
                          ),
                          Row(
                            crossAxisAlignment: CrossAxisAlignment.center,
                            mainAxisAlignment: MainAxisAlignment.start,
                            children: [
                              Image.asset(
                                'assets/golovi.png',
                                height: 18,
                              ),
                              SizedBox(
                                width: 5,
                              ),
                              Text(nastup.golovi.toString(),
                                  style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: Colors.black,
                                    letterSpacing: 0,
                                  )),
                              SizedBox(
                                width: 10,
                              ),
                              Image.asset(
                                'assets/asistencije.png',
                                height: 18,
                              ),
                              SizedBox(
                                width: 5,
                              ),
                              Text(nastup.asistencije.toString(),
                                  style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: Colors.black,
                                    letterSpacing: 0,
                                  )),
                              SizedBox(
                                width: 10,
                              ),
                              Image.asset(
                                'assets/zuti.png',
                                height: 17,
                              ),
                              SizedBox(
                                width: 5,
                              ),
                              Text(nastup.zutiKartoni.toString(),
                                  style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: Colors.black,
                                    letterSpacing: 0,
                                  )),
                              SizedBox(
                                width: 10,
                              ),
                              Image.asset(
                                'assets/crveni.png',
                                height: 17,
                              ),
                              SizedBox(
                                width: 5,
                              ),
                              Text(nastup.crveniKartoni.toString(),
                                  style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: Colors.black,
                                    letterSpacing: 0,
                                  )),
                            ],
                          ),
                          SizedBox(
                            height: 6,
                          ),
                          RatingBarIndicator(
                            rating: nastup.ocjena.toDouble(),
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
            SizedBox(
              height: 15,
            ),
            ocjene("KONTROLA LOPTE",
                nastup.igrac.igracSkills.kontrolaLopte.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene("DRIBLANJE", nastup.igrac.igracSkills.driblanje.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene("DODAVANJE", nastup.igrac.igracSkills.dodavanje.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene("KRETANJE", nastup.igrac.igracSkills.kretanje.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene("BRZINA", nastup.igrac.igracSkills.brzina.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene("ŠUT", nastup.igrac.igracSkills.sut.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene("SNAGA", nastup.igrac.igracSkills.snaga.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene(
                "MARKIRANJE", nastup.igrac.igracSkills.markiranje.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene("KLIZEĆI START",
                nastup.igrac.igracSkills.klizeciStart.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene("SKOK", nastup.igrac.igracSkills.skok.toDouble()),
            SizedBox(
              height: 3,
            ),
            ocjene("ODBRANA", nastup.igrac.igracSkills.odbrana.toDouble()),
            SizedBox(
              height: 15,
            ),
            Row(
              children: [
                Icon(
                  Icons.text_snippet,
                  color: HexColor("#400507"),
                  size: 16,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("KOMENTAR: " + nastup.komentar,
                    style: GoogleFonts.oswald(
                        fontSize: 12,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.w600)),
              ],
            ),
          ],
        ),
      ),
    ),
  );
}

void GetIgraceSaUcinkom(Izvjestaj izvjestaj) {
  igraciSaUcinkom = [];
  izvjestaj.nastupi.forEach((element) {
    // if (element.minute > 0 && !igraciSaUcinkom.contains(element)) {
    //   igraciSaUcinkom.add(element);
    // }
    if (element.golovi > 0 && !igraciSaUcinkom.contains(element)) {
      igraciSaUcinkom.add(element);
    }
    if (element.asistencije > 0 && !igraciSaUcinkom.contains(element)) {
      igraciSaUcinkom.add(element);
    }
    if (element.zutiKartoni > 0 && !igraciSaUcinkom.contains(element)) {
      igraciSaUcinkom.add(element);
    }
    if (element.crveniKartoni > 0 && !igraciSaUcinkom.contains(element)) {
      igraciSaUcinkom.add(element);
    }
  });
}

class _DetaljiIzvjestajaState extends State<DetaljiIzvjestaja> {
  @override
  Widget build(BuildContext context) {
    GetIgraceSaUcinkom(widget.izvjestaj!);
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
                    EdgeInsets.only(left: 13, top: 10, right: 13, bottom: 20),
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
                    widget.izvjestaj!.utakmica.vrstaUtakmice == "Domaća"
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
                                  Uint8List.fromList(widget
                                      .izvjestaj!.utakmica.takmicenje.logo),
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
                                      Uint8List.fromList(widget
                                          .izvjestaj!.utakmica.protivnik.grb),
                                      height: 40,
                                      width: 40,
                                    ),
                                  ),
                                  SizedBox(width: 7),
                                  Text(
                                      widget.izvjestaj!.utakmica.protivnik
                                          .nazivKluba
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
                                  Uint8List.fromList(widget
                                      .izvjestaj!.utakmica.takmicenje.logo),
                                  height: 40,
                                  width: 40,
                                ),
                              )
                            ],
                          ),
                    SizedBox(height: 10),
                    widget.izvjestaj!.utakmica.vrstaUtakmice == "Gostujuća"
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
                                      Uint8List.fromList(widget
                                          .izvjestaj!.utakmica.protivnik.grb),
                                      height: 40,
                                      width: 40,
                                    ),
                                  ),
                                  SizedBox(width: 7),
                                  Text(
                                      widget.izvjestaj!.utakmica.protivnik
                                          .nazivKluba
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
                    getRezultat(widget.izvjestaj),
                    SizedBox(height: 6),
                    Row(children: [
                      Icon(
                        widget.izvjestaj!.utakmica.vrstaUtakmice == "Gostujuća"
                            ? CupertinoIcons.airplane
                            : Icons.home,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          widget.izvjestaj!.utakmica.vrstaUtakmice == "Domaća"
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
                          widget.izvjestaj!.utakmica.opisUtakmice
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
                        Uint8List.fromList(
                            widget.izvjestaj!.utakmica.takmicenje.logo),
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
                                  widget.izvjestaj!.utakmica.datumOdigravanja))
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
                              "prije " +
                                  daysBetween(
                                    DateTime.parse(widget
                                        .izvjestaj!.utakmica.datumOdigravanja),
                                    DateTime.now(),
                                  ).toString() +
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
                      Text(widget.izvjestaj!.utakmica.satnica + " h",
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
                              widget.izvjestaj!.utakmica.stadion.nazivStadiona
                                  .toString()
                                  .toUpperCase() +
                              ", " +
                              widget.izvjestaj!.utakmica.stadion
                                  .lokacijaStadiona.nazivGrada,
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
                              Uint8List.fromList(widget.izvjestaj!.utakmica
                                  .stadion.lokacijaStadiona.drzava.zastava),
                              width: 15.5,
                              height: 15.5,
                              fit: BoxFit.cover,
                            ),
                          ),
                        ),
                      ),
                    ]),
                    SizedBox(
                      height: 10,
                    ),
                    ClipRRect(
                      borderRadius: BorderRadius.circular(12.0),
                      child: Image.memory(
                        Uint8List.fromList(widget.izvjestaj!.slikaSaUtakmice),
                        width: MediaQuery.of(context).size.width,
                      ),
                    ),
                  ],
                ),
              )),
          SizedBox(
            height: 20,
          ),
          Padding(
            padding: EdgeInsets.only(left: 13, top: 0, right: 13, bottom: 30),
            child: Container(
                child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                SizedBox(
                  height: 40,
                  width: MediaQuery.of(context).size.width,
                  child: TextButton.icon(
                    style: TextButton.styleFrom(
                      textStyle: TextStyle(color: Colors.blue),
                      backgroundColor: HexColor("#400507"),
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(25),
                      ),
                    ),
                    onPressed: () => {
                      Navigator.push(
                          context,
                          MaterialPageRoute(
                              builder: (context) => DetaljiUtakmice(
                                    utakmica: widget.izvjestaj!.utakmica,
                                  )))
                    },
                    icon: Icon(Icons.info_outline, color: Colors.white),
                    label: Text("PREGLED UTAKMICE",
                        style: GoogleFonts.ubuntu(
                            fontSize: 16,
                            color: Colors.white,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                  ),
                ),
                SizedBox(
                  height: 20,
                ),
                Text("IZMJENE NA UTAKMICI",
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
                  children: widget.izvjestaj!.izmjene
                      .map(
                          (element) => UtakmicaIzmjenaKartica(context, element))
                      .toList(),
                ),
                SizedBox(
                  height: 20,
                ),
                Text("OCJENE SA UTAKMICE",
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
                  children: widget.izvjestaj!.nastupi
                      .map((element) => IgracNastupKartica(context, element))
                      .toList(),
                ),
                SizedBox(
                  height: 20,
                ),
                Text("UČINAK IGRAČA NA UTAKMICI",
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
                  children: igraciSaUcinkom
                      .map((element) => IgracUcinakKartica(context, element))
                      .toList(),
                ),
                SizedBox(
                  height: 10,
                ),
                Text("IGRAČ UTAKMICE",
                    style: GoogleFonts.oswald(
                        fontSize: 18,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  height: 10,
                ),
                Container(
                  decoration: BoxDecoration(
                      borderRadius: BorderRadius.all(Radius.circular(15)),
                      image: DecorationImage(
                          fit: BoxFit.cover,
                          image:
                              AssetImage('assets/igrac-kartica-pozadina.png'))),
                  child: Stack(children: [
                    Positioned(
                      top: 0.0,
                      left: 15,
                      right: 0.0,
                      child: Text(
                          "#" +
                              widget.izvjestaj!.igracUtakmica.brojDresa
                                  .toString(),
                          style: GoogleFonts.oswald(
                            fontSize: 37,
                            color: Colors.white,
                            letterSpacing: 0,
                          )),
                    ),
                    Positioned(
                      top: 15,
                      left: MediaQuery.of(context).size.width - 70,
                      right: 0.0,
                      child: CircleAvatar(
                        radius: 15,
                        backgroundColor: Colors.white,
                        child: CircleAvatar(
                          radius: 30,
                          backgroundColor: Colors.white,
                          child: ClipOval(
                            child: Image.memory(
                              Uint8List.fromList(widget.izvjestaj!.igracUtakmica
                                  .korisnik.drzavljanstvo.zastava),
                              width: 33,
                              height: 33,
                              fit: BoxFit.cover,
                            ),
                          ),
                        ),
                      ),
                    ),
                    Column(children: [
                      Image.memory(
                          Uint8List.fromList(
                              widget.izvjestaj!.igracUtakmica.slikaPanel),
                          fit: BoxFit.cover),
                      SizedBox(height: 5),
                      Row(
                        crossAxisAlignment: CrossAxisAlignment.center,
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          Text(
                              widget.izvjestaj!.igracUtakmica.korisnik.ime
                                      .toString()
                                      .toUpperCase() +
                                  " " +
                                  widget
                                      .izvjestaj!.igracUtakmica.korisnik.prezime
                                      .toString()
                                      .toUpperCase(),
                              style: GoogleFonts.oswald(
                                  fontSize: 30,
                                  color: Colors.white,
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold)),
                        ],
                      ),
                      Text(
                          widget
                              .izvjestaj!.igracUtakmica.korisnik.korisnickoIme,
                          style: GoogleFonts.oswald(
                              fontSize: 15,
                              color: Colors.white,
                              letterSpacing: 0,
                              fontWeight: FontWeight.w300)),
                      SizedBox(
                        height: 5,
                      ),
                      Text(
                          widget.izvjestaj!.igracUtakmica.pozicija.skracenica +
                              " - " +
                              widget.izvjestaj!.igracUtakmica.pozicija
                                  .nazivPozicije
                                  .toString()
                                  .toUpperCase(),
                          style: GoogleFonts.oswald(
                              fontSize: 16,
                              color: Colors.white,
                              letterSpacing: 0,
                              fontWeight: FontWeight.bold)),
                      SizedBox(
                        height: 5,
                      ),
                      RatingBarIndicator(
                        rating: widget.izvjestaj!.igracUtakmica.igracStatistika
                            .prosjecnaOcjena
                            .toDouble(),
                        itemBuilder: (context, index) => Icon(
                          Icons.star,
                          color: Colors.amber,
                        ),
                        itemCount: 5,
                        itemSize: 28,
                        direction: Axis.horizontal,
                      ),
                      SizedBox(
                        height: 10,
                      ),
                    ]),
                  ]),
                ),
              ],
            )),
          ),
        ],
      ),
    );
  }
}

Widget UtakmicaIzmjenaKartica(BuildContext context, UtakmicaIzmjena element) {
  return Container(
      margin: EdgeInsets.only(bottom: 5),
      decoration: BoxDecoration(
        borderRadius: BorderRadius.circular(10),
        color: HexColor("#DCDCDC"),
      ),
      child: Padding(
        padding: EdgeInsets.all(10),
        child: Column(
          children: [
            Row(
              children: [
                Text("MINUTA: ",
                    style: GoogleFonts.oswald(
                        fontSize: 12,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(width: 2),
                Text(element.minuta.toString() + "'",
                    style: GoogleFonts.oswald(
                        fontSize: 12,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
              ],
            ),
            SizedBox(
              height: 4,
            ),
            Row(
              children: [
                Text("RAZLOG IZMJENE: ",
                    style: GoogleFonts.oswald(
                        fontSize: 12,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(width: 2),
                Text(getRazlogIzmjene(element.IzmjenaRazlog).toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 12,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
              ],
            ),
            SizedBox(
              height: 4,
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Container(
                  width: 160,
                  child: Row(
                    children: [
                      Image.asset(
                        'assets/out.png',
                        fit: BoxFit.contain,
                        height: 10,
                      ),
                      SizedBox(width: 5),
                      CircleAvatar(
                        radius: 7.5,
                        backgroundColor: Colors.white,
                        child: CircleAvatar(
                          radius: 7.5,
                          backgroundColor: Colors.white,
                          child: ClipOval(
                            child: Image.memory(
                              Uint8List.fromList(
                                  element.igracOut.korisnik.slika),
                              width: 17,
                              height: 17,
                              fit: BoxFit.cover,
                            ),
                          ),
                        ),
                      ),
                      SizedBox(width: 3),
                      Text(
                          element.igracOut.korisnik.ime +
                              " " +
                              element.igracOut.korisnik.prezime.toUpperCase() +
                              " ",
                          style: GoogleFonts.oswald(
                              fontSize: 12,
                              color: Colors.black,
                              letterSpacing: 0,
                              fontWeight: FontWeight.bold)),
                    ],
                  ),
                ),
                Container(
                  width: 35,
                  child: Text(
                      element.igracOut.pozicija.skracenica
                          .toUpperCase()
                          .toString(),
                      style: GoogleFonts.oswald(
                          fontSize: 12,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                ),
                Container(
                  width: 25,
                  child: Text("#" + element.igracOut.brojDresa.toString(),
                      style: GoogleFonts.oswald(
                          fontSize: 12,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                )
              ],
            ),
            SizedBox(
              height: 4,
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Container(
                  width: 160,
                  child: Row(
                    children: [
                      Image.asset(
                        'assets/in.png',
                        fit: BoxFit.contain,
                        height: 10,
                      ),
                      SizedBox(width: 5),
                      CircleAvatar(
                        radius: 7.5,
                        backgroundColor: Colors.white,
                        child: CircleAvatar(
                          radius: 7.5,
                          backgroundColor: Colors.white,
                          child: ClipOval(
                            child: Image.memory(
                              Uint8List.fromList(
                                  element.igracIn.korisnik.slika),
                              width: 17,
                              height: 17,
                              fit: BoxFit.cover,
                            ),
                          ),
                        ),
                      ),
                      SizedBox(width: 3),
                      Text(
                          element.igracIn.korisnik.ime +
                              " " +
                              element.igracIn.korisnik.prezime.toUpperCase() +
                              " ",
                          style: GoogleFonts.oswald(
                              fontSize: 12,
                              color: Colors.black,
                              letterSpacing: 0,
                              fontWeight: FontWeight.bold)),
                    ],
                  ),
                ),
                Container(
                  width: 35,
                  child: Text(
                      element.igracIn.pozicija.skracenica
                          .toUpperCase()
                          .toString(),
                      style: GoogleFonts.oswald(
                          fontSize: 12,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                ),
                Container(
                  width: 25,
                  child: Text("#" + element.igracIn.brojDresa.toString(),
                      style: GoogleFonts.oswald(
                          fontSize: 12,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                )
              ],
            ),
          ],
        ),
      ));
}

Widget IgracNastupKartica(BuildContext context, UtakmicaNastup element) {
  return TextButton(
    style: TextButton.styleFrom(
        padding: EdgeInsets.zero,
        minimumSize: Size(40, 40),
        alignment: Alignment.centerLeft),
    onPressed: () => {
      showCupertinoModalBottomSheet(
        context: context,
        topRadius: Radius.circular(20),
        builder: (context) => Container(
          height: 490,
          child: Material(
            child: getOcjeneZaIgraca(element, context),
          ),
        ),
      )
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
            width: 40,
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
                      fontSize: 15,
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
                  radius: 12,
                  backgroundColor: Colors.white,
                  child: CircleAvatar(
                    radius: 12.5,
                    backgroundColor: Colors.white,
                    child: ClipOval(
                      child: Image.memory(
                        Uint8List.fromList(element.igrac.korisnik.slika),
                        width: 24,
                        height: 24,
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
                      fontSize: 13,
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
                  element.igrac.pozicija.skracenica.toString().toUpperCase(),
                  style: GoogleFonts.oswald(
                      fontSize: 13,
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
                  rating: element.ocjena.toDouble(),
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

Widget IgracUcinakKartica(BuildContext context, UtakmicaNastup element) {
  return TextButton(
    style: TextButton.styleFrom(
        padding: EdgeInsets.zero,
        minimumSize: Size(40, 40),
        alignment: Alignment.centerLeft),
    onPressed: () => {
      showCupertinoModalBottomSheet(
        context: context,
        topRadius: Radius.circular(20),
        builder: (context) => Container(
          height: 490,
          child: Material(
            child: getOcjeneZaIgraca(element, context),
          ),
        ),
      )
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
            width: 40,
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
                      fontSize: 15,
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
                  radius: 12,
                  backgroundColor: Colors.white,
                  child: CircleAvatar(
                    radius: 12.5,
                    backgroundColor: Colors.white,
                    child: ClipOval(
                      child: Image.memory(
                        Uint8List.fromList(element.igrac.korisnik.slika),
                        width: 24,
                        height: 24,
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
            width: 110,
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
                      fontSize: 13,
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
                padding: EdgeInsets.only(),
                child: Align(
                    alignment: Alignment.centerLeft,
                    child: Row(
                      children: [
                        Image.asset(
                          'assets/nastupi.png',
                          height: 18,
                        ),
                        SizedBox(
                          width: 3,
                        ),
                        Text(
                          element.minute.toString() + "'",
                          style: GoogleFonts.oswald(
                              fontSize: 15,
                              color: Colors.black,
                              letterSpacing: 0,
                              fontWeight: FontWeight.bold),
                          textAlign: TextAlign.center,
                        ),
                      ],
                    ))),
          ),
          SizedBox(
            width: 10,
          ),
          (element.golovi > 0 ||
                  element.asistencije > 0 ||
                  element.zutiKartoni > 0 ||
                  element.crveniKartoni > 0)
              ? Row(
                  children: [
                    Container(
                      height: 40,
                      child: Padding(
                          padding: EdgeInsets.only(),
                          child: Align(
                              alignment: Alignment.centerLeft,
                              child: ListView.builder(
                                  scrollDirection: Axis.horizontal,
                                  shrinkWrap: true,
                                  itemCount: element.golovi,
                                  itemBuilder:
                                      (BuildContext context, int index) {
                                    return Align(
                                      alignment: Alignment.centerLeft,
                                      child: Row(
                                        children: [
                                          Image.asset(
                                            'assets/golovi.png',
                                            height: 18,
                                          ),
                                          SizedBox(
                                            width: 3,
                                          )
                                        ],
                                      ),
                                    );
                                  }))),
                    ),
                    Container(
                      height: 40,
                      child: Padding(
                          padding: EdgeInsets.only(),
                          child: Align(
                              alignment: Alignment.centerLeft,
                              child: ListView.builder(
                                  scrollDirection: Axis.horizontal,
                                  shrinkWrap: true,
                                  itemCount: element.asistencije,
                                  itemBuilder:
                                      (BuildContext context, int index) {
                                    return Align(
                                      alignment: Alignment.centerLeft,
                                      child: Row(
                                        children: [
                                          Image.asset(
                                            'assets/asistencije.png',
                                            height: 18,
                                          ),
                                          SizedBox(
                                            width: 3,
                                          )
                                        ],
                                      ),
                                    );
                                  }))),
                    ),
                    Container(
                      height: 40,
                      child: Padding(
                          padding: EdgeInsets.only(),
                          child: Align(
                              alignment: Alignment.centerLeft,
                              child: ListView.builder(
                                  scrollDirection: Axis.horizontal,
                                  shrinkWrap: true,
                                  itemCount: element.zutiKartoni,
                                  itemBuilder:
                                      (BuildContext context, int index) {
                                    return Align(
                                      alignment: Alignment.centerLeft,
                                      child: Row(
                                        children: [
                                          Image.asset(
                                            'assets/zuti.png',
                                            height: 19,
                                          ),
                                          SizedBox(
                                            width: 3,
                                          )
                                        ],
                                      ),
                                    );
                                  }))),
                    ),
                    Container(
                      height: 40,
                      child: Padding(
                          padding: EdgeInsets.only(),
                          child: Align(
                              alignment: Alignment.centerLeft,
                              child: ListView.builder(
                                  scrollDirection: Axis.horizontal,
                                  shrinkWrap: true,
                                  itemCount: element.crveniKartoni,
                                  itemBuilder:
                                      (BuildContext context, int index) {
                                    return Align(
                                      alignment: Alignment.centerLeft,
                                      child: Row(
                                        children: [
                                          Image.asset(
                                            'assets/crveni.png',
                                            height: 19,
                                          ),
                                          SizedBox(
                                            width: 3,
                                          )
                                        ],
                                      ),
                                    );
                                  }))),
                    ),
                  ],
                )
              : Row(
                  children: [
                    Icon(
                      CupertinoIcons.clear_circled_solid,
                      color: Colors.red[800]!,
                      size: 14,
                    ),
                    SizedBox(
                      width: 3,
                    ),
                    Text(
                      "Bez učinka!",
                      style: GoogleFonts.oswald(
                          fontSize: 12,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold),
                      textAlign: TextAlign.center,
                    ),
                  ],
                )
        ],
      ),
    ),
  );
}

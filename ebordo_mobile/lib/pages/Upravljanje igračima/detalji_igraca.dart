// ignore_for_file: override_on_non_overriding_member, must_be_immutable
import 'dart:typed_data';
import 'package:expandable/expandable.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import 'package:syncfusion_flutter_charts/charts.dart';

import '../../models/igrac.dart';

class LineChartData {
  LineChartData(this.x, this.y);

  final String x;
  final double y;
}

class PieChartData {
  PieChartData(this.x, this.y, this.color);
  final String x;
  final double y;
  final Color color;
}

class DetaljiIgraca extends StatefulWidget {
  final Igrac? igrac;
  DetaljiIgraca({Key? key, this.igrac}) : super(key: key);

  @override
  late List<LineChartData> data_skills = [
    LineChartData('KON', igrac!.igracSkills.kontrolaLopte.toDouble()),
    LineChartData('DRI', igrac!.igracSkills.driblanje.toDouble()),
    LineChartData('DOD', igrac!.igracSkills.dodavanje.toDouble()),
    LineChartData('KRE', igrac!.igracSkills.kretanje.toDouble()),
    LineChartData('BRZ', igrac!.igracSkills.brzina.toDouble()),
    LineChartData('ŠUT', igrac!.igracSkills.sut.toDouble()),
    LineChartData('SNA', igrac!.igracSkills.snaga.toDouble()),
    LineChartData('MAR', igrac!.igracSkills.markiranje.toDouble()),
    LineChartData('KLI', igrac!.igracSkills.klizeciStart.toDouble()),
    LineChartData('SKO', igrac!.igracSkills.skok.toDouble()),
    LineChartData('ODB', igrac!.igracSkills.odbrana.toDouble()),
  ];
  late TooltipBehavior _tooltip = TooltipBehavior(enable: true);

  late List<PieChartData> data_statistika = [
    PieChartData('GOLOVI', igrac!.igracStatistika.golovi.toDouble(),
        HexColor("#1A3150")),
    PieChartData('ASISTENCIJE', igrac!.igracStatistika.asistencije.toDouble(),
        HexColor("#729C2C")),
    PieChartData('ŽUTI KARTONI', igrac!.igracStatistika.zutiKartoni.toDouble(),
        HexColor("#F8D827")),
    PieChartData('CRVENI KARTONI',
        igrac!.igracStatistika.crveniKartoni.toDouble(), HexColor("#8F1A29")),
  ];

  @override
  _DetaljiIgracaState createState() => _DetaljiIgracaState();
}

Widget opisGrafa(String opis, Color boja) {
  return Row(children: [
    Container(height: 10, width: 10, color: boja),
    SizedBox(
      width: 3,
    ),
    Text(opis,
        style: GoogleFonts.oswald(
          fontSize: 12,
          color: Colors.black,
          letterSpacing: 0,
        )),
    SizedBox(
      width: 10,
    ),
  ]);
}

Widget statistika(String slika, String vrijednost, String opis) {
  return Column(
    crossAxisAlignment: CrossAxisAlignment.start,
    children: [
      Container(
          child: Row(
        children: [
          Image.asset(
            slika,
            height: 23,
          ),
          SizedBox(
            width: 7,
          ),
          Text(vrijednost,
              style: GoogleFonts.oswald(
                  fontSize: 25,
                  color: HexColor("#400507"),
                  letterSpacing: 0,
                  fontWeight: FontWeight.bold)),
        ],
      )),
      Container(
        child: Text(opis,
            style: GoogleFonts.oswald(
                fontSize: 12,
                color: HexColor("#400507"),
                letterSpacing: 0,
                fontWeight: FontWeight.bold)),
      ),
    ],
  );
}

Widget ocjene(String tekst, double rating) {
  return Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
    Row(
      children: [
        Icon(
          Icons.star_half,
          color: HexColor("#400507"),
          size: 18,
        ),
        SizedBox(
          width: 3,
        ),
        Text(tekst,
            style: GoogleFonts.oswald(
                fontSize: 14,
                color: HexColor("#400507"),
                letterSpacing: 0,
                fontWeight: FontWeight.bold)),
      ],
    ),
    RatingBarIndicator(
      rating: rating,
      itemBuilder: (context, index) => Icon(
        Icons.star,
        color: Colors.amber,
      ),
      itemCount: 5,
      itemSize: 20.0,
      direction: Axis.horizontal,
    )
  ]);
}

class _DetaljiIgracaState extends State<DetaljiIgraca> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Stack(
      children: [
        Container(
          height: 210,
          width: double.infinity,
          decoration: BoxDecoration(
              borderRadius: BorderRadius.only(
                  bottomRight: Radius.circular(15),
                  bottomLeft: Radius.circular(15)),
              image: DecorationImage(
                  fit: BoxFit.cover,
                  image: AssetImage('assets/igrac-kartica-pozadina.png'))),
          child: Padding(
            padding: const EdgeInsets.all(0),
            child: Stack(
              children: [
                Positioned(
                  top: 40.0,
                  left: 10.5,
                  right: 0.0,
                  child: Text("#" + widget.igrac!.brojDresa.toString(),
                      style: GoogleFonts.oswald(
                        fontSize: 16,
                        color: Colors.white,
                        letterSpacing: 0,
                      )),
                ),
                Positioned(
                  top: 12.0,
                  left: -310.0,
                  right: 0.0,
                  child: TextButton(
                    onPressed: () {
                      Navigator.pop(context);
                    },
                    child: Icon(
                      Icons.arrow_back,
                      color: Colors.white,
                      size: 19,
                    ),
                  ),
                ),
                Container(
                    margin: EdgeInsets.fromLTRB(25, 0, 0, 0),
                    height: 390,
                    width: 100,
                    child: FittedBox(
                      child: Image.memory(
                          Uint8List.fromList(widget.igrac!.slikaPanel)),
                      fit: BoxFit.cover,
                    )),
                Padding(
                  padding: EdgeInsets.fromLTRB(140, 15, 0, 0),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Row(
                        children: [
                          Text(
                              widget.igrac!.korisnik.ime
                                      .toString()
                                      .toUpperCase() +
                                  " " +
                                  widget.igrac!.korisnik.prezime
                                      .toString()
                                      .toUpperCase(),
                              style: GoogleFonts.oswald(
                                  fontSize: 18,
                                  color: Colors.white,
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold)),
                        ],
                      ),
                      Text(widget.igrac!.korisnik.korisnickoIme,
                          style: GoogleFonts.oswald(
                              fontSize: 13,
                              color: Colors.white,
                              letterSpacing: 0,
                              fontWeight: FontWeight.w300)),
                      SizedBox(
                        height: 10,
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
                            widget.igrac!.pozicija.skracenica +
                                " - " +
                                widget.igrac!.pozicija.nazivPozicije
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
                                    widget.igrac!.korisnik.datumRodjenja))
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
                                Uint8List.fromList(widget
                                    .igrac!.korisnik.drzavljanstvo.zastava),
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
                        Text(widget.igrac!.korisnik.drzavljanstvo.nazivDrzave,
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
                          Text(
                              widget.igrac!.igracStatistika.brojNastupa
                                  .toString(),
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
                          Text(widget.igrac!.igracStatistika.golovi.toString(),
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
                          Text(
                              widget.igrac!.igracStatistika.asistencije
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
                      RatingBarIndicator(
                        rating: widget.igrac!.igracStatistika.prosjecnaOcjena
                            .toDouble(),
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
                ),
              ],
            ),
          ),
        ),
        Padding(
          padding: EdgeInsets.only(left: 13, top: 220, right: 13),
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text("DETALJI O IGRAČU",
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
              )
            ],
          ),
        ),
        Padding(
          padding: EdgeInsets.only(left: 13, top: 260, right: 13),
          child: ListView(
            children: [
              Text("LIČNI PODACI",
                  style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
              SizedBox(
                height: 6,
              ),
              Row(children: [
                Icon(
                  Icons.military_tech,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Status:".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                widget.igrac!.korisnik.isAktivan
                    ? Row(
                        children: [
                          Icon(
                            Icons.check_circle,
                            color: HexColor("#28A731"),
                            size: 18,
                          ),
                          SizedBox(
                            width: 3,
                          ),
                          Text("Aktivan",
                              style: GoogleFonts.oswald(
                                  fontSize: 14,
                                  color: HexColor("#28A731"),
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold))
                        ],
                      )
                    : Row(
                        children: [
                          Icon(
                            Icons.do_disturb_on,
                            color: Colors.red[800]!,
                            size: 18,
                          ),
                          SizedBox(
                            width: 3,
                          ),
                          Text("Bivši igrač",
                              style: GoogleFonts.oswald(
                                  fontSize: 14,
                                  color: Colors.red[800]!,
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold))
                        ],
                      )
              ]),
              SizedBox(
                height: 5,
              ),
              Row(children: [
                Icon(
                  Icons.location_on,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Mjesto rođenja:".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                CircleAvatar(
                  radius: 8,
                  backgroundColor: Colors.white,
                  child: CircleAvatar(
                    radius: 16,
                    backgroundColor: Colors.white,
                    child: ClipOval(
                      child: Image.memory(
                        Uint8List.fromList(
                            widget.igrac!.korisnik.drzavljanstvo.zastava),
                        width: 17.5,
                        height: 17.5,
                        fit: BoxFit.cover,
                      ),
                    ),
                  ),
                ),
                SizedBox(
                  width: 3,
                ),
                Text(
                    widget.igrac!.korisnik.gradRodjenja.nazivGrada +
                        ", " +
                        widget.igrac!.korisnik.gradRodjenja.drzava.nazivDrzave,
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              SizedBox(
                height: 5,
              ),
              Row(children: [
                Icon(
                  Icons.home,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Adresa:".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                Text(widget.igrac!.korisnik.adresa,
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              SizedBox(
                height: 5,
              ),
              Row(children: [
                Icon(
                  Icons.phone,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Telefon:".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                Text("+" + widget.igrac!.korisnik.telefon,
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              SizedBox(
                height: 5,
              ),
              Row(children: [
                Icon(
                  Icons.email,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("E-mail:".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                Text(widget.igrac!.korisnik.email,
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              Divider(),
              Text("PODACI O UGOVORU",
                  style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
              SizedBox(
                height: 5,
              ),
              Row(children: [
                Icon(
                  Icons.calendar_month,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Datum početka ugovora: ".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                Text(
                    DateFormat.yMMMd()
                        .format(
                            DateTime.parse(widget.igrac!.ugovor.datumPocetka))
                        .toString(),
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              SizedBox(
                height: 3,
              ),
              Row(children: [
                Icon(
                  Icons.calendar_month,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Datum završetka ugovora: ".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                Text(
                    DateFormat.yMMMd()
                        .format(
                            DateTime.parse(widget.igrac!.ugovor.datumZavrsetka))
                        .toString(),
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              Divider(),
              Text("PODACI O IGRAČU",
                  style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
              SizedBox(
                height: 5,
              ),
              Container(
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: [
                    statistika(
                        'assets/minute.png',
                        (widget.igrac!.igracStatistika.brojNastupa * 90)
                            .toString(),
                        "UKUPNO MINUTA"),
                    SizedBox(width: 35),
                    statistika(
                        'assets/nastupi.png',
                        widget.igrac!.igracStatistika.brojNastupa.toString(),
                        "NASTUPI"),
                    SizedBox(width: 55),
                    statistika(
                        'assets/golovi.png',
                        widget.igrac!.igracStatistika.golovi.toString(),
                        "GOLOVI"),
                  ],
                ),
              ),
              Container(
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: [
                    statistika(
                        'assets/asistencije.png',
                        widget.igrac!.igracStatistika.asistencije.toString(),
                        "ASISTENCIJE"),
                    SizedBox(width: 60),
                    statistika(
                        'assets/zuti.png',
                        widget.igrac!.igracStatistika.zutiKartoni.toString(),
                        "ŽUTI KARTONI"),
                    SizedBox(width: 30),
                    statistika(
                        'assets/crveni.png',
                        widget.igrac!.igracStatistika.crveniKartoni.toString(),
                        "CRVENI KARTONI")
                  ],
                ),
              ),
              SizedBox(
                height: 10,
              ),
              Divider(),
              SizedBox(
                height: 5,
              ),
              Text("GRAFIČKI PRIKAZ STATISTIKE",
                  style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
              Container(
                  child: SfCircularChart(series: <CircularSeries>[
                PieSeries<PieChartData, String>(
                    dataSource: widget.data_statistika,
                    pointColorMapper: (PieChartData data, _) => data.color,
                    xValueMapper: (PieChartData data, _) => data.x,
                    yValueMapper: (PieChartData data, _) => data.y)
              ])),
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: widget.data_statistika
                    .map<Widget>((item) => opisGrafa(item.x, item.color))
                    .toList(),
              ),
              SizedBox(
                height: 10,
              ),
              Row(children: [
                Icon(
                  Icons.fact_check_outlined,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Pozicija:".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                Text(
                    widget.igrac!.pozicija.skracenica +
                        " - " +
                        widget.igrac!.pozicija.nazivPozicije
                            .toString()
                            .toUpperCase(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
              ]),
              SizedBox(
                height: 3,
              ),
              Row(children: [
                Icon(
                  Icons.done,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Bolja noga:".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                Text(widget.igrac!.boljaNoga,
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              SizedBox(
                height: 3,
              ),
              Row(children: [
                Icon(
                  Icons.bolt,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Jačina slabije noge:".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                RatingBarIndicator(
                  rating: widget.igrac!.jacinaSlabijeNoge.toDouble(),
                  itemBuilder: (context, index) => Icon(
                    Icons.star,
                    color: Colors.amber,
                  ),
                  itemCount: 5,
                  itemSize: 20.0,
                  direction: Axis.horizontal,
                )
              ]),
              SizedBox(
                height: 3,
              ),
              Row(
                children: [
                  Row(children: [
                    Icon(
                      Icons.height,
                      color: HexColor("#400507"),
                      size: 18,
                    ),
                    SizedBox(
                      width: 3,
                    ),
                    Text("Visina (cm):".toString(),
                        style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: HexColor("#400507"),
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                    SizedBox(
                      width: 3,
                    ),
                    Text(widget.igrac!.visina.toString(),
                        style: GoogleFonts.oswald(
                          fontSize: 14,
                          color: Colors.black,
                          letterSpacing: 0,
                        )),
                    SizedBox(
                      width: 6,
                    ),
                    Icon(
                      Icons.fitness_center,
                      color: HexColor("#400507"),
                      size: 18,
                    ),
                    SizedBox(
                      width: 3,
                    ),
                    Text("Težina (kg):".toString(),
                        style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: HexColor("#400507"),
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                    SizedBox(
                      width: 3,
                    ),
                    Text(widget.igrac!.tezina.toString(),
                        style: GoogleFonts.oswald(
                          fontSize: 14,
                          color: Colors.black,
                          letterSpacing: 0,
                        ))
                  ]),
                ],
              ),
              SizedBox(
                height: 3,
              ),
              Row(children: [
                Icon(
                  Icons.paid,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Tržišna vrijednost (€):".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 5,
                ),
                Text(widget.igrac!.trzisnaVrijednost.toString(),
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              SizedBox(
                height: 3,
              ),
              Row(children: [
                Icon(
                  Icons.text_snippet,
                  color: HexColor("#400507"),
                  size: 18,
                ),
                SizedBox(
                  width: 3,
                ),
                Text("Napomene:".toString(),
                    style: GoogleFonts.oswald(
                        fontSize: 14,
                        color: HexColor("#400507"),
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 3,
                ),
                Text(widget.igrac!.napomeneOIgracu.toString(),
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              Divider(),
              ExpandablePanel(
                theme: ExpandableThemeData(
                    inkWellBorderRadius: BorderRadius.all(Radius.circular(12))),
                header: Padding(
                  padding: EdgeInsets.only(top: 5, left: 5),
                  child: Row(
                    crossAxisAlignment: CrossAxisAlignment.center,
                    children: [
                      Icon(
                        Icons.auto_graph,
                        color: HexColor("#400507"),
                        size: 20,
                      ),
                      SizedBox(width: 5),
                      Text("STATISTIKA IGRAČA",
                          style: GoogleFonts.oswald(
                              fontSize: 18,
                              color: HexColor("#400507"),
                              letterSpacing: 0,
                              fontWeight: FontWeight.bold))
                    ],
                  ),
                ),
                collapsed: Text(""),
                expanded: Column(
                  mainAxisAlignment: MainAxisAlignment.start,
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    SizedBox(
                      height: 7,
                    ),
                    ocjene("KONTROLA LOPTE",
                        widget.igrac!.igracSkills.kontrolaLopte.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("DRIBLANJE",
                        widget.igrac!.igracSkills.driblanje.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("DODAVANJE",
                        widget.igrac!.igracSkills.dodavanje.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("KRETANJE",
                        widget.igrac!.igracSkills.kretanje.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene(
                        "BRZINA", widget.igrac!.igracSkills.brzina.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("ŠUT", widget.igrac!.igracSkills.sut.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("SNAGA", widget.igrac!.igracSkills.snaga.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("MARKIRANJE",
                        widget.igrac!.igracSkills.markiranje.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("KLIZEĆI START",
                        widget.igrac!.igracSkills.klizeciStart.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("SKOK", widget.igrac!.igracSkills.skok.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("ODBRANA",
                        widget.igrac!.igracSkills.odbrana.toDouble()),
                    SizedBox(
                      height: 3,
                    ),
                    Divider(),
                    SizedBox(
                      height: 3,
                    ),
                    ocjene("PROSJEČNA OCJENA",
                        widget.igrac!.igracSkills.prosjekOcjena.toDouble()),
                    SizedBox(
                      height: 10,
                    ),
                    Text("GRAFIČKI PRIKAZ STATISTIKE",
                        style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                    SizedBox(
                      height: 5,
                    ),
                    Container(
                        child: SfCartesianChart(
                            primaryXAxis: CategoryAxis(),
                            primaryYAxis: NumericAxis(
                                minimum: 0, maximum: 5, interval: 1),
                            tooltipBehavior: widget._tooltip,
                            series: <ChartSeries<LineChartData, String>>[
                          ColumnSeries<LineChartData, String>(
                              dataSource: widget.data_skills,
                              xValueMapper: (LineChartData data, _) => data.x,
                              yValueMapper: (LineChartData data, _) => data.y,
                              name: 'Gold',
                              color: HexColor("#400507"))
                        ])),
                  ],
                ),
              ),
              SizedBox(height: 20)
            ],
          ),
        )
      ],
    ));
  }
}

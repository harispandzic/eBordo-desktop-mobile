// ignore_for_file: override_on_non_overriding_member, must_be_immutable
import 'dart:typed_data';
import 'package:expandable/expandable.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import 'package:syncfusion_flutter_charts/charts.dart';

import '../../models/trener.dart';

class PieChartData {
  PieChartData(this.x, this.y, this.color);
  final String x;
  final double y;
  final Color color;
}

class DetaljiTrenera extends StatefulWidget {
  final Trener? trener;
  DetaljiTrenera({Key? key, this.trener}) : super(key: key);

  late List<PieChartData> data_statistika = [
    PieChartData('POBJEDE', trener!.trenerStatistika.brojPobjeda.toDouble(),
        HexColor("#28A731")),
    PieChartData('PORAZI', trener!.trenerStatistika.brojPoraza.toDouble(),
        Colors.red[800]!),
    PieChartData('NERJEŠENE',
        trener!.trenerStatistika.brojNerjesenih.toDouble(), Colors.grey),
  ];

  @override
  _DetaljiTreneraState createState() => _DetaljiTreneraState();
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

class _DetaljiTreneraState extends State<DetaljiTrenera> {
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
                          Uint8List.fromList(widget.trener!.slikaPanel)),
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
                              widget.trener!.korisnik.ime
                                      .toString()
                                      .toUpperCase() +
                                  " " +
                                  widget.trener!.korisnik.prezime
                                      .toString()
                                      .toUpperCase(),
                              style: GoogleFonts.oswald(
                                  fontSize: 18,
                                  color: Colors.white,
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold)),
                        ],
                      ),
                      Text(widget.trener!.korisnik.korisnickoIme,
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
                          Icons.workspace_premium_sharp,
                          color: Colors.white,
                          size: 18,
                        ),
                        SizedBox(
                          width: 5,
                        ),
                        Text(widget.trener!.ulogaTrenera.toString() + " TRENER",
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
                                    widget.trener!.korisnik.datumRodjenja))
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
                                    .trener!.korisnik.drzavljanstvo.zastava),
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
                        Text(widget.trener!.korisnik.drzavljanstvo.nazivDrzave,
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
                            widget.trener!.trenerskaLicenca.nazivLicence
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
                          Icons.favorite,
                          color: Colors.white,
                          size: 18,
                        ),
                        SizedBox(
                          width: 5,
                        ),
                        Text(widget.trener!.formacija.nazivFormacije.toString(),
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
                              widget.trener!.trenerStatistika.brojUtakmica
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
                              widget.trener!.trenerStatistika.brojPobjeda
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
                              widget.trener!.trenerStatistika.brojPoraza
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
                            Icons.do_disturb_on,
                            color: Colors.grey,
                            size: 18,
                          ),
                          SizedBox(
                            width: 5,
                          ),
                          Text(
                              widget.trener!.trenerStatistika.brojNerjesenih
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
              Text("DETALJI O TRENERU",
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
                widget.trener!.korisnik.isAktivan
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
                            CupertinoIcons.clear_circled_solid,
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
                        Uint8List.fromList(widget
                            .trener!.korisnik.gradRodjenja.drzava.zastava),
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
                    widget.trener!.korisnik.gradRodjenja.nazivGrada +
                        ", " +
                        widget.trener!.korisnik.gradRodjenja.drzava.nazivDrzave,
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
                Text(widget.trener!.korisnik.adresa,
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
                Text("+" + widget.trener!.korisnik.telefon,
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
                Text(widget.trener!.korisnik.email,
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
                            DateTime.parse(widget.trener!.ugovor.datumPocetka))
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
                        .format(DateTime.parse(
                            widget.trener!.ugovor.datumZavrsetka))
                        .toString(),
                    style: GoogleFonts.oswald(
                      fontSize: 14,
                      color: Colors.black,
                      letterSpacing: 0,
                    )),
              ]),
              Divider(),
              Text("PODACI O TRENERU",
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
                    Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Container(
                            child: Row(
                          children: [
                            Image.asset(
                              'assets/nastupi.png',
                              height: 23,
                            ),
                            SizedBox(
                              width: 7,
                            ),
                            Text(
                                widget.trener!.trenerStatistika.brojUtakmica
                                    .toString(),
                                style: GoogleFonts.oswald(
                                    fontSize: 25,
                                    color: HexColor("#400507"),
                                    letterSpacing: 0,
                                    fontWeight: FontWeight.bold)),
                          ],
                        )),
                        Container(
                          child: Text("NASTUPI",
                              style: GoogleFonts.oswald(
                                  fontSize: 12,
                                  color: HexColor("#400507"),
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold)),
                        ),
                      ],
                    ),
                    SizedBox(width: 30),
                    Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Container(
                            child: Row(
                          children: [
                            Icon(
                              Icons.check_circle,
                              color: HexColor("#28A731"),
                              size: 23,
                            ),
                            SizedBox(
                              width: 7,
                            ),
                            Text(
                                widget.trener!.trenerStatistika.brojPobjeda
                                    .toString(),
                                style: GoogleFonts.oswald(
                                    fontSize: 25,
                                    color: HexColor("#400507"),
                                    letterSpacing: 0,
                                    fontWeight: FontWeight.bold)),
                          ],
                        )),
                        Container(
                          child: Text("POBJEDE",
                              style: GoogleFonts.oswald(
                                  fontSize: 12,
                                  color: HexColor("#400507"),
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold)),
                        ),
                      ],
                    ),
                    SizedBox(width: 30),
                    Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Container(
                            child: Row(
                          children: [
                            Icon(
                              CupertinoIcons.clear_circled_solid,
                              color: Colors.red[800]!,
                              size: 23,
                            ),
                            SizedBox(
                              width: 7,
                            ),
                            Text(
                                widget.trener!.trenerStatistika.brojPoraza
                                    .toString(),
                                style: GoogleFonts.oswald(
                                    fontSize: 25,
                                    color: HexColor("#400507"),
                                    letterSpacing: 0,
                                    fontWeight: FontWeight.bold)),
                          ],
                        )),
                        Container(
                          child: Text("PORAZI",
                              style: GoogleFonts.oswald(
                                  fontSize: 12,
                                  color: HexColor("#400507"),
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold)),
                        ),
                      ],
                    ),
                    SizedBox(width: 30),
                    Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Container(
                            child: Row(
                          children: [
                            Icon(
                              Icons.do_disturb_on,
                              color: Colors.grey,
                              size: 23,
                            ),
                            SizedBox(
                              width: 7,
                            ),
                            Text(
                                widget.trener!.trenerStatistika.brojNerjesenih
                                    .toString(),
                                style: GoogleFonts.oswald(
                                    fontSize: 25,
                                    color: HexColor("#400507"),
                                    letterSpacing: 0,
                                    fontWeight: FontWeight.bold)),
                          ],
                        )),
                        Container(
                          child: Text("NERJEŠENE",
                              style: GoogleFonts.oswald(
                                  fontSize: 12,
                                  color: HexColor("#400507"),
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold)),
                        ),
                      ],
                    )
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
              SizedBox(height: 20)
            ],
          ),
        )
      ],
    ));
  }
}

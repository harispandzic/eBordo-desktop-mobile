import 'package:ebordo_mobile/pages/Kalendar/kalendar.dart';
import 'package:ebordo_mobile/pages/Shared/login.dart';
import 'package:ebordo_mobile/pages/Shared/pocetna.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20igra%C4%8Dima/detalji_igraca.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20igra%C4%8Dima/prikaz_igraca.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20izvje%C5%A1tajem/prikaz_izvjestaja.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20korisnickim%20racunom/korisnicki_racun.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20rasporedom/prikaz_rasporeda.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20trenerima/detalji_trenera.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20trenerima/prikaz_trenera.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20treningom/prikaz_treninga.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Login(),
      routes: {
        '/login': (context) => Login(),
        '/pocetna': (context) => Pocetna(),
        '/kalendar': (context) => Kalendar(),
        '/korisnicki_racun': (context) => KorisnickiRacun(),
        '/prikaz_igraca': (context) => PrikazIgraca(),
        '/detalji_igraca': (context) => DetaljiIgraca(),
        '/prikaz_trenera': (context) => PrikazTrenera(),
        '/detalji_trenera': (context) => DetaljiTrenera(),
        '/prikaz_rasporeda': (context) => PrikazRasporeda(),
        '/prikaz_rezultata': (context) => PrikazRezultata(),
        '/prikaz_treninga': (context) => PrikazTreninga(),
      },
    );
  }
}

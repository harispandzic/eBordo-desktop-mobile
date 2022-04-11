import 'package:ebordo_mobile/pages/Shared/login.dart';
import 'package:ebordo_mobile/pages/Shared/pocetna.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20igra%C4%8Dima/detalji_igraca.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20igra%C4%8Dima/prikaz_igraca.dart';
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
        '/prikaz_igraca': (context) => PrikazIgraca(),
        '/detalji_igraca': (context) => DetaljiIgraca(),
      },
    );
  }
}

import 'dart:typed_data';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import '../../models/igrac-pozicija.dart';
import '../../models/igrac.dart';
import '../../services/APIService.dart';

List<Igrac> golman = [];
List<Igrac> odbrana = [];
List<Igrac> vezniRed = [];
List<Igrac> krilo = [];
List<Igrac> napad = [];
List<IgracPozicija> pozicijeIgraca = [];

class Pocetna extends StatefulWidget {
  @override
  _PocetnaState createState() => _PocetnaState();
}

class _PocetnaState extends State<Pocetna> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        titleSpacing: 0.0,
        title: Row(
          mainAxisAlignment: MainAxisAlignment.start,
          children: [
            Padding(
              padding: EdgeInsets.only(right: 8),
              child: Image.asset(
                'assets/fksarajevo-grb.png',
                fit: BoxFit.contain,
                height: 30,
              ),
            ),
            Text("FUDBALSKI KLUB SARAJEVO",
                style: GoogleFonts.oswald(
                    fontSize: 15,
                    color: Colors.white,
                    letterSpacing: 0,
                    fontWeight: FontWeight.bold)),
          ],
        ),
        backgroundColor: HexColor("#400507"),
        actions: [
          Padding(
            padding: EdgeInsets.only(right: 10),
            child: CircleAvatar(
              radius: 16,
              backgroundColor: Colors.white,
              child: CircleAvatar(
                radius: 15.5,
                backgroundColor: Colors.white,
                child: ClipOval(
                  child: Image.memory(
                    Uint8List.fromList(APIService.logovaniKorisnik!.slika),
                    width: 30,
                    height: 30,
                    fit: BoxFit.cover,
                  ),
                ),
              ),
            ),
          ),
        ],
      ),
      drawer: Drawer(
        child: ListView(
          children: <Widget>[
            UserAccountsDrawerHeader(
                accountName: Text(
                    APIService.logovaniKorisnik!.ime +
                        " " +
                        APIService.logovaniKorisnik!.prezime,
                    style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.white,
                      letterSpacing: 0,
                    )),
                accountEmail: Text(APIService.logovaniKorisnik!.korisnickoIme,
                    style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.white,
                      letterSpacing: 0,
                    )),
                decoration: BoxDecoration(
                  color: Colors.black,
                  image: DecorationImage(
                    image: ExactAssetImage('assets/drawer-image.png'),
                    fit: BoxFit.cover,
                  ),
                ),
                currentAccountPicture: CircleAvatar(
                  backgroundColor: Colors.white,
                  child: ClipOval(
                    child: Image.memory(
                      Uint8List.fromList(APIService.logovaniKorisnik!.slika),
                      width: 70,
                      height: 70,
                      fit: BoxFit.cover,
                    ),
                  ),
                )),
            ListTile(
                leading: Icon(
                  Icons.home,
                  color: HexColor("#400507"),
                  size: 30,
                ),
                title: Text("Početna",
                    style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.w500,
                    )),
                onTap: () {
                  Navigator.pop(context);
                }),
            ListTile(
                leading: Icon(
                  Icons.directions_run,
                  color: HexColor("#400507"),
                  size: 30,
                ),
                title: Text("Igrači",
                    style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.w500,
                    )),
                onTap: () {
                  Navigator.of(context).pushNamed('/prikaz_igraca');
                }),
            ListTile(
                leading: Icon(
                  Icons.account_circle,
                  color: HexColor("#400507"),
                  size: 30,
                ),
                title: Text("Treneri",
                    style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.w500,
                    )),
                onTap: () {
                  Navigator.of(context).pushNamed('/detalji_igraca');
                }),
            ListTile(
                leading: Icon(
                  Icons.calendar_month,
                  color: HexColor("#400507"),
                  size: 30,
                ),
                title: Text("Raspored utakmica",
                    style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.w500,
                    )),
                onTap: () {
                  Navigator.pop(context);
                }),
            ListTile(
                leading: Icon(
                  Icons.sports_soccer,
                  color: HexColor("#400507"),
                  size: 30,
                ),
                title: Text("Odigrane utakmice",
                    style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.w500,
                    )),
                onTap: () {
                  Navigator.pop(context);
                }),
            ListTile(
                leading: Icon(
                  Icons.calendar_month,
                  color: HexColor("#400507"),
                  size: 30,
                ),
                title: Text("Raspored treninga",
                    style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.w500,
                    )),
                onTap: () {
                  Navigator.pop(context);
                }),
            Divider(),
            ListTile(
                leading: Icon(
                  Icons.info,
                  color: HexColor("#400507"),
                  size: 30,
                ),
                title: Text("O aplikaciji",
                    style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.w500,
                    )),
                onTap: () {
                  Navigator.pop(context);
                }),
            ListTile(
                leading: Icon(
                  Icons.logout,
                  color: HexColor("#400507"),
                  size: 30,
                ),
                title: Text("Odjava",
                    style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: HexColor("#400507"),
                      letterSpacing: 0,
                      fontWeight: FontWeight.w500,
                    )),
                onTap: () {
                  Navigator.of(context).pushNamed('/login');
                }),
          ],
        ),
      ),
      body: Text("Hello"),
    );
  }
}

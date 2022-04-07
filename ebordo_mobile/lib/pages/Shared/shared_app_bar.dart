import 'dart:typed_data';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import '../../services/APIService.dart';

class SharedAppBar extends StatelessWidget implements PreferredSizeWidget {
  @override
  Size get preferredSize => new Size.fromHeight(60);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        titleSpacing: 0.0,
        title: Row(mainAxisAlignment: MainAxisAlignment.start, children: [
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
        ]),
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
    );
  }
}

import 'dart:convert';
import 'package:ebordo_mobile/models/korisnik.dart';
import 'package:ebordo_mobile/models/trener-licenca.dart';
import 'package:ebordo_mobile/models/trener-statistika.dart';
import 'package:ebordo_mobile/models/ugovor.dart';

import 'formacija.dart';

class Trener {
  final int trenerId;
  final String prvaZvanicnaUtakmica;
  final int trzisnaVrijednost;
  final TrenerStatistika trenerStatistika;
  final Ugovor ugovor;
  final Korisnik korisnik;
  final Formacija formacija;
  final TrenerskaLicenca trenerskaLicenca;
  final String ulogaTrenera;
  final List<int> slikaPanel;

  Trener(
      {required this.trenerId,
      required this.prvaZvanicnaUtakmica,
      required this.trzisnaVrijednost,
      required this.trenerStatistika,
      required this.ugovor,
      required this.korisnik,
      required this.formacija,
      required this.trenerskaLicenca,
      required this.ulogaTrenera,
      required this.slikaPanel});

  factory Trener.fromJson(Map<String, dynamic> json) {
    String stringByte = json["slikaPanel"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Trener(
      trenerId: int.parse(json["trenerId"].toString()),
      prvaZvanicnaUtakmica: json["prvaZvanicnaUtakmica"],
      trzisnaVrijednost: json["trzisnaVrijednost"],
      trenerStatistika: TrenerStatistika.fromJson(json['trenerStatistika']),
      ugovor: Ugovor.fromJson(json['ugovor']),
      korisnik: Korisnik.fromJson(json['korisnik']),
      formacija: Formacija.fromJson(json['formacija']),
      trenerskaLicenca: TrenerskaLicenca.fromJson(json['trenerskaLicenca']),
      ulogaTrenera: json["ulogaTrenera"],
      slikaPanel: bytes,
    );
  }

  Map<String, dynamic> toJson() => {
        "trenerId": trenerId,
        "slikaPanel": slikaPanel,
        "prvaZvanicnaUtakmica": prvaZvanicnaUtakmica,
        "trzisnaVrijednost": trzisnaVrijednost,
        "trenerStatistika": trenerStatistika,
        "ugovor": ugovor,
        "korisnik": korisnik,
        "formacija": formacija,
        "trenerskaLicenca": trenerskaLicenca,
        "ulogaTrenera": ulogaTrenera,
      };
}

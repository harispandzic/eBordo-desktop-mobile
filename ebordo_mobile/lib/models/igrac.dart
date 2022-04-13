import 'dart:convert';
import 'package:ebordo_mobile/models/igrac-statistika.dart';
import 'package:ebordo_mobile/models/korisnik.dart';
import 'package:ebordo_mobile/models/pozicija.dart';
import 'package:ebordo_mobile/models/ugovor.dart';

import 'igrac-skills.dart';

class Igrac {
  final int igracId;
  final int brojDresa;
  final List<int> slikaPanel;
  final IgracStatistika igracStatistika;
  final IgracSkills igracSkills;
  final Pozicija pozicija;
  final Korisnik korisnik;
  final Ugovor ugovor;
  final String boljaNoga;
  final int jacinaSlabijeNoge;
  final int visina;
  final int tezina;
  final int trzisnaVrijednost;
  final String napomeneOIgracu;

  Igrac({
    required this.igracId,
    required this.brojDresa,
    required this.slikaPanel,
    required this.igracStatistika,
    required this.igracSkills,
    required this.pozicija,
    required this.korisnik,
    required this.ugovor,
    required this.boljaNoga,
    required this.jacinaSlabijeNoge,
    required this.visina,
    required this.tezina,
    required this.trzisnaVrijednost,
    required this.napomeneOIgracu,
  });

  factory Igrac.fromJson(Map<String, dynamic> json) {
    String stringByte = json["slikaPanel"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Igrac(
      igracId: int.parse(json["igracId"].toString()),
      brojDresa: int.parse(json["brojDresa"].toString()),
      slikaPanel: bytes,
      igracStatistika: IgracStatistika.fromJson(json['igracStatistika']),
      igracSkills: IgracSkills.fromJson(json['igracSkills']),
      pozicija: Pozicija.fromJson(json['pozicija']),
      korisnik: Korisnik.fromJson(json['korisnik']),
      ugovor: Ugovor.fromJson(json['ugovor']),
      boljaNoga: json["boljaNoga"],
      jacinaSlabijeNoge: json["jacinaSlabijeNoge"],
      visina: json["visina"],
      tezina: json["tezina"],
      trzisnaVrijednost: json["trzisnaVrijednost"],
      napomeneOIgracu: json["napomeneOIgracu"],
    );
  }

  Map<String, dynamic> toJson() => {
        "igracId": igracId,
        "brojDresa": brojDresa,
        "slikaPanel": slikaPanel,
        "igracStatistika": igracStatistika,
        "igracSkills": igracSkills,
        "pozicija": pozicija,
        "korisnik": korisnik,
        "ugovor": ugovor,
        "boljaNoga": boljaNoga,
        "jacinaSlabijeNoge": jacinaSlabijeNoge,
        "visina": visina,
        "tezina": tezina,
        "trzisnaVrijednost": trzisnaVrijednost,
        "napomeneOIgracu": napomeneOIgracu
      };
}

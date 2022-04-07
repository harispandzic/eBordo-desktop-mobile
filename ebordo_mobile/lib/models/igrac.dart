import 'dart:convert';
import 'package:ebordo_mobile/models/igrac_statistika.dart';
import 'package:ebordo_mobile/models/korisnik.dart';
import 'package:ebordo_mobile/models/pozicija.dart';

class Igrac {
  final int igracId;
  final int brojDresa;
  final List<int> slikaPanel;
  final IgracStatistika igracStatistika;
  final Pozicija pozicija;
  final Korisnik korisnik;

  Igrac({
    required this.igracId,
    required this.brojDresa,
    required this.slikaPanel,
    required this.igracStatistika,
    required this.pozicija,
    required this.korisnik,
  });

  factory Igrac.fromJson(Map<String, dynamic> json) {
    String stringByte = json["slikaPanel"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Igrac(
        igracId: int.parse(json["igracId"].toString()),
        brojDresa: int.parse(json["brojDresa"].toString()),
        slikaPanel: bytes,
        igracStatistika: IgracStatistika.fromJson(json['igracStatistika']),
        pozicija: Pozicija.fromJson(json['pozicija']),
        korisnik: Korisnik.fromJson(json['korisnik']));
  }

  Map<String, dynamic> toJson() => {
        "igracId": igracId,
        "brojDresa": brojDresa,
        "slikaPanel": slikaPanel,
        "igracStatistika": igracStatistika,
        "pozicija": pozicija,
        "korisnik": korisnik
      };
}

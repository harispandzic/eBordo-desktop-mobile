import 'dart:convert';
import 'package:ebordo_mobile/models/utakmica-izmjena.dart';
import 'package:ebordo_mobile/models/utakmica-nastup.dart';
import 'package:ebordo_mobile/models/utakmica.dart';
import 'igrac.dart';

class Izvjestaj {
  final int izvjestajId;
  final num goloviSarajevo;
  final num goloviProtivnik;
  final int rezultat;
  final String datumKreiranja;
  final String zapisnik;
  final int vrijeme;
  final Igrac igracUtakmica;
  final Utakmica utakmica;
  final List<int> slikaSaUtakmice;
  final List<UtakmicaIzmjena> izmjene;
  final List<UtakmicaNastup> nastupi;

  Izvjestaj({
    required this.izvjestajId,
    required this.goloviSarajevo,
    required this.goloviProtivnik,
    required this.rezultat,
    required this.datumKreiranja,
    required this.zapisnik,
    required this.vrijeme,
    required this.igracUtakmica,
    required this.utakmica,
    required this.slikaSaUtakmice,
    required this.izmjene,
    required this.nastupi,
  });

  factory Izvjestaj.fromJson(Map<String, dynamic> json) {
    String stringByte = json["slikaSaUtakmice"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Izvjestaj(
        izvjestajId: int.parse(json["izvještajId"].toString()),
        goloviSarajevo: json["goloviSarajevo"],
        goloviProtivnik: json["goloviProtivnik"],
        rezultat: json["rezultat"],
        datumKreiranja: json["datumKreiranja"],
        zapisnik: json["zapisnik"],
        vrijeme: json["vrijeme"],
        igracUtakmica: Igrac.fromJson(json['igracUtakmica']),
        utakmica: Utakmica.fromJson(json['utakmica']),
        slikaSaUtakmice: bytes,
        izmjene: (json['izmjene'] as List)
            .map((i) => UtakmicaIzmjena.fromJson(i))
            .toList(),
        nastupi: (json['nastupi'] as List)
            .map((i) => UtakmicaNastup.fromJson(i))
            .toList());
  }

  Map<String, dynamic> toJson() => {
        "izvjestajId": izvjestajId,
        "goloviSarajevo": goloviSarajevo,
        "goloviProtivnik": goloviProtivnik,
        "rezultat": rezultat,
        "zapisnik": zapisnik,
        "vrijeme": vrijeme,
        "igracUtakmica": igracUtakmica,
        "utakmica": utakmica,
        "slikaSaUtakmice": slikaSaUtakmice,
        "izmjene": izmjene,
        "nastupi": nastupi,
      };
}

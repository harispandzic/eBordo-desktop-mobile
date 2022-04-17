import 'package:ebordo_mobile/models/igrac.dart';
import 'package:ebordo_mobile/models/stadion.dart';
import 'package:ebordo_mobile/models/takmicenje.dart';
import 'package:ebordo_mobile/models/trener.dart';
import 'package:ebordo_mobile/models/utakmica-sastav.dart';
import 'klub.dart';

class Utakmica {
  final int utakmicaId;
  final String datumOdigravanja;
  final String satnica;
  final String sudija;
  final Stadion stadion;
  final String napomene;
  final String opisUtakmice;
  final int brojUlaznica;
  final Takmicenje takmicenje;
  final Igrac kapiten;
  final Trener trener;
  final Klub protivnik;
  final String tipGarniture;
  final String vrstaUtakmice;
  final bool odigrana;
  final List<UtakmicaSastav> sastav;

  Utakmica({
    required this.utakmicaId,
    required this.datumOdigravanja,
    required this.satnica,
    required this.sudija,
    required this.stadion,
    required this.napomene,
    required this.opisUtakmice,
    required this.brojUlaznica,
    required this.takmicenje,
    required this.kapiten,
    required this.trener,
    required this.protivnik,
    required this.tipGarniture,
    required this.vrstaUtakmice,
    required this.odigrana,
    required this.sastav,
  });

  factory Utakmica.fromJson(Map<String, dynamic> json) {
    return Utakmica(
        utakmicaId: int.parse(json["utakmicaId"].toString()),
        datumOdigravanja: json["datumOdigravanja"],
        satnica: json["satnica"],
        sudija: json["sudija"],
        stadion: Stadion.fromJson(json['stadion']),
        napomene: json["napomene"],
        opisUtakmice: json["opisUtakmice"],
        brojUlaznica: json["brojUlaznica"],
        takmicenje: Takmicenje.fromJson(json['takmicenje']),
        kapiten: Igrac.fromJson(json['kapiten']),
        trener: Trener.fromJson(json['trener']),
        protivnik: Klub.fromJson(json['protivnik']),
        tipGarniture: json["tipGarniture"],
        vrstaUtakmice: json["vrstaUtakmice"],
        odigrana: json["odigrana"],
        sastav: (json['sastav'] as List)
            .map((i) => UtakmicaSastav.fromJson(i))
            .toList());
  }

  Map<String, dynamic> toJson() => {
        "utakmicaId": utakmicaId,
        "datumOdigravanja": datumOdigravanja,
        "satnica": satnica,
        "sudija": sudija,
        "stadion": stadion,
        "napomene": napomene,
        "opisUtakmice": opisUtakmice,
        "brojUlaznica": brojUlaznica,
        "takmicenje": takmicenje,
        "kapiten": kapiten,
        "trener": trener,
        "protivnik": protivnik,
        "tipGarniture": tipGarniture,
        "vrstaUtakmice": vrstaUtakmice,
        "odigrana": odigrana,
        "sastav": sastav,
      };
}

import 'package:ebordo_mobile/models/igrac.dart';
import 'package:ebordo_mobile/models/pozicija.dart';

class UtakmicaSastav {
  final int utakmicaSastavId;
  final Igrac igrac;
  final Pozicija pozicija;
  final String uloga;

  UtakmicaSastav({
    required this.utakmicaSastavId,
    required this.igrac,
    required this.pozicija,
    required this.uloga,
  });

  factory UtakmicaSastav.fromJson(Map<String, dynamic> json) {
    return UtakmicaSastav(
      utakmicaSastavId: int.parse(json["utakmicaSastavId"].toString()),
      igrac: Igrac.fromJson(json['igrac']),
      pozicija: Pozicija.fromJson(json['pozicija']),
      uloga: json["uloga"],
    );
  }

  Map<String, dynamic> toJson() => {
        "utakmicaSastavId": utakmicaSastavId,
        "igrac": igrac,
        "pozicija": pozicija,
        "uloga": uloga,
      };
}

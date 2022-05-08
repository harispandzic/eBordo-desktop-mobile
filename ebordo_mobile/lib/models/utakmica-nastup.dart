import 'igrac.dart';

class UtakmicaNastup {
  final Igrac igrac;
  final num kontrolaLopte;
  final num driblanje;
  final num dodavanje;
  final num kretanje;
  final num brzina;
  final num sut;
  final num snaga;
  final num markiranje;
  final num klizeciStart;
  final num skok;
  final num odbrana;
  final int minute;
  final int golovi;
  final int asistencije;
  final int zutiKartoni;
  final int crveniKartoni;
  final int ocjena;
  final String komentar;

  UtakmicaNastup({
    required this.igrac,
    required this.kontrolaLopte,
    required this.driblanje,
    required this.dodavanje,
    required this.kretanje,
    required this.brzina,
    required this.sut,
    required this.snaga,
    required this.markiranje,
    required this.klizeciStart,
    required this.skok,
    required this.odbrana,
    required this.minute,
    required this.golovi,
    required this.asistencije,
    required this.zutiKartoni,
    required this.crveniKartoni,
    required this.ocjena,
    required this.komentar,
  });

  factory UtakmicaNastup.fromJson(Map<String, dynamic> json) {
    return UtakmicaNastup(
      igrac: Igrac.fromJson(json['igrac']),
      kontrolaLopte: json["kontrolaLopte"],
      driblanje: json["driblanje"],
      dodavanje: json["dodavanje"],
      kretanje: json["kretanje"],
      brzina: json["brzina"],
      sut: json["sut"],
      snaga: json["snaga"],
      markiranje: json["markiranje"],
      klizeciStart: json["klizeciStart"],
      skok: json["skok"],
      odbrana: json["odbrana"],
      minute: json["minute"],
      golovi: json["golovi"],
      asistencije: json["asistencije"],
      zutiKartoni: json["zutiKartoni"],
      crveniKartoni: json["crveniKartoni"],
      ocjena: json["ocjena"],
      komentar: json["komentar"],
    );
  }

  Map<String, dynamic> toJson() => {
        "kontrolaLopte": kontrolaLopte,
        "driblanje": driblanje,
        "dodavanje": dodavanje,
        "kretanje": kretanje,
        "brzina": brzina,
        "sut": sut,
        "snaga": snaga,
        "markiranje": markiranje,
        "klizeciStart": klizeciStart,
        "skok": skok,
        "odbrana": odbrana,
        "minute": minute,
        "golovi": golovi,
        "asistencije": asistencije,
        "zutiKartoni": zutiKartoni,
        "crveniKartoni": crveniKartoni,
        "ocjena": ocjena,
        "komentar": komentar,
      };
}

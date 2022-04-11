class IgracSkills {
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
  final num prosjekOcjena;

  IgracSkills({
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
    required this.prosjekOcjena,
  });

  factory IgracSkills.fromJson(Map<String, dynamic> json) {
    return IgracSkills(
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
      prosjekOcjena: json["prosjekOcjena"],
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
        "prosjekOcjena": prosjekOcjena
      };
}

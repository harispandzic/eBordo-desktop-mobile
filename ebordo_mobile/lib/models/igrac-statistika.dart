class IgracStatistika {
  final int brojNastupa;
  final int minute;
  final int golovi;
  final int asistencije;
  final int zutiKartoni;
  final int crveniKartoni;
  final num prosjecnaOcjena;

  IgracStatistika({
    required this.brojNastupa,
    required this.minute,
    required this.golovi,
    required this.asistencije,
    required this.zutiKartoni,
    required this.crveniKartoni,
    required this.prosjecnaOcjena,
  });

  factory IgracStatistika.fromJson(Map<String, dynamic> json) {
    return IgracStatistika(
      brojNastupa: int.parse(json["brojNastupa"].toString()),
      minute: json["minute"],
      golovi: json["golovi"],
      asistencije: json["asistencije"],
      zutiKartoni: json["zutiKartoni"],
      crveniKartoni: json["crveniKartoni"],
      prosjecnaOcjena: json["prosjecnaOcjena"],
    );
  }

  Map<String, dynamic> toJson() => {
        "brojNastupa": brojNastupa,
        "minute": minute,
        "golovi": golovi,
        "asistencije": asistencije,
        "zutiKartoni": zutiKartoni,
        "crveniKartoni": crveniKartoni,
        "prosjecnaOcjena": prosjecnaOcjena,
      };
}

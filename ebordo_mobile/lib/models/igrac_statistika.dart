class IgracStatistika {
  final int brojNastupa;
  final int golovi;
  final int asistencije;
  final num prosjecnaOcjena;

  IgracStatistika(
      {required this.brojNastupa,
      required this.golovi,
      required this.asistencije,
      required this.prosjecnaOcjena});

  factory IgracStatistika.fromJson(Map<String, dynamic> json) {
    return IgracStatistika(
      brojNastupa: int.parse(json["brojNastupa"].toString()),
      golovi: json["golovi"],
      asistencije: json["asistencije"],
      prosjecnaOcjena: json["prosjecnaOcjena"],
    );
  }

  Map<String, dynamic> toJson() => {
        "brojNastupa": brojNastupa,
        "golovi": golovi,
        "asistencije": asistencije,
        "prosjecnaOcjena": prosjecnaOcjena
      };
}

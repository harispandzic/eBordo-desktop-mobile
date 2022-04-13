class TrenerStatistika {
  final int trenerStatistikaID;
  final int brojUtakmica;
  final int brojPobjeda;
  final int brojNerjesenih;
  final int brojPoraza;

  TrenerStatistika(
      {required this.trenerStatistikaID,
      required this.brojUtakmica,
      required this.brojPobjeda,
      required this.brojNerjesenih,
      required this.brojPoraza});

  factory TrenerStatistika.fromJson(Map<String, dynamic> json) {
    return TrenerStatistika(
      trenerStatistikaID: json["trenerStatistikaID"],
      brojUtakmica: json["brojUtakmica"],
      brojPobjeda: json["brojPobjeda"],
      brojNerjesenih: json["brojNerjesenih"],
      brojPoraza: json["brojPoraza"],
    );
  }

  Map<String, dynamic> toJson() => {
        "trenerStatistikaID": trenerStatistikaID,
        "brojUtakmica": brojUtakmica,
        "brojPobjeda": brojPobjeda,
        "brojNerjesenih": brojNerjesenih,
        "brojPoraza": brojPoraza,
      };
}

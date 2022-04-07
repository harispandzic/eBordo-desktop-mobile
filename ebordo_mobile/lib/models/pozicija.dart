class Pozicija {
  final int pozicijaId;
  final String nazivPozicije;
  final String skracenica;

  Pozicija(
      {required this.pozicijaId,
      required this.nazivPozicije,
      required this.skracenica});

  factory Pozicija.fromJson(Map<String, dynamic> json) {
    return Pozicija(
      pozicijaId: int.parse(json["pozicijaId"].toString()),
      nazivPozicije: json["nazivPozicije"],
      skracenica: json["skracenica"],
    );
  }

  Map<String, dynamic> toJson() => {
        "pozicijaId": pozicijaId,
        "nazivPozicije": nazivPozicije,
        "skracenica": skracenica
      };
}

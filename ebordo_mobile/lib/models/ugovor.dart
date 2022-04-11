class Ugovor {
  final String datumPocetka;
  final String datumZavrsetka;

  Ugovor({required this.datumPocetka, required this.datumZavrsetka});

  factory Ugovor.fromJson(Map<String, dynamic> json) {
    return Ugovor(
      datumPocetka: json["datumPocetka"],
      datumZavrsetka: json["datumZavrsetka"],
    );
  }

  Map<String, dynamic> toJson() =>
      {"datumPocetka": datumPocetka, "datumZavrsetka": datumZavrsetka};
}

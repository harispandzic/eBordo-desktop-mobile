class Formacija {
  final int formacijaId;
  final String nazivFormacije;

  Formacija({
    required this.formacijaId,
    required this.nazivFormacije,
  });

  factory Formacija.fromJson(Map<String, dynamic> json) {
    return Formacija(
      formacijaId: json["formacijaId"],
      nazivFormacije: json["nazivFormacije"],
    );
  }

  Map<String, dynamic> toJson() =>
      {"formacijaId": formacijaId, "nazivFormacije": nazivFormacije};
}

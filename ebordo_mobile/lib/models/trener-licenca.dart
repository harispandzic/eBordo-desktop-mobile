class TrenerskaLicenca {
  final int trenerskaLicencaId;
  final String nazivLicence;

  TrenerskaLicenca({
    required this.trenerskaLicencaId,
    required this.nazivLicence,
  });

  factory TrenerskaLicenca.fromJson(Map<String, dynamic> json) {
    return TrenerskaLicenca(
      trenerskaLicencaId: json["trenerskaLicencaId"],
      nazivLicence: json["nazivLicence"],
    );
  }

  Map<String, dynamic> toJson() =>
      {"trenerskaLicencaId": trenerskaLicencaId, "nazivLicence": nazivLicence};
}

class UpdateSastav {
  final int utakmicaSastavid;
  final int igracId;
  final int utakmicaId;
  final int pozicijaId;
  final String uloga;

  UpdateSastav({
    required this.utakmicaSastavid,
    required this.igracId,
    required this.utakmicaId,
    required this.pozicijaId,
    required this.uloga,
  });

  Map<String, dynamic> toJson() {
    return {
      'utakmicaSastavid': utakmicaSastavid,
      'igracId': igracId,
      'utakmicaId': utakmicaId,
      'pozicijaId': pozicijaId,
      'uloga': uloga,
    };
  }
}

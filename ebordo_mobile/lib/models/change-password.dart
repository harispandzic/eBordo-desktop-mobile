class ChangePassword {
  final int korisnikId;
  final String oldPassword;
  final String newPassword;

  ChangePassword({
    required this.korisnikId,
    required this.oldPassword,
    required this.newPassword,
  });

  factory ChangePassword.fromJson(Map<String, dynamic> json) {
    return ChangePassword(
      korisnikId: json["korisnikId"],
      oldPassword: json["oldPassword"],
      newPassword: json["newPassword"],
    );
  }

  Map<String, dynamic> toJson() => {
        "korisnikId": korisnikId,
        "oldPassword": oldPassword,
        "newPassword": newPassword
      };
}

import 'drzava.dart';

class Grad {
  final int gradId;
  final String nazivGrada;
  final Drzava drzava;

  Grad({required this.gradId, required this.nazivGrada, required this.drzava});

  factory Grad.fromJson(Map<String, dynamic> json) {
    return Grad(
      gradId: int.parse(json["gradId"].toString()),
      nazivGrada: json["nazivGrada"],
      drzava: Drzava.fromJson(json['drzava']),
    );
  }

  Map<String, dynamic> toJson() =>
      {"gradId": gradId, "nazivGrada": nazivGrada, "drzava": drzava};
}

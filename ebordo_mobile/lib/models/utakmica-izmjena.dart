import 'igrac.dart';

class UtakmicaIzmjena {
  final Igrac igracOut;
  final Igrac igracIn;
  final int minuta;
  final num IzmjenaRazlog;

  UtakmicaIzmjena(
      {required this.igracOut,
      required this.igracIn,
      required this.minuta,
      required this.IzmjenaRazlog});

  factory UtakmicaIzmjena.fromJson(Map<String, dynamic> json) {
    return UtakmicaIzmjena(
      igracOut: Igrac.fromJson(json['igracOut']),
      igracIn: Igrac.fromJson(json['igracIn']),
      minuta: json["minuta"],
      IzmjenaRazlog: json["IzmjenaRazlog"],
    );
  }

  Map<String, dynamic> toJson() => {
        "igracOut": igracOut,
        "igracIn": igracIn,
        "minuta": minuta,
        "IzmjenaRazlog": IzmjenaRazlog
      };
}

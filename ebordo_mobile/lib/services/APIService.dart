import 'dart:convert';
import 'package:ebordo_mobile/models/change-password.dart';
import 'package:http/http.dart' as http;
import 'dart:io';
import '../models/change-password.dart';
import '../models/get-preporuceni.dart';
import '../models/korisnik.dart';

String server_adress = "http://10.0.2.2:5000/api/";

class APIService {
  static Korisnik? logovaniKorisnik;
  static String username = "";
  static String password = "";
  String route;

  APIService({required this.route});

  static void PostaviKredencijale(String Username, String Password) {
    username = Username;
    password = Password;
  }

  static void PostaviLogovanogKorisnika(var result) {
    logovaniKorisnik = result;
  }

  static Future Auth() async {
    String baseUrl = server_adress + "Korisnik/Auth";
    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));
    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );
    if (response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }

  static Future<dynamic> ChangeUserPassword(ChangePassword body) async {
    String baseUrl = server_adress + "Korisnik/ChangePassword";

    Map data = {
      'korisnikId': body.korisnikId,
      'oldPassword': body.oldPassword,
      'newPassword': body.newPassword,
    };

    final response = await http.post(Uri.parse(baseUrl),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        },
        body: json.encode(data));

    if (response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }

  static Future<dynamic> GetPreporuceneIgrace(
      String route, String naziv, GetPreporuceni body) async {
    String baseUrl = server_adress + route + "/" + naziv;

    Map data = {
      'igracId': body.igracId,
      'selectedIds': body.selectedIds,
    };

    final response = await http.post(Uri.parse(baseUrl),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        },
        body: json.encode(data));

    if (response.statusCode == 200) {
      return json.decode(response.body) as List;
    }
    return null;
  }

  static Future<List<dynamic>?> Get(String route, dynamic object) async {
    String queryString = Uri(queryParameters: object).query;
    String baseUrl = server_adress + route;
    if (object != null) {
      baseUrl = baseUrl + '?' + queryString;
    }

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));
    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );
    if (response.statusCode == 200) {
      return json.decode(response.body) as List;
    }
    return null;
  }

  static Future<dynamic> DeleteById(String route, int id) async {
    String baseUrl = server_adress + route + "/" + id.toString();
    final response = await http.delete(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
      },
    );

    if (response.statusCode == 201) {
      return json.decode(response.body);
    }
  }

  static Future<dynamic> Update(String route, int id, dynamic body) async {
    String baseUrl = server_adress + route + "/" + id.toString();

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.put(Uri.parse(baseUrl),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        },
        body: body);

    if (response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }
}

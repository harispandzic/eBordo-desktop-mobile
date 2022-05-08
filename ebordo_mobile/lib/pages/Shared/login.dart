// ignore_for_file: override_on_non_overriding_member, must_be_immutable
import 'package:ebordo_mobile/models/korisnik.dart';
import 'package:ebordo_mobile/services/APIService.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:loading_overlay/loading_overlay.dart';
import 'package:motion_toast/motion_toast.dart';
import 'package:motion_toast/resources/arrays.dart';

class Login extends StatefulWidget {
  bool _passwordVisible = false;

  @override
  void initState() {
    _passwordVisible = false;
  }

  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  TextEditingController usernameController = new TextEditingController();
  TextEditingController passwordController = new TextEditingController();
  var result = null;
  bool _isLoading = false;

  Future<void> Prijava(BuildContext context) async {
    setState(() {
      _isLoading = true;
    });

    APIService.PostaviKredencijale(
        usernameController.text, passwordController.text);
    try {
      result = await APIService.Auth();

      if (result == null) {
        MotionToast.error(
          title: "Korisničko ime i lozinka nisu ispravni!",
          titleStyle: TextStyle(fontWeight: FontWeight.bold),
          description: "Unesite ispravne kredencijale i pokušajte ponovo!",
          descriptionStyle: TextStyle(fontSize: 12),
          position: MOTION_TOAST_POSITION.TOP,
          animationType: ANIMATION.FROM_TOP,
          height: 100,
        ).show(context);
      } else {
        Korisnik logiraniKorisnik = Korisnik.fromJson(result);
        APIService.PostaviLogovanogKorisnika(logiraniKorisnik);
        setState(() {
          _isLoading = false;
        });

        Navigator.of(context).pushReplacementNamed('/pocetna');
      }
    } catch (e) {
      MotionToast.error(
        title: "Greška na serveru!",
        titleStyle: TextStyle(fontWeight: FontWeight.bold),
        description:
            "Desila se neočekivana greška. Za pomoć, javite se administratoru na mail eBordo@outlook.com!",
        descriptionStyle: TextStyle(fontSize: 12),
        position: MOTION_TOAST_POSITION.TOP,
        animationType: ANIMATION.FROM_TOP,
        height: 80,
        toastDuration: Duration(seconds: 4),
      ).show(context);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: LoadingOverlay(
        child: Stack(
          children: [
            Container(
              padding: EdgeInsets.only(top: 100),
              height: 280,
              decoration: BoxDecoration(
                image: DecorationImage(
                  image: AssetImage(
                    'assets/login-background.png',
                  ),
                  fit: BoxFit.cover,
                ),
              ),
            ),
            Align(
              alignment: Alignment.bottomCenter,
              child: ClipRRect(
                borderRadius: BorderRadius.only(
                    topRight: Radius.circular(30),
                    topLeft: Radius.circular(30)),
                child: Container(
                  height: MediaQuery.of(context).size.height - 220,
                  width: MediaQuery.of(context).size.width,
                  decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(10),
                      image: DecorationImage(
                          fit: BoxFit.cover,
                          image:
                              AssetImage('assets/login-background-slika.png'))),
                  child: Padding(
                    padding: EdgeInsets.only(left: 20, top: 20, right: 20),
                    child: Column(
                        mainAxisAlignment: MainAxisAlignment.start,
                        crossAxisAlignment: CrossAxisAlignment.center,
                        children: [
                          Container(
                            height: 100,
                            decoration: BoxDecoration(
                              image: DecorationImage(
                                image: AssetImage(
                                  'assets/fksarajevo-grb.png',
                                ),
                              ),
                            ),
                          ),
                          SizedBox(
                            height: 5,
                          ),
                          Row(
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: [
                                Text("Prijava na ",
                                    style: GoogleFonts.ubuntu(
                                        fontSize: 32,
                                        color: Colors.black,
                                        fontWeight: FontWeight.bold,
                                        letterSpacing: 0)),
                                SizedBox(
                                  height: 5,
                                ),
                                Text("eBordo",
                                    style: GoogleFonts.ubuntu(
                                        fontSize: 32,
                                        color: HexColor("#400507"),
                                        fontWeight: FontWeight.bold,
                                        letterSpacing: 0))
                              ]),
                          SizedBox(
                            height: 5,
                          ),
                          Text("UNESITE PODATKE ZA PRIJAVU",
                              style: GoogleFonts.oswald(
                                  fontSize: 15,
                                  color: Colors.black,
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.bold)),
                          Padding(
                            padding: EdgeInsets.only(left: 20, right: 20),
                            child: Column(
                              children: [
                                SizedBox(height: 20),
                                TextFormField(
                                  controller: usernameController,
                                  decoration: InputDecoration(
                                    enabledBorder: OutlineInputBorder(
                                      borderRadius: BorderRadius.circular(25.0),
                                      borderSide: BorderSide(
                                          color: HexColor("#400507"), width: 2),
                                    ),
                                    focusedBorder: OutlineInputBorder(
                                      borderRadius: BorderRadius.circular(25.0),
                                      borderSide: BorderSide(
                                          color: HexColor("#400507"), width: 2),
                                    ),
                                    labelStyle:
                                        TextStyle(color: HexColor("#400507")),
                                    prefixIcon: Padding(
                                      padding: EdgeInsets.only(left: 10),
                                      child: Icon(
                                        Icons.email,
                                        color: HexColor("#400507"),
                                      ),
                                    ),
                                    labelText: 'E-mail adresa',
                                  ),
                                ),
                                SizedBox(height: 21),
                                TextFormField(
                                  controller: passwordController,
                                  obscureText: !widget._passwordVisible,
                                  enableSuggestions: false,
                                  autocorrect: false,
                                  decoration: InputDecoration(
                                    enabledBorder: OutlineInputBorder(
                                      borderRadius: BorderRadius.circular(25.0),
                                      borderSide: BorderSide(
                                          color: HexColor("#400507"), width: 2),
                                    ),
                                    focusedBorder: OutlineInputBorder(
                                      borderRadius: BorderRadius.circular(25.0),
                                      borderSide: BorderSide(
                                          color: HexColor("#400507"), width: 2),
                                    ),
                                    labelStyle:
                                        TextStyle(color: HexColor("#400507")),
                                    prefixIcon: Padding(
                                      padding: EdgeInsets.only(left: 10),
                                      child: Icon(
                                        Icons.lock,
                                        color: HexColor("#400507"),
                                      ),
                                    ),
                                    labelText: 'Lozinka',
                                    suffixIcon: IconButton(
                                      icon: Padding(
                                        padding: EdgeInsets.only(right: 16),
                                        child: Padding(
                                          padding: EdgeInsets.only(right: 10),
                                          child: Icon(
                                            widget._passwordVisible
                                                ? Icons.visibility
                                                : Icons.visibility_off,
                                            color: Colors.black,
                                            size: 17,
                                          ),
                                        ),
                                      ),
                                      onPressed: () {
                                        setState(() {
                                          widget._passwordVisible =
                                              !widget._passwordVisible;
                                        });
                                      },
                                    ),
                                  ),
                                ),
                                SizedBox(height: 21),
                                SizedBox(
                                  width: 200,
                                  height: 50,
                                  child: TextButton.icon(
                                    style: TextButton.styleFrom(
                                      textStyle: TextStyle(color: Colors.blue),
                                      backgroundColor: HexColor("#400507"),
                                      shape: RoundedRectangleBorder(
                                        borderRadius: BorderRadius.circular(25),
                                      ),
                                    ),
                                    onPressed: () => {Prijava(context)},
                                    icon:
                                        Icon(Icons.login, color: Colors.white),
                                    label: Text("PRIJAVI SE",
                                        style: GoogleFonts.ubuntu(
                                            fontSize: 21,
                                            color: Colors.white,
                                            letterSpacing: 0,
                                            fontWeight: FontWeight.bold)),
                                  ),
                                ),
                                SizedBox(height: 10),
                                Container(
                                  height: 30,
                                  decoration: BoxDecoration(
                                    image: DecorationImage(
                                      image: AssetImage(
                                        'assets/loader.gif',
                                      ),
                                    ),
                                  ),
                                ),
                                SizedBox(height: 10),
                                Text(
                                    "Copyright 2022 © Haris Pandžić. Sva prava pridržana.",
                                    style: GoogleFonts.ubuntu(
                                        fontSize: 8,
                                        color: Colors.black,
                                        fontWeight: FontWeight.bold,
                                        letterSpacing: 0)),
                              ],
                            ),
                          )
                        ]),
                  ),
                ),
              ),
            )
          ],
        ),
        isLoading: _isLoading,
        opacity: 0.5,
        color: Colors.white,
        progressIndicator: CircularProgressIndicator(
          color: HexColor("#400507"),
        ),
      ),
    );
  }
}

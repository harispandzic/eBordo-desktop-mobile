import 'dart:typed_data';
import 'package:badges/badges.dart';
import 'package:collection/collection.dart';
import 'package:ebordo_mobile/pages/Shared/pocetna.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:modal_bottom_sheet/modal_bottom_sheet.dart';
import 'package:motion_toast/motion_toast.dart';
import 'package:motion_toast/resources/arrays.dart';
import '../../models/notifikacija.dart';
import '../../services/APIService.dart';

List<Notifikacija> dobavljeneNotifikacije = [];

class SharedAppBar extends StatefulWidget implements PreferredSizeWidget {
  @override
  _SharedAppBarState createState() => _SharedAppBarState();
  Size get preferredSize => new Size.fromHeight(56);
}

class _SharedAppBarState extends State<SharedAppBar> {
  @override
  // ignore: override_on_non_overriding_member
  List<Notifikacija> _obavijestiState = [];

  @override
  void initState() {
    super.initState();
    Future.delayed(const Duration(seconds: 0), GetNotifikacije);
  }

  Future DeleteNotifikacija(int notifikacijaId) async {
    await APIService.DeleteById("Notifikacija", notifikacijaId);
    GetNotifikacije();
    MotionToast.success(
      titleStyle: TextStyle(fontWeight: FontWeight.bold),
      description: "Notifikacija pročitana!",
      descriptionStyle: TextStyle(fontSize: 12),
      position: MOTION_TOAST_POSITION.TOP,
      animationType: ANIMATION.FROM_TOP,
      height: 40,
    ).show(context);
  }

  Future<List<Notifikacija>> GetNotifikacije() async {
    Map<String, String>? queryParams = null;
    queryParams = {'korisnikId': '${APIService.logovaniKorisnik!.korisnikId}'};

    var result = await APIService.Get("Notifikacija", queryParams) as List;

    List<Notifikacija> notifikacijeList =
        result.map((i) => Notifikacija.fromJson(i)).toList();

    dobavljeneNotifikacije = [];
    dobavljeneNotifikacije = notifikacijeList;

    setState(() {
      _obavijestiState = [];
      _obavijestiState = dobavljeneNotifikacije;
    });

    return notifikacijeList;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        titleSpacing: 0.0,
        title: Row(mainAxisAlignment: MainAxisAlignment.start, children: [
          Padding(
            padding: EdgeInsets.only(right: 8),
            child: Image.asset(
              'assets/fksarajevo-grb.png',
              fit: BoxFit.contain,
              height: 30,
            ),
          ),
          Text("eBORDO",
              style: GoogleFonts.oswald(
                  fontSize: 15,
                  color: Colors.white,
                  letterSpacing: 0,
                  fontWeight: FontWeight.bold)),
          SizedBox(width: MediaQuery.of(context).size.width - 245),
          TextButton(
              child: Badge(
                badgeColor: HexColor("#FFC107"),
                position: BadgePosition.topEnd(top: -8, end: -5),
                padding: EdgeInsets.all(3),
                showBadge: _obavijestiState.length > 0,
                badgeContent: Container(
                  child: Text(_obavijestiState.length.toString(),
                      style: GoogleFonts.oswald(
                        fontSize: 11,
                        color: Colors.black,
                        letterSpacing: 0,
                      )),
                ),
                child: Icon(
                  Icons.notifications,
                  color: Colors.white,
                ),
              ),
              onPressed: () => {
                    GetNotifikacije(),
                    showCupertinoModalBottomSheet(
                      context: context,
                      topRadius: Radius.circular(0),
                      builder: (context) => Container(
                        height: MediaQuery.of(context).size.height - 60,
                        child: Material(
                          child: Container(
                            decoration: BoxDecoration(
                                borderRadius: BorderRadius.only(
                                    bottomRight: Radius.circular(0),
                                    bottomLeft: Radius.circular(0)),
                                image: DecorationImage(
                                    fit: BoxFit.cover,
                                    image: AssetImage(
                                        'assets/login-background-slika.png'))),
                            child: Padding(
                              padding: EdgeInsets.all(15),
                              child: ListView(
                                scrollDirection: Axis.vertical,
                                shrinkWrap: true,
                                children: [
                                  Row(
                                    children: [
                                      Text("OBAVJEŠTENJA",
                                          style: GoogleFonts.oswald(
                                              fontSize: 20,
                                              color: Colors.black,
                                              letterSpacing: 0,
                                              fontWeight: FontWeight.bold)),
                                      SizedBox(
                                        width: 185,
                                      ),
                                      Container(
                                        child: Align(
                                          alignment: Alignment(1, 1),
                                          child: InkWell(
                                            onTap: () {
                                              Navigator.pop(context);
                                            },
                                            child: Container(
                                              decoration: BoxDecoration(
                                                color: Colors.grey[200],
                                                borderRadius:
                                                    BorderRadius.circular(12),
                                              ),
                                              child: Padding(
                                                padding: EdgeInsets.all(5),
                                                child: Icon(
                                                  Icons.close,
                                                  size: 13,
                                                  color: Colors.black,
                                                ),
                                              ),
                                            ),
                                          ),
                                        ),
                                      )
                                    ],
                                  ),
                                  SizedBox(
                                    height: 20,
                                  ),
                                  ListView(
                                    scrollDirection: Axis.vertical,
                                    shrinkWrap: true,
                                    children: _obavijestiState
                                        .mapIndexed((element, index) =>
                                            NotifikacijaKartica(context, index,
                                                element, DeleteNotifikacija))
                                        .toList(),
                                  )
                                ],
                              ),
                            ),
                          ),
                        ),
                      ),
                    )
                  })
        ]),
        backgroundColor: HexColor("#400507"),
        actions: [
          Padding(
            padding: EdgeInsets.only(right: 10),
            child: CircleAvatar(
              radius: 16,
              backgroundColor: Colors.white,
              child: CircleAvatar(
                radius: 15.5,
                backgroundColor: Colors.white,
                child: ClipOval(
                  child: Image.memory(
                    Uint8List.fromList(APIService.logovaniKorisnik!.slika),
                    width: 30,
                    height: 30,
                    fit: BoxFit.cover,
                  ),
                ),
              ),
            ),
          ),
        ],
      ),
    );
  }
}

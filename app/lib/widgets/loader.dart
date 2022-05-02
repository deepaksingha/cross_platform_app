import 'package:b2b/contstants/style.dart';
import 'package:flutter/material.dart';

class Loader extends StatelessWidget {
  final Color color;

  const Loader({Key? key,this.color=Colors.blue})
      : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Container(

        alignment: Alignment.center,
        width: double.maxFinite,
        padding: EdgeInsets.symmetric(vertical: 16),
        child: Center(
          child: Padding(
            padding: EdgeInsets.all(0),
            child: SizedBox(
              child: CircularProgressIndicator(
                color: color,
              ),
              height: 20.0,
              width: 20.0,
            ),
          ),
        ));
  }
}

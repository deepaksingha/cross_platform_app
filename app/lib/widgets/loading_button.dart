import 'package:b2b/contstants/style.dart';
import 'package:flutter/material.dart';

class LoadingButton extends StatelessWidget {

  const LoadingButton({Key? key})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
        decoration: BoxDecoration(
            color: active,
            borderRadius: BorderRadius.circular(20)),
        alignment: Alignment.center,
        width: double.maxFinite,
        padding: EdgeInsets.symmetric(vertical: 16),
        child: Center(
          child: Padding(
            padding: EdgeInsets.all(0),
            child: SizedBox(
              child: CircularProgressIndicator(
                color: light,
              ),
              height: 20.0,
              width: 20.0,
            ),
          ),
        ));
  }
}

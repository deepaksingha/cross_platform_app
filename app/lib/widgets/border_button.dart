import 'package:b2b/contstants/style.dart';
import 'package:flutter/material.dart';

import 'custom_text.dart';

class BorderButton extends StatelessWidget {
  final String text;
  final Color color;

  const BorderButton({Key? key,this.text="",this.color=Colors.blue})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
        decoration: BoxDecoration(
            color: color,
            borderRadius: BorderRadius.circular(20)),
        alignment: Alignment.center,
        width: double.maxFinite,
        padding: EdgeInsets.symmetric(vertical: 16),
        child: CustomText(
            text: text, color: Colors.white));
  }
}

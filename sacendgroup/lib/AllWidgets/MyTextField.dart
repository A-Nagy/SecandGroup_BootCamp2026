import 'package:flutter/material.dart';

class Mytextfield extends StatelessWidget {
  String Tlabel ;
  Mytextfield({super.key, required this.Tlabel});

  @override
  Widget build(BuildContext context) {
    return  TextFormField(
      decoration: InputDecoration(
          labelText: Tlabel,
      enabledBorder: OutlineInputBorder(
        borderSide: BorderSide(
          color: Colors.blue,
          width: 1
        ),borderRadius: BorderRadius.all(Radius.circular(20))
      ),
      ),
      validator:(value)
      {
        if(value == null || value.isEmpty)
        {
          return "Please Enter Your ${Tlabel} " ;
        }
        return null;
      } ,
    );
  }
}

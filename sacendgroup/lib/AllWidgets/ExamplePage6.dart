import 'package:flutter/material.dart';
import 'package:sacendgroup/AllWidgets/MyTextField.dart';

class Examplepage6 extends StatefulWidget {
  const Examplepage6({super.key});

  @override
  State<Examplepage6> createState() => _Examplepage6State();
}

class _Examplepage6State extends State<Examplepage6> {
  void _showDialog(BuildContext context , String title)
  {
    showDialog(
        context: context,
        builder: (context){
          return AlertDialog(
            //backgroundColor: Colors.amber,
            title: Row(
              children: [
                Icon(Icons.warning , color: Colors.red),
                SizedBox(width: 5),
                Text(
                  'Waring',
                  style: TextStyle(
                      color:Colors.black))
              ],
            ),
            content:Text('This is Alert Dialog') ,
            actions: [
              TextButton(
                  onPressed: ()=> Navigator.of(context).pop(),
                  child: Text('Ok'))
            ],

          );
        }
    );
  }
  String? _selectedvalue;
  bool _isChecked  = false ;
  bool _isSwitched = true;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Forms'),
        centerTitle: true,
        backgroundColor: Colors.blue,
      ),
      body: Padding(
        padding: EdgeInsets.all(20),
        child: Form(
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
               /* TextFormField(
                  decoration: InputDecoration(
                    labelText: "User Name"),
                  validator:(value)
                  {
                    if(value == null || value.isEmpty)
                    {
                      return "Please Enter Your UserName " ;
                    }
                    return null;
                  } ,
                ),*/
                const SizedBox(height: 20),
                TextFormField(
                  decoration: InputDecoration(
                      labelText: "Password"),
                  validator:(value)
                  {
                    if(value == null || value.isEmpty)
                    {
                      return "Please Enter Your Password " ;
                    }
                    return null;
                  } ,
                ),
                const SizedBox(height: 20),
                Mytextfield(Tlabel: 'Email'),
                const SizedBox(height: 20),
             //   Mytextfield(Tlabel: 'Phone'),
                Center(
                  child: DropdownButton(
                      hint: const Text('Select Option'),
                      value: _selectedvalue,
                      items: <String>['OP1','OP2','OP3']
                          .map<DropdownMenuItem<String>>((String value)
                      {
                        return DropdownMenuItem(
                          value: value,
                        child: Text(value));
                      }).toList(),
                      onChanged: (String? value)
                      {
                        setState(() {
                          _selectedvalue=value;
                        });
                      }),
                ),
                SizedBox(height: 5),
                Center(
                  child: Checkbox(
                      value: _isChecked,
                      onChanged: (value)
                      {
                        setState(() {
                          _isChecked=value!;
                        });
                      }),
                ),
                SizedBox(height: 5),
                Center(
                  child: Switch(
                      value: _isSwitched,
                      onChanged: (value)
                      {
                        setState(() {
                          _isSwitched=value;
                        });
                      }),
                ),
                ElevatedButton(
                    onPressed: ()=>_showDialog(context,'Warning'),
                    child: const Text('ShowAlert'))
              ],
            )),

      ),
    );
  }
}

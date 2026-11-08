import 'package:flutter/material.dart';

class Examplepage3 extends StatelessWidget {
  const Examplepage3({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(
          'Example Page 3',
        style: TextStyle(
          fontWeight: FontWeight.bold,
          fontSize:26)),
        centerTitle: true,
        backgroundColor: Colors.amber,
      ),
      body: Directionality(
          textDirection: TextDirection.rtl,
          child: SingleChildScrollView(
            child: Column(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Icon(Icons.person,color: Colors.amber,size: 60),
                      SizedBox(width: 10,),
                      Icon(Icons.person_2,color: Colors.amber,size: 60),
                      SizedBox(width: 10,),
                      Icon(Icons.percent_rounded,color: Colors.amber,size: 60)
                    ],
                  ),
                  SizedBox(height: 10,),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Icon(Icons.person,color: Colors.amber,size: 60),
                      Icon(Icons.person_2,color: Colors.amber,size: 60),
                      Icon(Icons.percent_rounded,color: Colors.amber,size: 60)
                    ],
                  ),
                  SizedBox(height: 10,),
                  Center(
                    child: Image.asset('assets/Images/f9.jpg'
                    ,width: 150,
                    height: 150,),
                  ),
                  SizedBox(height: 10,),
                  Center(
                    child: Image.network(
                      'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS-SmX4r9PqcGnGPwacyYSQYLojk85juniI4A&s',
                      width: 250,
                      height: 250,
                    ),
                  ),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Icon(Icons.person,color: Colors.amber,size: 60),
                      SizedBox(width: 10,),
                      Icon(Icons.person_2,color: Colors.amber,size: 60),
                      SizedBox(width: 10,),
                      Icon(Icons.percent_rounded,color: Colors.amber,size: 60)
                    ],
                  ),
                  SizedBox(height: 10,),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Icon(Icons.person,color: Colors.amber,size: 60),
                      Icon(Icons.person_2,color: Colors.amber,size: 60),
                      Icon(Icons.percent_rounded,color: Colors.amber,size: 60)
                    ],
                  ),
                  SizedBox(height: 10,),
                  Center(
                    child: Image.asset('assets/Images/f9.jpg'
                      ,width: 150,
                      height: 150,),
                  ),
                  SizedBox(height: 10,),
                  Center(
                    child: Image.network(
                      'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS-SmX4r9PqcGnGPwacyYSQYLojk85juniI4A&s',
                      width: 250,
                      height: 250,
                    ),
                  ),
                ],
              ),
          ),
          ),
    );
  }
}

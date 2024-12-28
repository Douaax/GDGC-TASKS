import 'package:flutter/material.dart';


class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: ProfilePage(),
    );
  }
}

class ProfilePage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('My profile'),
        backgroundColor: Colors.white,
        elevation: 0,
        actions: [
          IconButton(
            icon: Icon(Icons.search, color: Colors.black),
            onPressed: () {},
          ),
        ],
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              'My Profile',
              style: TextStyle(
                fontSize: 22,
                fontWeight: FontWeight.bold,
              ),
            ),
            SizedBox(height: 16),
            Row(
              children: [
                CircleAvatar(
                  radius: 30,
                  backgroundImage: AssetImage('assets/profile_picture.png'),
                ),
                SizedBox(width: 16),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      'Matilda Brown',
                      style: TextStyle(
                        fontSize: 20,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    Text('matildabrown@mail.com'),
                  ],
                ),
              ],
            ),
            SizedBox(height: 32),
            ProfileMenuItem(
              title: 'My orders',
              subtitle: 'Already have 12 orders',
              onTap: () {},
            ),
            ProfileMenuItem(
              title: 'Shipping addresses',
              subtitle: '3 addresses',
              onTap: () {},
            ),
            ProfileMenuItem(
              title: 'Payment methods',
              subtitle: 'Visa **34',
              onTap: () {},
            ),
            ProfileMenuItem(
              title: 'Promocodes',
              subtitle: 'You have special promocodes',
              onTap: () {},
            ),
            ProfileMenuItem(
              title: 'My reviews',
              subtitle: 'Reviews for 4 items',
              onTap: () {},
            ),
            ProfileMenuItem(
              title: 'Settings',
              subtitle: 'Notifications, password',
              onTap: () {},
            ),
          ],
        ),
      ),
      bottomNavigationBar: BottomNavigationBar(
        currentIndex: 4,
        items: [
          BottomNavigationBarItem(
            icon: Icon(Icons.home),
            label: 'Home',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.shop),
            label: 'Shop',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.shopping_bag),
            label: 'Bag',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.favorite),
            label: 'Favorites',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.person),
            label: 'Profile',
          ),
        ],
      ),
    );
  }
}

class ProfileMenuItem extends StatelessWidget {
  final String title;
  final String subtitle;
  final VoidCallback onTap;

  ProfileMenuItem({
    required this.title,
    required this.subtitle,
    required this.onTap,
  });

  @override
  Widget build(BuildContext context) {
    return ListTile(
      title: Text(title),
      subtitle: Text(subtitle),
      trailing: Icon(Icons.arrow_forward_ios),
      onTap: onTap,
    );
  }
}

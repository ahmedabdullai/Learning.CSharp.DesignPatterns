// Create mediator
using Mediator;

IChatRoomMediator chatRoom = new ChatRoom();

// Create users
User user1 = new User("Alice", chatRoom);
User user2 = new User("Bob", chatRoom);
User user3 = new User("Charlie", chatRoom);

// Users send messages via the mediator
user1.Send("Hello, everyone!");
user2.Send("Hi, Alice!");
user3.Send("Good morning!");
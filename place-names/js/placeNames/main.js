const names = [
  "Nashville",
  "Hong Kong",
  "The back yard",
  "Earth",
  "London",
  "The mall",
  "Ryman Auditorium",
  "The Great Wall of China",
];

console.log("All Place Names");
names.forEach((name) => console.log(name));

let thenames = names.filter((name) => name.includes("The"));

thenames.forEach((name) => console.log(`The Place Names ${name}`));

console.log("Let's roll some dice, baby!");
console.log("---------------------------");

const getRoll = (min, max) => {
  min = Math.ceil(1);
  max = Math.floor(6);
  return Math.floor(Math.random() * 6) + 1;
};

const results = () => {
  for (let i = 0; i < 10; i++) {
    let die1 = getRoll();
    let die2 = getRoll();

    let message = `${die1} + ${die2} == ${die1 + die2}`;

    if (die1 == die2) {
      console.log((message += " DOUBLES!"));
    } else {
      console.log(message);
    }
  }
};
results();

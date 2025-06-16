import './App.css';
import { FootballClubInfo, FootballClubRewards, FootballClubTeam } from './FootballClub';

function ClubInfo(name, city, dateFound, countWins, image)
{
  return {
    name: name,
    city: city,
    dateFound: dateFound,
    countWins: countWins, 
    image: image,
  }
}
function ClubReward(date, description, photos)
{
  return {
    date: date,
    description: description,
    photos: photos,
  }
}
function ClubPlayer(name, surname, countGoals, position, description, photo)
{
  return {
    photo: photo,
    name: name,
    surname: surname,
    countGoals: countGoals,
    position: position,
    description: description,
  }
}

class Club {
  info;
  rewards;
  players;
  constructor(info, rewards, players)
  {
    this.info = info;
    this.rewards = rewards;
    this.players = players;
  }
}

let clubs = [];

clubs.push(new Club(
  ClubInfo("Red Hawks", "New York", 1992, 48, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQm7rWLuDs7TSICTnLHiGQIw2viIAK3V6z0_w&s"),
  [
    ClubReward("2010-05-12", "Championship Victory", ["https://www.recordnet.com/gcdn/authoring/2019/04/08/NRCD/ghows-SR-860d833d-dd4b-298c-e053-0100007fee69-314cccfb.jpeg?width=660&height=495&fit=crop&format=pjpg&auto=webp", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8t2bsCUBGPBKsk6kA23CBlAo_zKq_P8RWSwGIWX4djCuYTqhLkGS5Xbie62_TsLvQIwU&usqp=CAU"]),
    ClubReward("2018-11-03", "Best Team Award", ["https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeiz1TanhQ7wYdIu7iT01PondNEUKUgxTtLw&s"])
  ],
  [
    ClubPlayer("John", "Smith", 120, "Forward", "Fast and aggressive attacker.", " "),
    ClubPlayer("Alex", "Turner", 80, "Midfielder", "Great at assists and ball control.", "  ")
  ],
));

// Клуб 2
clubs.push(new Club(
  ClubInfo("Blue Storm", "Chicago", 1985, 63, "https://patch.com/img/biz/sites/default/files/users/22879250/20180724132334/blue_storm_logo2_rev_d_medium.jpg"),
  [
    ClubReward("2005-06-22", "Cup Winner", ["https://media-cldnry.s-nbcnews.com/image/upload/t_social_share_1024x768_scale,f_auto,q_auto:best/rockcms/2024-07/240714-spain-victory-championship-wm-239p-5c6473.jpg"]),
    ClubReward("2020-09-14", "Top Scoring Team", ["https://i0.wp.com/herfootballhub.com/wp-content/uploads/2024/12/atletico-madrid-v-rangers-fc-uefa-womens-champions-league-first-round-mini-tournament-3rd-4th-play-off-scaled-e1734642136925.jpg?resize=678%2C381&ssl=1", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSaU8HN-60p2c3TBON3x2RK3EOkUD3RDn3wL4FkdkJsXq00lRwDdpfXirqIgtUn7_uX0mM&usqp=CAU"])
  ],
  [
    ClubPlayer("Mike", "Anderson", 95, "Forward", "Sharp shooter."),
    ClubPlayer("Brian", "Lewis", 60, "Defender", "Wall in defense.")
  ]
));

// Клуб 3
clubs.push(new Club(
  ClubInfo("Green Eagles", "San Francisco", 2001, 39, "https://upload.wikimedia.org/wikipedia/en/e/e3/Green_Eagles_emblem_2021.png"),
  [
    ClubReward("2015-03-19", "Surprise Team of the Year", ["https://cdn-attachments.timesofmalta.com/fe36c8bec8af3d577010a6aa080dcaf6b724d92e-1568050868-5d768eb4-630x420.jpg"]),
  ],
  [
    ClubPlayer("Chris", "Johnson", 110, "Forward", "Excellent finisher."),
    ClubPlayer("Kevin", "White", 70, "Goalkeeper", "Cat-like reflexes.")
  ]
));


function App() {
  return (
    <div>
      {clubs.map(item => (
        <div key={""} id="club">
          
          <FootballClubInfo 
          nameClub={item.info.name} 
          city={item.info.city} 
          countWins={item.info.countWins} 
          date={item.info.dateFound} 
          image={item.info.image}> 
          </FootballClubInfo>

          <FootballClubRewards
          rewards={item.rewards}>
          </FootballClubRewards>

          <FootballClubTeam
           team={item.players}
          
          ></FootballClubTeam>
        </div>
      ))}
    </div>
  );
}

export default App;

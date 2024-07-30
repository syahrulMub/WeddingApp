import React from "react";

function RenderSkill(props) {
  return <li>I have learn {props.currentSkill}</li>;
}
function MySkill() {
  const skills = ["Javascript", "CSS", "C#", "SQL"];
  return (
    <div>
      <h2>Skill</h2>
      <ul>
        {skills.map((skill) => (
          <RenderSkill currentSkill={skill} />
        ))}
      </ul>
    </div>
  );
}

export default MySkill;

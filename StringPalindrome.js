/*
String Challenge
Have the function StringChallenge(str) take the str parameter being passed and return the string true if the parameter is a palindrome, (the string is the same forward as it is backward) otherwise return the string false. The parameter entered may have punctuation and symbols but they should not affect whether the string is in fact a palindrome. For example: "Anne, I vote more cars race Rome-to-Vienna" should return true.
*/

function StringChallenge(str) { 

  if(str.toLowerCase().replace(/[^a-z]/g,'') == str.toLowerCase().replace(/[^a-z]/g,'').split('').reverse().join('')){
    return true;
  }
  return false; 

}
   
// keep this function call here 
console.log(StringChallenge(readline()));

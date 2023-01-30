using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class EnablerCmtsDB
{
    public string welcome;
    public string brain_gym_1;
    public string magic_e_revision;
    public string vowel_teams;
    public string phonic_sounds;
    public string intro_ai_ay;
    public string vowel_ai_ay;
    public string long_vowel_a;
    public string brain_gym_2;
    public string Intro_ea_ee_ey;
    public string long_vowel_e;
    public string goodbye;

    public EnablerCmtsDB()
    {
        welcome = Main_Blended.OBJ_main_blended.enablerComments[0];
        brain_gym_1 = Main_Blended.OBJ_main_blended.enablerComments[1];
        magic_e_revision = Main_Blended.OBJ_main_blended.enablerComments[2];
        vowel_teams = Main_Blended.OBJ_main_blended.enablerComments[3];
        phonic_sounds = Main_Blended.OBJ_main_blended.enablerComments[4];
        intro_ai_ay = Main_Blended.OBJ_main_blended.enablerComments[5];
        vowel_ai_ay = Main_Blended.OBJ_main_blended.enablerComments[6];
        long_vowel_a = Main_Blended.OBJ_main_blended.enablerComments[7];
        brain_gym_2 = Main_Blended.OBJ_main_blended.enablerComments[8];
        Intro_ea_ee_ey = Main_Blended.OBJ_main_blended.enablerComments[9];
        long_vowel_e = Main_Blended.OBJ_main_blended.enablerComments[10];
        goodbye = Main_Blended.OBJ_main_blended.enablerComments[11];
    }
}
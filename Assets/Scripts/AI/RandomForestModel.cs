namespace ML {
    public static class RandomForestModel {

    // =========================================================
    // StandardScaler dari Python
    // Urutan fitur:
    // 0. current_level
    // 1. avg_hand_velocity
    // 2. max_hand_jerk
    // 3. hesitation_time
    // 4. focus_consistency
    // 5. total_duration
    // =========================================================

    public static double[] scaler_mean = new double[] { 1.7807881773399015, 0.42597241379310341, 1549.2080953201971, 40.707832512315271, 12.115795812807882, 142.33362068965516 };
    public static double[] scaler_scale = new double[] { 0.82074420720059194, 0.15479996269645496, 1564.2969240526947, 56.253429252723429, 4.445571607348846, 106.09987783589614 };

    public static double[] Standardize(double[] input)
    {
        if (input.Length != scaler_mean.Length)
        {
            throw new System.ArgumentException("Jumlah fitur input tidak sesuai dengan scaler.");
        }

        double[] scaled = new double[input.Length];

        for (int i = 0; i < input.Length; ++i)
        {
            if (scaler_scale[i] == 0)
            {
                scaled[i] = 0;
            }
            else
            {
                scaled[i] = (input[i] - scaler_mean[i]) / scaler_scale[i];
            }
        }

        return scaled;
    }


        public static double[] Score(double[] input) {
            double[] var0;
            if (input[1] <= 2.1216257214546204) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[1] <= -2.050532877445221) {
                            var0 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= 1.5263413786888123) {
                                if (input[5] <= 5.280320763587952) {
                                    if (input[3] <= 1.8571697473526) {
                                        var0 = new double[2] {0.0, 1.0};
                                    } else {
                                        var0 = new double[2] {0.4, 0.6};
                                    }
                                } else {
                                    var0 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var0 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            }
                        }
                    } else {
                        var0 = new double[2] {0.2, 0.8};
                    }
                } else {
                    var0 = new double[2] {1.0, 0.0};
                }
            } else {
                var0 = new double[2] {0.8888888888888888, 0.1111111111111111};
            }
            double[] var1;
            if (input[2] <= 1.4859262704849243) {
                if (input[4] <= 2.1863789558410645) {
                    var1 = new double[2] {0.0, 1.0};
                } else {
                    var1 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.7532561421394348) {
                    if (input[4] <= -1.4453137516975403) {
                        var1 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 5.280320763587952) {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[5] <= 1.4536904096603394) {
                                    if (input[1] <= -1.36287122964859) {
                                        var1 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[3] <= 1.3142695128917694) {
                                            var1 = new double[2] {0.0, 1.0};
                                        } else {
                                            var1 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var1 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                if (input[4] <= -0.11199815385043621) {
                                    var1 = new double[2] {0.21428571428571427, 0.7857142857142857};
                                } else {
                                    var1 = new double[2] {0.6666666666666666, 0.3333333333333333};
                                }
                            }
                        } else {
                            var1 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var1 = new double[2] {0.9230769230769231, 0.07692307692307693};
                }
            }
            double[] var2;
            if (input[3] <= 1.7416212558746338) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[5] <= 1.165518581867218) {
                        if (input[2] <= 2.175404667854309) {
                            var2 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 2.12840873003006) {
                                if (input[3] <= 0.3639274537563324) {
                                    var2 = new double[2] {0.0, 1.0};
                                } else {
                                    var2 = new double[2] {0.125, 0.875};
                                }
                            } else {
                                var2 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var2 = new double[2] {0.42857142857142855, 0.5714285714285714};
                    }
                } else {
                    var2 = new double[2] {0.8, 0.2};
                }
            } else {
                var2 = new double[2] {1.0, 0.0};
            }
            double[] var3;
            if (input[5] <= 0.43870341777801514) {
                if (input[3] <= 0.30668650567531586) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[4] <= -0.8789861500263214) {
                            if (input[1] <= 1.9814448356628418) {
                                var3 = new double[2] {0.0, 1.0};
                            } else {
                                var3 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var3 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var3 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var3 = new double[2] {0.08333333333333333, 0.9166666666666666};
                }
            } else {
                if (input[3] <= 0.7842573821544647) {
                    if (input[4] <= 0.09023680537939072) {
                        var3 = new double[2] {0.0, 1.0};
                    } else {
                        var3 = new double[2] {0.875, 0.125};
                    }
                } else {
                    var3 = new double[2] {0.8666666666666667, 0.13333333333333333};
                }
            }
            double[] var4;
            if (input[5] <= 0.9428510367870331) {
                if (input[2] <= 1.4623540043830872) {
                    var4 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 1.5374759435653687) {
                        var4 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[3] <= -0.38713787496089935) {
                                var4 = new double[2] {0.2, 0.8};
                            } else {
                                var4 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var4 = new double[2] {0.75, 0.25};
                        }
                    }
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var4 = new double[2] {0.4, 0.6};
                } else {
                    var4 = new double[2] {0.9411764705882353, 0.058823529411764705};
                }
            }
            double[] var5;
            if (input[3] <= 0.7842573821544647) {
                if (input[5] <= 1.165518581867218) {
                    if (input[1] <= 1.8961734771728516) {
                        if (input[4] <= 2.034778654575348) {
                            if (input[3] <= 0.37566007673740387) {
                                if (input[4] <= 1.7611917853355408) {
                                    var5 = new double[2] {0.0, 1.0};
                                } else {
                                    var5 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var5 = new double[2] {0.06666666666666667, 0.9333333333333333};
                            }
                        } else {
                            var5 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var5 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var5 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -1.3192665576934814) {
                    var5 = new double[2] {0.5, 0.5};
                } else {
                    var5 = new double[2] {1.0, 0.0};
                }
            }
            double[] var6;
            if (input[2] <= 0.40715569257736206) {
                var6 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 1.150134265422821) {
                    if (input[1] <= 2.118072807788849) {
                        if (input[5] <= 2.853314995765686) {
                            if (input[1] <= 1.5263413786888123) {
                                var6 = new double[2] {0.0, 1.0};
                            } else {
                                var6 = new double[2] {0.4, 0.6};
                            }
                        } else {
                            var6 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        }
                    } else {
                        var6 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var6 = new double[2] {1.0, 0.0};
                }
            }
            double[] var7;
            if (input[5] <= 0.4007203280925751) {
                if (input[4] <= 1.8934694528579712) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[1] <= -1.4827032685279846) {
                            if (input[2] <= 0.9722183644771576) {
                                var7 = new double[2] {0.0, 1.0};
                            } else {
                                var7 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var7 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var7 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var7 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 0.9808341264724731) {
                    var7 = new double[2] {0.35714285714285715, 0.6428571428571429};
                } else {
                    if (input[3] <= 2.440600872039795) {
                        var7 = new double[2] {0.9166666666666666, 0.08333333333333333};
                    } else {
                        var7 = new double[2] {0.5, 0.5};
                    }
                }
            }
            double[] var8;
            if (input[2] <= 1.2749791145324707) {
                if (input[3] <= -0.5628604888916016) {
                    if (input[4] <= 2.1181874871253967) {
                        var8 = new double[2] {0.0, 1.0};
                    } else {
                        var8 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var8 = new double[2] {0.0, 1.0};
                }
            } else {
                if (input[5] <= 0.9808341264724731) {
                    if (input[3] <= 0.42614588141441345) {
                        if (input[4] <= -0.1321305464953184) {
                            if (input[1] <= 2.0550883412361145) {
                                var8 = new double[2] {0.0, 1.0};
                            } else {
                                var8 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var8 = new double[2] {0.8, 0.2};
                        }
                    } else {
                        var8 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var8 = new double[2] {1.0, 0.0};
                }
            }
            double[] var9;
            if (input[3] <= 0.7842573821544647) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[5] <= 0.5814462602138519) {
                            var9 = new double[2] {0.0, 1.0};
                        } else {
                            var9 = new double[2] {0.1, 0.9};
                        }
                    } else {
                        var9 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var9 = new double[2] {0.875, 0.125};
                }
            } else {
                if (input[5] <= 1.144736260175705) {
                    var9 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 1.6531969904899597) {
                        var9 = new double[2] {0.0, 1.0};
                    } else {
                        var9 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var10;
            if (input[4] <= 1.8199918866157532) {
                if (input[3] <= 1.2698277831077576) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[5] <= 0.6243304014205933) {
                                var10 = new double[2] {0.0, 1.0};
                            } else {
                                var10 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var10 = new double[2] {0.13333333333333333, 0.8666666666666667};
                        }
                    } else {
                        var10 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var10 = new double[2] {1.0, 0.0};
                }
            } else {
                var10 = new double[2] {1.0, 0.0};
            }
            double[] var11;
            if (input[1] <= 1.8961734771728516) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[5] <= 3.6857852935791016) {
                        if (input[1] <= -0.6451708078384399) {
                            if (input[2] <= 1.548285573720932) {
                                var11 = new double[2] {0.0, 1.0};
                            } else {
                                var11 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var11 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var11 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var11 = new double[2] {0.7142857142857143, 0.2857142857142857};
                }
            } else {
                var11 = new double[2] {0.8571428571428571, 0.14285714285714285};
            }
            double[] var12;
            if (input[2] <= 2.060991406440735) {
                if (input[2] <= 0.4325118213891983) {
                    var12 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.5217327326536179) {
                        var12 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 1.4791381061077118) {
                            var12 = new double[2] {0.0, 1.0};
                        } else {
                            var12 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    }
                }
            } else {
                if (input[1] <= 2.011483609676361) {
                    if (input[3] <= 0.777857780456543) {
                        if (input[1] <= 0.33867958188056946) {
                            var12 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= -0.32323065400123596) {
                                var12 = new double[2] {0.2222222222222222, 0.7777777777777778};
                            } else {
                                var12 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var12 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var12 = new double[2] {1.0, 0.0};
                }
            }
            double[] var13;
            if (input[2] <= 0.2773258090019226) {
                var13 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 0.034833358600735664) {
                    if (input[3] <= 1.545366495847702) {
                        if (input[1] <= 3.6432669162750244) {
                            if (input[1] <= 1.8916515111923218) {
                                var13 = new double[2] {0.0, 1.0};
                            } else {
                                var13 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var13 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var13 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[5] <= 0.15142693370580673) {
                        var13 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        if (input[4] <= 1.068716138601303) {
                            var13 = new double[2] {0.7142857142857143, 0.2857142857142857};
                        } else {
                            var13 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var14;
            if (input[2] <= 2.060991406440735) {
                if (input[3] <= 0.010082363151013851) {
                    var14 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 0.015859788749367) {
                        var14 = new double[2] {1.0, 0.0};
                    } else {
                        var14 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[4] <= -0.3435094356536865) {
                    if (input[4] <= -0.8815842270851135) {
                        if (input[3] <= -0.07480135187506676) {
                            var14 = new double[2] {0.25, 0.75};
                        } else {
                            var14 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var14 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[5] <= 1.055810660123825) {
                        var14 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        var14 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var15;
            if (input[4] <= 1.8199918866157532) {
                if (input[3] <= 0.777857780456543) {
                    if (input[2] <= 2.171961545944214) {
                        var15 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 1.165518581867218) {
                            if (input[5] <= -0.03971371799707413) {
                                if (input[5] <= -0.06388905085623264) {
                                    if (input[3] <= 0.19184906035661697) {
                                        var15 = new double[2] {0.08333333333333333, 0.9166666666666666};
                                    } else {
                                        var15 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var15 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.7294346988201141) {
                                    var15 = new double[2] {0.0, 1.0};
                                } else {
                                    var15 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var15 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[2] <= 1.8541556596755981) {
                        var15 = new double[2] {0.0, 1.0};
                    } else {
                        var15 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var15 = new double[2] {1.0, 0.0};
            }
            double[] var16;
            if (input[5] <= 1.118770182132721) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[5] <= 0.5814462602138519) {
                        if (input[1] <= 2.230798900127411) {
                            if (input[4] <= 1.7611917853355408) {
                                var16 = new double[2] {0.0, 1.0};
                            } else {
                                var16 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var16 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var16 = new double[2] {0.2857142857142857, 0.7142857142857143};
                    }
                } else {
                    var16 = new double[2] {1.0, 0.0};
                }
            } else {
                var16 = new double[2] {0.9285714285714286, 0.07142857142857142};
            }
            double[] var17;
            if (input[3] <= 1.0039772987365723) {
                if (input[4] <= 1.7565242052078247) {
                    if (input[3] <= 0.3040200024843216) {
                        if (input[3] <= -0.1068882867693901) {
                            var17 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.9052174091339111) {
                                var17 = new double[2] {0.0, 1.0};
                            } else {
                                var17 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[0] <= 0.876292273402214) {
                            var17 = new double[2] {0.0, 1.0};
                        } else {
                            var17 = new double[2] {0.7142857142857143, 0.2857142857142857};
                        }
                    }
                } else {
                    var17 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                if (input[5] <= 3.5527032613754272) {
                    var17 = new double[2] {0.45454545454545453, 0.5454545454545454};
                } else {
                    var17 = new double[2] {1.0, 0.0};
                }
            }
            double[] var18;
            if (input[4] <= 1.8199918866157532) {
                if (input[2] <= 1.686274766921997) {
                    var18 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 0.7842573821544647) {
                        if (input[4] <= 0.4860239289700985) {
                            if (input[4] <= -1.4453137516975403) {
                                var18 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 2.4804760217666626) {
                                    var18 = new double[2] {0.0, 1.0};
                                } else {
                                    var18 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var18 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var18 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var18 = new double[2] {1.0, 0.0};
            }
            double[] var19;
            if (input[2] <= 0.40715569257736206) {
                var19 = new double[2] {0.0, 1.0};
            } else {
                if (input[3] <= 0.7842573821544647) {
                    if (input[4] <= 1.4729836583137512) {
                        if (input[1] <= -1.36287122964859) {
                            var19 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.7294346988201141) {
                                if (input[1] <= 2.7992745637893677) {
                                    var19 = new double[2] {0.0, 1.0};
                                } else {
                                    var19 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var19 = new double[2] {0.25, 0.75};
                            }
                        }
                    } else {
                        var19 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[0] <= -0.3421141058206558) {
                        if (input[2] <= 1.6334203481674194) {
                            var19 = new double[2] {0.25, 0.75};
                        } else {
                            var19 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var19 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var20;
            if (input[1] <= 2.1171037554740906) {
                if (input[0] <= -0.3421141058206558) {
                    if (input[4] <= 1.9012749791145325) {
                        if (input[5] <= 1.273577094078064) {
                            if (input[3] <= -0.40482568740844727) {
                                if (input[3] <= -0.41744713485240936) {
                                    var20 = new double[2] {0.0, 1.0};
                                } else {
                                    var20 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var20 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var20 = new double[2] {0.9285714285714286, 0.07142857142857142};
                        }
                    } else {
                        var20 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 1.2698277831077576) {
                        if (input[1] <= 1.5053465366363525) {
                            if (input[5] <= 0.4117005616426468) {
                                var20 = new double[2] {0.0, 1.0};
                            } else {
                                var20 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var20 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var20 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var20 = new double[2] {1.0, 0.0};
            }
            double[] var21;
            if (input[3] <= 1.7416212558746338) {
                if (input[5] <= 1.165518581867218) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[1] <= 2.4804760217666626) {
                            if (input[2] <= 2.171961545944214) {
                                var21 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 0.6243304014205933) {
                                    if (input[1] <= 2.011483609676361) {
                                        if (input[0] <= -0.3421141058206558) {
                                            if (input[1] <= 0.3467545211315155) {
                                                var21 = new double[2] {0.1111111111111111, 0.8888888888888888};
                                            } else {
                                                var21 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var21 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var21 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var21 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            }
                        } else {
                            var21 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var21 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var21 = new double[2] {0.4444444444444444, 0.5555555555555556};
                }
            } else {
                var21 = new double[2] {1.0, 0.0};
            }
            double[] var22;
            if (input[4] <= 1.9012749791145325) {
                if (input[5] <= 1.165518581867218) {
                    if (input[3] <= 0.30668650567531586) {
                        if (input[4] <= -0.8186227083206177) {
                            if (input[1] <= 2.011483609676361) {
                                var22 = new double[2] {0.0, 1.0};
                            } else {
                                var22 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= 2.1532992124557495) {
                                var22 = new double[2] {0.0, 1.0};
                            } else {
                                var22 = new double[2] {0.06666666666666667, 0.9333333333333333};
                            }
                        }
                    } else {
                        if (input[2] <= 1.9895713329315186) {
                            var22 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 2.118072807788849) {
                                var22 = new double[2] {0.1, 0.9};
                            } else {
                                var22 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var22 = new double[2] {1.0, 0.0};
                }
            } else {
                var22 = new double[2] {1.0, 0.0};
            }
            double[] var23;
            if (input[1] <= 1.8961734771728516) {
                if (input[5] <= 3.5527032613754272) {
                    if (input[3] <= 0.476276159286499) {
                        if (input[1] <= 1.512775480747223) {
                            if (input[5] <= 1.2366308271884918) {
                                if (input[2] <= 1.4859262704849243) {
                                    var23 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= 0.13874413073062897) {
                                        var23 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[5] <= -0.27868666499853134) {
                                            var23 = new double[2] {0.0, 1.0};
                                        } else {
                                            var23 = new double[2] {0.2, 0.8};
                                        }
                                    }
                                }
                            } else {
                                var23 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var23 = new double[2] {0.4, 0.6};
                        }
                    } else {
                        if (input[5] <= 0.21151183545589447) {
                            var23 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= 1.5816310048103333) {
                                var23 = new double[2] {0.0, 1.0};
                            } else {
                                var23 = new double[2] {0.2, 0.8};
                            }
                        }
                    }
                } else {
                    var23 = new double[2] {1.0, 0.0};
                }
            } else {
                var23 = new double[2] {0.8571428571428571, 0.14285714285714285};
            }
            double[] var24;
            if (input[3] <= 1.5517660975456238) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 0.40715569257736206) {
                        var24 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 1.4407605528831482) {
                            if (input[1] <= -1.36287122964859) {
                                var24 = new double[2] {1.0, 0.0};
                            } else {
                                var24 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var24 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var24 = new double[2] {1.0, 0.0};
                }
            } else {
                var24 = new double[2] {0.8461538461538461, 0.15384615384615385};
            }
            double[] var25;
            if (input[3] <= 0.49405285716056824) {
                if (input[1] <= 2.4149075746536255) {
                    if (input[4] <= 2.034778654575348) {
                        if (input[4] <= 1.7600783109664917) {
                            if (input[5] <= 0.6243304014205933) {
                                if (input[3] <= 0.379926472902298) {
                                    if (input[5] <= -0.06327642314136028) {
                                        var25 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[5] <= -0.06054314784705639) {
                                            var25 = new double[2] {1.0, 0.0};
                                        } else {
                                            var25 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var25 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                var25 = new double[2] {0.2, 0.8};
                            }
                        } else {
                            var25 = new double[2] {0.25, 0.75};
                        }
                    } else {
                        var25 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var25 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 1.5816310048103333) {
                    var25 = new double[2] {0.5, 0.5};
                } else {
                    var25 = new double[2] {1.0, 0.0};
                }
            }
            double[] var26;
            if (input[5] <= 1.4536904096603394) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[5] <= 0.16122902184724808) {
                        if (input[3] <= -0.4148695170879364) {
                            if (input[5] <= -0.157574363052845) {
                                var26 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= 0.9617903530597687) {
                                    var26 = new double[2] {0.0, 1.0};
                                } else {
                                    var26 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var26 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= 1.7442760467529297) {
                            var26 = new double[2] {0.0, 1.0};
                        } else {
                            var26 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var26 = new double[2] {0.9166666666666666, 0.08333333333333333};
                }
            } else {
                var26 = new double[2] {0.875, 0.125};
            }
            double[] var27;
            if (input[3] <= 1.5816310048103333) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[2] <= 2.175404667854309) {
                        var27 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.7294346988201141) {
                            if (input[1] <= 2.0848039984703064) {
                                if (input[5] <= -0.16902583837509155) {
                                    var27 = new double[2] {0.1111111111111111, 0.8888888888888888};
                                } else {
                                    var27 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var27 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var27 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var27 = new double[2] {1.0, 0.0};
                }
            } else {
                var27 = new double[2] {0.8, 0.2};
            }
            double[] var28;
            if (input[3] <= 1.1131262183189392) {
                if (input[1] <= 1.790553331375122) {
                    if (input[4] <= 1.7600783109664917) {
                        if (input[1] <= -1.4671993851661682) {
                            if (input[1] <= -1.483995258808136) {
                                var28 = new double[2] {0.0, 1.0};
                            } else {
                                var28 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var28 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var28 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var28 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            } else {
                var28 = new double[2] {0.75, 0.25};
            }
            double[] var29;
            if (input[3] <= 1.5816310048103333) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[3] <= 0.9975776970386505) {
                            if (input[3] <= 0.379926472902298) {
                                var29 = new double[2] {0.0, 1.0};
                            } else {
                                var29 = new double[2] {0.05555555555555555, 0.9444444444444444};
                            }
                        } else {
                            var29 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var29 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var29 = new double[2] {1.0, 0.0};
                }
            } else {
                var29 = new double[2] {0.9166666666666666, 0.08333333333333333};
            }
            double[] var30;
            if (input[2] <= 0.43158040940761566) {
                var30 = new double[2] {0.0, 1.0};
            } else {
                if (input[3] <= 1.5816310048103333) {
                    if (input[4] <= 1.150134265422821) {
                        if (input[4] <= -1.4453137516975403) {
                            var30 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= 2.011483609676361) {
                                if (input[1] <= -1.3619022369384766) {
                                    var30 = new double[2] {1.0, 0.0};
                                } else {
                                    var30 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var30 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var30 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var30 = new double[2] {0.9166666666666666, 0.08333333333333333};
                }
            }
            double[] var31;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 2.154894530773163) {
                    if (input[3] <= 0.37566007673740387) {
                        if (input[2] <= 0.40715569257736206) {
                            var31 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 1.2495590448379517) {
                                var31 = new double[2] {0.0, 1.0};
                            } else {
                                var31 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= 0.5118295550346375) {
                            var31 = new double[2] {0.5714285714285714, 0.42857142857142855};
                        } else {
                            var31 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var31 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 0.9859141409397125) {
                    var31 = new double[2] {0.0, 1.0};
                } else {
                    var31 = new double[2] {0.9166666666666666, 0.08333333333333333};
                }
            }
            double[] var32;
            if (input[3] <= 1.429818034172058) {
                if (input[2] <= 0.40715569257736206) {
                    var32 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        if (input[2] <= 0.5208013206720352) {
                            var32 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= 2.4149075746536255) {
                                if (input[5] <= 0.43870341777801514) {
                                    if (input[4] <= 0.03569938801229) {
                                        var32 = new double[2] {0.0, 1.0};
                                    } else {
                                        var32 = new double[2] {0.2, 0.8};
                                    }
                                } else {
                                    var32 = new double[2] {0.2727272727272727, 0.7272727272727273};
                                }
                            } else {
                                var32 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var32 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var32 = new double[2] {1.0, 0.0};
            }
            double[] var33;
            if (input[1] <= 2.1216257214546204) {
                if (input[3] <= 0.379926472902298) {
                    if (input[1] <= 1.5263413786888123) {
                        if (input[2] <= 0.27639439702033997) {
                            var33 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= 0.6727293282747269) {
                                var33 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[0] <= 0.876292273402214) {
                                    var33 = new double[2] {0.0, 1.0};
                                } else {
                                    var33 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            }
                        }
                    } else {
                        var33 = new double[2] {0.14285714285714285, 0.8571428571428571};
                    }
                } else {
                    if (input[3] <= 3.6247063875198364) {
                        if (input[5] <= -0.16398341953754425) {
                            var33 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= 1.4840682744979858) {
                                var33 = new double[2] {0.75, 0.25};
                            } else {
                                var33 = new double[2] {0.13333333333333333, 0.8666666666666667};
                            }
                        }
                    } else {
                        var33 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var33 = new double[2] {1.0, 0.0};
            }
            double[] var34;
            if (input[2] <= 2.175404667854309) {
                if (input[1] <= -2.050532877445221) {
                    var34 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 1.6842871308326721) {
                        if (input[1] <= -0.22915001213550568) {
                            if (input[1] <= -0.2301190048456192) {
                                var34 = new double[2] {0.0, 1.0};
                            } else {
                                var34 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var34 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var34 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[3] <= 1.1606788635253906) {
                    if (input[4] <= 0.7294346988201141) {
                        if (input[5] <= 0.12216205149888992) {
                            if (input[3] <= 0.13851897791028023) {
                                if (input[5] <= -0.0688843447715044) {
                                    if (input[0] <= -0.3421141058206558) {
                                        var34 = new double[2] {0.0, 1.0};
                                    } else {
                                        var34 = new double[2] {0.5, 0.5};
                                    }
                                } else {
                                    var34 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                var34 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var34 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var34 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var34 = new double[2] {1.0, 0.0};
                }
            }
            double[] var35;
            if (input[3] <= 0.7842573821544647) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[5] <= 0.43870341777801514) {
                        var35 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.7294346988201141) {
                            var35 = new double[2] {0.0, 1.0};
                        } else {
                            var35 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var35 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -0.46687617897987366) {
                    var35 = new double[2] {0.8333333333333334, 0.16666666666666666};
                } else {
                    var35 = new double[2] {0.3333333333333333, 0.6666666666666666};
                }
            }
            double[] var36;
            if (input[1] <= 1.8961734771728516) {
                if (input[3] <= 1.800817608833313) {
                    if (input[2] <= 0.9300557971000671) {
                        var36 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.0241162478923798) {
                            var36 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -0.38802669942379) {
                                var36 = new double[2] {0.4, 0.6};
                            } else {
                                if (input[2] <= 1.5537692308425903) {
                                    var36 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                } else {
                                    if (input[4] <= 0.7294346988201141) {
                                        var36 = new double[2] {0.0, 1.0};
                                    } else {
                                        var36 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var36 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            } else {
                var36 = new double[2] {0.8571428571428571, 0.14285714285714285};
            }
            double[] var37;
            if (input[1] <= 1.5263413786888123) {
                if (input[2] <= 0.43158040940761566) {
                    var37 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.1982495486736298) {
                        if (input[3] <= 1.4515056014060974) {
                            var37 = new double[2] {0.0, 1.0};
                        } else {
                            var37 = new double[2] {0.75, 0.25};
                        }
                    } else {
                        var37 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var37 = new double[2] {0.8, 0.2};
            }
            double[] var38;
            if (input[5] <= 0.4139154553413391) {
                if (input[3] <= 0.3589499741792679) {
                    if (input[4] <= 2.226238787174225) {
                        if (input[3] <= 0.30668650567531586) {
                            if (input[3] <= -0.1068882867693901) {
                                var38 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.8842225670814514) {
                                    var38 = new double[2] {0.0, 1.0};
                                } else {
                                    var38 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var38 = new double[2] {0.07142857142857142, 0.9285714285714286};
                        }
                    } else {
                        var38 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var38 = new double[2] {0.8, 0.2};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var38 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        var38 = new double[2] {0.25, 0.75};
                    } else {
                        var38 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var39;
            if (input[5] <= 0.9407775104045868) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[3] <= 0.4673878103494644) {
                        if (input[2] <= 0.43158040940761566) {
                            var39 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= 0.876292273402214) {
                                if (input[3] <= -0.38802669942379) {
                                    var39 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                } else {
                                    var39 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var39 = new double[2] {0.2, 0.8};
                            }
                        }
                    } else {
                        var39 = new double[2] {0.2222222222222222, 0.7777777777777778};
                    }
                } else {
                    var39 = new double[2] {0.8, 0.2};
                }
            } else {
                if (input[5] <= 2.5976597666740417) {
                    var39 = new double[2] {1.0, 0.0};
                } else {
                    var39 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            }
            double[] var40;
            if (input[3] <= 0.7842573821544647) {
                if (input[1] <= 1.5263413786888123) {
                    if (input[5] <= 0.43870341777801514) {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[2] <= 2.175404667854309) {
                                var40 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= -0.3033207580447197) {
                                    var40 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[1] <= -1.3619022369384766) {
                                        var40 = new double[2] {1.0, 0.0};
                                    } else {
                                        var40 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            var40 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[3] <= 0.05870161997154355) {
                            var40 = new double[2] {1.0, 0.0};
                        } else {
                            var40 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var40 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                if (input[4] <= 1.068716138601303) {
                    if (input[1] <= -0.49756093323230743) {
                        var40 = new double[2] {0.8, 0.2};
                    } else {
                        var40 = new double[2] {0.42857142857142855, 0.5714285714285714};
                    }
                } else {
                    var40 = new double[2] {1.0, 0.0};
                }
            }
            double[] var41;
            if (input[2] <= 1.4859262704849243) {
                if (input[2] <= 0.43158040940761566) {
                    var41 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.5741516947746277) {
                        var41 = new double[2] {0.0, 1.0};
                    } else {
                        var41 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[4] <= 1.068716138601303) {
                    if (input[1] <= 2.4045716524124146) {
                        if (input[5] <= 1.4536904096603394) {
                            if (input[4] <= 0.05114172212779522) {
                                if (input[1] <= 2.011483609676361) {
                                    var41 = new double[2] {0.0, 1.0};
                                } else {
                                    var41 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                var41 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            }
                        } else {
                            var41 = new double[2] {0.75, 0.25};
                        }
                    } else {
                        var41 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var41 = new double[2] {1.0, 0.0};
                }
            }
            double[] var42;
            if (input[3] <= 1.800817608833313) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[2] <= 2.175404667854309) {
                        var42 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.14740732312202454) {
                            if (input[1] <= 3.2834476828575134) {
                                var42 = new double[2] {0.0, 1.0};
                            } else {
                                var42 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.1890936717391014) {
                                var42 = new double[2] {1.0, 0.0};
                            } else {
                                var42 = new double[2] {0.42857142857142855, 0.5714285714285714};
                            }
                        }
                    }
                } else {
                    var42 = new double[2] {1.0, 0.0};
                }
            } else {
                var42 = new double[2] {1.0, 0.0};
            }
            double[] var43;
            if (input[5] <= 1.165518581867218) {
                if (input[2] <= 2.175404667854309) {
                    if (input[4] <= 1.9211599230766296) {
                        var43 = new double[2] {0.0, 1.0};
                    } else {
                        var43 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= 1.512775480747223) {
                        if (input[5] <= -0.12684859335422516) {
                            if (input[4] <= 0.8304903022944927) {
                                var43 = new double[2] {0.0, 1.0};
                            } else {
                                var43 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var43 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var43 = new double[2] {0.8888888888888888, 0.1111111111111111};
                    }
                }
            } else {
                if (input[1] <= -0.9274705946445465) {
                    var43 = new double[2] {0.14285714285714285, 0.8571428571428571};
                } else {
                    var43 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            }
            double[] var44;
            if (input[2] <= 1.4859262704849243) {
                if (input[4] <= 1.9211599230766296) {
                    var44 = new double[2] {0.0, 1.0};
                } else {
                    var44 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= 2.0848039984703064) {
                    if (input[5] <= 1.273577094078064) {
                        if (input[3] <= -0.38802669942379) {
                            var44 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 1.418333739042282) {
                                if (input[4] <= 0.05114172212779522) {
                                    var44 = new double[2] {0.0, 1.0};
                                } else {
                                    var44 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var44 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var44 = new double[2] {0.7, 0.3};
                    }
                } else {
                    var44 = new double[2] {1.0, 0.0};
                }
            }
            double[] var45;
            if (input[3] <= 1.0039772987365723) {
                if (input[5] <= 1.3463387489318848) {
                    if (input[2] <= 0.43158040940761566) {
                        var45 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 1.5741516947746277) {
                            if (input[4] <= -1.4453137516975403) {
                                var45 = new double[2] {0.5, 0.5};
                            } else {
                                if (input[1] <= 2.0848039984703064) {
                                    if (input[1] <= -1.3619022369384766) {
                                        var45 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[5] <= 0.6243304014205933) {
                                            var45 = new double[2] {0.0, 1.0};
                                        } else {
                                            var45 = new double[2] {0.1111111111111111, 0.8888888888888888};
                                        }
                                    }
                                } else {
                                    var45 = new double[2] {0.75, 0.25};
                                }
                            }
                        } else {
                            var45 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var45 = new double[2] {1.0, 0.0};
                }
            } else {
                var45 = new double[2] {0.8, 0.2};
            }
            double[] var46;
            if (input[5] <= 0.9428510367870331) {
                if (input[1] <= 1.5263413786888123) {
                    if (input[3] <= 0.379926472902298) {
                        if (input[4] <= 1.7565242052078247) {
                            var46 = new double[2] {0.0, 1.0};
                        } else {
                            var46 = new double[2] {0.25, 0.75};
                        }
                    } else {
                        var46 = new double[2] {0.21428571428571427, 0.7857142857142857};
                    }
                } else {
                    var46 = new double[2] {0.75, 0.25};
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var46 = new double[2] {0.2, 0.8};
                } else {
                    var46 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            }
            double[] var47;
            if (input[1] <= 1.5263413786888123) {
                if (input[2] <= 0.43158040940761566) {
                    var47 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.5208013206720352) {
                        var47 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= 0.7842573821544647) {
                            if (input[2] <= 2.0938578844070435) {
                                if (input[2] <= 0.9300557971000671) {
                                    var47 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= 0.9488103240728378) {
                                        var47 = new double[2] {0.0, 1.0};
                                    } else {
                                        var47 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var47 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[5] <= 1.144736260175705) {
                                var47 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= 1.6531969904899597) {
                                    var47 = new double[2] {0.0, 1.0};
                                } else {
                                    var47 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                var47 = new double[2] {0.8666666666666667, 0.13333333333333333};
            }
            double[] var48;
            if (input[5] <= 0.923718124628067) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[1] <= 1.5263413786888123) {
                                var48 = new double[2] {0.0, 1.0};
                            } else {
                                var48 = new double[2] {0.16666666666666666, 0.8333333333333334};
                            }
                        } else {
                            var48 = new double[2] {0.14285714285714285, 0.8571428571428571};
                        }
                    } else {
                        var48 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var48 = new double[2] {0.5, 0.5};
                }
            } else {
                if (input[4] <= 0.33364757522940636) {
                    var48 = new double[2] {0.875, 0.125};
                } else {
                    var48 = new double[2] {0.5, 0.5};
                }
            }
            double[] var49;
            if (input[5] <= 0.9808341264724731) {
                if (input[3] <= 0.30695316195487976) {
                    if (input[2] <= 0.4325118213891983) {
                        var49 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 1.4407605528831482) {
                            if (input[3] <= -0.14590812847018242) {
                                var49 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 2.0143905878067017) {
                                    var49 = new double[2] {0.0, 1.0};
                                } else {
                                    var49 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var49 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[5] <= 0.17239774018526077) {
                        var49 = new double[2] {0.4166666666666667, 0.5833333333333334};
                    } else {
                        var49 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var49 = new double[2] {0.5, 0.5};
                } else {
                    if (input[1] <= -0.46687617897987366) {
                        var49 = new double[2] {1.0, 0.0};
                    } else {
                        var49 = new double[2] {0.75, 0.25};
                    }
                }
            }
            double[] var50;
            if (input[4] <= 1.7600783109664917) {
                if (input[3] <= 0.7842573821544647) {
                    if (input[0] <= 0.876292273402214) {
                        if (input[1] <= -1.4827032685279846) {
                            if (input[2] <= 0.9428580552339554) {
                                var50 = new double[2] {0.0, 1.0};
                            } else {
                                var50 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var50 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= 2.0550883412361145) {
                            var50 = new double[2] {0.0, 1.0};
                        } else {
                            var50 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[5] <= 0.923718124628067) {
                        var50 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.6531969904899597) {
                            var50 = new double[2] {0.0, 1.0};
                        } else {
                            var50 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var50 = new double[2] {0.9090909090909091, 0.09090909090909091};
            }
            double[] var51;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[4] <= 0.05178280919790268) {
                        var51 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.23990245163440704) {
                            if (input[2] <= 0.9859864339232445) {
                                var51 = new double[2] {0.0, 1.0};
                            } else {
                                var51 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var51 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var51 = new double[2] {0.8, 0.2};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var51 = new double[2] {0.16666666666666666, 0.8333333333333334};
                } else {
                    var51 = new double[2] {1.0, 0.0};
                }
            }
            double[] var52;
            if (input[3] <= 0.7641697227954865) {
                if (input[3] <= 0.3589499741792679) {
                    if (input[5] <= 0.45364217460155487) {
                        var52 = new double[2] {0.0, 1.0};
                    } else {
                        var52 = new double[2] {0.2222222222222222, 0.7777777777777778};
                    }
                } else {
                    var52 = new double[2] {0.26666666666666666, 0.7333333333333333};
                }
            } else {
                var52 = new double[2] {0.8, 0.2};
            }
            double[] var53;
            if (input[2] <= 0.22912395966704935) {
                var53 = new double[2] {0.0, 1.0};
            } else {
                if (input[3] <= 0.16162867844104767) {
                    if (input[4] <= 1.4729836583137512) {
                        if (input[4] <= -0.8132353127002716) {
                            if (input[1] <= 2.011483609676361) {
                                var53 = new double[2] {0.0, 1.0};
                            } else {
                                var53 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var53 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var53 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.09023680537939072) {
                        if (input[1] <= 2.4149075746536255) {
                            if (input[1] <= -0.8305713534355164) {
                                var53 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            } else {
                                var53 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var53 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var53 = new double[2] {0.875, 0.125};
                    }
                }
            }
            double[] var54;
            if (input[2] <= 2.060991406440735) {
                if (input[5] <= 5.3345149755477905) {
                    if (input[4] <= 1.9211599230766296) {
                        var54 = new double[2] {0.0, 1.0};
                    } else {
                        var54 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var54 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 1.273577094078064) {
                    if (input[0] <= -0.3421141058206558) {
                        if (input[2] <= 2.171961545944214) {
                            var54 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 2.118072807788849) {
                                var54 = new double[2] {0.0, 1.0};
                            } else {
                                var54 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= -0.15479647740721703) {
                            var54 = new double[2] {0.0, 1.0};
                        } else {
                            var54 = new double[2] {0.7647058823529411, 0.23529411764705882};
                        }
                    }
                } else {
                    var54 = new double[2] {1.0, 0.0};
                }
            }
            double[] var55;
            if (input[1] <= 2.154894530773163) {
                if (input[5] <= 1.273577094078064) {
                    if (input[2] <= 0.4325118213891983) {
                        var55 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.38713787496089935) {
                            var55 = new double[2] {0.6, 0.4};
                        } else {
                            if (input[1] <= -1.36287122964859) {
                                var55 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 1.461741864681244) {
                                    if (input[2] <= 1.207397609949112) {
                                        var55 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                    } else {
                                        var55 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var55 = new double[2] {0.4, 0.6};
                                }
                            }
                        }
                    }
                } else {
                    var55 = new double[2] {0.7, 0.3};
                }
            } else {
                var55 = new double[2] {1.0, 0.0};
            }
            double[] var56;
            if (input[4] <= 1.8199918866157532) {
                if (input[5] <= 2.853314995765686) {
                    if (input[2] <= 2.1532992124557495) {
                        var56 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 2.011483609676361) {
                            if (input[1] <= -0.8044085502624512) {
                                var56 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= -0.12684859335422516) {
                                    var56 = new double[2] {0.14285714285714285, 0.8571428571428571};
                                } else {
                                    var56 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var56 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var56 = new double[2] {1.0, 0.0};
                }
            } else {
                var56 = new double[2] {1.0, 0.0};
            }
            double[] var57;
            if (input[1] <= 2.118072807788849) {
                if (input[5] <= 1.273577094078064) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[2] <= 0.43158040940761566) {
                            var57 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 1.002549171447754) {
                                var57 = new double[2] {0.0, 1.0};
                            } else {
                                var57 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var57 = new double[2] {0.14285714285714285, 0.8571428571428571};
                    }
                } else {
                    var57 = new double[2] {0.6428571428571429, 0.35714285714285715};
                }
            } else {
                var57 = new double[2] {1.0, 0.0};
            }
            double[] var58;
            if (input[3] <= 1.5816310048103333) {
                if (input[5] <= 1.118770182132721) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[4] <= -0.8186227083206177) {
                            if (input[2] <= 1.8401802778244019) {
                                var58 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[0] <= -0.3421141058206558) {
                                    var58 = new double[2] {0.0, 1.0};
                                } else {
                                    var58 = new double[2] {0.4444444444444444, 0.5555555555555556};
                                }
                            }
                        } else {
                            var58 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var58 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var58 = new double[2] {0.5, 0.5};
                }
            } else {
                var58 = new double[2] {0.8, 0.2};
            }
            double[] var59;
            if (input[1] <= 1.8961734771728516) {
                if (input[3] <= 1.6706922054290771) {
                    if (input[3] <= 0.7842573821544647) {
                        if (input[4] <= 1.8199918866157532) {
                            if (input[2] <= 2.175404667854309) {
                                var59 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.3619022369384766) {
                                    var59 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[3] <= -0.38331587612628937) {
                                        var59 = new double[2] {0.2, 0.8};
                                    } else {
                                        var59 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            var59 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var59 = new double[2] {0.4, 0.6};
                    }
                } else {
                    var59 = new double[2] {0.9166666666666666, 0.08333333333333333};
                }
            } else {
                var59 = new double[2] {0.75, 0.25};
            }
            double[] var60;
            if (input[3] <= 1.5816310048103333) {
                if (input[2] <= 1.4623540043830872) {
                    if (input[1] <= 1.6632922887802124) {
                        var60 = new double[2] {0.0, 1.0};
                    } else {
                        var60 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[2] <= 1.5537692308425903) {
                            var60 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= 1.273577094078064) {
                                if (input[3] <= -0.38802669942379) {
                                    var60 = new double[2] {0.5, 0.5};
                                } else {
                                    if (input[5] <= -0.03971371799707413) {
                                        var60 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                    } else {
                                        var60 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var60 = new double[2] {0.5, 0.5};
                            }
                        }
                    } else {
                        var60 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var60 = new double[2] {0.8, 0.2};
            }
            double[] var61;
            if (input[3] <= 1.5816310048103333) {
                if (input[1] <= 2.4149075746536255) {
                    if (input[1] <= 1.5263413786888123) {
                        if (input[4] <= 1.8199918866157532) {
                            if (input[5] <= 3.2119393348693848) {
                                var61 = new double[2] {0.0, 1.0};
                            } else {
                                var61 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var61 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var61 = new double[2] {0.3, 0.7};
                    }
                } else {
                    var61 = new double[2] {1.0, 0.0};
                }
            } else {
                var61 = new double[2] {1.0, 0.0};
            }
            double[] var62;
            if (input[5] <= 2.853314995765686) {
                if (input[1] <= 1.512775480747223) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[2] <= 2.175404667854309) {
                            var62 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.7842573821544647) {
                                if (input[3] <= 0.3639274537563324) {
                                    var62 = new double[2] {0.0, 1.0};
                                } else {
                                    var62 = new double[2] {0.08333333333333333, 0.9166666666666666};
                                }
                            } else {
                                var62 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var62 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var62 = new double[2] {0.625, 0.375};
                }
            } else {
                var62 = new double[2] {1.0, 0.0};
            }
            double[] var63;
            if (input[2] <= 1.9836953282356262) {
                if (input[1] <= 1.6842871308326721) {
                    if (input[4] <= 2.034778654575348) {
                        var63 = new double[2] {0.0, 1.0};
                    } else {
                        var63 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var63 = new double[2] {0.5, 0.5};
                }
            } else {
                if (input[3] <= 1.1542792618274689) {
                    if (input[2] <= 2.0986069440841675) {
                        var63 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= -0.11035474017262459) {
                            var63 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 1.165518581867218) {
                                if (input[5] <= -0.18566110730171204) {
                                    var63 = new double[2] {0.5, 0.5};
                                } else {
                                    if (input[0] <= -0.3421141058206558) {
                                        var63 = new double[2] {0.0, 1.0};
                                    } else {
                                        var63 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                    }
                                }
                            } else {
                                var63 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var63 = new double[2] {1.0, 0.0};
                }
            }
            double[] var64;
            if (input[3] <= 0.3589499741792679) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[0] <= 0.876292273402214) {
                        var64 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 2.173849642276764) {
                            var64 = new double[2] {0.0, 1.0};
                        } else {
                            var64 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var64 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= 2.4045716524124146) {
                    if (input[4] <= 1.068716138601303) {
                        if (input[3] <= 3.6247063875198364) {
                            if (input[1] <= -0.79859459400177) {
                                var64 = new double[2] {0.6, 0.4};
                            } else {
                                var64 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var64 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var64 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var64 = new double[2] {1.0, 0.0};
                }
            }
            double[] var65;
            if (input[3] <= 1.7416212558746338) {
                if (input[1] <= 2.165230453014374) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[2] <= 2.175404667854309) {
                            var65 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 0.5606600046157837) {
                                if (input[3] <= 0.31948571652173996) {
                                    var65 = new double[2] {0.0, 1.0};
                                } else {
                                    var65 = new double[2] {0.1, 0.9};
                                }
                            } else {
                                var65 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var65 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    var65 = new double[2] {1.0, 0.0};
                }
            } else {
                var65 = new double[2] {0.8461538461538461, 0.15384615384615385};
            }
            double[] var66;
            if (input[1] <= 1.8961734771728516) {
                if (input[4] <= 1.7600333094596863) {
                    if (input[3] <= 1.1606788635253906) {
                        if (input[3] <= 0.37566007673740387) {
                            var66 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.2107393741607666) {
                                var66 = new double[2] {1.0, 0.0};
                            } else {
                                var66 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var66 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var66 = new double[2] {0.875, 0.125};
                }
            } else {
                var66 = new double[2] {0.9090909090909091, 0.09090909090909091};
            }
            double[] var67;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 2.4149075746536255) {
                    if (input[2] <= 0.22094968054443598) {
                        var67 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 1.4407605528831482) {
                            if (input[1] <= -1.36287122964859) {
                                var67 = new double[2] {1.0, 0.0};
                            } else {
                                var67 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var67 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var67 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var67 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    var67 = new double[2] {1.0, 0.0};
                }
            }
            double[] var68;
            if (input[3] <= 0.3589499741792679) {
                if (input[2] <= 0.4325118213891983) {
                    var68 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.4407605528831482) {
                        if (input[1] <= 2.011483609676361) {
                            var68 = new double[2] {0.0, 1.0};
                        } else {
                            var68 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var68 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[5] <= 2.853314995765686) {
                    if (input[5] <= 0.923718124628067) {
                        if (input[5] <= 0.21151183545589447) {
                            var68 = new double[2] {0.5714285714285714, 0.42857142857142855};
                        } else {
                            var68 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var68 = new double[2] {0.5625, 0.4375};
                    }
                } else {
                    var68 = new double[2] {1.0, 0.0};
                }
            }
            double[] var69;
            if (input[1] <= 1.8961734771728516) {
                if (input[2] <= 1.9836953282356262) {
                    if (input[4] <= 2.034778654575348) {
                        var69 = new double[2] {0.0, 1.0};
                    } else {
                        var69 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= -0.16452233120799065) {
                        if (input[3] <= 3.2772609293460846) {
                            var69 = new double[2] {0.0, 1.0};
                        } else {
                            var69 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var69 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                }
            } else {
                var69 = new double[2] {0.875, 0.125};
            }
            double[] var70;
            if (input[1] <= 2.1216257214546204) {
                if (input[3] <= 0.7842573821544647) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[2] <= 2.171961545944214) {
                            var70 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.2566050291061401) {
                                var70 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 1.512775480747223) {
                                    if (input[4] <= 1.002549171447754) {
                                        var70 = new double[2] {0.0, 1.0};
                                    } else {
                                        var70 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var70 = new double[2] {0.5, 0.5};
                                }
                            }
                        }
                    } else {
                        var70 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var70 = new double[2] {0.625, 0.375};
                }
            } else {
                var70 = new double[2] {1.0, 0.0};
            }
            double[] var71;
            if (input[1] <= 2.1216257214546204) {
                if (input[3] <= 1.1131262183189392) {
                    if (input[4] <= 1.7600333094596863) {
                        if (input[2] <= 2.175404667854309) {
                            var71 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= -0.02962404675781727) {
                                var71 = new double[2] {0.0, 1.0};
                            } else {
                                var71 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            }
                        }
                    } else {
                        var71 = new double[2] {0.875, 0.125};
                    }
                } else {
                    if (input[1] <= -0.46687617897987366) {
                        var71 = new double[2] {1.0, 0.0};
                    } else {
                        var71 = new double[2] {0.7777777777777778, 0.2222222222222222};
                    }
                }
            } else {
                var71 = new double[2] {1.0, 0.0};
            }
            double[] var72;
            if (input[1] <= 1.5263413786888123) {
                if (input[5] <= 1.226828694343567) {
                    if (input[5] <= 0.4156590849161148) {
                        if (input[2] <= 2.1580482721328735) {
                            var72 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.1122251451015472) {
                                var72 = new double[2] {1.0, 0.0};
                            } else {
                                var72 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var72 = new double[2] {0.125, 0.875};
                    }
                } else {
                    var72 = new double[2] {0.8181818181818182, 0.18181818181818182};
                }
            } else {
                if (input[4] <= 0.0018342267721891403) {
                    var72 = new double[2] {1.0, 0.0};
                } else {
                    var72 = new double[2] {0.3333333333333333, 0.6666666666666666};
                }
            }
            double[] var73;
            if (input[2] <= 2.060991406440735) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[3] <= 7.33639132976532) {
                        var73 = new double[2] {0.0, 1.0};
                    } else {
                        var73 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var73 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= 2.011483609676361) {
                    if (input[1] <= -0.04794842004776001) {
                        if (input[5] <= 0.7054803315550089) {
                            var73 = new double[2] {0.0, 1.0};
                        } else {
                            var73 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 0.37141549587249756) {
                            var73 = new double[2] {0.0, 1.0};
                        } else {
                            var73 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var73 = new double[2] {1.0, 0.0};
                }
            }
            double[] var74;
            if (input[3] <= 0.7842573821544647) {
                if (input[1] <= 2.4149075746536255) {
                    if (input[3] <= -0.42189130187034607) {
                        var74 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.5053465366363525) {
                            if (input[1] <= 0.14197410643100739) {
                                var74 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 1.7611917853355408) {
                                    var74 = new double[2] {0.0, 1.0};
                                } else {
                                    var74 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var74 = new double[2] {0.25, 0.75};
                        }
                    }
                } else {
                    var74 = new double[2] {1.0, 0.0};
                }
            } else {
                var74 = new double[2] {0.75, 0.25};
            }
            double[] var75;
            if (input[2] <= 1.958547592163086) {
                if (input[4] <= 2.034778654575348) {
                    if (input[2] <= 1.686274766921997) {
                        var75 = new double[2] {0.0, 1.0};
                    } else {
                        var75 = new double[2] {0.16666666666666666, 0.8333333333333334};
                    }
                } else {
                    var75 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 1.165518581867218) {
                    if (input[0] <= -0.3421141058206558) {
                        if (input[1] <= -1.3619022369384766) {
                            var75 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= -1.183243989944458) {
                                var75 = new double[2] {0.25, 0.75};
                            } else {
                                var75 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var75 = new double[2] {0.46153846153846156, 0.5384615384615384};
                    }
                } else {
                    var75 = new double[2] {1.0, 0.0};
                }
            }
            double[] var76;
            if (input[1] <= 2.1171037554740906) {
                if (input[5] <= 3.5527032613754272) {
                    if (input[4] <= 0.05178280919790268) {
                        var76 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 2.0124151706695557) {
                            var76 = new double[2] {0.0, 1.0};
                        } else {
                            var76 = new double[2] {0.4444444444444444, 0.5555555555555556};
                        }
                    }
                } else {
                    var76 = new double[2] {1.0, 0.0};
                }
            } else {
                var76 = new double[2] {0.8888888888888888, 0.1111111111111111};
            }
            double[] var77;
            if (input[3] <= 0.7842573821544647) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[1] <= 2.011483609676361) {
                        if (input[5] <= 0.6243304014205933) {
                            if (input[2] <= 2.171961545944214) {
                                var77 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.16902583837509155) {
                                    if (input[1] <= -1.3619022369384766) {
                                        var77 = new double[2] {1.0, 0.0};
                                    } else {
                                        var77 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var77 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var77 = new double[2] {0.16666666666666666, 0.8333333333333334};
                        }
                    } else {
                        var77 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var77 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 1.068716138601303) {
                    var77 = new double[2] {0.3076923076923077, 0.6923076923076923};
                } else {
                    var77 = new double[2] {1.0, 0.0};
                }
            }
            double[] var78;
            if (input[2] <= 0.27639439702033997) {
                var78 = new double[2] {0.0, 1.0};
            } else {
                if (input[2] <= 0.5154676288366318) {
                    var78 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[5] <= -0.21577424556016922) {
                                if (input[3] <= 0.2483789399266243) {
                                    var78 = new double[2] {0.0, 1.0};
                                } else {
                                    var78 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var78 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= 1.461741864681244) {
                                var78 = new double[2] {0.0, 1.0};
                            } else {
                                var78 = new double[2] {0.8571428571428571, 0.14285714285714285};
                            }
                        }
                    } else {
                        var78 = new double[2] {0.8571428571428571, 0.14285714285714285};
                    }
                }
            }
            double[] var79;
            if (input[3] <= 1.8571697473526) {
                if (input[1] <= 2.2882924675941467) {
                    if (input[5] <= 3.2119393348693848) {
                        if (input[4] <= 2.2004266381263733) {
                            if (input[3] <= 0.1634063497185707) {
                                if (input[3] <= -0.413802906870842) {
                                    if (input[4] <= 1.7368642091751099) {
                                        var79 = new double[2] {0.0, 1.0};
                                    } else {
                                        var79 = new double[2] {0.25, 0.75};
                                    }
                                } else {
                                    var79 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= 0.5814462602138519) {
                                    if (input[1] <= -1.4484655261039734) {
                                        var79 = new double[2] {0.1, 0.9};
                                    } else {
                                        var79 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var79 = new double[2] {0.07692307692307693, 0.9230769230769231};
                                }
                            }
                        } else {
                            var79 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var79 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var79 = new double[2] {1.0, 0.0};
                }
            } else {
                var79 = new double[2] {0.875, 0.125};
            }
            double[] var80;
            if (input[5] <= 0.9428510367870331) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[1] <= 1.5263413786888123) {
                        var80 = new double[2] {0.0, 1.0};
                    } else {
                        var80 = new double[2] {0.7692307692307693, 0.23076923076923078};
                    }
                } else {
                    var80 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.540190190076828) {
                    var80 = new double[2] {1.0, 0.0};
                } else {
                    var80 = new double[2] {0.4444444444444444, 0.5555555555555556};
                }
            }
            double[] var81;
            if (input[5] <= 1.0537371337413788) {
                if (input[3] <= 0.379926472902298) {
                    if (input[1] <= 1.5263413786888123) {
                        if (input[4] <= 2.034778654575348) {
                            if (input[4] <= 1.7611917853355408) {
                                var81 = new double[2] {0.0, 1.0};
                            } else {
                                var81 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var81 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var81 = new double[2] {0.8, 0.2};
                    }
                } else {
                    var81 = new double[2] {0.3125, 0.6875};
                }
            } else {
                if (input[4] <= 0.5534618198871613) {
                    var81 = new double[2] {1.0, 0.0};
                } else {
                    var81 = new double[2] {0.75, 0.25};
                }
            }
            double[] var82;
            if (input[5] <= 0.45364217460155487) {
                if (input[5] <= -0.7569624483585358) {
                    if (input[3] <= -0.42944639921188354) {
                        var82 = new double[2] {0.0, 1.0};
                    } else {
                        var82 = new double[2] {0.5714285714285714, 0.42857142857142855};
                    }
                } else {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[2] <= 2.175404667854309) {
                            var82 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 2.011483609676361) {
                                var82 = new double[2] {0.0, 1.0};
                            } else {
                                var82 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var82 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= 0.5922326147556305) {
                    if (input[5] <= 2.853314995765686) {
                        var82 = new double[2] {0.08333333333333333, 0.9166666666666666};
                    } else {
                        var82 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var82 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            }
            double[] var83;
            if (input[2] <= 2.175404667854309) {
                if (input[1] <= -2.0456879138946533) {
                    var83 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= 0.19626223109662533) {
                        var83 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.3897154778242111) {
                            var83 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 1.5542667508125305) {
                                var83 = new double[2] {0.0, 1.0};
                            } else {
                                var83 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= 1.8406178951263428) {
                    if (input[4] <= 0.37141549587249756) {
                        if (input[1] <= -0.21041616052389145) {
                            var83 = new double[2] {0.4444444444444444, 0.5555555555555556};
                        } else {
                            var83 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var83 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var83 = new double[2] {1.0, 0.0};
                }
            }
            double[] var84;
            if (input[2] <= 1.4859262704849243) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[4] <= 2.1863789558410645) {
                        var84 = new double[2] {0.0, 1.0};
                    } else {
                        var84 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var84 = new double[2] {0.5, 0.5};
                }
            } else {
                if (input[2] <= 1.5374759435653687) {
                    var84 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 0.9808341264724731) {
                        if (input[3] <= 0.2274024486541748) {
                            if (input[4] <= 0.9976454079151154) {
                                if (input[5] <= -0.0688843447715044) {
                                    var84 = new double[2] {0.0, 1.0};
                                } else {
                                    var84 = new double[2] {0.2, 0.8};
                                }
                            } else {
                                var84 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var84 = new double[2] {0.4, 0.6};
                        }
                    } else {
                        if (input[4] <= -0.3684443533420563) {
                            var84 = new double[2] {0.25, 0.75};
                        } else {
                            var84 = new double[2] {0.9333333333333333, 0.06666666666666667};
                        }
                    }
                }
            }
            double[] var85;
            if (input[5] <= 1.165518581867218) {
                if (input[3] <= 0.30695316195487976) {
                    if (input[3] <= -0.1068882867693901) {
                        var85 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.4623540043830872) {
                            var85 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= 1.6581611633300781) {
                                var85 = new double[2] {1.0, 0.0};
                            } else {
                                var85 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            }
                        }
                    }
                } else {
                    if (input[5] <= 0.18747787177562714) {
                        var85 = new double[2] {0.5, 0.5};
                    } else {
                        var85 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[1] <= -0.8195894360542297) {
                    var85 = new double[2] {0.0, 1.0};
                } else {
                    var85 = new double[2] {0.9411764705882353, 0.058823529411764705};
                }
            }
            double[] var86;
            if (input[4] <= 1.8059442043304443) {
                if (input[0] <= -0.3421141058206558) {
                    if (input[4] <= -0.340866357088089) {
                        if (input[2] <= 2.175404667854309) {
                            var86 = new double[2] {0.0, 1.0};
                        } else {
                            var86 = new double[2] {0.15, 0.85};
                        }
                    } else {
                        if (input[2] <= 1.636903703212738) {
                            var86 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 1.165518581867218) {
                                var86 = new double[2] {0.08333333333333333, 0.9166666666666666};
                            } else {
                                var86 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[5] <= 0.9469038099050522) {
                        if (input[1] <= 2.4804760217666626) {
                            var86 = new double[2] {0.0, 1.0};
                        } else {
                            var86 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var86 = new double[2] {0.75, 0.25};
                    }
                }
            } else {
                var86 = new double[2] {1.0, 0.0};
            }
            double[] var87;
            if (input[5] <= 2.853314995765686) {
                if (input[1] <= 2.165230453014374) {
                    if (input[5] <= 1.273577094078064) {
                        if (input[1] <= 1.8961734771728516) {
                            if (input[5] <= 0.43870341777801514) {
                                if (input[1] <= -1.4827032685279846) {
                                    if (input[4] <= -0.09058358334004879) {
                                        var87 = new double[2] {0.0, 1.0};
                                    } else {
                                        var87 = new double[2] {0.1, 0.9};
                                    }
                                } else {
                                    var87 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var87 = new double[2] {0.1, 0.9};
                            }
                        } else {
                            var87 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var87 = new double[2] {0.2857142857142857, 0.7142857142857143};
                    }
                } else {
                    var87 = new double[2] {1.0, 0.0};
                }
            } else {
                var87 = new double[2] {0.9, 0.1};
            }
            double[] var88;
            if (input[5] <= 0.9808341264724731) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[4] <= -0.8186227083206177) {
                        if (input[5] <= -0.06388905085623264) {
                            if (input[4] <= -0.9551180601119995) {
                                var88 = new double[2] {0.0, 1.0};
                            } else {
                                var88 = new double[2] {0.09090909090909091, 0.9090909090909091};
                            }
                        } else {
                            if (input[5] <= -0.05884663388133049) {
                                var88 = new double[2] {1.0, 0.0};
                            } else {
                                var88 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[3] <= 0.1634063497185707) {
                            var88 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.3574137091636658) {
                                var88 = new double[2] {0.0, 1.0};
                            } else {
                                var88 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        }
                    }
                } else {
                    var88 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 4.369763493537903) {
                    var88 = new double[2] {0.4444444444444444, 0.5555555555555556};
                } else {
                    var88 = new double[2] {1.0, 0.0};
                }
            }
            double[] var89;
            if (input[3] <= 0.30695316195487976) {
                if (input[2] <= 2.175404667854309) {
                    var89 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 2.011483609676361) {
                        if (input[5] <= -0.11162708699703217) {
                            var89 = new double[2] {0.125, 0.875};
                        } else {
                            var89 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var89 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= 2.4045716524124146) {
                    if (input[5] <= 3.5527032613754272) {
                        if (input[4] <= 0.9045190215110779) {
                            if (input[3] <= 1.5816310048103333) {
                                if (input[5] <= -0.16398341953754425) {
                                    var89 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                } else {
                                    var89 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var89 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var89 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var89 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var89 = new double[2] {1.0, 0.0};
                }
            }
            double[] var90;
            if (input[1] <= 1.5263413786888123) {
                if (input[5] <= 1.2995903491973877) {
                    if (input[1] <= 0.14229710400104523) {
                        var90 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 0.43158040940761566) {
                            var90 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 1.687770426273346) {
                                var90 = new double[2] {0.0, 1.0};
                            } else {
                                var90 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var90 = new double[2] {0.5714285714285714, 0.42857142857142855};
                }
            } else {
                var90 = new double[2] {0.6923076923076923, 0.3076923076923077};
            }
            double[] var91;
            if (input[1] <= 2.4149075746536255) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[5] <= 1.273577094078064) {
                        if (input[2] <= 2.171961545944214) {
                            var91 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.5814462602138519) {
                                if (input[1] <= -1.3619022369384766) {
                                    var91 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[3] <= -0.07480135187506676) {
                                        var91 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                    } else {
                                        var91 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var91 = new double[2] {0.375, 0.625};
                            }
                        }
                    } else {
                        var91 = new double[2] {0.9090909090909091, 0.09090909090909091};
                    }
                } else {
                    var91 = new double[2] {1.0, 0.0};
                }
            } else {
                var91 = new double[2] {1.0, 0.0};
            }
            double[] var92;
            if (input[1] <= 2.4149075746536255) {
                if (input[3] <= 1.1131262183189392) {
                    if (input[2] <= 0.8235533237457275) {
                        var92 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 1.2995903491973877) {
                            if (input[1] <= -1.3619022369384766) {
                                var92 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 0.49405285716056824) {
                                    if (input[4] <= 0.5606600046157837) {
                                        var92 = new double[2] {0.0, 1.0};
                                    } else {
                                        var92 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var92 = new double[2] {0.2222222222222222, 0.7777777777777778};
                                }
                            }
                        } else {
                            var92 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var92 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                var92 = new double[2] {1.0, 0.0};
            }
            double[] var93;
            if (input[5] <= 0.9808341264724731) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[3] <= 0.30695316195487976) {
                        if (input[1] <= 1.5263413786888123) {
                            var93 = new double[2] {0.0, 1.0};
                        } else {
                            var93 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 0.15821298956871033) {
                            var93 = new double[2] {0.5, 0.5};
                        } else {
                            var93 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var93 = new double[2] {0.7142857142857143, 0.2857142857142857};
                }
            } else {
                var93 = new double[2] {0.8333333333333334, 0.16666666666666666};
            }
            double[] var94;
            if (input[5] <= 1.315471589565277) {
                if (input[1] <= 2.160708487033844) {
                    if (input[2] <= 0.43158040940761566) {
                        var94 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.38713787496089935) {
                            var94 = new double[2] {0.5714285714285714, 0.42857142857142855};
                        } else {
                            if (input[1] <= -1.36287122964859) {
                                var94 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= 0.7294346988201141) {
                                    var94 = new double[2] {0.0, 1.0};
                                } else {
                                    var94 = new double[2] {0.6666666666666666, 0.3333333333333333};
                                }
                            }
                        }
                    }
                } else {
                    var94 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.8485819101333618) {
                    var94 = new double[2] {0.0, 1.0};
                } else {
                    var94 = new double[2] {1.0, 0.0};
                }
            }
            double[] var95;
            if (input[5] <= 0.9808341264724731) {
                if (input[2] <= 0.40715569257736206) {
                    var95 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= -0.746689110994339) {
                        var95 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 2.011483609676361) {
                            if (input[1] <= -1.3619022369384766) {
                                var95 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= 1.4407605528831482) {
                                    var95 = new double[2] {0.0, 1.0};
                                } else {
                                    var95 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var95 = new double[2] {0.75, 0.25};
                        }
                    }
                }
            } else {
                if (input[2] <= 1.8288052678108215) {
                    var95 = new double[2] {0.14285714285714285, 0.8571428571428571};
                } else {
                    var95 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            }
            double[] var96;
            if (input[5] <= 1.315471589565277) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[3] <= 0.37494900822639465) {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[5] <= 0.39676180481910706) {
                                var96 = new double[2] {0.0, 1.0};
                            } else {
                                var96 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var96 = new double[2] {0.6, 0.4};
                        }
                    } else {
                        var96 = new double[2] {0.375, 0.625};
                    }
                } else {
                    var96 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var96 = new double[2] {0.25, 0.75};
                } else {
                    var96 = new double[2] {1.0, 0.0};
                }
            }
            double[] var97;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 2.1171037554740906) {
                    if (input[3] <= 0.476276159286499) {
                        if (input[4] <= 2.2004266381263733) {
                            if (input[2] <= 2.1580482721328735) {
                                var97 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 0.5672143995761871) {
                                    var97 = new double[2] {0.0, 1.0};
                                } else {
                                    var97 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var97 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var97 = new double[2] {0.25, 0.75};
                    }
                } else {
                    var97 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 3.5527032613754272) {
                    var97 = new double[2] {0.4666666666666667, 0.5333333333333333};
                } else {
                    var97 = new double[2] {1.0, 0.0};
                }
            }
            double[] var98;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 1.4859262704849243) {
                        var98 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -1.2566050291061401) {
                            var98 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -0.38802669942379) {
                                var98 = new double[2] {0.5, 0.5};
                            } else {
                                if (input[1] <= 1.461741864681244) {
                                    if (input[3] <= 0.03612521896138787) {
                                        var98 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                    } else {
                                        var98 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var98 = new double[2] {0.25, 0.75};
                                }
                            }
                        }
                    }
                } else {
                    var98 = new double[2] {1.0, 0.0};
                }
            } else {
                var98 = new double[2] {0.9, 0.1};
            }
            double[] var99;
            if (input[5] <= 0.9808341264724731) {
                if (input[4] <= 1.8945829272270203) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[1] <= 1.5263413786888123) {
                                var99 = new double[2] {0.0, 1.0};
                            } else {
                                var99 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var99 = new double[2] {0.125, 0.875};
                        }
                    } else {
                        var99 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var99 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 2.3250523805618286) {
                    var99 = new double[2] {1.0, 0.0};
                } else {
                    var99 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            }
            double[] var100;
            if (input[5] <= 0.9808341264724731) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 1.5263413786888123) {
                        var100 = new double[2] {0.0, 1.0};
                    } else {
                        var100 = new double[2] {0.8181818181818182, 0.18181818181818182};
                    }
                } else {
                    var100 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                if (input[4] <= 0.9045190215110779) {
                    var100 = new double[2] {0.5, 0.5};
                } else {
                    var100 = new double[2] {1.0, 0.0};
                }
            }
            double[] var101;
            if (input[3] <= 1.5816310048103333) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 0.6889068782329559) {
                        var101 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 1.3808807730674744) {
                            if (input[1] <= -1.3619022369384766) {
                                var101 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= 0.6243304014205933) {
                                    var101 = new double[2] {0.0, 1.0};
                                } else {
                                    var101 = new double[2] {0.05, 0.95};
                                }
                            }
                        } else {
                            var101 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var101 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.8882465958595276) {
                    var101 = new double[2] {0.25, 0.75};
                } else {
                    var101 = new double[2] {1.0, 0.0};
                }
            }
            double[] var102;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8638737201690674) {
                    if (input[5] <= 0.43870341777801514) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[2] <= 2.1532992124557495) {
                                var102 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 1.002549171447754) {
                                    var102 = new double[2] {0.0, 1.0};
                                } else {
                                    var102 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var102 = new double[2] {0.6, 0.4};
                        }
                    } else {
                        if (input[4] <= 0.7294346988201141) {
                            var102 = new double[2] {0.0, 1.0};
                        } else {
                            var102 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        }
                    }
                } else {
                    var102 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            } else {
                var102 = new double[2] {1.0, 0.0};
            }
            double[] var103;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[2] <= 2.171961545944214) {
                        var103 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.3212409019470215) {
                            var103 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.12216205149888992) {
                                if (input[0] <= 0.876292273402214) {
                                    var103 = new double[2] {0.45454545454545453, 0.5454545454545454};
                                } else {
                                    var103 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 1.0547650456428528) {
                                    var103 = new double[2] {0.0, 1.0};
                                } else {
                                    var103 = new double[2] {0.75, 0.25};
                                }
                            }
                        }
                    }
                } else {
                    var103 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var103 = new double[2] {0.36363636363636365, 0.6363636363636364};
                } else {
                    var103 = new double[2] {1.0, 0.0};
                }
            }
            double[] var104;
            if (input[1] <= 1.6842871308326721) {
                if (input[0] <= -0.3421141058206558) {
                    if (input[1] <= 0.20398962497711182) {
                        if (input[2] <= 0.9300557971000671) {
                            var104 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 2.681741714477539) {
                                if (input[2] <= 1.5374759435653687) {
                                    var104 = new double[2] {1.0, 0.0};
                                } else {
                                    var104 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var104 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var104 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[4] <= 2.173849642276764) {
                        var104 = new double[2] {0.0, 1.0};
                    } else {
                        var104 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var104 = new double[2] {0.8333333333333334, 0.16666666666666666};
            }
            double[] var105;
            if (input[5] <= 1.273577094078064) {
                if (input[4] <= 2.034778654575348) {
                    if (input[2] <= 2.171961545944214) {
                        var105 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.461741864681244) {
                            if (input[1] <= -1.3619022369384766) {
                                var105 = new double[2] {1.0, 0.0};
                            } else {
                                var105 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var105 = new double[2] {0.75, 0.25};
                        }
                    }
                } else {
                    var105 = new double[2] {1.0, 0.0};
                }
            } else {
                var105 = new double[2] {0.8823529411764706, 0.11764705882352941};
            }
            double[] var106;
            if (input[1] <= 1.8638737201690674) {
                if (input[5] <= 1.273577094078064) {
                    if (input[3] <= -0.5628604888916016) {
                        if (input[5] <= 0.4084489047527313) {
                            var106 = new double[2] {0.0, 1.0};
                        } else {
                            var106 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 1.512775480747223) {
                            var106 = new double[2] {0.0, 1.0};
                        } else {
                            var106 = new double[2] {0.2, 0.8};
                        }
                    }
                } else {
                    var106 = new double[2] {0.5384615384615384, 0.46153846153846156};
                }
            } else {
                var106 = new double[2] {0.75, 0.25};
            }
            double[] var107;
            if (input[5] <= 1.273577094078064) {
                if (input[1] <= 2.4149075746536255) {
                    if (input[5] <= -0.7569624483585358) {
                        if (input[5] <= -0.7685552835464478) {
                            var107 = new double[2] {0.0, 1.0};
                        } else {
                            var107 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 0.5814462602138519) {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[4] <= 1.7416442036628723) {
                                    var107 = new double[2] {0.0, 1.0};
                                } else {
                                    var107 = new double[2] {0.6, 0.4};
                                }
                            } else {
                                var107 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var107 = new double[2] {0.07142857142857142, 0.9285714285714286};
                        }
                    }
                } else {
                    var107 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 3.6247063875198364) {
                    var107 = new double[2] {0.5555555555555556, 0.4444444444444444};
                } else {
                    var107 = new double[2] {1.0, 0.0};
                }
            }
            double[] var108;
            if (input[5] <= 0.9407775104045868) {
                if (input[1] <= 2.4149075746536255) {
                    if (input[5] <= 0.43870341777801514) {
                        if (input[1] <= 0.3322196304798126) {
                            var108 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 0.34546253085136414) {
                                var108 = new double[2] {1.0, 0.0};
                            } else {
                                var108 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var108 = new double[2] {0.25, 0.75};
                    }
                } else {
                    var108 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 1.862126350402832) {
                    var108 = new double[2] {1.0, 0.0};
                } else {
                    var108 = new double[2] {0.8, 0.2};
                }
            }
            double[] var109;
            if (input[5] <= 0.43870341777801514) {
                if (input[4] <= 1.8750353455543518) {
                    if (input[5] <= -0.24197597056627274) {
                        var109 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.8722716569900513) {
                            if (input[1] <= -1.4542794823646545) {
                                if (input[3] <= 0.37494900822639465) {
                                    var109 = new double[2] {0.0, 1.0};
                                } else {
                                    var109 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var109 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var109 = new double[2] {0.6666666666666666, 0.3333333333333333};
                        }
                    }
                } else {
                    var109 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 3.6247063875198364) {
                    if (input[4] <= 0.7532561421394348) {
                        if (input[2] <= 1.9080232381820679) {
                            var109 = new double[2] {0.0, 1.0};
                        } else {
                            var109 = new double[2] {0.6, 0.4};
                        }
                    } else {
                        var109 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var109 = new double[2] {1.0, 0.0};
                }
            }
            double[] var110;
            if (input[3] <= 0.5473829507827759) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 1.4859262704849243) {
                        var110 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 0.43870341777801514) {
                            if (input[5] <= -0.2511182948946953) {
                                var110 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.12180617451667786) {
                                    var110 = new double[2] {0.6666666666666666, 0.3333333333333333};
                                } else {
                                    var110 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var110 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    }
                } else {
                    var110 = new double[2] {0.5384615384615384, 0.46153846153846156};
                }
            } else {
                if (input[4] <= -0.7171958833932877) {
                    var110 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 1.036677747964859) {
                        var110 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -0.46687617897987366) {
                            var110 = new double[2] {1.0, 0.0};
                        } else {
                            var110 = new double[2] {0.8571428571428571, 0.14285714285714285};
                        }
                    }
                }
            }
            double[] var111;
            if (input[1] <= 1.8638737201690674) {
                if (input[3] <= 0.7842573821544647) {
                    if (input[4] <= 1.7611917853355408) {
                        var111 = new double[2] {0.0, 1.0};
                    } else {
                        var111 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    }
                } else {
                    if (input[2] <= 1.6531969904899597) {
                        var111 = new double[2] {0.0, 1.0};
                    } else {
                        var111 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var111 = new double[2] {1.0, 0.0};
            }
            double[] var112;
            if (input[2] <= 0.40715569257736206) {
                var112 = new double[2] {0.0, 1.0};
            } else {
                if (input[0] <= -0.3421141058206558) {
                    if (input[3] <= 0.476276159286499) {
                        if (input[5] <= -0.6511187851428986) {
                            var112 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        } else {
                            var112 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[5] <= 0.923718124628067) {
                            var112 = new double[2] {0.16666666666666666, 0.8333333333333334};
                        } else {
                            if (input[3] <= 2.440600872039795) {
                                var112 = new double[2] {0.8888888888888888, 0.1111111111111111};
                            } else {
                                var112 = new double[2] {0.6, 0.4};
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.06078052893280983) {
                        if (input[4] <= -0.6897191405296326) {
                            var112 = new double[2] {0.8571428571428571, 0.14285714285714285};
                        } else {
                            var112 = new double[2] {0.18181818181818182, 0.8181818181818182};
                        }
                    } else {
                        var112 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var113;
            if (input[2] <= 0.4080871045589447) {
                var113 = new double[2] {0.0, 1.0};
            } else {
                if (input[3] <= 0.7842573821544647) {
                    if (input[1] <= 1.790553331375122) {
                        if (input[4] <= 1.4407605528831482) {
                            if (input[4] <= 0.042278969660401344) {
                                var113 = new double[2] {0.0, 1.0};
                            } else {
                                var113 = new double[2] {0.125, 0.875};
                            }
                        } else {
                            var113 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var113 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var113 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            }
            double[] var114;
            if (input[1] <= 1.8961734771728516) {
                if (input[4] <= 1.8059442043304443) {
                    if (input[3] <= 0.7842573821544647) {
                        if (input[2] <= 2.175404667854309) {
                            var114 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 0.05114172212779522) {
                                var114 = new double[2] {0.0, 1.0};
                            } else {
                                var114 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        }
                    } else {
                        if (input[3] <= 3.6247063875198364) {
                            var114 = new double[2] {0.46153846153846156, 0.5384615384615384};
                        } else {
                            var114 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var114 = new double[2] {1.0, 0.0};
                }
            } else {
                var114 = new double[2] {1.0, 0.0};
            }
            double[] var115;
            if (input[5] <= 3.5527032613754272) {
                if (input[2] <= 0.40715569257736206) {
                    var115 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= -0.5289958864450455) {
                        var115 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -0.25295618921518326) {
                            var115 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 1.3593424260616302) {
                                if (input[2] <= 2.1532992124557495) {
                                    var115 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.11199815385043621) {
                                        if (input[4] <= -0.8022356033325195) {
                                            var115 = new double[2] {0.38461538461538464, 0.6153846153846154};
                                        } else {
                                            var115 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var115 = new double[2] {0.6666666666666666, 0.3333333333333333};
                                    }
                                }
                            } else {
                                var115 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                var115 = new double[2] {1.0, 0.0};
            }
            double[] var116;
            if (input[5] <= 4.369763493537903) {
                if (input[4] <= 1.7600333094596863) {
                    if (input[2] <= 2.175404667854309) {
                        var116 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 2.0550883412361145) {
                            if (input[4] <= 0.7119228839874268) {
                                if (input[4] <= -0.3435094356536865) {
                                    var116 = new double[2] {0.0, 1.0};
                                } else {
                                    var116 = new double[2] {0.125, 0.875};
                                }
                            } else {
                                var116 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var116 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var116 = new double[2] {0.8, 0.2};
                }
            } else {
                var116 = new double[2] {1.0, 0.0};
            }
            double[] var117;
            if (input[5] <= 2.853314995765686) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[5] <= 1.273577094078064) {
                        if (input[5] <= -0.24197597056627274) {
                            var117 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.23990245163440704) {
                                var117 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            } else {
                                if (input[2] <= 2.175404667854309) {
                                    var117 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= 2.12840873003006) {
                                        var117 = new double[2] {0.0, 1.0};
                                    } else {
                                        var117 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var117 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    var117 = new double[2] {0.8, 0.2};
                }
            } else {
                var117 = new double[2] {0.8333333333333334, 0.16666666666666666};
            }
            double[] var118;
            if (input[3] <= 1.8571697473526) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[2] <= 2.066565155982971) {
                        var118 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.5606600046157837) {
                            if (input[1] <= 1.8916515111923218) {
                                if (input[4] <= 0.05114172212779522) {
                                    var118 = new double[2] {0.0, 1.0};
                                } else {
                                    var118 = new double[2] {0.2, 0.8};
                                }
                            } else {
                                var118 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var118 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var118 = new double[2] {0.75, 0.25};
                }
            } else {
                var118 = new double[2] {0.6923076923076923, 0.3076923076923077};
            }
            double[] var119;
            if (input[1] <= 2.4045716524124146) {
                if (input[5] <= 1.273577094078064) {
                    if (input[2] <= 0.27639439702033997) {
                        var119 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 0.651624009013176) {
                            var119 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= 1.0061759054660797) {
                                var119 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            } else {
                                if (input[5] <= -0.14348386228084564) {
                                    if (input[4] <= 1.4407605528831482) {
                                        var119 = new double[2] {0.07142857142857142, 0.9285714285714286};
                                    } else {
                                        var119 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 0.6243304014205933) {
                                        var119 = new double[2] {0.0, 1.0};
                                    } else {
                                        var119 = new double[2] {0.125, 0.875};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= 1.8541556596755981) {
                        var119 = new double[2] {0.4, 0.6};
                    } else {
                        var119 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var119 = new double[2] {1.0, 0.0};
            }
            double[] var120;
            if (input[3] <= 0.7842573821544647) {
                if (input[1] <= 1.8638737201690674) {
                    if (input[4] <= 2.034778654575348) {
                        var120 = new double[2] {0.0, 1.0};
                    } else {
                        var120 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var120 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            } else {
                if (input[5] <= 3.5527032613754272) {
                    var120 = new double[2] {0.5833333333333334, 0.4166666666666667};
                } else {
                    var120 = new double[2] {1.0, 0.0};
                }
            }
            double[] var121;
            if (input[4] <= 1.9211599230766296) {
                if (input[5] <= 1.273577094078064) {
                    if (input[2] <= 2.175404667854309) {
                        var121 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.42614588141441345) {
                            if (input[1] <= 2.011483609676361) {
                                if (input[3] <= 0.3639274537563324) {
                                    if (input[0] <= -0.3421141058206558) {
                                        var121 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                    } else {
                                        var121 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var121 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var121 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var121 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var121 = new double[2] {0.6923076923076923, 0.3076923076923077};
                }
            } else {
                var121 = new double[2] {1.0, 0.0};
            }
            double[] var122;
            if (input[4] <= 1.7600783109664917) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[5] <= 1.26872318983078) {
                        if (input[1] <= 1.512775480747223) {
                            if (input[3] <= 0.379926472902298) {
                                var122 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.42614588141441345) {
                                    var122 = new double[2] {1.0, 0.0};
                                } else {
                                    var122 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var122 = new double[2] {0.2222222222222222, 0.7777777777777778};
                        }
                    } else {
                        var122 = new double[2] {0.5714285714285714, 0.42857142857142855};
                    }
                } else {
                    var122 = new double[2] {1.0, 0.0};
                }
            } else {
                var122 = new double[2] {0.9, 0.1};
            }
            double[] var123;
            if (input[4] <= 1.7611917853355408) {
                if (input[3] <= 1.7416212558746338) {
                    if (input[4] <= 1.6456498503684998) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[2] <= 2.175404667854309) {
                                var123 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.461741864681244) {
                                    var123 = new double[2] {0.0, 1.0};
                                } else {
                                    var123 = new double[2] {0.8, 0.2};
                                }
                            }
                        } else {
                            if (input[4] <= 0.05114172212779522) {
                                var123 = new double[2] {0.0, 1.0};
                            } else {
                                var123 = new double[2] {0.8333333333333334, 0.16666666666666666};
                            }
                        }
                    } else {
                        var123 = new double[2] {0.15384615384615385, 0.8461538461538461};
                    }
                } else {
                    var123 = new double[2] {0.9333333333333333, 0.06666666666666667};
                }
            } else {
                var123 = new double[2] {0.8181818181818182, 0.18181818181818182};
            }
            double[] var124;
            if (input[3] <= 0.7842573821544647) {
                if (input[2] <= 0.4325118213891983) {
                    var124 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.4407605528831482) {
                        if (input[0] <= 0.876292273402214) {
                            if (input[1] <= -1.36287122964859) {
                                var124 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= -0.09444459900259972) {
                                    if (input[4] <= -0.8080615997314453) {
                                        var124 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                    } else {
                                        var124 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var124 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var124 = new double[2] {0.375, 0.625};
                        }
                    } else {
                        var124 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var124 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    var124 = new double[2] {1.0, 0.0};
                }
            }
            double[] var125;
            if (input[3] <= 1.800817608833313) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[3] <= -0.33105239272117615) {
                        if (input[4] <= 1.8199918866157532) {
                            if (input[5] <= -0.157574363052845) {
                                var125 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.15309745073318481) {
                                    var125 = new double[2] {1.0, 0.0};
                                } else {
                                    var125 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var125 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var125 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var125 = new double[2] {1.0, 0.0};
                }
            } else {
                var125 = new double[2] {0.8181818181818182, 0.18181818181818182};
            }
            double[] var126;
            if (input[5] <= 1.3463387489318848) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[5] <= 0.1661771908402443) {
                        if (input[2] <= 2.171961545944214) {
                            var126 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= -0.38331587612628937) {
                                var126 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            } else {
                                var126 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[5] <= 0.1711253598332405) {
                            var126 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 2.172736167907715) {
                                var126 = new double[2] {0.0, 1.0};
                            } else {
                                var126 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var126 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                var126 = new double[2] {0.9, 0.1};
            }
            double[] var127;
            if (input[4] <= 2.020730972290039) {
                if (input[5] <= 1.165518581867218) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[3] <= 0.379926472902298) {
                                var127 = new double[2] {0.0, 1.0};
                            } else {
                                var127 = new double[2] {0.08333333333333333, 0.9166666666666666};
                            }
                        } else {
                            var127 = new double[2] {0.3, 0.7};
                        }
                    } else {
                        var127 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    if (input[4] <= 0.34956228733062744) {
                        var127 = new double[2] {0.9, 0.1};
                    } else {
                        var127 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                }
            } else {
                var127 = new double[2] {1.0, 0.0};
            }
            double[] var128;
            if (input[3] <= 1.611495852470398) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[1] <= 1.5263413786888123) {
                        if (input[3] <= 0.379926472902298) {
                            var128 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.16398341953754425) {
                                var128 = new double[2] {1.0, 0.0};
                            } else {
                                var128 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var128 = new double[2] {0.5384615384615384, 0.46153846153846156};
                    }
                } else {
                    var128 = new double[2] {1.0, 0.0};
                }
            } else {
                var128 = new double[2] {0.6363636363636364, 0.36363636363636365};
            }
            double[] var129;
            if (input[5] <= 0.43870341777801514) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[2] <= 0.8400958776473999) {
                        var129 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.0241162478923798) {
                            var129 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -0.38802669942379) {
                                var129 = new double[2] {0.18181818181818182, 0.8181818181818182};
                            } else {
                                if (input[1] <= -1.36287122964859) {
                                    var129 = new double[2] {1.0, 0.0};
                                } else {
                                    var129 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    var129 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.29850922524929047) {
                    var129 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        var129 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.6531969904899597) {
                            var129 = new double[2] {0.2222222222222222, 0.7777777777777778};
                        } else {
                            var129 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var130;
            if (input[5] <= 0.43870341777801514) {
                if (input[2] <= 2.175404667854309) {
                    if (input[2] <= 0.9300557971000671) {
                        var130 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -0.23754795640707016) {
                            var130 = new double[2] {0.5, 0.5};
                        } else {
                            var130 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[0] <= 0.876292273402214) {
                        if (input[5] <= -0.28976114094257355) {
                            var130 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        } else {
                            if (input[5] <= -0.16398341953754425) {
                                var130 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            } else {
                                var130 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var130 = new double[2] {0.5555555555555556, 0.4444444444444444};
                    }
                }
            } else {
                if (input[2] <= 1.2202273607254028) {
                    var130 = new double[2] {0.125, 0.875};
                } else {
                    if (input[4] <= 1.068716138601303) {
                        if (input[5] <= 0.9808341264724731) {
                            var130 = new double[2] {0.2727272727272727, 0.7272727272727273};
                        } else {
                            if (input[4] <= 0.5640116333961487) {
                                if (input[3] <= 1.1405912041664124) {
                                    var130 = new double[2] {0.5, 0.5};
                                } else {
                                    var130 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var130 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var130 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var131;
            if (input[3] <= 0.777857780456543) {
                if (input[2] <= 0.40715569257736206) {
                    var131 = new double[2] {0.0, 1.0};
                } else {
                    if (input[0] <= 0.876292273402214) {
                        if (input[3] <= -0.38802669942379) {
                            var131 = new double[2] {0.5, 0.5};
                        } else {
                            if (input[5] <= 0.36683717370033264) {
                                if (input[1] <= -1.36287122964859) {
                                    var131 = new double[2] {1.0, 0.0};
                                } else {
                                    var131 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var131 = new double[2] {0.25, 0.75};
                            }
                        }
                    } else {
                        var131 = new double[2] {0.5833333333333334, 0.4166666666666667};
                    }
                }
            } else {
                if (input[4] <= -0.3684443533420563) {
                    var131 = new double[2] {0.6, 0.4};
                } else {
                    var131 = new double[2] {0.9230769230769231, 0.07692307692307693};
                }
            }
            double[] var132;
            if (input[3] <= 1.7416212558746338) {
                if (input[4] <= 1.7600333094596863) {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[3] <= 0.379926472902298) {
                                var132 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.05114172212779522) {
                                    var132 = new double[2] {0.0, 1.0};
                                } else {
                                    var132 = new double[2] {0.75, 0.25};
                                }
                            }
                        } else {
                            var132 = new double[2] {0.16666666666666666, 0.8333333333333334};
                        }
                    } else {
                        var132 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var132 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                var132 = new double[2] {0.9090909090909091, 0.09090909090909091};
            }
            double[] var133;
            if (input[3] <= 1.0039772987365723) {
                if (input[1] <= 2.4149075746536255) {
                    if (input[2] <= 0.43158040940761566) {
                        var133 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.5193964689970016) {
                            var133 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[0] <= 0.876292273402214) {
                                if (input[4] <= 1.3047150075435638) {
                                    var133 = new double[2] {0.0, 1.0};
                                } else {
                                    var133 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var133 = new double[2] {0.25, 0.75};
                            }
                        }
                    }
                } else {
                    var133 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.636903703212738) {
                    var133 = new double[2] {0.0, 1.0};
                } else {
                    var133 = new double[2] {1.0, 0.0};
                }
            }
            double[] var134;
            if (input[4] <= 1.8199918866157532) {
                if (input[4] <= -0.1342562548816204) {
                    if (input[1] <= 1.8916515111923218) {
                        var134 = new double[2] {0.0, 1.0};
                    } else {
                        var134 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.11582406610250473) {
                        if (input[3] <= 0.9171381667256355) {
                            var134 = new double[2] {0.0, 1.0};
                        } else {
                            var134 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 0.5908469706773758) {
                            var134 = new double[2] {0.0, 1.0};
                        } else {
                            var134 = new double[2] {0.375, 0.625};
                        }
                    }
                }
            } else {
                var134 = new double[2] {1.0, 0.0};
            }
            double[] var135;
            if (input[1] <= 2.1216257214546204) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[5] <= 2.853314995765686) {
                        if (input[5] <= 0.6243304014205933) {
                            if (input[2] <= 2.175404667854309) {
                                var135 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.05114172212779522) {
                                    var135 = new double[2] {0.0, 1.0};
                                } else {
                                    var135 = new double[2] {0.25, 0.75};
                                }
                            }
                        } else {
                            if (input[4] <= 0.7294346988201141) {
                                var135 = new double[2] {0.0, 1.0};
                            } else {
                                var135 = new double[2] {0.8, 0.2};
                            }
                        }
                    } else {
                        var135 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var135 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            } else {
                var135 = new double[2] {1.0, 0.0};
            }
            double[] var136;
            if (input[3] <= 0.7842573821544647) {
                if (input[5] <= 1.2995903491973877) {
                    if (input[1] <= 2.1171037554740906) {
                        if (input[5] <= 0.43870341777801514) {
                            if (input[4] <= 1.9211599230766296) {
                                var136 = new double[2] {0.0, 1.0};
                            } else {
                                var136 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var136 = new double[2] {0.25, 0.75};
                        }
                    } else {
                        var136 = new double[2] {0.7142857142857143, 0.2857142857142857};
                    }
                } else {
                    var136 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -1.0518246293067932) {
                    var136 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -0.46687617897987366) {
                        var136 = new double[2] {1.0, 0.0};
                    } else {
                        var136 = new double[2] {0.75, 0.25};
                    }
                }
            }
            double[] var137;
            if (input[4] <= 1.8199918866157532) {
                if (input[2] <= 2.066565155982971) {
                    if (input[0] <= -0.3421141058206558) {
                        if (input[5] <= 5.3345149755477905) {
                            var137 = new double[2] {0.0, 1.0};
                        } else {
                            var137 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var137 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[3] <= 0.14740732312202454) {
                        if (input[1] <= 1.8916515111923218) {
                            if (input[3] <= -0.38802669942379) {
                                var137 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            } else {
                                var137 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var137 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= -1.20718914270401) {
                            var137 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.8789961040019989) {
                                var137 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            } else {
                                var137 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                var137 = new double[2] {1.0, 0.0};
            }
            double[] var138;
            if (input[3] <= 1.5816310048103333) {
                if (input[2] <= 1.481344997882843) {
                    if (input[3] <= -0.41655829548835754) {
                        if (input[5] <= -0.7485741078853607) {
                            var138 = new double[2] {0.125, 0.875};
                        } else {
                            var138 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var138 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[2] <= 1.5537692308425903) {
                        var138 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 1.0937937498092651) {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[1] <= 0.3467545211315155) {
                                    var138 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                } else {
                                    var138 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var138 = new double[2] {0.3076923076923077, 0.6923076923076923};
                            }
                        } else {
                            var138 = new double[2] {0.625, 0.375};
                        }
                    }
                }
            } else {
                var138 = new double[2] {0.8888888888888888, 0.1111111111111111};
            }
            double[] var139;
            if (input[2] <= 0.43158040940761566) {
                var139 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 1.150134265422821) {
                    if (input[5] <= 1.165518581867218) {
                        if (input[1] <= 2.0848039984703064) {
                            if (input[4] <= 0.042278969660401344) {
                                var139 = new double[2] {0.0, 1.0};
                            } else {
                                var139 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var139 = new double[2] {0.7777777777777778, 0.2222222222222222};
                        }
                    } else {
                        if (input[2] <= 1.6531969904899597) {
                            var139 = new double[2] {0.0, 1.0};
                        } else {
                            var139 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var139 = new double[2] {1.0, 0.0};
                }
            }
            double[] var140;
            if (input[4] <= 1.9012749791145325) {
                if (input[3] <= 1.2698277831077576) {
                    if (input[2] <= 2.171961545944214) {
                        var140 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 2.0848039984703064) {
                            if (input[1] <= 1.4052172899246216) {
                                var140 = new double[2] {0.0, 1.0};
                            } else {
                                var140 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var140 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var140 = new double[2] {0.9166666666666666, 0.08333333333333333};
                }
            } else {
                var140 = new double[2] {1.0, 0.0};
            }
            double[] var141;
            if (input[3] <= 0.49405285716056824) {
                if (input[4] <= 2.034778654575348) {
                    if (input[5] <= 0.6243304014205933) {
                        if (input[2] <= 2.175404667854309) {
                            var141 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.3212409019470215) {
                                var141 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.8367419242858887) {
                                    if (input[1] <= -1.2566050291061401) {
                                        var141 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[5] <= -0.12684859335422516) {
                                            var141 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                        } else {
                                            var141 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var141 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var141 = new double[2] {0.5, 0.5};
                    }
                } else {
                    var141 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.7487040162086487) {
                    var141 = new double[2] {0.5, 0.5};
                } else {
                    var141 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            }
            double[] var142;
            if (input[5] <= 0.9428510367870331) {
                if (input[5] <= -0.1849542260169983) {
                    var142 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[4] <= 1.7600783109664917) {
                            var142 = new double[2] {0.0, 1.0};
                        } else {
                            var142 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var142 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[5] <= 2.394124984741211) {
                    var142 = new double[2] {1.0, 0.0};
                } else {
                    var142 = new double[2] {0.5, 0.5};
                }
            }
            double[] var143;
            if (input[1] <= 1.8638737201690674) {
                if (input[4] <= 1.8872272968292236) {
                    if (input[2] <= 1.686274766921997) {
                        var143 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 1.0039772987365723) {
                            if (input[3] <= -0.38802669942379) {
                                var143 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            } else {
                                if (input[4] <= 0.7294346988201141) {
                                    var143 = new double[2] {0.0, 1.0};
                                } else {
                                    var143 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var143 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var143 = new double[2] {1.0, 0.0};
                }
            } else {
                var143 = new double[2] {0.9285714285714286, 0.07142857142857142};
            }
            double[] var144;
            if (input[5] <= 1.165518581867218) {
                if (input[2] <= 2.120432734489441) {
                    if (input[3] <= 0.41690200567245483) {
                        if (input[4] <= 2.1863789558410645) {
                            var144 = new double[2] {0.0, 1.0};
                        } else {
                            var144 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var144 = new double[2] {0.25, 0.75};
                    }
                } else {
                    if (input[1] <= 2.0848039984703064) {
                        if (input[4] <= 1.1713238656520844) {
                            if (input[3] <= 0.31948571652173996) {
                                var144 = new double[2] {0.0, 1.0};
                            } else {
                                var144 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            var144 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var144 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var144 = new double[2] {0.0, 1.0};
                } else {
                    var144 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            }
            double[] var145;
            if (input[5] <= 1.0937937498092651) {
                if (input[4] <= 1.9071122407913208) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[3] <= 0.3725491464138031) {
                            if (input[2] <= 2.175404667854309) {
                                var145 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.9279130958020687) {
                                    var145 = new double[2] {0.0, 1.0};
                                } else {
                                    var145 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var145 = new double[2] {0.1111111111111111, 0.8888888888888888};
                        }
                    } else {
                        var145 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    var145 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[0] <= -0.3421141058206558) {
                    var145 = new double[2] {0.9090909090909091, 0.09090909090909091};
                } else {
                    var145 = new double[2] {0.3333333333333333, 0.6666666666666666};
                }
            }
            double[] var146;
            if (input[5] <= 1.0937937498092651) {
                if (input[2] <= 0.43158040940761566) {
                    var146 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 2.4394553303718567) {
                        if (input[5] <= -0.2511182948946953) {
                            var146 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 1.002549171447754) {
                                if (input[4] <= -0.07813299261033535) {
                                    var146 = new double[2] {0.0, 1.0};
                                } else {
                                    var146 = new double[2] {0.1, 0.9};
                                }
                            } else {
                                var146 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var146 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var146 = new double[2] {0.2, 0.8};
                } else {
                    var146 = new double[2] {1.0, 0.0};
                }
            }
            double[] var147;
            if (input[5] <= 1.226828694343567) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[2] <= 2.175404667854309) {
                        var147 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.010260338429361582) {
                            if (input[4] <= -1.4062073826789856) {
                                var147 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= -0.2653030529618263) {
                                    var147 = new double[2] {0.0, 1.0};
                                } else {
                                    var147 = new double[2] {0.6, 0.4};
                                }
                            }
                        } else {
                            var147 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var147 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.1932025570422411) {
                    var147 = new double[2] {0.0, 1.0};
                } else {
                    var147 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            }
            double[] var148;
            if (input[5] <= 0.4007203280925751) {
                if (input[5] <= -0.1849542260169983) {
                    if (input[2] <= 0.22188109252601862) {
                        var148 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.746689110994339) {
                            var148 = new double[2] {0.5, 0.5};
                        } else {
                            if (input[1] <= 3.2834476828575134) {
                                var148 = new double[2] {0.0, 1.0};
                            } else {
                                var148 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= 1.7600783109664917) {
                        if (input[1] <= 2.165230453014374) {
                            var148 = new double[2] {0.0, 1.0};
                        } else {
                            var148 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var148 = new double[2] {0.6, 0.4};
                    }
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var148 = new double[2] {0.3, 0.7};
                } else {
                    if (input[4] <= -0.1990060843527317) {
                        var148 = new double[2] {0.5714285714285714, 0.42857142857142855};
                    } else {
                        if (input[5] <= 1.273577094078064) {
                            var148 = new double[2] {0.5, 0.5};
                        } else {
                            var148 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var149;
            if (input[4] <= 1.7611917853355408) {
                if (input[3] <= 0.777857780456543) {
                    if (input[1] <= 2.1171037554740906) {
                        if (input[3] <= 0.37566007673740387) {
                            if (input[4] <= 0.8884468674659729) {
                                var149 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= 0.9861797839403152) {
                                    var149 = new double[2] {0.0, 1.0};
                                } else {
                                    var149 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var149 = new double[2] {0.125, 0.875};
                        }
                    } else {
                        var149 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    if (input[3] <= 3.2797497510910034) {
                        var149 = new double[2] {0.5714285714285714, 0.42857142857142855};
                    } else {
                        var149 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var149 = new double[2] {0.8571428571428571, 0.14285714285714285};
            }
            double[] var150;
            if (input[3] <= 1.5816310048103333) {
                if (input[2] <= 0.43158040940761566) {
                    var150 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[3] <= -0.5289958864450455) {
                            var150 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= 0.5671582669019699) {
                                var150 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 0.1707208827137947) {
                                    if (input[4] <= 1.2994626462459564) {
                                        var150 = new double[2] {0.0, 1.0};
                                    } else {
                                        var150 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[2] <= 2.0986069440841675) {
                                        var150 = new double[2] {0.0625, 0.9375};
                                    } else {
                                        var150 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var150 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var150 = new double[2] {1.0, 0.0};
            }
            double[] var151;
            if (input[3] <= 1.611495852470398) {
                if (input[2] <= 0.40715569257736206) {
                    var151 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        if (input[4] <= 1.4407605528831482) {
                            if (input[4] <= -1.4453137516975403) {
                                var151 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[0] <= 0.876292273402214) {
                                    if (input[4] <= 0.7294346988201141) {
                                        var151 = new double[2] {0.0, 1.0};
                                    } else {
                                        var151 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                    }
                                } else {
                                    var151 = new double[2] {0.36363636363636365, 0.6363636363636364};
                                }
                            }
                        } else {
                            var151 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var151 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var151 = new double[2] {1.0, 0.0};
            }
            double[] var152;
            if (input[2] <= 0.43158040940761566) {
                var152 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 1.118770182132721) {
                    if (input[4] <= 1.4407605528831482) {
                        if (input[2] <= 2.1580482721328735) {
                            var152 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.4578658938407898) {
                                if (input[0] <= -0.3421141058206558) {
                                    if (input[5] <= -0.16902583837509155) {
                                        var152 = new double[2] {0.15384615384615385, 0.8461538461538461};
                                    } else {
                                        var152 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var152 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var152 = new double[2] {0.8333333333333334, 0.16666666666666666};
                            }
                        }
                    } else {
                        var152 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 1.424929440021515) {
                        var152 = new double[2] {1.0, 0.0};
                    } else {
                        var152 = new double[2] {0.8, 0.2};
                    }
                }
            }
            double[] var153;
            if (input[5] <= 1.273577094078064) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[2] <= 2.171961545944214) {
                            var153 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.5814462602138519) {
                                var153 = new double[2] {0.0, 1.0};
                            } else {
                                var153 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            }
                        }
                    } else {
                        var153 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    var153 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.8288052678108215) {
                    var153 = new double[2] {0.25, 0.75};
                } else {
                    var153 = new double[2] {1.0, 0.0};
                }
            }
            double[] var154;
            if (input[5] <= 1.055810660123825) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[2] <= 2.175404667854309) {
                        var154 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.3504115343093872) {
                            var154 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 0.5606600046157837) {
                                if (input[1] <= 1.8367419242858887) {
                                    if (input[5] <= -0.16902583837509155) {
                                        var154 = new double[2] {0.25, 0.75};
                                    } else {
                                        var154 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var154 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var154 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var154 = new double[2] {1.0, 0.0};
                }
            } else {
                var154 = new double[2] {0.8571428571428571, 0.14285714285714285};
            }
            double[] var155;
            if (input[5] <= 0.9808341264724731) {
                if (input[3] <= 0.30695316195487976) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[4] <= 2.034778654575348) {
                            var155 = new double[2] {0.0, 1.0};
                        } else {
                            var155 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var155 = new double[2] {0.75, 0.25};
                    }
                } else {
                    if (input[1] <= 1.8425559401512146) {
                        if (input[2] <= 1.587740033864975) {
                            var155 = new double[2] {0.1111111111111111, 0.8888888888888888};
                        } else {
                            var155 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var155 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[3] <= 1.7416212558746338) {
                    var155 = new double[2] {0.6, 0.4};
                } else {
                    var155 = new double[2] {1.0, 0.0};
                }
            }
            double[] var156;
            if (input[2] <= 0.9300557971000671) {
                if (input[4] <= 2.2004266381263733) {
                    var156 = new double[2] {0.0, 1.0};
                } else {
                    var156 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= 2.4045716524124146) {
                    if (input[1] <= 0.19752967357635498) {
                        if (input[4] <= -0.3699514716863632) {
                            var156 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 1.163869172334671) {
                                var156 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            } else {
                                var156 = new double[2] {0.8888888888888888, 0.1111111111111111};
                            }
                        }
                    } else {
                        if (input[5] <= 0.6243304014205933) {
                            if (input[2] <= 2.175404667854309) {
                                var156 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 2.011483609676361) {
                                    if (input[5] <= -0.12684859335422516) {
                                        var156 = new double[2] {0.14285714285714285, 0.8571428571428571};
                                    } else {
                                        var156 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var156 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var156 = new double[2] {0.6666666666666666, 0.3333333333333333};
                        }
                    }
                } else {
                    var156 = new double[2] {1.0, 0.0};
                }
            }
            double[] var157;
            if (input[4] <= 1.8872272968292236) {
                if (input[2] <= 2.066565155982971) {
                    if (input[3] <= 6.991434693336487) {
                        var157 = new double[2] {0.0, 1.0};
                    } else {
                        var157 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[5] <= 1.165518581867218) {
                        if (input[5] <= -0.34532199800014496) {
                            var157 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 0.05114172212779522) {
                                if (input[1] <= 1.7989512085914612) {
                                    var157 = new double[2] {0.0, 1.0};
                                } else {
                                    var157 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var157 = new double[2] {0.5, 0.5};
                            }
                        }
                    } else {
                        var157 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var157 = new double[2] {1.0, 0.0};
            }
            double[] var158;
            if (input[1] <= 1.8961734771728516) {
                if (input[4] <= 1.8872272968292236) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[3] <= 0.7842573821544647) {
                            if (input[1] <= -1.4827032685279846) {
                                if (input[2] <= 0.9428580552339554) {
                                    var158 = new double[2] {0.0, 1.0};
                                } else {
                                    var158 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[5] <= -0.157574363052845) {
                                    var158 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= -0.41255854070186615) {
                                        if (input[5] <= -0.14141034334897995) {
                                            var158 = new double[2] {1.0, 0.0};
                                        } else {
                                            var158 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var158 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            var158 = new double[2] {0.6, 0.4};
                        }
                    } else {
                        var158 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    var158 = new double[2] {1.0, 0.0};
                }
            } else {
                var158 = new double[2] {0.9230769230769231, 0.07692307692307693};
            }
            double[] var159;
            if (input[4] <= 1.7934148907661438) {
                if (input[0] <= -0.3421141058206558) {
                    if (input[3] <= 1.3206691145896912) {
                        if (input[5] <= -0.23990245163440704) {
                            if (input[3] <= 0.356105700135231) {
                                var159 = new double[2] {0.0, 1.0};
                            } else {
                                var159 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var159 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= -1.3192665576934814) {
                            var159 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        } else {
                            var159 = new double[2] {0.8181818181818182, 0.18181818181818182};
                        }
                    }
                } else {
                    if (input[5] <= -0.29141052067279816) {
                        var159 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 2.312194287776947) {
                            var159 = new double[2] {0.0, 1.0};
                        } else {
                            var159 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var159 = new double[2] {1.0, 0.0};
            }
            double[] var160;
            if (input[2] <= 0.27639439702033997) {
                var160 = new double[2] {0.0, 1.0};
            } else {
                if (input[3] <= 0.7641697227954865) {
                    if (input[3] <= 0.42614588141441345) {
                        if (input[4] <= 0.5557562410831451) {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[4] <= -0.09826538525521755) {
                                    var160 = new double[2] {0.0, 1.0};
                                } else {
                                    var160 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                if (input[1] <= 2.011483609676361) {
                                    var160 = new double[2] {0.0, 1.0};
                                } else {
                                    var160 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var160 = new double[2] {0.9090909090909091, 0.09090909090909091};
                        }
                    } else {
                        var160 = new double[2] {0.0625, 0.9375};
                    }
                } else {
                    var160 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            }
            double[] var161;
            if (input[5] <= 1.165518581867218) {
                if (input[2] <= 2.175404667854309) {
                    if (input[5] <= 0.4139154553413391) {
                        if (input[4] <= 2.226238787174225) {
                            var161 = new double[2] {0.0, 1.0};
                        } else {
                            var161 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var161 = new double[2] {0.125, 0.875};
                    }
                } else {
                    if (input[5] <= -0.010260338429361582) {
                        if (input[5] <= -0.2511182948946953) {
                            var161 = new double[2] {0.09090909090909091, 0.9090909090909091};
                        } else {
                            var161 = new double[2] {0.5833333333333334, 0.4166666666666667};
                        }
                    } else {
                        if (input[3] <= 1.3142695128917694) {
                            if (input[1] <= 1.4200751781463623) {
                                var161 = new double[2] {0.0, 1.0};
                            } else {
                                var161 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            }
                        } else {
                            var161 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[4] <= -0.38663099706172943) {
                    var161 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -1.3192665576934814) {
                        var161 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        var161 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var162;
            if (input[4] <= 1.8199918866157532) {
                if (input[2] <= 1.6531969904899597) {
                    var162 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        if (input[4] <= -0.11199815385043621) {
                            if (input[4] <= -0.7483955025672913) {
                                if (input[3] <= -0.08315639942884445) {
                                    var162 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                } else {
                                    var162 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var162 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var162 = new double[2] {0.4166666666666667, 0.5833333333333334};
                        }
                    } else {
                        var162 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var162 = new double[2] {1.0, 0.0};
            }
            double[] var163;
            if (input[3] <= 1.7416212558746338) {
                if (input[2] <= 0.43158040940761566) {
                    var163 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.068716138601303) {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[2] <= 2.171961545944214) {
                                var163 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.5473829507827759) {
                                    var163 = new double[2] {0.0, 1.0};
                                } else {
                                    var163 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                }
                            }
                        } else {
                            if (input[1] <= 1.461741864681244) {
                                var163 = new double[2] {0.0, 1.0};
                            } else {
                                var163 = new double[2] {0.8333333333333334, 0.16666666666666666};
                            }
                        }
                    } else {
                        var163 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var163 = new double[2] {0.8, 0.2};
            }
            double[] var164;
            if (input[4] <= 1.7611917853355408) {
                if (input[3] <= 4.546605706214905) {
                    if (input[1] <= 2.4045716524124146) {
                        if (input[5] <= 2.853314995765686) {
                            if (input[2] <= 2.1580482721328735) {
                                var164 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[0] <= -0.3421141058206558) {
                                    var164 = new double[2] {0.0, 1.0};
                                } else {
                                    var164 = new double[2] {0.23076923076923078, 0.7692307692307693};
                                }
                            }
                        } else {
                            var164 = new double[2] {0.2, 0.8};
                        }
                    } else {
                        var164 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var164 = new double[2] {1.0, 0.0};
                }
            } else {
                var164 = new double[2] {0.8333333333333334, 0.16666666666666666};
            }
            double[] var165;
            if (input[3] <= 0.3589499741792679) {
                if (input[1] <= 2.165230453014374) {
                    if (input[5] <= 0.4117005616426468) {
                        var165 = new double[2] {0.0, 1.0};
                    } else {
                        var165 = new double[2] {0.4, 0.6};
                    }
                } else {
                    var165 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 4.369763493537903) {
                    if (input[5] <= -0.16398341953754425) {
                        var165 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= 0.40516938269138336) {
                            var165 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= 1.273577094078064) {
                                var165 = new double[2] {0.08333333333333333, 0.9166666666666666};
                            } else {
                                var165 = new double[2] {0.5, 0.5};
                            }
                        }
                    }
                } else {
                    var165 = new double[2] {1.0, 0.0};
                }
            }
            double[] var166;
            if (input[2] <= 2.066565155982971) {
                if (input[3] <= 7.33639132976532) {
                    if (input[2] <= 1.4859262704849243) {
                        var166 = new double[2] {0.0, 1.0};
                    } else {
                        var166 = new double[2] {0.09090909090909091, 0.9090909090909091};
                    }
                } else {
                    var166 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= 2.118072807788849) {
                    if (input[5] <= 1.315471589565277) {
                        if (input[3] <= -0.38802669942379) {
                            var166 = new double[2] {0.6666666666666666, 0.3333333333333333};
                        } else {
                            var166 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var166 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var166 = new double[2] {1.0, 0.0};
                }
            }
            double[] var167;
            if (input[2] <= 0.43158040940761566) {
                var167 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 0.9808341264724731) {
                    if (input[5] <= -0.3504115343093872) {
                        var167 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[4] <= 1.4407605528831482) {
                                if (input[4] <= 0.05114172212779522) {
                                    var167 = new double[2] {0.0, 1.0};
                                } else {
                                    var167 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var167 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var167 = new double[2] {0.7142857142857143, 0.2857142857142857};
                        }
                    }
                } else {
                    var167 = new double[2] {1.0, 0.0};
                }
            }
            double[] var168;
            if (input[3] <= 0.3546835780143738) {
                if (input[1] <= 1.5263413786888123) {
                    if (input[2] <= 2.060991406440735) {
                        var168 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.8304903022944927) {
                            var168 = new double[2] {0.0, 1.0};
                        } else {
                            var168 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var168 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var168 = new double[2] {0.1, 0.9};
                } else {
                    if (input[3] <= 0.9975776970386505) {
                        var168 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        var168 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var169;
            if (input[5] <= 1.26872318983078) {
                if (input[2] <= 0.40715569257736206) {
                    var169 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.5741516947746277) {
                        if (input[0] <= 0.876292273402214) {
                            if (input[1] <= 1.5263413786888123) {
                                var169 = new double[2] {0.0, 1.0};
                            } else {
                                var169 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var169 = new double[2] {0.36363636363636365, 0.6363636363636364};
                        }
                    } else {
                        var169 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var169 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    var169 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            }
            double[] var170;
            if (input[5] <= 1.26872318983078) {
                if (input[2] <= 0.43158040940761566) {
                    var170 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.651624009013176) {
                        var170 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= 0.3429509550333023) {
                            if (input[1] <= 2.011483609676361) {
                                var170 = new double[2] {0.0, 1.0};
                            } else {
                                var170 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.05114172212779522) {
                                var170 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            } else {
                                var170 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var170 = new double[2] {0.0, 1.0};
                } else {
                    var170 = new double[2] {1.0, 0.0};
                }
            }
            double[] var171;
            if (input[5] <= 1.118770182132721) {
                if (input[4] <= 2.020730972290039) {
                    if (input[2] <= 2.175404667854309) {
                        var171 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.5606600046157837) {
                            if (input[4] <= -1.4453137516975403) {
                                var171 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.2566050291061401) {
                                    var171 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[1] <= 2.1206567883491516) {
                                        var171 = new double[2] {0.0, 1.0};
                                    } else {
                                        var171 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            var171 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var171 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 1.9136815667152405) {
                    var171 = new double[2] {1.0, 0.0};
                } else {
                    var171 = new double[2] {0.8, 0.2};
                }
            }
            double[] var172;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 2.034778654575348) {
                    if (input[5] <= 0.6243304014205933) {
                        if (input[3] <= 0.30695316195487976) {
                            if (input[2] <= 2.175404667854309) {
                                var172 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.8367419242858887) {
                                    var172 = new double[2] {0.0, 1.0};
                                } else {
                                    var172 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[4] <= -1.4453137516975403) {
                                var172 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -0.23947331868112087) {
                                    var172 = new double[2] {0.0, 1.0};
                                } else {
                                    var172 = new double[2] {0.2727272727272727, 0.7272727272727273};
                                }
                            }
                        }
                    } else {
                        var172 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    var172 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.8288052678108215) {
                    var172 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    var172 = new double[2] {1.0, 0.0};
                }
            }
            double[] var173;
            if (input[5] <= 1.165518581867218) {
                if (input[5] <= 0.4139154553413391) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[3] <= 0.30695316195487976) {
                            if (input[1] <= 2.1216257214546204) {
                                var173 = new double[2] {0.0, 1.0};
                            } else {
                                var173 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= 1.9895713329315186) {
                                var173 = new double[2] {0.0, 1.0};
                            } else {
                                var173 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        }
                    } else {
                        var173 = new double[2] {0.5, 0.5};
                    }
                } else {
                    if (input[4] <= 0.7294346988201141) {
                        if (input[1] <= 2.118072807788849) {
                            var173 = new double[2] {0.0, 1.0};
                        } else {
                            var173 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var173 = new double[2] {0.75, 0.25};
                    }
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var173 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -0.335093192756176) {
                        var173 = new double[2] {0.7, 0.3};
                    } else {
                        var173 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var174;
            if (input[5] <= 1.165518581867218) {
                if (input[2] <= 0.43158040940761566) {
                    var174 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.3593424260616302) {
                        if (input[4] <= -0.8559294939041138) {
                            if (input[1] <= 1.393912449479103) {
                                var174 = new double[2] {0.0, 1.0};
                            } else {
                                var174 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.16162867844104767) {
                                var174 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.2107393741607666) {
                                    var174 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[3] <= 0.1890936717391014) {
                                        var174 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.40516938269138336) {
                                            var174 = new double[2] {0.25, 0.75};
                                        } else {
                                            var174 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var174 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var174 = new double[2] {0.0, 1.0};
                } else {
                    var174 = new double[2] {1.0, 0.0};
                }
            }
            double[] var175;
            if (input[5] <= 1.118770182132721) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.1216257214546204) {
                        var175 = new double[2] {0.0, 1.0};
                    } else {
                        var175 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    }
                } else {
                    var175 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.8934063017368317) {
                    var175 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= 1.8343790173530579) {
                        var175 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        var175 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var176;
            if (input[4] <= 1.7611917853355408) {
                if (input[2] <= 1.686274766921997) {
                    var176 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[4] <= 0.37141549587249756) {
                            if (input[5] <= 4.118820786476135) {
                                var176 = new double[2] {0.0, 1.0};
                            } else {
                                var176 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var176 = new double[2] {0.6, 0.4};
                        }
                    } else {
                        var176 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var176 = new double[2] {0.9285714285714286, 0.07142857142857142};
            }
            double[] var177;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[4] <= -0.8186227083206177) {
                        if (input[4] <= -0.9387647211551666) {
                            if (input[2] <= 2.1580482721328735) {
                                var177 = new double[2] {0.0, 1.0};
                            } else {
                                var177 = new double[2] {0.2857142857142857, 0.7142857142857143};
                            }
                        } else {
                            var177 = new double[2] {0.4444444444444444, 0.5555555555555556};
                        }
                    } else {
                        if (input[1] <= 2.549597442150116) {
                            if (input[5] <= 0.5672143995761871) {
                                var177 = new double[2] {0.0, 1.0};
                            } else {
                                var177 = new double[2] {0.08333333333333333, 0.9166666666666666};
                            }
                        } else {
                            var177 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var177 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var177 = new double[2] {0.0, 1.0};
                } else {
                    var177 = new double[2] {1.0, 0.0};
                }
            }
            double[] var178;
            if (input[3] <= 1.5816310048103333) {
                if (input[2] <= 0.4325118213891983) {
                    var178 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= -0.29656560719013214) {
                        var178 = new double[2] {0.5294117647058824, 0.47058823529411764};
                    } else {
                        if (input[4] <= 0.7294346988201141) {
                            if (input[1] <= 2.4804760217666626) {
                                if (input[5] <= -0.15879962593317032) {
                                    if (input[3] <= 0.2661556340754032) {
                                        var178 = new double[2] {0.0, 1.0};
                                    } else {
                                        var178 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var178 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var178 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var178 = new double[2] {0.75, 0.25};
                        }
                    }
                }
            } else {
                var178 = new double[2] {1.0, 0.0};
            }
            double[] var179;
            if (input[1] <= 2.1216257214546204) {
                if (input[5] <= 1.273577094078064) {
                    if (input[1] <= 1.5263413786888123) {
                        if (input[3] <= 0.37566007673740387) {
                            if (input[5] <= 0.4156590849161148) {
                                var179 = new double[2] {0.0, 1.0};
                            } else {
                                var179 = new double[2] {0.1111111111111111, 0.8888888888888888};
                            }
                        } else {
                            var179 = new double[2] {0.15384615384615385, 0.8461538461538461};
                        }
                    } else {
                        var179 = new double[2] {0.2857142857142857, 0.7142857142857143};
                    }
                } else {
                    if (input[5] <= 2.050910711288452) {
                        var179 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    } else {
                        var179 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var179 = new double[2] {1.0, 0.0};
            }
            double[] var180;
            if (input[3] <= 0.983889639377594) {
                if (input[3] <= 0.35397250950336456) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[4] <= 1.7611917853355408) {
                            if (input[5] <= 0.6243304014205933) {
                                var180 = new double[2] {0.0, 1.0};
                            } else {
                                var180 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var180 = new double[2] {0.8571428571428571, 0.14285714285714285};
                        }
                    } else {
                        var180 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var180 = new double[2] {0.18181818181818182, 0.8181818181818182};
                }
            } else {
                if (input[3] <= 3.702746033668518) {
                    var180 = new double[2] {0.5714285714285714, 0.42857142857142855};
                } else {
                    var180 = new double[2] {1.0, 0.0};
                }
            }
            double[] var181;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[3] <= 1.611495852470398) {
                        if (input[4] <= -1.4582929611206055) {
                            if (input[1] <= 1.9158763885498047) {
                                var181 = new double[2] {0.0, 1.0};
                            } else {
                                var181 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= 2.171961545944214) {
                                var181 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.7294346988201141) {
                                    if (input[5] <= -0.010825843550264835) {
                                        if (input[0] <= -0.3421141058206558) {
                                            var181 = new double[2] {0.125, 0.875};
                                        } else {
                                            var181 = new double[2] {0.2857142857142857, 0.7142857142857143};
                                        }
                                    } else {
                                        var181 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var181 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var181 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var181 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            } else {
                var181 = new double[2] {0.9375, 0.0625};
            }
            double[] var182;
            if (input[1] <= 2.1216257214546204) {
                if (input[2] <= 0.43158040940761566) {
                    var182 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= -0.12701309099793434) {
                        if (input[5] <= 4.089603006839752) {
                            var182 = new double[2] {0.0, 1.0};
                        } else {
                            var182 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= 0.9080190658569336) {
                            var182 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        } else {
                            if (input[3] <= -0.11497667757794261) {
                                var182 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.05027569271624088) {
                                    var182 = new double[2] {0.5, 0.5};
                                } else {
                                    var182 = new double[2] {0.9285714285714286, 0.07142857142857142};
                                }
                            }
                        }
                    }
                }
            } else {
                var182 = new double[2] {0.9, 0.1};
            }
            double[] var183;
            if (input[1] <= 1.790553331375122) {
                if (input[5] <= 1.226828694343567) {
                    if (input[2] <= 0.43158040940761566) {
                        var183 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.5557562410831451) {
                            if (input[5] <= -0.2304302453994751) {
                                if (input[4] <= -0.040623752400279045) {
                                    var183 = new double[2] {0.0, 1.0};
                                } else {
                                    var183 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var183 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var183 = new double[2] {0.6666666666666666, 0.3333333333333333};
                        }
                    }
                } else {
                    var183 = new double[2] {1.0, 0.0};
                }
            } else {
                var183 = new double[2] {0.7142857142857143, 0.2857142857142857};
            }
            double[] var184;
            if (input[3] <= 0.777857780456543) {
                if (input[5] <= 0.43870341777801514) {
                    if (input[3] <= 0.379926472902298) {
                        if (input[5] <= -0.7569624483585358) {
                            if (input[4] <= 2.212191104888916) {
                                var184 = new double[2] {0.0, 1.0};
                            } else {
                                var184 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 2.011483609676361) {
                                var184 = new double[2] {0.0, 1.0};
                            } else {
                                var184 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var184 = new double[2] {0.5, 0.5};
                    }
                } else {
                    if (input[4] <= 0.09023680537939072) {
                        var184 = new double[2] {0.0, 1.0};
                    } else {
                        var184 = new double[2] {0.9090909090909091, 0.09090909090909091};
                    }
                }
            } else {
                if (input[4] <= 1.068716138601303) {
                    if (input[3] <= 1.5816310048103333) {
                        var184 = new double[2] {0.0, 1.0};
                    } else {
                        var184 = new double[2] {0.7272727272727273, 0.2727272727272727};
                    }
                } else {
                    var184 = new double[2] {1.0, 0.0};
                }
            }
            double[] var185;
            if (input[5] <= 1.165518581867218) {
                if (input[3] <= 0.3687271624803543) {
                    if (input[1] <= 1.5263413786888123) {
                        var185 = new double[2] {0.0, 1.0};
                    } else {
                        var185 = new double[2] {0.375, 0.625};
                    }
                } else {
                    if (input[3] <= 0.42614588141441345) {
                        var185 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 0.21151183545589447) {
                            var185 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        } else {
                            var185 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[5] <= 1.862126350402832) {
                    var185 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 3.5527032613754272) {
                        var185 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        var185 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var186;
            if (input[2] <= 1.2749791145324707) {
                if (input[4] <= 2.212191104888916) {
                    var186 = new double[2] {0.0, 1.0};
                } else {
                    var186 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= 2.0848039984703064) {
                    if (input[4] <= -0.3435094356536865) {
                        var186 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -0.46687617897987366) {
                            var186 = new double[2] {0.9285714285714286, 0.07142857142857142};
                        } else {
                            if (input[3] <= 0.04501356603577733) {
                                var186 = new double[2] {0.8, 0.2};
                            } else {
                                var186 = new double[2] {0.1, 0.9};
                            }
                        }
                    }
                } else {
                    var186 = new double[2] {1.0, 0.0};
                }
            }
            double[] var187;
            if (input[4] <= 1.7611917853355408) {
                if (input[5] <= 3.5527032613754272) {
                    if (input[3] <= 0.3589499741792679) {
                        if (input[3] <= 0.16162867844104767) {
                            if (input[0] <= -0.3421141058206558) {
                                var187 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= -0.10777711868286133) {
                                    var187 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[2] <= 0.9874875247478485) {
                                        var187 = new double[2] {0.0, 1.0};
                                    } else {
                                        var187 = new double[2] {0.75, 0.25};
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.1669616922736168) {
                                var187 = new double[2] {1.0, 0.0};
                            } else {
                                var187 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= 2.118072807788849) {
                            if (input[4] <= 1.068716138601303) {
                                if (input[4] <= -0.16452233120799065) {
                                    var187 = new double[2] {0.0, 1.0};
                                } else {
                                    var187 = new double[2] {0.26666666666666666, 0.7333333333333333};
                                }
                            } else {
                                var187 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var187 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var187 = new double[2] {1.0, 0.0};
                }
            } else {
                var187 = new double[2] {1.0, 0.0};
            }
            double[] var188;
            if (input[3] <= 1.7416212558746338) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[3] <= 0.30668650567531586) {
                        if (input[1] <= 2.1216257214546204) {
                            if (input[1] <= 1.5053465366363525) {
                                var188 = new double[2] {0.0, 1.0};
                            } else {
                                var188 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            var188 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= -0.08024745993316174) {
                            if (input[3] <= 0.3094418942928314) {
                                var188 = new double[2] {1.0, 0.0};
                            } else {
                                var188 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var188 = new double[2] {0.8, 0.2};
                        }
                    }
                } else {
                    var188 = new double[2] {0.7692307692307693, 0.23076923076923078};
                }
            } else {
                var188 = new double[2] {1.0, 0.0};
            }
            double[] var189;
            if (input[5] <= 0.9428510367870331) {
                if (input[1] <= 2.1171037554740906) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[2] <= 2.175404667854309) {
                            var189 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.3619022369384766) {
                                var189 = new double[2] {1.0, 0.0};
                            } else {
                                var189 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var189 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var189 = new double[2] {0.625, 0.375};
                }
            } else {
                if (input[3] <= 1.5816310048103333) {
                    var189 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    var189 = new double[2] {1.0, 0.0};
                }
            }
            double[] var190;
            if (input[5] <= 0.9808341264724731) {
                if (input[2] <= 2.175404667854309) {
                    if (input[5] <= 0.4139154553413391) {
                        if (input[3] <= 0.49405285716056824) {
                            if (input[1] <= 1.6529563665390015) {
                                var190 = new double[2] {0.0, 1.0};
                            } else {
                                var190 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            var190 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var190 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    if (input[1] <= 1.461741864681244) {
                        if (input[4] <= 1.002549171447754) {
                            if (input[1] <= -1.2566050291061401) {
                                var190 = new double[2] {1.0, 0.0};
                            } else {
                                var190 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var190 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var190 = new double[2] {0.9166666666666666, 0.08333333333333333};
                    }
                }
            } else {
                if (input[2] <= 1.8541556596755981) {
                    var190 = new double[2] {0.0, 1.0};
                } else {
                    var190 = new double[2] {1.0, 0.0};
                }
            }
            double[] var191;
            if (input[5] <= 1.273577094078064) {
                if (input[3] <= 1.611495852470398) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[2] <= 2.175404667854309) {
                            var191 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= -0.3421141058206558) {
                                var191 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.116780549287796) {
                                    var191 = new double[2] {0.0, 1.0};
                                } else {
                                    var191 = new double[2] {0.875, 0.125};
                                }
                            }
                        }
                    } else {
                        var191 = new double[2] {0.7, 0.3};
                    }
                } else {
                    var191 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 3.5527032613754272) {
                    var191 = new double[2] {0.6666666666666666, 0.3333333333333333};
                } else {
                    var191 = new double[2] {1.0, 0.0};
                }
            }
            double[] var192;
            if (input[3] <= 1.1131262183189392) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[2] <= 2.175404667854309) {
                        var192 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 2.2559927105903625) {
                            if (input[5] <= 0.6243304014205933) {
                                if (input[4] <= -0.02962404675781727) {
                                    var192 = new double[2] {0.0, 1.0};
                                } else {
                                    var192 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                var192 = new double[2] {0.16666666666666666, 0.8333333333333334};
                            }
                        } else {
                            var192 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var192 = new double[2] {0.5714285714285714, 0.42857142857142855};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var192 = new double[2] {0.5, 0.5};
                } else {
                    var192 = new double[2] {1.0, 0.0};
                }
            }
            double[] var193;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[3] <= 0.37566007673740387) {
                        if (input[4] <= 2.1863789558410645) {
                            if (input[5] <= 0.6243304014205933) {
                                var193 = new double[2] {0.0, 1.0};
                            } else {
                                var193 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            var193 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var193 = new double[2] {0.23076923076923078, 0.7692307692307693};
                    }
                } else {
                    var193 = new double[2] {0.5, 0.5};
                }
            } else {
                if (input[3] <= 0.8934063017368317) {
                    var193 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= -0.9655843079090118) {
                        var193 = new double[2] {0.2, 0.8};
                    } else {
                        var193 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var194;
            if (input[2] <= 0.2773258090019226) {
                var194 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 1.165518581867218) {
                    if (input[1] <= 1.8638737201690674) {
                        if (input[2] <= 1.0241162478923798) {
                            var194 = new double[2] {0.75, 0.25};
                        } else {
                            if (input[4] <= 1.3593424260616302) {
                                if (input[3] <= 0.16162867844104767) {
                                    var194 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= 0.1890936717391014) {
                                        var194 = new double[2] {1.0, 0.0};
                                    } else {
                                        var194 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var194 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var194 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= 1.6334203481674194) {
                        var194 = new double[2] {0.0, 1.0};
                    } else {
                        var194 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var195;
            if (input[3] <= 0.7842573821544647) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[1] <= -1.4646154046058655) {
                            if (input[1] <= -1.483995258808136) {
                                var195 = new double[2] {0.0, 1.0};
                            } else {
                                var195 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var195 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var195 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    var195 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -0.9655843079090118) {
                    var195 = new double[2] {0.0, 1.0};
                } else {
                    var195 = new double[2] {0.7142857142857143, 0.2857142857142857};
                }
            }
            double[] var196;
            if (input[4] <= 1.8199918866157532) {
                if (input[5] <= 1.315471589565277) {
                    if (input[3] <= 1.611495852470398) {
                        if (input[1] <= 2.4804760217666626) {
                            if (input[5] <= 0.6243304014205933) {
                                if (input[1] <= 2.1216257214546204) {
                                    if (input[4] <= 1.7611917853355408) {
                                        if (input[5] <= -0.23990245163440704) {
                                            if (input[2] <= 2.171961545944214) {
                                                var196 = new double[2] {0.0, 1.0};
                                            } else {
                                                var196 = new double[2] {0.13333333333333333, 0.8666666666666667};
                                            }
                                        } else {
                                            var196 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var196 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                    }
                                } else {
                                    var196 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var196 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            }
                        } else {
                            var196 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var196 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var196 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                var196 = new double[2] {1.0, 0.0};
            }
            double[] var197;
            if (input[1] <= 2.4045716524124146) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[5] <= 3.5527032613754272) {
                        if (input[5] <= 1.315471589565277) {
                            if (input[0] <= 0.876292273402214) {
                                if (input[2] <= 2.1532992124557495) {
                                    var197 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -1.1396799385547638) {
                                        var197 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[1] <= 2.0848039984703064) {
                                            if (input[4] <= 0.7294346988201141) {
                                                var197 = new double[2] {0.0, 1.0};
                                            } else {
                                                var197 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var197 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var197 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var197 = new double[2] {0.375, 0.625};
                        }
                    } else {
                        var197 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var197 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                var197 = new double[2] {1.0, 0.0};
            }
            double[] var198;
            if (input[3] <= 1.1131262183189392) {
                if (input[4] <= 1.7600333094596863) {
                    if (input[2] <= 2.171961545944214) {
                        var198 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 2.0848039984703064) {
                            if (input[1] <= -1.2107393741607666) {
                                var198 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= 1.273577094078064) {
                                    var198 = new double[2] {0.0, 1.0};
                                } else {
                                    var198 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var198 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var198 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 0.923718124628067) {
                    var198 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 1.6531969904899597) {
                        var198 = new double[2] {0.42857142857142855, 0.5714285714285714};
                    } else {
                        var198 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var199;
            if (input[2] <= 1.4859262704849243) {
                if (input[2] <= 0.43158040940761566) {
                    var199 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.5972533524036407) {
                        var199 = new double[2] {0.0, 1.0};
                    } else {
                        var199 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= 2.4045716524124146) {
                    if (input[5] <= 0.43870341777801514) {
                        if (input[4] <= 0.9976454079151154) {
                            if (input[3] <= 0.28926533460617065) {
                                if (input[3] <= -0.11035474017262459) {
                                    var199 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.8132353127002716) {
                                        var199 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                    } else {
                                        var199 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var199 = new double[2] {0.2, 0.8};
                            }
                        } else {
                            var199 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 0.7532561421394348) {
                            var199 = new double[2] {0.5, 0.5};
                        } else {
                            var199 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var199 = new double[2] {1.0, 0.0};
                }
            }
            double[] var200;
            if (input[2] <= 1.686274766921997) {
                if (input[2] <= 0.9080190658569336) {
                    var200 = new double[2] {0.0, 1.0};
                } else {
                    var200 = new double[2] {0.07692307692307693, 0.9230769230769231};
                }
            } else {
                if (input[3] <= 0.5296062529087067) {
                    if (input[3] <= 0.26020044833421707) {
                        if (input[1] <= 1.9052174091339111) {
                            if (input[3] <= -0.32323065400123596) {
                                var200 = new double[2] {0.4, 0.6};
                            } else {
                                var200 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var200 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var200 = new double[2] {0.42857142857142855, 0.5714285714285714};
                    }
                } else {
                    if (input[2] <= 1.9511435627937317) {
                        var200 = new double[2] {1.0, 0.0};
                    } else {
                        var200 = new double[2] {0.8666666666666667, 0.13333333333333333};
                    }
                }
            }
            double[] var201;
            if (input[5] <= 2.050910711288452) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[3] <= 0.30668650567531586) {
                        if (input[4] <= -0.8169131278991699) {
                            if (input[1] <= 1.8916515111923218) {
                                var201 = new double[2] {0.0, 1.0};
                            } else {
                                var201 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var201 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= 2.12840873003006) {
                            if (input[3] <= 1.7270443439483643) {
                                var201 = new double[2] {0.0, 1.0};
                            } else {
                                var201 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            var201 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var201 = new double[2] {1.0, 0.0};
                }
            } else {
                var201 = new double[2] {1.0, 0.0};
            }
            double[] var202;
            if (input[5] <= 0.9407775104045868) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[3] <= 0.37566007673740387) {
                        if (input[5] <= 0.6243304014205933) {
                            if (input[1] <= 2.1216257214546204) {
                                var202 = new double[2] {0.0, 1.0};
                            } else {
                                var202 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var202 = new double[2] {0.25, 0.75};
                        }
                    } else {
                        var202 = new double[2] {0.125, 0.875};
                    }
                } else {
                    var202 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            } else {
                if (input[5] <= 1.118770182132721) {
                    var202 = new double[2] {0.5, 0.5};
                } else {
                    if (input[2] <= 1.8485819101333618) {
                        var202 = new double[2] {0.0, 1.0};
                    } else {
                        var202 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var203;
            if (input[5] <= 1.118770182132721) {
                if (input[1] <= 2.4045716524124146) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[4] <= 1.7611917853355408) {
                            if (input[2] <= 2.175404667854309) {
                                var203 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.5606600046157837) {
                                    if (input[3] <= 0.3639274537563324) {
                                        var203 = new double[2] {0.0, 1.0};
                                    } else {
                                        var203 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                    }
                                } else {
                                    var203 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var203 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var203 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var203 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var203 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 1.6334203481674194) {
                        var203 = new double[2] {0.0, 1.0};
                    } else {
                        var203 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var204;
            if (input[3] <= 0.7641697227954865) {
                if (input[2] <= 0.43158040940761566) {
                    var204 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 0.7294346988201141) {
                        if (input[0] <= -0.3421141058206558) {
                            var204 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.0016152644529938698) {
                                if (input[1] <= 2.0550883412361145) {
                                    var204 = new double[2] {0.0, 1.0};
                                } else {
                                    var204 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var204 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var204 = new double[2] {0.9166666666666666, 0.08333333333333333};
                    }
                }
            } else {
                if (input[3] <= 2.440600872039795) {
                    var204 = new double[2] {0.9166666666666666, 0.08333333333333333};
                } else {
                    var204 = new double[2] {0.3333333333333333, 0.6666666666666666};
                }
            }
            double[] var205;
            if (input[1] <= 1.5263413786888123) {
                if (input[3] <= 0.777857780456543) {
                    if (input[2] <= 0.43158040940761566) {
                        var205 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.5066861361265182) {
                            var205 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= 1.5868470072746277) {
                                var205 = new double[2] {0.25, 0.75};
                            } else {
                                if (input[5] <= 1.2746139168739319) {
                                    if (input[4] <= 1.002549171447754) {
                                        if (input[4] <= 0.05114172212779522) {
                                            var205 = new double[2] {0.0, 1.0};
                                        } else {
                                            var205 = new double[2] {0.14285714285714285, 0.8571428571428571};
                                        }
                                    } else {
                                        var205 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var205 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[0] <= -0.3421141058206558) {
                        var205 = new double[2] {0.7692307692307693, 0.23076923076923078};
                    } else {
                        var205 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[1] <= 2.4045716524124146) {
                    var205 = new double[2] {0.5, 0.5};
                } else {
                    var205 = new double[2] {1.0, 0.0};
                }
            }
            double[] var206;
            if (input[5] <= 0.9808341264724731) {
                if (input[2] <= 1.4859262704849243) {
                    var206 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 0.42614588141441345) {
                        if (input[3] <= 0.16162867844104767) {
                            if (input[4] <= 1.002549171447754) {
                                var206 = new double[2] {0.0, 1.0};
                            } else {
                                var206 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var206 = new double[2] {0.8571428571428571, 0.14285714285714285};
                        }
                    } else {
                        var206 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[5] <= 1.165518581867218) {
                    var206 = new double[2] {0.6666666666666666, 0.3333333333333333};
                } else {
                    if (input[1] <= -1.2889047861099243) {
                        var206 = new double[2] {0.0, 1.0};
                    } else {
                        var206 = new double[2] {0.9444444444444444, 0.05555555555555555};
                    }
                }
            }
            double[] var207;
            if (input[5] <= 0.9808341264724731) {
                if (input[4] <= 2.020730972290039) {
                    if (input[3] <= 0.15736227482557297) {
                        if (input[5] <= -0.157574363052845) {
                            var207 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.15521808713674545) {
                                var207 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= -0.10982143878936768) {
                                    var207 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= -0.10084420815110207) {
                                        var207 = new double[2] {0.5, 0.5};
                                    } else {
                                        var207 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[5] <= -0.010872968938201666) {
                            if (input[3] <= 0.16856159269809723) {
                                var207 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 1.6904241442680359) {
                                    if (input[2] <= 0.9558829069137573) {
                                        var207 = new double[2] {0.0, 1.0};
                                    } else {
                                        var207 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                    }
                                } else {
                                    var207 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[4] <= 0.7353169620037079) {
                                var207 = new double[2] {0.0, 1.0};
                            } else {
                                var207 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var207 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var207 = new double[2] {0.25, 0.75};
                } else {
                    var207 = new double[2] {1.0, 0.0};
                }
            }
            double[] var208;
            if (input[4] <= 1.8199918866157532) {
                if (input[2] <= 2.175404667854309) {
                    var208 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 0.7842573821544647) {
                        if (input[3] <= 0.42614588141441345) {
                            if (input[3] <= 0.2957538291811943) {
                                if (input[0] <= -0.3421141058206558) {
                                    var208 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                } else {
                                    var208 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                var208 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var208 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var208 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var208 = new double[2] {1.0, 0.0};
            }
            double[] var209;
            if (input[3] <= 1.0039772987365723) {
                if (input[3] <= 0.1587844118475914) {
                    if (input[5] <= 0.43870341777801514) {
                        if (input[3] <= -0.10084420815110207) {
                            if (input[5] <= -0.7511660158634186) {
                                var209 = new double[2] {0.16666666666666666, 0.8333333333333334};
                            } else {
                                if (input[2] <= 2.171961545944214) {
                                    var209 = new double[2] {0.0, 1.0};
                                } else {
                                    var209 = new double[2] {0.3, 0.7};
                                }
                            }
                        } else {
                            var209 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var209 = new double[2] {0.2857142857142857, 0.7142857142857143};
                    }
                } else {
                    if (input[3] <= 0.16838382184505463) {
                        var209 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 1.779894471168518) {
                            var209 = new double[2] {0.0, 1.0};
                        } else {
                            var209 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var209 = new double[2] {0.9333333333333333, 0.06666666666666667};
            }
            double[] var210;
            if (input[1] <= 1.5263413786888123) {
                if (input[3] <= 1.1131262183189392) {
                    if (input[1] <= -1.4646154046058655) {
                        if (input[1] <= -1.483995258808136) {
                            var210 = new double[2] {0.0, 1.0};
                        } else {
                            var210 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 0.43870341777801514) {
                            var210 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 0.9601362012326717) {
                                var210 = new double[2] {0.0, 1.0};
                            } else {
                                var210 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var210 = new double[2] {0.8, 0.2};
                }
            } else {
                if (input[0] <= 0.876292273402214) {
                    var210 = new double[2] {0.9090909090909091, 0.09090909090909091};
                } else {
                    var210 = new double[2] {0.5, 0.5};
                }
            }
            double[] var211;
            if (input[4] <= 1.8199918866157532) {
                if (input[1] <= 2.4045716524124146) {
                    if (input[5] <= 2.5101007223129272) {
                        if (input[2] <= 2.175404667854309) {
                            var211 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 0.5606600046157837) {
                                if (input[1] <= -1.3619022369384766) {
                                    var211 = new double[2] {1.0, 0.0};
                                } else {
                                    var211 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var211 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var211 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var211 = new double[2] {1.0, 0.0};
                }
            } else {
                var211 = new double[2] {1.0, 0.0};
            }
            double[] var212;
            if (input[5] <= 1.0937937498092651) {
                if (input[2] <= 0.43158040940761566) {
                    var212 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= -0.5289958864450455) {
                        var212 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 1.3593424260616302) {
                            if (input[1] <= 1.512775480747223) {
                                var212 = new double[2] {0.0, 1.0};
                            } else {
                                var212 = new double[2] {0.8571428571428571, 0.14285714285714285};
                            }
                        } else {
                            var212 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var212 = new double[2] {0.16666666666666666, 0.8333333333333334};
                } else {
                    var212 = new double[2] {0.9230769230769231, 0.07692307692307693};
                }
            }
            double[] var213;
            if (input[5] <= 1.0937937498092651) {
                if (input[4] <= 2.2004266381263733) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[4] <= 1.7611917853355408) {
                            if (input[5] <= 0.6243304014205933) {
                                if (input[1] <= -1.4671993851661682) {
                                    if (input[3] <= 0.37494900822639465) {
                                        var213 = new double[2] {0.0, 1.0};
                                    } else {
                                        var213 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var213 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var213 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var213 = new double[2] {0.25, 0.75};
                        }
                    } else {
                        var213 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    var213 = new double[2] {1.0, 0.0};
                }
            } else {
                var213 = new double[2] {0.8181818181818182, 0.18181818181818182};
            }
            double[] var214;
            if (input[1] <= 1.8961734771728516) {
                if (input[5] <= 4.244833946228027) {
                    if (input[5] <= 0.4156590849161148) {
                        if (input[1] <= -1.4646154046058655) {
                            if (input[5] <= -0.22953486442565918) {
                                var214 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            } else {
                                var214 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var214 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= 0.7427063286304474) {
                            if (input[5] <= 1.315471589565277) {
                                var214 = new double[2] {0.0, 1.0};
                            } else {
                                var214 = new double[2] {0.16666666666666666, 0.8333333333333334};
                            }
                        } else {
                            var214 = new double[2] {0.75, 0.25};
                        }
                    }
                } else {
                    var214 = new double[2] {1.0, 0.0};
                }
            } else {
                var214 = new double[2] {0.8888888888888888, 0.1111111111111111};
            }
            double[] var215;
            if (input[3] <= 0.777857780456543) {
                if (input[1] <= 2.1171037554740906) {
                    if (input[4] <= 1.7611917853355408) {
                        var215 = new double[2] {0.0, 1.0};
                    } else {
                        var215 = new double[2] {0.8571428571428571, 0.14285714285714285};
                    }
                } else {
                    var215 = new double[2] {0.875, 0.125};
                }
            } else {
                if (input[4] <= -0.26204634085297585) {
                    var215 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    var215 = new double[2] {1.0, 0.0};
                }
            }
            double[] var216;
            if (input[2] <= 1.2381677031517029) {
                if (input[2] <= 0.40715569257736206) {
                    var216 = new double[2] {0.0, 1.0};
                } else {
                    var216 = new double[2] {0.16666666666666666, 0.8333333333333334};
                }
            } else {
                if (input[1] <= 1.5263413786888123) {
                    if (input[1] <= -0.4633232057094574) {
                        if (input[5] <= 1.2801275551319122) {
                            var216 = new double[2] {0.16666666666666666, 0.8333333333333334};
                        } else {
                            var216 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 1.2437467575073242) {
                            if (input[4] <= 1.3593424260616302) {
                                var216 = new double[2] {0.0, 1.0};
                            } else {
                                var216 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var216 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var216 = new double[2] {0.9, 0.1};
                }
            }
            double[] var217;
            if (input[4] <= 1.8199918866157532) {
                if (input[3] <= 1.5816310048103333) {
                    if (input[3] <= 0.1634063497185707) {
                        if (input[1] <= 2.1216257214546204) {
                            if (input[5] <= -0.157574363052845) {
                                var217 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 1.7465029954910278) {
                                    var217 = new double[2] {0.0, 1.0};
                                } else {
                                    var217 = new double[2] {0.5, 0.5};
                                }
                            }
                        } else {
                            var217 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 2.4149075746536255) {
                            if (input[4] <= 1.6196352243423462) {
                                if (input[4] <= 0.03569938801229) {
                                    var217 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= 0.06779874674975872) {
                                        var217 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.17860542237758636) {
                                            var217 = new double[2] {1.0, 0.0};
                                        } else {
                                            var217 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var217 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var217 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var217 = new double[2] {1.0, 0.0};
                }
            } else {
                var217 = new double[2] {1.0, 0.0};
            }
            double[] var218;
            if (input[1] <= 1.790553331375122) {
                if (input[3] <= 3.6247063875198364) {
                    if (input[4] <= 1.8199918866157532) {
                        if (input[2] <= 2.175404667854309) {
                            var218 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 1.4362176060676575) {
                                if (input[4] <= 0.05114172212779522) {
                                    var218 = new double[2] {0.0, 1.0};
                                } else {
                                    var218 = new double[2] {0.75, 0.25};
                                }
                            } else {
                                var218 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var218 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var218 = new double[2] {1.0, 0.0};
                }
            } else {
                var218 = new double[2] {1.0, 0.0};
            }
            double[] var219;
            if (input[3] <= 0.7842573821544647) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[3] <= 0.379926472902298) {
                        if (input[5] <= 0.4007203280925751) {
                            if (input[2] <= 0.2773258090019226) {
                                var219 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.790553331375122) {
                                    if (input[2] <= 2.171961545944214) {
                                        var219 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= -0.3299857974052429) {
                                            var219 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                        } else {
                                            var219 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var219 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var219 = new double[2] {0.6, 0.4};
                        }
                    } else {
                        if (input[5] <= 0.21151183545589447) {
                            var219 = new double[2] {0.5714285714285714, 0.42857142857142855};
                        } else {
                            var219 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var219 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            } else {
                if (input[5] <= 1.144736260175705) {
                    var219 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 2.853314995765686) {
                        var219 = new double[2] {0.7142857142857143, 0.2857142857142857};
                    } else {
                        var219 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var220;
            if (input[4] <= 1.7611917853355408) {
                if (input[2] <= 1.9892690777778625) {
                    if (input[1] <= -2.0456879138946533) {
                        var220 = new double[2] {1.0, 0.0};
                    } else {
                        var220 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[3] <= 0.7842573821544647) {
                        if (input[4] <= -0.06348920799791813) {
                            if (input[4] <= -1.4068822264671326) {
                                var220 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -0.8132353127002716) {
                                    var220 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                } else {
                                    var220 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var220 = new double[2] {0.5, 0.5};
                        }
                    } else {
                        var220 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var220 = new double[2] {0.875, 0.125};
            }
            double[] var221;
            if (input[3] <= 0.7842573821544647) {
                if (input[3] <= 0.30695316195487976) {
                    if (input[5] <= 0.4007203280925751) {
                        if (input[2] <= 0.4325118213891983) {
                            var221 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.07911055721342564) {
                                if (input[1] <= 1.790553331375122) {
                                    var221 = new double[2] {0.0, 1.0};
                                } else {
                                    var221 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var221 = new double[2] {0.36363636363636365, 0.6363636363636364};
                            }
                        }
                    } else {
                        var221 = new double[2] {0.6363636363636364, 0.36363636363636365};
                    }
                } else {
                    if (input[4] <= -0.11199815385043621) {
                        if (input[3] <= 0.3093530088663101) {
                            var221 = new double[2] {0.5, 0.5};
                        } else {
                            var221 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var221 = new double[2] {0.4444444444444444, 0.5555555555555556};
                    }
                }
            } else {
                if (input[2] <= 1.636903703212738) {
                    var221 = new double[2] {0.0, 1.0};
                } else {
                    var221 = new double[2] {1.0, 0.0};
                }
            }
            double[] var222;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[5] <= 0.3960549235343933) {
                        if (input[5] <= -0.157574363052845) {
                            var222 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 1.7600783109664917) {
                                var222 = new double[2] {0.0, 1.0};
                            } else {
                                var222 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var222 = new double[2] {0.4, 0.6};
                    }
                } else {
                    var222 = new double[2] {0.9, 0.1};
                }
            } else {
                if (input[2] <= 1.5807727575302124) {
                    var222 = new double[2] {0.75, 0.25};
                } else {
                    if (input[3] <= 0.5473829507827759) {
                        var222 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    } else {
                        var222 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var223;
            if (input[5] <= 0.9808341264724731) {
                if (input[2] <= 0.40715569257736206) {
                    var223 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.5208013206720352) {
                        var223 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[1] <= -1.3619022369384766) {
                                var223 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= 1.4927335679531097) {
                                    var223 = new double[2] {0.0, 1.0};
                                } else {
                                    var223 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= 2.1532992124557495) {
                                var223 = new double[2] {0.0, 1.0};
                            } else {
                                var223 = new double[2] {0.46153846153846156, 0.5384615384615384};
                            }
                        }
                    }
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var223 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 0.6864855885505676) {
                        var223 = new double[2] {0.4, 0.6};
                    } else {
                        var223 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var224;
            if (input[4] <= 1.7611917853355408) {
                if (input[3] <= 1.7416212558746338) {
                    if (input[1] <= 2.1171037554740906) {
                        if (input[4] <= 1.6456498503684998) {
                            var224 = new double[2] {0.0, 1.0};
                        } else {
                            var224 = new double[2] {0.06666666666666667, 0.9333333333333333};
                        }
                    } else {
                        var224 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var224 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            } else {
                var224 = new double[2] {0.9230769230769231, 0.07692307692307693};
            }
            double[] var225;
            if (input[1] <= 1.5263413786888123) {
                if (input[3] <= 0.379926472902298) {
                    if (input[2] <= 0.43158040940761566) {
                        var225 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 1.4407605528831482) {
                            var225 = new double[2] {0.0, 1.0};
                        } else {
                            var225 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[5] <= 0.21151183545589447) {
                        var225 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 1.068716138601303) {
                            if (input[3] <= 1.5816310048103333) {
                                var225 = new double[2] {0.0, 1.0};
                            } else {
                                var225 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var225 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var225 = new double[2] {0.9166666666666666, 0.08333333333333333};
            }
            double[] var226;
            if (input[3] <= 1.5816310048103333) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[4] <= 1.7600333094596863) {
                        if (input[3] <= 0.37494900822639465) {
                            var226 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= -0.08024745993316174) {
                                var226 = new double[2] {0.0, 1.0};
                            } else {
                                var226 = new double[2] {0.8, 0.2};
                            }
                        }
                    } else {
                        var226 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var226 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            } else {
                var226 = new double[2] {0.7647058823529411, 0.23529411764705882};
            }
            double[] var227;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[2] <= 2.1580482721328735) {
                            var227 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= 0.876292273402214) {
                                if (input[0] <= -0.3421141058206558) {
                                    if (input[4] <= 1.1713238656520844) {
                                        if (input[4] <= 0.05114172212779522) {
                                            var227 = new double[2] {0.0, 1.0};
                                        } else {
                                            var227 = new double[2] {0.2222222222222222, 0.7777777777777778};
                                        }
                                    } else {
                                        var227 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var227 = new double[2] {0.2222222222222222, 0.7777777777777778};
                                }
                            } else {
                                var227 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var227 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var227 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var227 = new double[2] {0.0, 1.0};
                } else {
                    var227 = new double[2] {0.8, 0.2};
                }
            }
            double[] var228;
            if (input[4] <= 1.8059442043304443) {
                if (input[5] <= 0.9808341264724731) {
                    if (input[2] <= 2.175404667854309) {
                        var228 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.512775480747223) {
                            if (input[1] <= -1.2107393741607666) {
                                var228 = new double[2] {1.0, 0.0};
                            } else {
                                var228 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var228 = new double[2] {0.8571428571428571, 0.14285714285714285};
                        }
                    }
                } else {
                    var228 = new double[2] {0.7692307692307693, 0.23076923076923078};
                }
            } else {
                var228 = new double[2] {1.0, 0.0};
            }
            double[] var229;
            if (input[5] <= 3.5527032613754272) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[2] <= 0.9300557971000671) {
                        var229 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -1.36287122964859) {
                            var229 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.7532561421394348) {
                                if (input[5] <= 1.4536904096603394) {
                                    var229 = new double[2] {0.0, 1.0};
                                } else {
                                    var229 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var229 = new double[2] {0.8333333333333334, 0.16666666666666666};
                            }
                        }
                    }
                } else {
                    var229 = new double[2] {1.0, 0.0};
                }
            } else {
                var229 = new double[2] {1.0, 0.0};
            }
            double[] var230;
            if (input[1] <= 1.8961734771728516) {
                if (input[5] <= 1.273577094078064) {
                    if (input[5] <= 0.45364217460155487) {
                        if (input[4] <= 1.9211599230766296) {
                            if (input[2] <= 2.175404667854309) {
                                var230 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.2566050291061401) {
                                    var230 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[1] <= 0.2385503575205803) {
                                        var230 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[4] <= 1.002549171447754) {
                                            var230 = new double[2] {0.0, 1.0};
                                        } else {
                                            var230 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var230 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var230 = new double[2] {0.25, 0.75};
                    }
                } else {
                    var230 = new double[2] {0.8, 0.2};
                }
            } else {
                var230 = new double[2] {0.875, 0.125};
            }
            double[] var231;
            if (input[4] <= 1.8199918866157532) {
                if (input[3] <= 3.6247063875198364) {
                    if (input[2] <= 2.066565155982971) {
                        var231 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[3] <= 0.777857780456543) {
                                var231 = new double[2] {0.0, 1.0};
                            } else {
                                var231 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= -0.11199815385043621) {
                                if (input[1] <= 2.0550883412361145) {
                                    var231 = new double[2] {0.0, 1.0};
                                } else {
                                    var231 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var231 = new double[2] {0.8333333333333334, 0.16666666666666666};
                            }
                        }
                    }
                } else {
                    var231 = new double[2] {1.0, 0.0};
                }
            } else {
                var231 = new double[2] {1.0, 0.0};
            }
            double[] var232;
            if (input[1] <= 1.8961734771728516) {
                if (input[5] <= 4.369763493537903) {
                    if (input[1] <= -1.4827032685279846) {
                        if (input[1] <= -1.483995258808136) {
                            var232 = new double[2] {0.0, 1.0};
                        } else {
                            var232 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 1.5816310048103333) {
                            if (input[5] <= 0.45364217460155487) {
                                if (input[2] <= 2.175404667854309) {
                                    var232 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= -0.38331587612628937) {
                                        var232 = new double[2] {0.5, 0.5};
                                    } else {
                                        var232 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var232 = new double[2] {0.08333333333333333, 0.9166666666666666};
                            }
                        } else {
                            var232 = new double[2] {0.5, 0.5};
                        }
                    }
                } else {
                    var232 = new double[2] {1.0, 0.0};
                }
            } else {
                var232 = new double[2] {0.8666666666666667, 0.13333333333333333};
            }
            double[] var233;
            if (input[4] <= 1.7611917853355408) {
                if (input[3] <= 1.9727182388305664) {
                    if (input[2] <= 2.175404667854309) {
                        var233 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.7842573821544647) {
                            if (input[1] <= 2.12840873003006) {
                                if (input[4] <= -0.08024745993316174) {
                                    var233 = new double[2] {0.0, 1.0};
                                } else {
                                    var233 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var233 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var233 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var233 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                var233 = new double[2] {0.9166666666666666, 0.08333333333333333};
            }
            double[] var234;
            if (input[2] <= 0.9300557971000671) {
                var234 = new double[2] {0.0, 1.0};
            } else {
                if (input[1] <= 2.0447524189949036) {
                    if (input[4] <= 1.150134265422821) {
                        if (input[3] <= 4.546605706214905) {
                            if (input[5] <= 0.5814462602138519) {
                                var234 = new double[2] {0.0, 1.0};
                            } else {
                                var234 = new double[2] {0.18181818181818182, 0.8181818181818182};
                            }
                        } else {
                            var234 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var234 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var234 = new double[2] {1.0, 0.0};
                }
            }
            double[] var235;
            if (input[2] <= 2.175404667854309) {
                if (input[1] <= -2.050532877445221) {
                    var235 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 2.034778654575348) {
                        var235 = new double[2] {0.0, 1.0};
                    } else {
                        var235 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[0] <= 0.876292273402214) {
                    if (input[5] <= 0.9808341264724731) {
                        if (input[1] <= 1.8916515111923218) {
                            if (input[4] <= 1.002549171447754) {
                                var235 = new double[2] {0.0, 1.0};
                            } else {
                                var235 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var235 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var235 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var235 = new double[2] {0.5384615384615384, 0.46153846153846156};
                }
            }
            double[] var236;
            if (input[4] <= 1.8199918866157532) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[4] <= 1.7600783109664917) {
                        if (input[3] <= 3.6247063875198364) {
                            if (input[5] <= 0.5814462602138519) {
                                if (input[1] <= -1.4827032685279846) {
                                    if (input[2] <= 0.9395709484815598) {
                                        var236 = new double[2] {0.0, 1.0};
                                    } else {
                                        var236 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var236 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[0] <= -0.3421141058206558) {
                                    var236 = new double[2] {0.0, 1.0};
                                } else {
                                    var236 = new double[2] {0.5714285714285714, 0.42857142857142855};
                                }
                            }
                        } else {
                            var236 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var236 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    var236 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            } else {
                var236 = new double[2] {1.0, 0.0};
            }
            double[] var237;
            if (input[4] <= 1.8199918866157532) {
                if (input[3] <= 1.8571697473526) {
                    if (input[1] <= 2.230798900127411) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[5] <= 0.6243304014205933) {
                                if (input[2] <= 2.171961545944214) {
                                    var237 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= 0.4827364534139633) {
                                        var237 = new double[2] {0.14285714285714285, 0.8571428571428571};
                                    } else {
                                        var237 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var237 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            }
                        } else {
                            if (input[5] <= -0.12962899915874004) {
                                var237 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= 1.273577094078064) {
                                    var237 = new double[2] {0.0, 1.0};
                                } else {
                                    var237 = new double[2] {0.25, 0.75};
                                }
                            }
                        }
                    } else {
                        var237 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var237 = new double[2] {0.9230769230769231, 0.07692307692307693};
                }
            } else {
                var237 = new double[2] {1.0, 0.0};
            }
            double[] var238;
            if (input[3] <= 0.7842573821544647) {
                if (input[2] <= 0.27639439702033997) {
                    var238 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.5662268549203873) {
                        var238 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 1.165518581867218) {
                            if (input[5] <= -0.3212409019470215) {
                                var238 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 1.418333739042282) {
                                    if (input[0] <= -0.3421141058206558) {
                                        var238 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= 2.2685896158218384) {
                                            var238 = new double[2] {0.0, 1.0};
                                        } else {
                                            var238 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var238 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var238 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[3] <= 2.440600872039795) {
                    var238 = new double[2] {0.9285714285714286, 0.07142857142857142};
                } else {
                    var238 = new double[2] {0.2857142857142857, 0.7142857142857143};
                }
            }
            double[] var239;
            if (input[2] <= 1.4859262704849243) {
                if (input[3] <= 0.41690200567245483) {
                    if (input[3] <= -0.562682718038559) {
                        if (input[4] <= 2.088450014591217) {
                            var239 = new double[2] {0.0, 1.0};
                        } else {
                            var239 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var239 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var239 = new double[2] {0.5, 0.5};
                }
            } else {
                if (input[5] <= 0.9808341264724731) {
                    if (input[5] <= -0.22731996327638626) {
                        var239 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.5374759435653687) {
                            var239 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= -0.12684859335422516) {
                                var239 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            } else {
                                if (input[0] <= 0.876292273402214) {
                                    if (input[4] <= 0.5606600046157837) {
                                        var239 = new double[2] {0.0, 1.0};
                                    } else {
                                        var239 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                    }
                                } else {
                                    var239 = new double[2] {0.6666666666666666, 0.3333333333333333};
                                }
                            }
                        }
                    }
                } else {
                    if (input[3] <= 3.6247063875198364) {
                        var239 = new double[2] {0.7692307692307693, 0.23076923076923078};
                    } else {
                        var239 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var240;
            if (input[5] <= 1.165518581867218) {
                if (input[5] <= -0.7569624483585358) {
                    if (input[3] <= -0.42944639921188354) {
                        var240 = new double[2] {0.0, 1.0};
                    } else {
                        var240 = new double[2] {0.5714285714285714, 0.42857142857142855};
                    }
                } else {
                    if (input[1] <= 2.0848039984703064) {
                        if (input[2] <= 0.43158040940761566) {
                            var240 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= -0.5066861361265182) {
                                var240 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.36287122964859) {
                                    var240 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[5] <= 0.34987202286720276) {
                                        var240 = new double[2] {0.0, 1.0};
                                    } else {
                                        var240 = new double[2] {0.13333333333333333, 0.8666666666666667};
                                    }
                                }
                            }
                        }
                    } else {
                        var240 = new double[2] {0.8, 0.2};
                    }
                }
            } else {
                if (input[1] <= -0.8195894360542297) {
                    var240 = new double[2] {0.5, 0.5};
                } else {
                    var240 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            }
            double[] var241;
            if (input[3] <= 0.3589499741792679) {
                if (input[1] <= 1.512775480747223) {
                    if (input[5] <= 1.2345573008060455) {
                        if (input[5] <= 0.43870341777801514) {
                            var241 = new double[2] {0.0, 1.0};
                        } else {
                            var241 = new double[2] {0.25, 0.75};
                        }
                    } else {
                        var241 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var241 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var241 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 0.5473829507827759) {
                        var241 = new double[2] {0.5555555555555556, 0.4444444444444444};
                    } else {
                        var241 = new double[2] {0.8571428571428571, 0.14285714285714285};
                    }
                }
            }
            double[] var242;
            if (input[5] <= 0.9808341264724731) {
                if (input[5] <= 0.45364217460155487) {
                    if (input[4] <= 1.7600333094596863) {
                        if (input[2] <= 2.171961545944214) {
                            var242 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.8916515111923218) {
                                if (input[0] <= -0.3421141058206558) {
                                    var242 = new double[2] {0.1, 0.9};
                                } else {
                                    var242 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var242 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var242 = new double[2] {0.8, 0.2};
                    }
                } else {
                    if (input[5] <= 0.5452068448066711) {
                        var242 = new double[2] {1.0, 0.0};
                    } else {
                        var242 = new double[2] {0.07142857142857142, 0.9285714285714286};
                    }
                }
            } else {
                if (input[3] <= 0.5473829507827759) {
                    var242 = new double[2] {0.0, 1.0};
                } else {
                    var242 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            }
            double[] var243;
            if (input[5] <= 1.273577094078064) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 0.43158040940761566) {
                        var243 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.38802669942379) {
                            var243 = new double[2] {0.5, 0.5};
                        } else {
                            if (input[5] <= 0.43870341777801514) {
                                var243 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.7294346988201141) {
                                    var243 = new double[2] {0.0, 1.0};
                                } else {
                                    var243 = new double[2] {0.75, 0.25};
                                }
                            }
                        }
                    }
                } else {
                    var243 = new double[2] {0.9166666666666666, 0.08333333333333333};
                }
            } else {
                if (input[4] <= -0.38663099706172943) {
                    var243 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -0.46687617897987366) {
                        var243 = new double[2] {1.0, 0.0};
                    } else {
                        var243 = new double[2] {0.75, 0.25};
                    }
                }
            }
            double[] var244;
            if (input[2] <= 0.9300557971000671) {
                var244 = new double[2] {0.0, 1.0};
            } else {
                if (input[1] <= 2.4149075746536255) {
                    if (input[5] <= 1.26872318983078) {
                        if (input[2] <= 1.0061759054660797) {
                            var244 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.05114172212779522) {
                                var244 = new double[2] {0.0, 1.0};
                            } else {
                                var244 = new double[2] {0.6363636363636364, 0.36363636363636365};
                            }
                        }
                    } else {
                        if (input[5] <= 3.5527032613754272) {
                            var244 = new double[2] {0.625, 0.375};
                        } else {
                            var244 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var244 = new double[2] {1.0, 0.0};
                }
            }
            double[] var245;
            if (input[4] <= 1.9012749791145325) {
                if (input[3] <= 1.1131262183189392) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[1] <= 0.3422325551509857) {
                            var245 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= 2.171961545944214) {
                                var245 = new double[2] {0.0, 1.0};
                            } else {
                                var245 = new double[2] {0.13333333333333333, 0.8666666666666667};
                            }
                        }
                    } else {
                        var245 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var245 = new double[2] {0.5714285714285714, 0.42857142857142855};
                }
            } else {
                var245 = new double[2] {1.0, 0.0};
            }
            double[] var246;
            if (input[2] <= 0.43158040940761566) {
                var246 = new double[2] {0.0, 1.0};
            } else {
                if (input[2] <= 0.5154676288366318) {
                    var246 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 2.0848039984703064) {
                        if (input[3] <= 3.702746033668518) {
                            if (input[3] <= 0.777857780456543) {
                                if (input[4] <= 0.7294346988201141) {
                                    if (input[4] <= 0.042278969660401344) {
                                        var246 = new double[2] {0.0, 1.0};
                                    } else {
                                        var246 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                    }
                                } else {
                                    var246 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var246 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var246 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var246 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var247;
            if (input[1] <= 2.4149075746536255) {
                if (input[5] <= 1.273577094078064) {
                    if (input[4] <= 1.7600783109664917) {
                        if (input[1] <= 1.512775480747223) {
                            if (input[3] <= 0.379926472902298) {
                                var247 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.42614588141441345) {
                                    var247 = new double[2] {1.0, 0.0};
                                } else {
                                    var247 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var247 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var247 = new double[2] {0.875, 0.125};
                    }
                } else {
                    if (input[4] <= 0.5534618198871613) {
                        var247 = new double[2] {1.0, 0.0};
                    } else {
                        var247 = new double[2] {0.7142857142857143, 0.2857142857142857};
                    }
                }
            } else {
                var247 = new double[2] {1.0, 0.0};
            }
            double[] var248;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[4] <= 1.9211599230766296) {
                            var248 = new double[2] {0.0, 1.0};
                        } else {
                            var248 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var248 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    var248 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -1.3192665576934814) {
                    var248 = new double[2] {0.0, 1.0};
                } else {
                    var248 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            }
            double[] var249;
            if (input[1] <= 2.4045716524124146) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[5] <= 1.315471589565277) {
                        if (input[1] <= -1.4827032685279846) {
                            if (input[5] <= -0.20573653280735016) {
                                var249 = new double[2] {0.16666666666666666, 0.8333333333333334};
                            } else {
                                var249 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[4] <= 1.7611917853355408) {
                                var249 = new double[2] {0.0, 1.0};
                            } else {
                                var249 = new double[2] {0.4, 0.6};
                            }
                        }
                    } else {
                        var249 = new double[2] {0.8888888888888888, 0.1111111111111111};
                    }
                } else {
                    var249 = new double[2] {1.0, 0.0};
                }
            } else {
                var249 = new double[2] {1.0, 0.0};
            }
            double[] var250;
            if (input[1] <= 2.1216257214546204) {
                if (input[5] <= 1.273577094078064) {
                    if (input[4] <= 1.7600783109664917) {
                        if (input[5] <= -0.23990245163440704) {
                            if (input[3] <= 0.3725491464138031) {
                                var250 = new double[2] {0.0, 1.0};
                            } else {
                                var250 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var250 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var250 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= -0.3851238787174225) {
                        var250 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.6334203481674194) {
                            var250 = new double[2] {0.25, 0.75};
                        } else {
                            var250 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var250 = new double[2] {1.0, 0.0};
            }
            double[] var251;
            if (input[5] <= 0.9428510367870331) {
                if (input[2] <= 2.171961545944214) {
                    if (input[5] <= 0.4139154553413391) {
                        if (input[3] <= 0.49405285716056824) {
                            var251 = new double[2] {0.0, 1.0};
                        } else {
                            var251 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var251 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    }
                } else {
                    if (input[0] <= -0.3421141058206558) {
                        if (input[4] <= 1.002549171447754) {
                            var251 = new double[2] {0.0, 1.0};
                        } else {
                            var251 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= -0.15479647740721703) {
                            var251 = new double[2] {0.0, 1.0};
                        } else {
                            var251 = new double[2] {0.4375, 0.5625};
                        }
                    }
                }
            } else {
                if (input[3] <= 1.1131262183189392) {
                    var251 = new double[2] {0.25, 0.75};
                } else {
                    if (input[2] <= 0.9859141409397125) {
                        var251 = new double[2] {0.0, 1.0};
                    } else {
                        var251 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var252;
            if (input[4] <= 1.9012749791145325) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[3] <= 1.7416212558746338) {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[5] <= -0.23801743984222412) {
                                if (input[4] <= 0.05178280919790268) {
                                    var252 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= 0.2165310252457857) {
                                        var252 = new double[2] {1.0, 0.0};
                                    } else {
                                        var252 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var252 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= 2.1532992124557495) {
                                var252 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.461741864681244) {
                                    var252 = new double[2] {0.0, 1.0};
                                } else {
                                    var252 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var252 = new double[2] {0.8888888888888888, 0.1111111111111111};
                    }
                } else {
                    var252 = new double[2] {0.4, 0.6};
                }
            } else {
                var252 = new double[2] {1.0, 0.0};
            }
            double[] var253;
            if (input[3] <= 1.0039772987365723) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[1] <= 2.1171037554740906) {
                        if (input[4] <= 1.7611917853355408) {
                            if (input[3] <= 0.1634063497185707) {
                                var253 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.1669616922736168) {
                                    var253 = new double[2] {1.0, 0.0};
                                } else {
                                    var253 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var253 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var253 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var253 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 2.394124984741211) {
                    var253 = new double[2] {1.0, 0.0};
                } else {
                    var253 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            }
            double[] var254;
            if (input[1] <= 1.8961734771728516) {
                if (input[3] <= 1.5816310048103333) {
                    if (input[1] <= -1.4827032685279846) {
                        if (input[4] <= 0.12759982980787754) {
                            var254 = new double[2] {0.1111111111111111, 0.8888888888888888};
                        } else {
                            var254 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= 0.659739077091217) {
                            if (input[4] <= 2.169182062149048) {
                                if (input[3] <= 0.7842573821544647) {
                                    var254 = new double[2] {0.0, 1.0};
                                } else {
                                    var254 = new double[2] {0.25, 0.75};
                                }
                            } else {
                                var254 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var254 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var254 = new double[2] {1.0, 0.0};
                }
            } else {
                var254 = new double[2] {0.8333333333333334, 0.16666666666666666};
            }
            double[] var255;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.8934694528579712) {
                    if (input[3] <= 0.1634063497185707) {
                        if (input[1] <= 1.8916515111923218) {
                            var255 = new double[2] {0.0, 1.0};
                        } else {
                            var255 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 0.1669616922736168) {
                            var255 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= 1.8917299509048462) {
                                var255 = new double[2] {0.0, 1.0};
                            } else {
                                var255 = new double[2] {0.125, 0.875};
                            }
                        }
                    }
                } else {
                    var255 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.38663099706172943) {
                    var255 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 1.6334203481674194) {
                        var255 = new double[2] {0.0, 1.0};
                    } else {
                        var255 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var256;
            if (input[5] <= 0.9428510367870331) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[2] <= 2.175404667854309) {
                        var256 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 2.0550883412361145) {
                            if (input[3] <= 0.14740732312202454) {
                                var256 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.1890936717391014) {
                                    var256 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[4] <= 0.05114172212779522) {
                                        var256 = new double[2] {0.0, 1.0};
                                    } else {
                                        var256 = new double[2] {0.5, 0.5};
                                    }
                                }
                            }
                        } else {
                            var256 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var256 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                if (input[2] <= 1.8288052678108215) {
                    var256 = new double[2] {0.4, 0.6};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        var256 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    } else {
                        var256 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var257;
            if (input[3] <= 0.7842573821544647) {
                if (input[2] <= 2.175404667854309) {
                    if (input[5] <= 0.4139154553413391) {
                        if (input[4] <= 2.226238787174225) {
                            var257 = new double[2] {0.0, 1.0};
                        } else {
                            var257 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var257 = new double[2] {0.25, 0.75};
                    }
                } else {
                    if (input[4] <= -1.380721390247345) {
                        var257 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 1.055810660123825) {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[5] <= -0.16902583837509155) {
                                    var257 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                } else {
                                    var257 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var257 = new double[2] {0.42857142857142855, 0.5714285714285714};
                            }
                        } else {
                            var257 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[5] <= 3.5527032613754272) {
                    var257 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    var257 = new double[2] {1.0, 0.0};
                }
            }
            double[] var258;
            if (input[2] <= 0.9080190658569336) {
                var258 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 1.2796676754951477) {
                    if (input[2] <= 2.171961545944214) {
                        var258 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 0.9808341264724731) {
                            if (input[0] <= -0.3421141058206558) {
                                var258 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.40516938269138336) {
                                    if (input[1] <= 2.011483609676361) {
                                        var258 = new double[2] {0.1111111111111111, 0.8888888888888888};
                                    } else {
                                        var258 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var258 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var258 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var258 = new double[2] {1.0, 0.0};
                }
            }
            double[] var259;
            if (input[1] <= 2.4045716524124146) {
                if (input[3] <= 1.5816310048103333) {
                    if (input[5] <= 3.2119393348693848) {
                        if (input[5] <= 0.42885421216487885) {
                            if (input[4] <= 1.7600783109664917) {
                                if (input[1] <= 2.1171037554740906) {
                                    var259 = new double[2] {0.0, 1.0};
                                } else {
                                    var259 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var259 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            if (input[5] <= 0.488090842962265) {
                                var259 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= 1.9080232381820679) {
                                    var259 = new double[2] {0.0, 1.0};
                                } else {
                                    var259 = new double[2] {0.25, 0.75};
                                }
                            }
                        }
                    } else {
                        var259 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var259 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            } else {
                var259 = new double[2] {1.0, 0.0};
            }
            double[] var260;
            if (input[3] <= 1.7416212558746338) {
                if (input[5] <= 1.118770182132721) {
                    if (input[3] <= 0.49405285716056824) {
                        if (input[3] <= 0.014615420252084732) {
                            if (input[4] <= 1.7600783109664917) {
                                if (input[3] <= -0.1068882867693901) {
                                    var260 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.8186227083206177) {
                                        var260 = new double[2] {0.2857142857142857, 0.7142857142857143};
                                    } else {
                                        var260 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var260 = new double[2] {0.8571428571428571, 0.14285714285714285};
                            }
                        } else {
                            var260 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var260 = new double[2] {0.08333333333333333, 0.9166666666666666};
                    }
                } else {
                    var260 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var260 = new double[2] {0.2, 0.8};
                } else {
                    var260 = new double[2] {1.0, 0.0};
                }
            }
            double[] var261;
            if (input[4] <= 1.8199918866157532) {
                if (input[5] <= 1.165518581867218) {
                    if (input[4] <= -0.8169131278991699) {
                        if (input[3] <= 0.2995758205652237) {
                            if (input[4] <= -0.8207821547985077) {
                                if (input[2] <= 2.175404667854309) {
                                    var261 = new double[2] {0.0, 1.0};
                                } else {
                                    var261 = new double[2] {0.1, 0.9};
                                }
                            } else {
                                var261 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var261 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        if (input[4] <= 0.05178280919790268) {
                            var261 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.4947826415300369) {
                                if (input[2] <= 1.5262488424777985) {
                                    var261 = new double[2] {0.0, 1.0};
                                } else {
                                    var261 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var261 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        }
                    }
                } else {
                    var261 = new double[2] {0.7142857142857143, 0.2857142857142857};
                }
            } else {
                var261 = new double[2] {1.0, 0.0};
            }
            double[] var262;
            if (input[2] <= 0.9300557971000671) {
                if (input[5] <= -0.7553130388259888) {
                    var262 = new double[2] {0.08333333333333333, 0.9166666666666666};
                } else {
                    var262 = new double[2] {0.0, 1.0};
                }
            } else {
                if (input[4] <= 1.2796676754951477) {
                    if (input[1] <= 2.0848039984703064) {
                        if (input[3] <= 1.7270443439483643) {
                            var262 = new double[2] {0.0, 1.0};
                        } else {
                            var262 = new double[2] {0.875, 0.125};
                        }
                    } else {
                        var262 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var262 = new double[2] {1.0, 0.0};
                }
            }
            double[] var263;
            if (input[5] <= 0.9428510367870331) {
                if (input[1] <= 1.4950106143951416) {
                    if (input[2] <= 0.43158040940761566) {
                        var263 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 1.5741516947746277) {
                            if (input[5] <= -0.21577424556016922) {
                                if (input[3] <= 0.2661556340754032) {
                                    var263 = new double[2] {0.0, 1.0};
                                } else {
                                    var263 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var263 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var263 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var263 = new double[2] {0.6428571428571429, 0.35714285714285715};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var263 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 1.5609020590782166) {
                        var263 = new double[2] {1.0, 0.0};
                    } else {
                        var263 = new double[2] {0.75, 0.25};
                    }
                }
            }
            double[] var264;
            if (input[5] <= 1.165518581867218) {
                if (input[3] <= 0.30695316195487976) {
                    if (input[1] <= 1.8961734771728516) {
                        if (input[2] <= 1.4713733792304993) {
                            var264 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.43870341777801514) {
                                if (input[4] <= 0.9165872186422348) {
                                    var264 = new double[2] {0.0, 1.0};
                                } else {
                                    var264 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var264 = new double[2] {0.5, 0.5};
                            }
                        }
                    } else {
                        var264 = new double[2] {0.8, 0.2};
                    }
                } else {
                    if (input[3] <= 0.3093530088663101) {
                        var264 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 1.4927335679531097) {
                            if (input[1] <= 2.7992745637893677) {
                                if (input[0] <= -0.3421141058206558) {
                                    var264 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                } else {
                                    var264 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var264 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var264 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var264 = new double[2] {0.0, 1.0};
                } else {
                    var264 = new double[2] {1.0, 0.0};
                }
            }
            double[] var265;
            if (input[2] <= 2.175404667854309) {
                if (input[4] <= 1.9012749791145325) {
                    if (input[5] <= 3.5527032613754272) {
                        var265 = new double[2] {0.0, 1.0};
                    } else {
                        var265 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var265 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 1.3206691145896912) {
                    if (input[1] <= 2.0848039984703064) {
                        if (input[4] <= 1.1713238656520844) {
                            if (input[1] <= -1.2566050291061401) {
                                var265 = new double[2] {1.0, 0.0};
                            } else {
                                var265 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var265 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var265 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var265 = new double[2] {1.0, 0.0};
                }
            }
            double[] var266;
            if (input[4] <= 1.8059442043304443) {
                if (input[3] <= 1.5816310048103333) {
                    if (input[2] <= 2.066565155982971) {
                        var266 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.4578658938407898) {
                            if (input[2] <= 2.104180693626404) {
                                var266 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.2566050291061401) {
                                    var266 = new double[2] {1.0, 0.0};
                                } else {
                                    var266 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var266 = new double[2] {0.875, 0.125};
                        }
                    }
                } else {
                    var266 = new double[2] {0.9, 0.1};
                }
            } else {
                var266 = new double[2] {1.0, 0.0};
            }
            double[] var267;
            if (input[3] <= 1.0039772987365723) {
                if (input[4] <= 2.226238787174225) {
                    if (input[3] <= 0.1634063497185707) {
                        if (input[4] <= 1.7600783109664917) {
                            if (input[3] <= -0.1068882867693901) {
                                var267 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= -0.9306105375289917) {
                                    if (input[1] <= 2.9520522356033325) {
                                        var267 = new double[2] {0.0, 1.0};
                                    } else {
                                        var267 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var267 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var267 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        if (input[4] <= -1.4517695903778076) {
                            var267 = new double[2] {0.4, 0.6};
                        } else {
                            if (input[5] <= -0.015444133430719376) {
                                var267 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[0] <= -0.3421141058206558) {
                                    var267 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= 2.4804760217666626) {
                                        var267 = new double[2] {0.08333333333333333, 0.9166666666666666};
                                    } else {
                                        var267 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var267 = new double[2] {1.0, 0.0};
                }
            } else {
                var267 = new double[2] {0.5555555555555556, 0.4444444444444444};
            }
            double[] var268;
            if (input[2] <= 1.1441072523593903) {
                if (input[5] <= 0.4156590849161148) {
                    var268 = new double[2] {0.0, 1.0};
                } else {
                    var268 = new double[2] {0.5, 0.5};
                }
            } else {
                if (input[3] <= 0.7487040162086487) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[3] <= -0.32323065400123596) {
                            var268 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        } else {
                            if (input[2] <= 1.635317325592041) {
                                var268 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            } else {
                                if (input[5] <= 0.6243304014205933) {
                                    if (input[5] <= -0.06388905085623264) {
                                        var268 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[5] <= -0.04631127417087555) {
                                            var268 = new double[2] {1.0, 0.0};
                                        } else {
                                            var268 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var268 = new double[2] {0.2, 0.8};
                                }
                            }
                        }
                    } else {
                        var268 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var268 = new double[2] {0.9333333333333333, 0.06666666666666667};
                }
            }
            double[] var269;
            if (input[3] <= 0.3589499741792679) {
                if (input[4] <= 1.8059442043304443) {
                    if (input[2] <= 2.1580482721328735) {
                        var269 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.3033207580447197) {
                            var269 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= -1.3347542881965637) {
                                var269 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 0.15629567205905914) {
                                    var269 = new double[2] {0.0, 1.0};
                                } else {
                                    var269 = new double[2] {0.25, 0.75};
                                }
                            }
                        }
                    }
                } else {
                    var269 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 3.2119393348693848) {
                    if (input[3] <= 0.42614588141441345) {
                        var269 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 1.068716138601303) {
                            if (input[2] <= 1.9895713329315186) {
                                var269 = new double[2] {0.0, 1.0};
                            } else {
                                var269 = new double[2] {0.23076923076923078, 0.7692307692307693};
                            }
                        } else {
                            var269 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var269 = new double[2] {1.0, 0.0};
                }
            }
            double[] var270;
            if (input[4] <= 1.7934148907661438) {
                if (input[1] <= 2.0848039984703064) {
                    if (input[5] <= 1.273577094078064) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[5] <= 0.532765731215477) {
                                var270 = new double[2] {0.0, 1.0};
                            } else {
                                var270 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            var270 = new double[2] {0.26666666666666666, 0.7333333333333333};
                        }
                    } else {
                        var270 = new double[2] {0.5714285714285714, 0.42857142857142855};
                    }
                } else {
                    var270 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            } else {
                var270 = new double[2] {1.0, 0.0};
            }
            double[] var271;
            if (input[2] <= 1.481344997882843) {
                if (input[2] <= 0.43158040940761566) {
                    var271 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.8534184098243713) {
                        var271 = new double[2] {0.0, 1.0};
                    } else {
                        var271 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= 1.5263413786888123) {
                    if (input[3] <= 0.7842573821544647) {
                        if (input[2] <= 1.5868470072746277) {
                            var271 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.9976454079151154) {
                                var271 = new double[2] {0.0, 1.0};
                            } else {
                                var271 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= 3.5527032613754272) {
                            var271 = new double[2] {0.42857142857142855, 0.5714285714285714};
                        } else {
                            var271 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var271 = new double[2] {0.9, 0.1};
                }
            }
            double[] var272;
            if (input[5] <= 1.165518581867218) {
                if (input[2] <= 0.4080871045589447) {
                    var272 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 1.0241162478923798) {
                        var272 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    } else {
                        if (input[5] <= -0.179911807179451) {
                            if (input[1] <= -1.3619022369384766) {
                                var272 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -1.4062073826789856) {
                                    var272 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[1] <= 3.2834476828575134) {
                                        var272 = new double[2] {0.0, 1.0};
                                    } else {
                                        var272 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 1.606352299451828) {
                                var272 = new double[2] {0.0, 1.0};
                            } else {
                                var272 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= -0.38663099706172943) {
                    var272 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -0.335093192756176) {
                        var272 = new double[2] {0.875, 0.125};
                    } else {
                        var272 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var273;
            if (input[1] <= 1.8961734771728516) {
                if (input[3] <= 1.1131262183189392) {
                    if (input[4] <= 1.8199918866157532) {
                        if (input[2] <= 2.175404667854309) {
                            var273 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.2566050291061401) {
                                var273 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 1.512775480747223) {
                                    var273 = new double[2] {0.0, 1.0};
                                } else {
                                    var273 = new double[2] {0.6666666666666666, 0.3333333333333333};
                                }
                            }
                        }
                    } else {
                        var273 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 3.6247063875198364) {
                        var273 = new double[2] {0.7777777777777778, 0.2222222222222222};
                    } else {
                        var273 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var273 = new double[2] {0.8888888888888888, 0.1111111111111111};
            }
            double[] var274;
            if (input[2] <= 0.9300557971000671) {
                var274 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 1.165518581867218) {
                    if (input[2] <= 1.0061759054660797) {
                        var274 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 2.0848039984703064) {
                            if (input[4] <= 1.4407605528831482) {
                                var274 = new double[2] {0.0, 1.0};
                            } else {
                                var274 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var274 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[4] <= -0.3699514716863632) {
                        var274 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.8288052678108215) {
                            var274 = new double[2] {0.0, 1.0};
                        } else {
                            var274 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var275;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[2] <= 2.175404667854309) {
                        var275 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.7294346988201141) {
                            if (input[3] <= 0.26020044833421707) {
                                if (input[1] <= 3.163615584373474) {
                                    var275 = new double[2] {0.0, 1.0};
                                } else {
                                    var275 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.40516938269138336) {
                                    var275 = new double[2] {0.75, 0.25};
                                } else {
                                    var275 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var275 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var275 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var275 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    var275 = new double[2] {1.0, 0.0};
                }
            }
            double[] var276;
            if (input[4] <= 1.8199918866157532) {
                if (input[1] <= 2.0848039984703064) {
                    if (input[4] <= -0.3404502123594284) {
                        var276 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.6864855885505676) {
                            if (input[2] <= 2.0431366562843323) {
                                var276 = new double[2] {0.0, 1.0};
                            } else {
                                var276 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            }
                        } else {
                            if (input[5] <= 2.5101007223129272) {
                                var276 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            } else {
                                var276 = new double[2] {0.8888888888888888, 0.1111111111111111};
                            }
                        }
                    }
                } else {
                    var276 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                var276 = new double[2] {1.0, 0.0};
            }
            double[] var277;
            if (input[2] <= 2.060991406440735) {
                if (input[5] <= 2.050910711288452) {
                    if (input[3] <= 0.49405285716056824) {
                        if (input[4] <= 2.212191104888916) {
                            var277 = new double[2] {0.0, 1.0};
                        } else {
                            var277 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var277 = new double[2] {0.25, 0.75};
                    }
                } else {
                    var277 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            } else {
                if (input[2] <= 2.09943163394928) {
                    var277 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 1.512775480747223) {
                        if (input[4] <= -0.40009383857250214) {
                            var277 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.6509321928024292) {
                                var277 = new double[2] {0.4444444444444444, 0.5555555555555556};
                            } else {
                                var277 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var277 = new double[2] {0.9, 0.1};
                    }
                }
            }
            double[] var278;
            if (input[2] <= 0.9300557971000671) {
                if (input[4] <= 2.1863789558410645) {
                    var278 = new double[2] {0.0, 1.0};
                } else {
                    var278 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 1.150134265422821) {
                    if (input[0] <= 0.876292273402214) {
                        if (input[3] <= 3.6247063875198364) {
                            if (input[4] <= 0.09023680537939072) {
                                if (input[1] <= 3.1771814823150635) {
                                    var278 = new double[2] {0.0, 1.0};
                                } else {
                                    var278 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var278 = new double[2] {0.2727272727272727, 0.7272727272727273};
                            }
                        } else {
                            var278 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var278 = new double[2] {0.6, 0.4};
                    }
                } else {
                    var278 = new double[2] {1.0, 0.0};
                }
            }
            double[] var279;
            if (input[1] <= 2.4149075746536255) {
                if (input[5] <= 1.273577094078064) {
                    if (input[1] <= 1.5263413786888123) {
                        if (input[2] <= 0.22094968054443598) {
                            var279 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.36287122964859) {
                                var279 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= 1.4407605528831482) {
                                    var279 = new double[2] {0.0, 1.0};
                                } else {
                                    var279 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var279 = new double[2] {0.375, 0.625};
                    }
                } else {
                    if (input[0] <= -0.3421141058206558) {
                        var279 = new double[2] {1.0, 0.0};
                    } else {
                        var279 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                }
            } else {
                var279 = new double[2] {1.0, 0.0};
            }
            double[] var280;
            if (input[2] <= 0.27639439702033997) {
                var280 = new double[2] {0.0, 1.0};
            } else {
                if (input[1] <= 1.8638737201690674) {
                    if (input[5] <= 1.273577094078064) {
                        if (input[3] <= -0.5016197860240936) {
                            var280 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= 1.0061759054660797) {
                                var280 = new double[2] {0.5, 0.5};
                            } else {
                                if (input[1] <= -1.2107393741607666) {
                                    var280 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[4] <= 1.4407605528831482) {
                                        if (input[4] <= 0.7294346988201141) {
                                            var280 = new double[2] {0.0, 1.0};
                                        } else {
                                            var280 = new double[2] {0.25, 0.75};
                                        }
                                    } else {
                                        var280 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var280 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var280 = new double[2] {1.0, 0.0};
                }
            }
            double[] var281;
            if (input[1] <= 1.8638737201690674) {
                if (input[3] <= 0.777857780456543) {
                    if (input[0] <= 0.876292273402214) {
                        if (input[1] <= 0.14552707970142365) {
                            if (input[2] <= 0.9300557971000671) {
                                var281 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 1.0613042376935482) {
                                    var281 = new double[2] {0.0, 1.0};
                                } else {
                                    var281 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var281 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= 0.6552171111106873) {
                            var281 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.3989766985177994) {
                                var281 = new double[2] {0.0, 1.0};
                            } else {
                                var281 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= 1.636903703212738) {
                        var281 = new double[2] {0.125, 0.875};
                    } else {
                        var281 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var281 = new double[2] {1.0, 0.0};
            }
            double[] var282;
            if (input[3] <= 1.8571697473526) {
                if (input[5] <= 1.165518581867218) {
                    if (input[1] <= 2.0848039984703064) {
                        if (input[2] <= 0.9300557971000671) {
                            var282 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.2511182948946953) {
                                var282 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.12684859335422516) {
                                    var282 = new double[2] {0.8333333333333334, 0.16666666666666666};
                                } else {
                                    if (input[4] <= 1.4927335679531097) {
                                        var282 = new double[2] {0.0, 1.0};
                                    } else {
                                        var282 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var282 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    var282 = new double[2] {0.7142857142857143, 0.2857142857142857};
                }
            } else {
                var282 = new double[2] {1.0, 0.0};
            }
            double[] var283;
            if (input[2] <= 1.2749791145324707) {
                if (input[5] <= 0.4156590849161148) {
                    var283 = new double[2] {0.0, 1.0};
                } else {
                    var283 = new double[2] {0.16666666666666666, 0.8333333333333334};
                }
            } else {
                if (input[3] <= 1.800817608833313) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[4] <= 1.2994626462459564) {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[5] <= -0.18566110730171204) {
                                    if (input[1] <= -1.3619022369384766) {
                                        var283 = new double[2] {1.0, 0.0};
                                    } else {
                                        var283 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var283 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var283 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var283 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var283 = new double[2] {0.8, 0.2};
                    }
                } else {
                    var283 = new double[2] {0.9, 0.1};
                }
            }
            double[] var284;
            if (input[3] <= 0.3589499741792679) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[1] <= 1.5263413786888123) {
                            var284 = new double[2] {0.0, 1.0};
                        } else {
                            var284 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var284 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var284 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            } else {
                if (input[5] <= 1.273577094078064) {
                    if (input[3] <= 0.42614588141441345) {
                        var284 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 2.4045716524124146) {
                            if (input[2] <= 1.2735001742839813) {
                                var284 = new double[2] {1.0, 0.0};
                            } else {
                                var284 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var284 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[2] <= 1.6531969904899597) {
                        var284 = new double[2] {0.0, 1.0};
                    } else {
                        var284 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var285;
            if (input[5] <= 1.118770182132721) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[1] <= -1.4827032685279846) {
                            if (input[1] <= -1.483995258808136) {
                                var285 = new double[2] {0.0, 1.0};
                            } else {
                                var285 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var285 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var285 = new double[2] {0.4, 0.6};
                    }
                } else {
                    var285 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var285 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 2.440600872039795) {
                        var285 = new double[2] {1.0, 0.0};
                    } else {
                        var285 = new double[2] {0.7142857142857143, 0.2857142857142857};
                    }
                }
            }
            double[] var286;
            if (input[3] <= 0.3589499741792679) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[5] <= 0.4947826415300369) {
                        if (input[1] <= 2.226276934146881) {
                            var286 = new double[2] {0.0, 1.0};
                        } else {
                            var286 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var286 = new double[2] {0.42857142857142855, 0.5714285714285714};
                    }
                } else {
                    var286 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            } else {
                if (input[1] <= 2.5424915552139282) {
                    if (input[4] <= 0.05114172212779522) {
                        if (input[3] <= 1.8571697473526) {
                            var286 = new double[2] {0.0, 1.0};
                        } else {
                            var286 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var286 = new double[2] {0.8, 0.2};
                    }
                } else {
                    var286 = new double[2] {1.0, 0.0};
                }
            }
            double[] var287;
            if (input[2] <= 0.9080190658569336) {
                if (input[3] <= -0.4194025695323944) {
                    if (input[4] <= 2.226238787174225) {
                        var287 = new double[2] {0.0, 1.0};
                    } else {
                        var287 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var287 = new double[2] {0.0, 1.0};
                }
            } else {
                if (input[5] <= 1.165518581867218) {
                    if (input[4] <= 0.7294346988201141) {
                        if (input[2] <= 2.175404667854309) {
                            var287 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.7432278096675873) {
                                if (input[1] <= 1.8916515111923218) {
                                    if (input[4] <= 0.05114172212779522) {
                                        var287 = new double[2] {0.0, 1.0};
                                    } else {
                                        var287 = new double[2] {0.2, 0.8};
                                    }
                                } else {
                                    var287 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var287 = new double[2] {0.5, 0.5};
                            }
                        }
                    } else {
                        var287 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var287 = new double[2] {0.9230769230769231, 0.07692307692307693};
                }
            }
            double[] var288;
            if (input[1] <= 2.1216257214546204) {
                if (input[5] <= 1.315471589565277) {
                    if (input[3] <= 0.476276159286499) {
                        if (input[2] <= 0.43158040940761566) {
                            var288 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 1.002549171447754) {
                                var288 = new double[2] {0.0, 1.0};
                            } else {
                                var288 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var288 = new double[2] {0.15, 0.85};
                    }
                } else {
                    if (input[5] <= 4.369763493537903) {
                        var288 = new double[2] {0.5, 0.5};
                    } else {
                        var288 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var288 = new double[2] {0.8571428571428571, 0.14285714285714285};
            }
            double[] var289;
            if (input[3] <= 0.3546835780143738) {
                if (input[5] <= 0.4007203280925751) {
                    if (input[4] <= 1.7611917853355408) {
                        var289 = new double[2] {0.0, 1.0};
                    } else {
                        var289 = new double[2] {0.5, 0.5};
                    }
                } else {
                    var289 = new double[2] {0.45454545454545453, 0.5454545454545454};
                }
            } else {
                if (input[2] <= 1.9895713329315186) {
                    var289 = new double[2] {0.08333333333333333, 0.9166666666666666};
                } else {
                    if (input[4] <= -0.40009383857250214) {
                        var289 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 0.8561874330043793) {
                            var289 = new double[2] {0.75, 0.25};
                        } else {
                            var289 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var290;
            if (input[2] <= 0.4325118213891983) {
                var290 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 1.150134265422821) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[2] <= 2.175404667854309) {
                            var290 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 1.3819655776023865) {
                                if (input[4] <= -0.07813299261033535) {
                                    var290 = new double[2] {0.0, 1.0};
                                } else {
                                    var290 = new double[2] {0.25, 0.75};
                                }
                            } else {
                                var290 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var290 = new double[2] {0.5833333333333334, 0.4166666666666667};
                    }
                } else {
                    var290 = new double[2] {1.0, 0.0};
                }
            }
            double[] var291;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 0.27639439702033997) {
                        var291 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.0609276592731476) {
                            var291 = new double[2] {0.5, 0.5};
                        } else {
                            if (input[3] <= -0.38802669942379) {
                                var291 = new double[2] {0.5, 0.5};
                            } else {
                                if (input[2] <= 1.5374759435653687) {
                                    var291 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                } else {
                                    if (input[1] <= -1.36287122964859) {
                                        var291 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[1] <= 1.5263413786888123) {
                                            var291 = new double[2] {0.0, 1.0};
                                        } else {
                                            var291 = new double[2] {0.5, 0.5};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var291 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            } else {
                if (input[1] <= -0.10414998233318329) {
                    var291 = new double[2] {0.7, 0.3};
                } else {
                    var291 = new double[2] {1.0, 0.0};
                }
            }
            double[] var292;
            if (input[1] <= 2.160708487033844) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[2] <= 2.066565155982971) {
                        var292 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 1.0039772987365723) {
                            if (input[4] <= 0.5606600046157837) {
                                var292 = new double[2] {0.0, 1.0};
                            } else {
                                var292 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var292 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var292 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            } else {
                var292 = new double[2] {1.0, 0.0};
            }
            double[] var293;
            if (input[3] <= 0.476276159286499) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[1] <= 2.160708487033844) {
                        if (input[3] <= 0.1634063497185707) {
                            var293 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.3842225074768066) {
                                var293 = new double[2] {0.0, 1.0};
                            } else {
                                var293 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var293 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var293 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 0.9808341264724731) {
                    var293 = new double[2] {0.125, 0.875};
                } else {
                    if (input[1] <= -0.9274705946445465) {
                        var293 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        var293 = new double[2] {0.8461538461538461, 0.15384615384615385};
                    }
                }
            }
            double[] var294;
            if (input[2] <= 0.43158040940761566) {
                var294 = new double[2] {0.0, 1.0};
            } else {
                if (input[1] <= 1.5263413786888123) {
                    if (input[1] <= -0.46687617897987366) {
                        if (input[5] <= 1.1000142395496368) {
                            var294 = new double[2] {0.0, 1.0};
                        } else {
                            var294 = new double[2] {0.9166666666666666, 0.08333333333333333};
                        }
                    } else {
                        if (input[5] <= 0.16122902184724808) {
                            if (input[5] <= -0.17359700053930283) {
                                var294 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 1.002549171447754) {
                                    var294 = new double[2] {0.0, 1.0};
                                } else {
                                    var294 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var294 = new double[2] {0.5625, 0.4375};
                        }
                    }
                } else {
                    var294 = new double[2] {0.9166666666666666, 0.08333333333333333};
                }
            }
            double[] var295;
            if (input[1] <= 1.5263413786888123) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[5] <= 2.853314995765686) {
                        if (input[2] <= 2.1580482721328735) {
                            var295 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 1.4362176060676575) {
                                var295 = new double[2] {0.0, 1.0};
                            } else {
                                var295 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var295 = new double[2] {0.9, 0.1};
                    }
                } else {
                    var295 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            } else {
                var295 = new double[2] {0.8666666666666667, 0.13333333333333333};
            }
            double[] var296;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 1.4623540043830872) {
                        var296 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.5374759435653687) {
                            var296 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.7294346988201141) {
                                var296 = new double[2] {0.0, 1.0};
                            } else {
                                var296 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        }
                    }
                } else {
                    var296 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            } else {
                if (input[5] <= 1.862126350402832) {
                    var296 = new double[2] {1.0, 0.0};
                } else {
                    var296 = new double[2] {0.625, 0.375};
                }
            }
            double[] var297;
            if (input[1] <= 2.165230453014374) {
                if (input[5] <= 1.226828694343567) {
                    if (input[3] <= -0.413802906870842) {
                        if (input[2] <= 0.11074131727218628) {
                            var297 = new double[2] {0.0, 1.0};
                        } else {
                            var297 = new double[2] {0.5555555555555556, 0.4444444444444444};
                        }
                    } else {
                        if (input[3] <= 0.4673878103494644) {
                            if (input[3] <= 0.009815712692216039) {
                                var297 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.014615420252084732) {
                                    var297 = new double[2] {1.0, 0.0};
                                } else {
                                    var297 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var297 = new double[2] {0.08333333333333333, 0.9166666666666666};
                        }
                    }
                } else {
                    if (input[4] <= -0.3699514716863632) {
                        var297 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.5534618198871613) {
                            var297 = new double[2] {1.0, 0.0};
                        } else {
                            var297 = new double[2] {0.6363636363636364, 0.36363636363636365};
                        }
                    }
                }
            } else {
                var297 = new double[2] {1.0, 0.0};
            }
            double[] var298;
            if (input[3] <= 1.5816310048103333) {
                if (input[4] <= 1.7923014163970947) {
                    if (input[4] <= -0.8651521503925323) {
                        if (input[4] <= -0.9387647211551666) {
                            var298 = new double[2] {0.0, 1.0};
                        } else {
                            var298 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        }
                    } else {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[1] <= -1.4646154046058655) {
                                if (input[1] <= -1.483995258808136) {
                                    var298 = new double[2] {0.0, 1.0};
                                } else {
                                    var298 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var298 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var298 = new double[2] {0.2857142857142857, 0.7142857142857143};
                        }
                    }
                } else {
                    var298 = new double[2] {1.0, 0.0};
                }
            } else {
                var298 = new double[2] {0.9, 0.1};
            }
            double[] var299;
            if (input[5] <= 1.273577094078064) {
                if (input[4] <= 2.2004266381263733) {
                    if (input[2] <= 2.171961545944214) {
                        var299 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -1.4453137516975403) {
                            var299 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.05114172212779522) {
                                if (input[4] <= -0.8132353127002716) {
                                    var299 = new double[2] {0.2, 0.8};
                                } else {
                                    var299 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var299 = new double[2] {0.5555555555555556, 0.4444444444444444};
                            }
                        }
                    }
                } else {
                    var299 = new double[2] {1.0, 0.0};
                }
            } else {
                var299 = new double[2] {0.8235294117647058, 0.17647058823529413};
            }
            double[] var300;
            if (input[2] <= 0.9300557971000671) {
                var300 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 0.05027569271624088) {
                    if (input[0] <= -0.3421141058206558) {
                        if (input[1] <= -0.9588013291358948) {
                            var300 = new double[2] {0.16666666666666666, 0.8333333333333334};
                        } else {
                            var300 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[3] <= 0.24197933822870255) {
                            if (input[1] <= 2.011483609676361) {
                                var300 = new double[2] {0.0, 1.0};
                            } else {
                                var300 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var300 = new double[2] {0.75, 0.25};
                        }
                    }
                } else {
                    if (input[5] <= 1.055810660123825) {
                        var300 = new double[2] {0.6363636363636364, 0.36363636363636365};
                    } else {
                        var300 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var301;
            if (input[3] <= 1.5816310048103333) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[2] <= 2.066565155982971) {
                        var301 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 2.011483609676361) {
                            if (input[1] <= -1.2566050291061401) {
                                var301 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= 2.09943163394928) {
                                    var301 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[0] <= -0.3421141058206558) {
                                        var301 = new double[2] {0.0, 1.0};
                                    } else {
                                        var301 = new double[2] {0.07692307692307693, 0.9230769230769231};
                                    }
                                }
                            }
                        } else {
                            var301 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var301 = new double[2] {1.0, 0.0};
                }
            } else {
                var301 = new double[2] {0.875, 0.125};
            }
            double[] var302;
            if (input[3] <= 1.1131262183189392) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[2] <= 2.175404667854309) {
                            var302 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.2566050291061401) {
                                var302 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= 1.273577094078064) {
                                    if (input[3] <= 0.19184906035661697) {
                                        if (input[0] <= -0.3421141058206558) {
                                            var302 = new double[2] {0.0, 1.0};
                                        } else {
                                            var302 = new double[2] {0.15384615384615385, 0.8461538461538461};
                                        }
                                    } else {
                                        var302 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var302 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var302 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var302 = new double[2] {0.875, 0.125};
                }
            } else {
                if (input[2] <= 1.636903703212738) {
                    var302 = new double[2] {0.25, 0.75};
                } else {
                    var302 = new double[2] {1.0, 0.0};
                }
            }
            double[] var303;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 2.020730972290039) {
                    if (input[5] <= -0.1849542260169983) {
                        var303 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 2.165230453014374) {
                            if (input[5] <= 0.6243304014205933) {
                                var303 = new double[2] {0.0, 1.0};
                            } else {
                                var303 = new double[2] {0.125, 0.875};
                            }
                        } else {
                            var303 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var303 = new double[2] {1.0, 0.0};
                }
            } else {
                var303 = new double[2] {0.8461538461538461, 0.15384615384615385};
            }
            double[] var304;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 1.790553331375122) {
                    if (input[1] <= -1.4827032685279846) {
                        if (input[5] <= -0.22953486442565918) {
                            var304 = new double[2] {0.5, 0.5};
                        } else {
                            var304 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[3] <= 0.4673878103494644) {
                            if (input[2] <= 0.43158040940761566) {
                                var304 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 0.43870341777801514) {
                                    if (input[4] <= 1.4407605528831482) {
                                        var304 = new double[2] {0.0, 1.0};
                                    } else {
                                        var304 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var304 = new double[2] {0.5, 0.5};
                                }
                            }
                        } else {
                            var304 = new double[2] {0.14285714285714285, 0.8571428571428571};
                        }
                    }
                } else {
                    var304 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                if (input[4] <= 0.9045190215110779) {
                    var304 = new double[2] {0.7, 0.3};
                } else {
                    var304 = new double[2] {1.0, 0.0};
                }
            }
            double[] var305;
            if (input[5] <= 1.118770182132721) {
                if (input[1] <= 2.4045716524124146) {
                    if (input[3] <= 0.37566007673740387) {
                        if (input[4] <= 1.7611917853355408) {
                            if (input[5] <= 0.532765731215477) {
                                var305 = new double[2] {0.0, 1.0};
                            } else {
                                var305 = new double[2] {0.4, 0.6};
                            }
                        } else {
                            var305 = new double[2] {0.75, 0.25};
                        }
                    } else {
                        if (input[5] <= -0.16398341953754425) {
                            var305 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 1.4927335679531097) {
                                var305 = new double[2] {0.0, 1.0};
                            } else {
                                var305 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var305 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var305 = new double[2] {0.2, 0.8};
                } else {
                    var305 = new double[2] {1.0, 0.0};
                }
            }
            double[] var306;
            if (input[1] <= 2.154894530773163) {
                if (input[2] <= 1.686274766921997) {
                    if (input[3] <= 0.4161909371614456) {
                        if (input[4] <= 2.2004266381263733) {
                            var306 = new double[2] {0.0, 1.0};
                        } else {
                            var306 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var306 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    if (input[1] <= -0.4684911519289017) {
                        if (input[3] <= 0.7309273183345795) {
                            var306 = new double[2] {0.0, 1.0};
                        } else {
                            var306 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[4] <= 0.9279130958020687) {
                                var306 = new double[2] {0.0, 1.0};
                            } else {
                                var306 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var306 = new double[2] {0.4666666666666667, 0.5333333333333333};
                        }
                    }
                }
            } else {
                var306 = new double[2] {1.0, 0.0};
            }
            double[] var307;
            if (input[3] <= 1.5816310048103333) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[5] <= 3.2119393348693848) {
                        if (input[4] <= -0.8789861500263214) {
                            if (input[2] <= 2.175404667854309) {
                                var307 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.5392613112926483) {
                                    var307 = new double[2] {0.0, 1.0};
                                } else {
                                    var307 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[1] <= 2.2928144335746765) {
                                if (input[2] <= 2.171961545944214) {
                                    var307 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= -0.12962899915874004) {
                                        var307 = new double[2] {0.25, 0.75};
                                    } else {
                                        if (input[4] <= 0.5557562410831451) {
                                            var307 = new double[2] {0.0, 1.0};
                                        } else {
                                            var307 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var307 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var307 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var307 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            } else {
                var307 = new double[2] {1.0, 0.0};
            }
            double[] var308;
            if (input[2] <= 0.43158040940761566) {
                var308 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 0.9428510367870331) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[1] <= -1.36287122964859) {
                            var308 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 1.3593424260616302) {
                                var308 = new double[2] {0.0, 1.0};
                            } else {
                                var308 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var308 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.9045190215110779) {
                        var308 = new double[2] {0.6153846153846154, 0.38461538461538464};
                    } else {
                        var308 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var309;
            if (input[5] <= 0.9808341264724731) {
                if (input[4] <= 2.2004266381263733) {
                    if (input[5] <= 0.6243304014205933) {
                        if (input[1] <= 2.4804760217666626) {
                            if (input[1] <= -1.4827032685279846) {
                                if (input[1] <= -1.496269166469574) {
                                    var309 = new double[2] {0.0, 1.0};
                                } else {
                                    var309 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var309 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var309 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var309 = new double[2] {0.1111111111111111, 0.8888888888888888};
                    }
                } else {
                    var309 = new double[2] {1.0, 0.0};
                }
            } else {
                var309 = new double[2] {0.8181818181818182, 0.18181818181818182};
            }
            double[] var310;
            if (input[4] <= 1.8872272968292236) {
                if (input[3] <= 0.7842573821544647) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[2] <= 2.120432734489441) {
                            var310 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.06388905085623264) {
                                var310 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.4336410760879517) {
                                    var310 = new double[2] {0.0, 1.0};
                                } else {
                                    var310 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var310 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var310 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                var310 = new double[2] {1.0, 0.0};
            }
            double[] var311;
            if (input[5] <= 2.050910711288452) {
                if (input[1] <= 1.8638737201690674) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[1] <= -1.4827032685279846) {
                            if (input[5] <= -0.2340589016675949) {
                                var311 = new double[2] {0.18181818181818182, 0.8181818181818182};
                            } else {
                                var311 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var311 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var311 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var311 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                var311 = new double[2] {0.8333333333333334, 0.16666666666666666};
            }
            double[] var312;
            if (input[5] <= 1.315471589565277) {
                if (input[5] <= 0.4139154553413391) {
                    if (input[2] <= 2.171961545944214) {
                        if (input[2] <= 0.19719364307820797) {
                            var312 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 1.879230558872223) {
                                var312 = new double[2] {0.0, 1.0};
                            } else {
                                var312 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[0] <= 0.876292273402214) {
                            if (input[3] <= -0.11035474017262459) {
                                var312 = new double[2] {0.0, 1.0};
                            } else {
                                var312 = new double[2] {0.15384615384615385, 0.8461538461538461};
                            }
                        } else {
                            var312 = new double[2] {0.375, 0.625};
                        }
                    }
                } else {
                    if (input[3] <= 0.05870161997154355) {
                        var312 = new double[2] {1.0, 0.0};
                    } else {
                        var312 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[2] <= 1.8541556596755981) {
                    var312 = new double[2] {0.14285714285714285, 0.8571428571428571};
                } else {
                    var312 = new double[2] {1.0, 0.0};
                }
            }
            double[] var313;
            if (input[5] <= 0.9428510367870331) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[1] <= -1.4671993851661682) {
                                if (input[4] <= 0.23839548416435719) {
                                    var313 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                } else {
                                    var313 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var313 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var313 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var313 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var313 = new double[2] {0.75, 0.25};
                }
            } else {
                if (input[2] <= 1.8485819101333618) {
                    var313 = new double[2] {0.16666666666666666, 0.8333333333333334};
                } else {
                    var313 = new double[2] {0.9333333333333333, 0.06666666666666667};
                }
            }
            double[] var314;
            if (input[1] <= 1.5263413786888123) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= -2.050532877445221) {
                        var314 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 3.5527032613754272) {
                            if (input[5] <= 1.226828694343567) {
                                var314 = new double[2] {0.0, 1.0};
                            } else {
                                var314 = new double[2] {0.3, 0.7};
                            }
                        } else {
                            var314 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var314 = new double[2] {0.9, 0.1};
                }
            } else {
                var314 = new double[2] {0.9090909090909091, 0.09090909090909091};
            }
            double[] var315;
            if (input[2] <= 0.40715569257736206) {
                var315 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 0.9407775104045868) {
                    if (input[5] <= -0.7097427845001221) {
                        var315 = new double[2] {0.6, 0.4};
                    } else {
                        if (input[4] <= 1.5741516947746277) {
                            if (input[1] <= 1.5263413786888123) {
                                var315 = new double[2] {0.0, 1.0};
                            } else {
                                var315 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var315 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var315 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            }
            double[] var316;
            if (input[1] <= 1.8961734771728516) {
                if (input[3] <= 1.5816310048103333) {
                    if (input[4] <= 1.7887473106384277) {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[3] <= 0.37566007673740387) {
                                var316 = new double[2] {0.0, 1.0};
                            } else {
                                var316 = new double[2] {0.2, 0.8};
                            }
                        } else {
                            var316 = new double[2] {0.4, 0.6};
                        }
                    } else {
                        var316 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var316 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                var316 = new double[2] {0.9230769230769231, 0.07692307692307693};
            }
            double[] var317;
            if (input[5] <= 1.118770182132721) {
                if (input[2] <= 0.40715569257736206) {
                    var317 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.3593424260616302) {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[5] <= -0.2304302453994751) {
                                if (input[5] <= -0.2511182948946953) {
                                    var317 = new double[2] {0.0, 1.0};
                                } else {
                                    var317 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var317 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var317 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var317 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[5] <= 2.853314995765686) {
                    var317 = new double[2] {0.8181818181818182, 0.18181818181818182};
                } else {
                    var317 = new double[2] {1.0, 0.0};
                }
            }
            double[] var318;
            if (input[3] <= 0.7842573821544647) {
                if (input[4] <= 1.8059442043304443) {
                    if (input[4] <= -1.4582929611206055) {
                        if (input[2] <= 1.8401802778244019) {
                            var318 = new double[2] {0.0, 1.0};
                        } else {
                            var318 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 0.05647286958992481) {
                            if (input[5] <= -0.290232390165329) {
                                var318 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 2.7992745637893677) {
                                    if (input[2] <= 2.175404667854309) {
                                        var318 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[4] <= 0.05114172212779522) {
                                            var318 = new double[2] {0.0, 1.0};
                                        } else {
                                            var318 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var318 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var318 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var318 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.8343790173530579) {
                    var318 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    var318 = new double[2] {1.0, 0.0};
                }
            }
            double[] var319;
            if (input[4] <= 1.7611917853355408) {
                if (input[4] <= 0.07617787271738052) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[3] <= 1.8571697473526) {
                            if (input[1] <= -1.4504035115242004) {
                                var319 = new double[2] {0.08333333333333333, 0.9166666666666666};
                            } else {
                                var319 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var319 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var319 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= 1.8378623723983765) {
                        var319 = new double[2] {0.0, 1.0};
                    } else {
                        var319 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                }
            } else {
                var319 = new double[2] {1.0, 0.0};
            }
            double[] var320;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 2.034778654575348) {
                    if (input[0] <= -0.3421141058206558) {
                        var320 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -0.8097149729728699) {
                            if (input[1] <= 2.011483609676361) {
                                var320 = new double[2] {0.0, 1.0};
                            } else {
                                var320 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.1587844118475914) {
                                var320 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 0.507977768778801) {
                                    var320 = new double[2] {0.0, 1.0};
                                } else {
                                    var320 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            }
                        }
                    }
                } else {
                    var320 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var320 = new double[2] {0.0, 1.0};
                } else {
                    var320 = new double[2] {1.0, 0.0};
                }
            }
            double[] var321;
            if (input[3] <= 1.611495852470398) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[5] <= 0.4156590849161148) {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[4] <= 1.7416442036628723) {
                                var321 = new double[2] {0.0, 1.0};
                            } else {
                                var321 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            }
                        } else {
                            var321 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= 0.7294346988201141) {
                            var321 = new double[2] {0.0, 1.0};
                        } else {
                            var321 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        }
                    }
                } else {
                    var321 = new double[2] {1.0, 0.0};
                }
            } else {
                var321 = new double[2] {1.0, 0.0};
            }
            double[] var322;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[3] <= 1.3142695128917694) {
                        if (input[1] <= 1.5263413786888123) {
                            var322 = new double[2] {0.0, 1.0};
                        } else {
                            var322 = new double[2] {0.75, 0.25};
                        }
                    } else {
                        var322 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var322 = new double[2] {0.8, 0.2};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var322 = new double[2] {0.4, 0.6};
                } else {
                    var322 = new double[2] {1.0, 0.0};
                }
            }
            double[] var323;
            if (input[5] <= 1.226828694343567) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[4] <= 2.034778654575348) {
                        if (input[5] <= 0.6243304014205933) {
                            var323 = new double[2] {0.0, 1.0};
                        } else {
                            var323 = new double[2] {0.1, 0.9};
                        }
                    } else {
                        var323 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var323 = new double[2] {0.875, 0.125};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var323 = new double[2] {0.2857142857142857, 0.7142857142857143};
                } else {
                    var323 = new double[2] {1.0, 0.0};
                }
            }
            double[] var324;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 1.512775480747223) {
                    if (input[2] <= 0.40715569257736206) {
                        var324 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -1.36287122964859) {
                            var324 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -0.5289958864450455) {
                                var324 = new double[2] {1.0, 0.0};
                            } else {
                                var324 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var324 = new double[2] {0.7142857142857143, 0.2857142857142857};
                }
            } else {
                if (input[1] <= 1.5609020590782166) {
                    if (input[4] <= 0.5640116333961487) {
                        var324 = new double[2] {1.0, 0.0};
                    } else {
                        var324 = new double[2] {0.875, 0.125};
                    }
                } else {
                    var324 = new double[2] {0.5, 0.5};
                }
            }
            double[] var325;
            if (input[3] <= 1.1131262183189392) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[4] <= -0.8186227083206177) {
                            if (input[5] <= -0.06388905085623264) {
                                var325 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= -0.8648484945297241) {
                                    var325 = new double[2] {0.0, 1.0};
                                } else {
                                    var325 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var325 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var325 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var325 = new double[2] {1.0, 0.0};
                }
            } else {
                var325 = new double[2] {0.875, 0.125};
            }
            double[] var326;
            if (input[1] <= 1.8961734771728516) {
                if (input[3] <= 1.5816310048103333) {
                    if (input[5] <= 0.4117005616426468) {
                        if (input[3] <= 0.4673878103494644) {
                            if (input[3] <= -0.4148695170879364) {
                                if (input[4] <= 1.7368642091751099) {
                                    var326 = new double[2] {0.0, 1.0};
                                } else {
                                    var326 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                var326 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var326 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        if (input[3] <= -0.07755673676729202) {
                            var326 = new double[2] {1.0, 0.0};
                        } else {
                            var326 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var326 = new double[2] {0.7857142857142857, 0.21428571428571427};
                }
            } else {
                var326 = new double[2] {0.9166666666666666, 0.08333333333333333};
            }
            double[] var327;
            if (input[5] <= 0.9428510367870331) {
                if (input[5] <= 0.4156590849161148) {
                    if (input[5] <= -0.1480550318956375) {
                        if (input[2] <= 2.171961545944214) {
                            if (input[5] <= -0.7568681836128235) {
                                if (input[4] <= 2.212191104888916) {
                                    var327 = new double[2] {0.0, 1.0};
                                } else {
                                    var327 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var327 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var327 = new double[2] {0.4117647058823529, 0.5882352941176471};
                        }
                    } else {
                        if (input[1] <= 2.230798900127411) {
                            var327 = new double[2] {0.0, 1.0};
                        } else {
                            var327 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var327 = new double[2] {0.3333333333333333, 0.6666666666666666};
                }
            } else {
                if (input[4] <= -0.38663099706172943) {
                    var327 = new double[2] {0.3333333333333333, 0.6666666666666666};
                } else {
                    if (input[2] <= 1.6334203481674194) {
                        var327 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        var327 = new double[2] {0.9333333333333333, 0.06666666666666667};
                    }
                }
            }
            double[] var328;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[1] <= 1.5263413786888123) {
                        if (input[3] <= 0.476276159286499) {
                            if (input[2] <= 1.4623540043830872) {
                                var328 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 0.43870341777801514) {
                                    if (input[1] <= 0.3467545211315155) {
                                        if (input[1] <= 0.32382169365882874) {
                                            var328 = new double[2] {0.0, 1.0};
                                        } else {
                                            var328 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var328 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var328 = new double[2] {0.25, 0.75};
                                }
                            }
                        } else {
                            var328 = new double[2] {0.18181818181818182, 0.8181818181818182};
                        }
                    } else {
                        var328 = new double[2] {0.4, 0.6};
                    }
                } else {
                    var328 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            } else {
                var328 = new double[2] {0.8, 0.2};
            }
            double[] var329;
            if (input[3] <= 0.7842573821544647) {
                if (input[2] <= 0.40715569257736206) {
                    var329 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 1.8638737201690674) {
                        if (input[3] <= -0.5289958864450455) {
                            var329 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.7294346988201141) {
                                if (input[4] <= 0.042278969660401344) {
                                    var329 = new double[2] {0.0, 1.0};
                                } else {
                                    var329 = new double[2] {0.125, 0.875};
                                }
                            } else {
                                var329 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var329 = new double[2] {0.9090909090909091, 0.09090909090909091};
                    }
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var329 = new double[2] {0.0, 1.0};
                } else {
                    var329 = new double[2] {1.0, 0.0};
                }
            }
            double[] var330;
            if (input[5] <= 0.45364217460155487) {
                if (input[1] <= 1.790553331375122) {
                    if (input[1] <= -1.4671993851661682) {
                        if (input[1] <= -1.483995258808136) {
                            var330 = new double[2] {0.0, 1.0};
                        } else {
                            var330 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 0.4673878103494644) {
                            if (input[3] <= -0.4148695170879364) {
                                if (input[3] <= -0.41744713485240936) {
                                    var330 = new double[2] {0.0, 1.0};
                                } else {
                                    var330 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var330 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var330 = new double[2] {0.4, 0.6};
                        }
                    }
                } else {
                    var330 = new double[2] {0.5555555555555556, 0.4444444444444444};
                }
            } else {
                if (input[4] <= -0.009874051436781883) {
                    var330 = new double[2] {0.15384615384615385, 0.8461538461538461};
                } else {
                    if (input[4] <= 0.7427063286304474) {
                        var330 = new double[2] {0.5714285714285714, 0.42857142857142855};
                    } else {
                        var330 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var331;
            if (input[3] <= 0.3589499741792679) {
                if (input[5] <= 0.6243304014205933) {
                    if (input[4] <= 2.226238787174225) {
                        if (input[1] <= 2.0550883412361145) {
                            var331 = new double[2] {0.0, 1.0};
                        } else {
                            var331 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var331 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var331 = new double[2] {0.5714285714285714, 0.42857142857142855};
                }
            } else {
                if (input[4] <= -0.38663099706172943) {
                    var331 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.7718626856803894) {
                        var331 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -0.14671810530126095) {
                            var331 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        } else {
                            var331 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var332;
            if (input[5] <= 1.273577094078064) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[2] <= 2.1580482721328735) {
                        var332 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.38331587612628937) {
                            var332 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= 0.059956515207886696) {
                                if (input[4] <= -0.7446052134037018) {
                                    var332 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                } else {
                                    var332 = new double[2] {0.07692307692307693, 0.9230769230769231};
                                }
                            } else {
                                var332 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var332 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 2.440600872039795) {
                    var332 = new double[2] {1.0, 0.0};
                } else {
                    var332 = new double[2] {0.8, 0.2};
                }
            }
            double[] var333;
            if (input[5] <= 0.9428510367870331) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[4] <= -1.4582929611206055) {
                        if (input[1] <= 1.8629047870635986) {
                            var333 = new double[2] {0.0, 1.0};
                        } else {
                            var333 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 2.1216257214546204) {
                            if (input[3] <= 0.379926472902298) {
                                if (input[3] <= 0.15629567205905914) {
                                    var333 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= 0.1667839214205742) {
                                        var333 = new double[2] {1.0, 0.0};
                                    } else {
                                        var333 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var333 = new double[2] {0.2, 0.8};
                            }
                        } else {
                            var333 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var333 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var333 = new double[2] {0.0, 1.0};
                } else {
                    var333 = new double[2] {0.9375, 0.0625};
                }
            }
            double[] var334;
            if (input[5] <= 0.9428510367870331) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[1] <= 1.5263413786888123) {
                        if (input[3] <= 0.379926472902298) {
                            var334 = new double[2] {0.0, 1.0};
                        } else {
                            var334 = new double[2] {0.09090909090909091, 0.9090909090909091};
                        }
                    } else {
                        var334 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    }
                } else {
                    var334 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 1.7416212558746338) {
                    var334 = new double[2] {0.14285714285714285, 0.8571428571428571};
                } else {
                    var334 = new double[2] {0.8235294117647058, 0.17647058823529413};
                }
            }
            double[] var335;
            if (input[3] <= 0.7842573821544647) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.160708487033844) {
                        if (input[1] <= 1.5053465366363525) {
                            if (input[2] <= 2.175404667854309) {
                                var335 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.1383879482746124) {
                                    var335 = new double[2] {1.0, 0.0};
                                } else {
                                    var335 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var335 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var335 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var335 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                if (input[2] <= 1.8378623723983765) {
                    var335 = new double[2] {0.25, 0.75};
                } else {
                    var335 = new double[2] {1.0, 0.0};
                }
            }
            double[] var336;
            if (input[4] <= 1.7611917853355408) {
                if (input[2] <= 2.1580482721328735) {
                    if (input[1] <= -2.050532877445221) {
                        var336 = new double[2] {1.0, 0.0};
                    } else {
                        var336 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= 2.118072807788849) {
                        if (input[5] <= 1.315471589565277) {
                            if (input[1] <= -1.3619022369384766) {
                                var336 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[0] <= -0.3421141058206558) {
                                    var336 = new double[2] {0.0, 1.0};
                                } else {
                                    var336 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                }
                            }
                        } else {
                            var336 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var336 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var336 = new double[2] {0.8, 0.2};
            }
            double[] var337;
            if (input[2] <= 1.686274766921997) {
                if (input[2] <= 0.9080190658569336) {
                    var337 = new double[2] {0.0, 1.0};
                } else {
                    var337 = new double[2] {0.07142857142857142, 0.9285714285714286};
                }
            } else {
                if (input[2] <= 1.7347450852394104) {
                    var337 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[5] <= 1.315471589565277) {
                            if (input[1] <= 2.0848039984703064) {
                                if (input[0] <= -0.3421141058206558) {
                                    if (input[5] <= -0.14348386228084564) {
                                        var337 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                    } else {
                                        var337 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var337 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var337 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var337 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var337 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var338;
            if (input[5] <= 0.9428510367870331) {
                if (input[4] <= 2.226238787174225) {
                    if (input[2] <= 2.175404667854309) {
                        var338 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.03961946628987789) {
                            if (input[3] <= -0.08315639942884445) {
                                var338 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            } else {
                                var338 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[0] <= -0.3421141058206558) {
                                var338 = new double[2] {0.0, 1.0};
                            } else {
                                var338 = new double[2] {0.5, 0.5};
                            }
                        }
                    }
                } else {
                    var338 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.5473829507827759) {
                    var338 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 2.440600872039795) {
                        var338 = new double[2] {1.0, 0.0};
                    } else {
                        var338 = new double[2] {0.75, 0.25};
                    }
                }
            }
            double[] var339;
            if (input[3] <= 0.3546835780143738) {
                if (input[5] <= 0.43870341777801514) {
                    if (input[1] <= 1.8961734771728516) {
                        if (input[3] <= -0.413802906870842) {
                            if (input[3] <= -0.41744713485240936) {
                                var339 = new double[2] {0.0, 1.0};
                            } else {
                                var339 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var339 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var339 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    var339 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            } else {
                if (input[3] <= 3.6247063875198364) {
                    if (input[3] <= 0.42614588141441345) {
                        var339 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 1.068716138601303) {
                            if (input[1] <= 2.5424915552139282) {
                                if (input[1] <= 0.5796356871724129) {
                                    var339 = new double[2] {0.0, 1.0};
                                } else {
                                    var339 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                }
                            } else {
                                var339 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var339 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var339 = new double[2] {1.0, 0.0};
                }
            }
            double[] var340;
            if (input[3] <= 0.49405285716056824) {
                if (input[4] <= 2.034778654575348) {
                    if (input[3] <= 0.1634063497185707) {
                        if (input[5] <= -0.29141052067279816) {
                            var340 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 2.1216257214546204) {
                                if (input[4] <= 1.7465029954910278) {
                                    var340 = new double[2] {0.0, 1.0};
                                } else {
                                    var340 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var340 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= 0.1667839214205742) {
                            var340 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= 2.4149075746536255) {
                                var340 = new double[2] {0.0, 1.0};
                            } else {
                                var340 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var340 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var340 = new double[2] {0.16666666666666666, 0.8333333333333334};
                } else {
                    if (input[4] <= -0.19924228265881538) {
                        var340 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    } else {
                        if (input[3] <= 2.785557508468628) {
                            var340 = new double[2] {1.0, 0.0};
                        } else {
                            var340 = new double[2] {0.8, 0.2};
                        }
                    }
                }
            }
            double[] var341;
            if (input[5] <= 0.45364217460155487) {
                if (input[4] <= 1.9071122407913208) {
                    if (input[3] <= 0.3589499741792679) {
                        if (input[1] <= 2.1171037554740906) {
                            var341 = new double[2] {0.0, 1.0};
                        } else {
                            var341 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var341 = new double[2] {0.2857142857142857, 0.7142857142857143};
                    }
                } else {
                    var341 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 1.068716138601303) {
                    if (input[3] <= 0.6096013784408569) {
                        var341 = new double[2] {0.8571428571428571, 0.14285714285714285};
                    } else {
                        if (input[4] <= 0.34956228733062744) {
                            var341 = new double[2] {0.5714285714285714, 0.42857142857142855};
                        } else {
                            var341 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var341 = new double[2] {1.0, 0.0};
                }
            }
            double[] var342;
            if (input[5] <= 0.9428510367870331) {
                if (input[1] <= 2.4149075746536255) {
                    if (input[3] <= 0.49405285716056824) {
                        if (input[4] <= 1.7600783109664917) {
                            if (input[5] <= 0.6243304014205933) {
                                var342 = new double[2] {0.0, 1.0};
                            } else {
                                var342 = new double[2] {0.2, 0.8};
                            }
                        } else {
                            var342 = new double[2] {0.75, 0.25};
                        }
                    } else {
                        var342 = new double[2] {0.2, 0.8};
                    }
                } else {
                    var342 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 0.9859141409397125) {
                    var342 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -0.9833491444587708) {
                        var342 = new double[2] {0.0, 1.0};
                    } else {
                        var342 = new double[2] {0.9375, 0.0625};
                    }
                }
            }
            double[] var343;
            if (input[4] <= 1.7611917853355408) {
                if (input[1] <= 2.165230453014374) {
                    if (input[3] <= 1.5816310048103333) {
                        var343 = new double[2] {0.0, 1.0};
                    } else {
                        var343 = new double[2] {0.7142857142857143, 0.2857142857142857};
                    }
                } else {
                    var343 = new double[2] {1.0, 0.0};
                }
            } else {
                var343 = new double[2] {0.875, 0.125};
            }
            double[] var344;
            if (input[2] <= 1.9836953282356262) {
                if (input[3] <= -0.5628604888916016) {
                    if (input[2] <= 0.08774925768375397) {
                        var344 = new double[2] {0.0, 1.0};
                    } else {
                        var344 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var344 = new double[2] {0.0, 1.0};
                }
            } else {
                if (input[2] <= 2.09943163394928) {
                    var344 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.7294346988201141) {
                        if (input[3] <= 1.3206691145896912) {
                            if (input[3] <= 0.15629567205905914) {
                                if (input[4] <= -0.8729014098644257) {
                                    var344 = new double[2] {0.125, 0.875};
                                } else {
                                    var344 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[3] <= 0.42614588141441345) {
                                    var344 = new double[2] {0.8, 0.2};
                                } else {
                                    var344 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                }
                            }
                        } else {
                            var344 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var344 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var345;
            if (input[1] <= 1.8961734771728516) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[5] <= 1.315471589565277) {
                        var345 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 1.5816310048103333) {
                            var345 = new double[2] {0.0, 1.0};
                        } else {
                            var345 = new double[2] {0.8666666666666667, 0.13333333333333333};
                        }
                    }
                } else {
                    var345 = new double[2] {0.75, 0.25};
                }
            } else {
                var345 = new double[2] {0.8181818181818182, 0.18181818181818182};
            }
            double[] var346;
            if (input[4] <= 1.7611917853355408) {
                if (input[3] <= 1.5816310048103333) {
                    if (input[2] <= 1.9892690777778625) {
                        var346 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.5606600046157837) {
                            if (input[0] <= 0.876292273402214) {
                                if (input[2] <= 2.175404667854309) {
                                    var346 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= -0.16902583837509155) {
                                        var346 = new double[2] {0.3, 0.7};
                                    } else {
                                        var346 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var346 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            }
                        } else {
                            var346 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var346 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            } else {
                var346 = new double[2] {0.8888888888888888, 0.1111111111111111};
            }
            double[] var347;
            if (input[4] <= 1.8199918866157532) {
                if (input[5] <= 0.923718124628067) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[5] <= -0.23990245163440704) {
                            if (input[5] <= -0.24197597056627274) {
                                var347 = new double[2] {0.0, 1.0};
                            } else {
                                var347 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var347 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var347 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 1.5816310048103333) {
                        var347 = new double[2] {0.125, 0.875};
                    } else {
                        var347 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var347 = new double[2] {1.0, 0.0};
            }
            double[] var348;
            if (input[3] <= 0.7842573821544647) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[3] <= 0.1634063497185707) {
                        var348 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.16838382184505463) {
                            var348 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= -1.4517695903778076) {
                                var348 = new double[2] {0.5, 0.5};
                            } else {
                                if (input[5] <= 1.165518581867218) {
                                    var348 = new double[2] {0.0, 1.0};
                                } else {
                                    var348 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    var348 = new double[2] {0.5714285714285714, 0.42857142857142855};
                }
            } else {
                if (input[2] <= 1.636903703212738) {
                    var348 = new double[2] {0.16666666666666666, 0.8333333333333334};
                } else {
                    var348 = new double[2] {1.0, 0.0};
                }
            }
            double[] var349;
            if (input[3] <= 0.3589499741792679) {
                if (input[0] <= 0.876292273402214) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[2] <= 2.175404667854309) {
                            var349 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 0.5606600046157837) {
                                var349 = new double[2] {0.0, 1.0};
                            } else {
                                var349 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var349 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= 0.11193127930164337) {
                        var349 = new double[2] {0.0, 1.0};
                    } else {
                        var349 = new double[2] {0.36363636363636365, 0.6363636363636364};
                    }
                }
            } else {
                if (input[2] <= 1.9357037544250488) {
                    var349 = new double[2] {0.2727272727272727, 0.7272727272727273};
                } else {
                    if (input[4] <= -0.11199815385043621) {
                        var349 = new double[2] {0.25, 0.75};
                    } else {
                        var349 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var350;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[3] <= -0.4148695170879364) {
                        if (input[4] <= 1.7055296301841736) {
                            var350 = new double[2] {0.0, 1.0};
                        } else {
                            var350 = new double[2] {0.14285714285714285, 0.8571428571428571};
                        }
                    } else {
                        var350 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var350 = new double[2] {1.0, 0.0};
                }
            } else {
                var350 = new double[2] {0.6875, 0.3125};
            }
            double[] var351;
            if (input[5] <= 0.9407775104045868) {
                if (input[2] <= 0.43158040940761566) {
                    var351 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.687770426273346) {
                        if (input[3] <= 0.3429509550333023) {
                            var351 = new double[2] {0.0, 1.0};
                        } else {
                            var351 = new double[2] {0.25, 0.75};
                        }
                    } else {
                        var351 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var351 = new double[2] {0.7333333333333333, 0.26666666666666666};
            }
            double[] var352;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[5] <= 0.43870341777801514) {
                        if (input[3] <= 0.379926472902298) {
                            var352 = new double[2] {0.0, 1.0};
                        } else {
                            var352 = new double[2] {0.5, 0.5};
                        }
                    } else {
                        if (input[2] <= 1.5374759435653687) {
                            var352 = new double[2] {0.6666666666666666, 0.3333333333333333};
                        } else {
                            if (input[4] <= 0.7294346988201141) {
                                var352 = new double[2] {0.0, 1.0};
                            } else {
                                var352 = new double[2] {0.75, 0.25};
                            }
                        }
                    }
                } else {
                    var352 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var352 = new double[2] {0.4, 0.6};
                } else {
                    var352 = new double[2] {1.0, 0.0};
                }
            }
            double[] var353;
            if (input[5] <= 1.201852262020111) {
                if (input[4] <= 1.9071122407913208) {
                    if (input[2] <= 2.175404667854309) {
                        var353 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.03509542811661959) {
                            if (input[5] <= -0.06388905085623264) {
                                if (input[4] <= -1.4062073826789856) {
                                    var353 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[3] <= 0.2661556340754032) {
                                        var353 = new double[2] {0.0, 1.0};
                                    } else {
                                        var353 = new double[2] {0.5, 0.5};
                                    }
                                }
                            } else {
                                var353 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[5] <= 0.5814462602138519) {
                                var353 = new double[2] {0.0, 1.0};
                            } else {
                                var353 = new double[2] {0.16666666666666666, 0.8333333333333334};
                            }
                        }
                    }
                } else {
                    var353 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 0.9859141409397125) {
                    var353 = new double[2] {0.0, 1.0};
                } else {
                    var353 = new double[2] {1.0, 0.0};
                }
            }
            double[] var354;
            if (input[3] <= 0.3589499741792679) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[5] <= 0.6243304014205933) {
                            var354 = new double[2] {0.0, 1.0};
                        } else {
                            var354 = new double[2] {0.25, 0.75};
                        }
                    } else {
                        var354 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var354 = new double[2] {0.9090909090909091, 0.09090909090909091};
                }
            } else {
                if (input[2] <= 1.9357037544250488) {
                    var354 = new double[2] {0.375, 0.625};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        var354 = new double[2] {0.5294117647058824, 0.47058823529411764};
                    } else {
                        var354 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var355;
            if (input[5] <= 1.118770182132721) {
                if (input[3] <= 0.3589499741792679) {
                    if (input[2] <= 2.171961545944214) {
                        var355 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.1987619698047638) {
                            if (input[4] <= -0.8815842270851135) {
                                var355 = new double[2] {0.125, 0.875};
                            } else {
                                var355 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[4] <= 0.5557562410831451) {
                                var355 = new double[2] {0.25, 0.75};
                            } else {
                                var355 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[3] <= 0.42614588141441345) {
                        var355 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 2.4045716524124146) {
                            if (input[4] <= 1.4927335679531097) {
                                var355 = new double[2] {0.0, 1.0};
                            } else {
                                var355 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var355 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var355 = new double[2] {0.8, 0.2};
            }
            double[] var356;
            if (input[4] <= 1.8199918866157532) {
                if (input[2] <= 1.6531969904899597) {
                    var356 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 0.06042061746120453) {
                        if (input[3] <= 1.3206691145896912) {
                            if (input[1] <= 2.011483609676361) {
                                var356 = new double[2] {0.0, 1.0};
                            } else {
                                var356 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var356 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var356 = new double[2] {0.8461538461538461, 0.15384615384615385};
                    }
                }
            } else {
                var356 = new double[2] {1.0, 0.0};
            }
            double[] var357;
            if (input[3] <= 1.7416212558746338) {
                if (input[4] <= 1.7600333094596863) {
                    if (input[4] <= 0.8884468674659729) {
                        if (input[1] <= 2.12840873003006) {
                            var357 = new double[2] {0.0, 1.0};
                        } else {
                            var357 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= 1.8917299509048462) {
                            var357 = new double[2] {0.0, 1.0};
                        } else {
                            var357 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var357 = new double[2] {1.0, 0.0};
                }
            } else {
                var357 = new double[2] {0.9, 0.1};
            }
            double[] var358;
            if (input[3] <= 1.5816310048103333) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[1] <= -0.6432328224182129) {
                            if (input[1] <= -0.6664886474609375) {
                                var358 = new double[2] {0.0, 1.0};
                            } else {
                                var358 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var358 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var358 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var358 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                var358 = new double[2] {1.0, 0.0};
            }
            double[] var359;
            if (input[2] <= 1.6531969904899597) {
                if (input[3] <= -0.5628604888916016) {
                    if (input[2] <= 0.08774925768375397) {
                        var359 = new double[2] {0.0, 1.0};
                    } else {
                        var359 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[5] <= -0.7569624483585358) {
                        var359 = new double[2] {0.25, 0.75};
                    } else {
                        if (input[4] <= 1.9211599230766296) {
                            var359 = new double[2] {0.0, 1.0};
                        } else {
                            var359 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[5] <= 1.165518581867218) {
                    if (input[5] <= -0.2226545438170433) {
                        var359 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.7294346988201141) {
                            if (input[4] <= -0.739544004201889) {
                                var359 = new double[2] {0.36363636363636365, 0.6363636363636364};
                            } else {
                                var359 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var359 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var359 = new double[2] {1.0, 0.0};
                }
            }
            double[] var360;
            if (input[4] <= 1.8199918866157532) {
                if (input[5] <= 1.165518581867218) {
                    if (input[1] <= 2.1171037554740906) {
                        if (input[2] <= 2.175404667854309) {
                            var360 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[1] <= -1.2566050291061401) {
                                    var360 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[1] <= 0.4013410955667496) {
                                        var360 = new double[2] {0.1, 0.9};
                                    } else {
                                        var360 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var360 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var360 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var360 = new double[2] {0.5384615384615384, 0.46153846153846156};
                }
            } else {
                var360 = new double[2] {1.0, 0.0};
            }
            double[] var361;
            if (input[2] <= 1.6531969904899597) {
                if (input[2] <= 0.40715569257736206) {
                    var361 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.5217327326536179) {
                        var361 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= 1.412429690361023) {
                            var361 = new double[2] {0.16666666666666666, 0.8333333333333334};
                        } else {
                            var361 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[5] <= 1.165518581867218) {
                    if (input[1] <= 2.512775719165802) {
                        if (input[3] <= -0.38802669942379) {
                            var361 = new double[2] {0.6666666666666666, 0.3333333333333333};
                        } else {
                            if (input[4] <= 0.05114172212779522) {
                                var361 = new double[2] {0.0, 1.0};
                            } else {
                                var361 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            }
                        }
                    } else {
                        var361 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var361 = new double[2] {1.0, 0.0};
                }
            }
            double[] var362;
            if (input[4] <= 1.9012749791145325) {
                if (input[5] <= 1.118770182132721) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[4] <= -0.8186227083206177) {
                            if (input[4] <= -0.8207821547985077) {
                                if (input[2] <= 2.1580482721328735) {
                                    var362 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -1.0053140819072723) {
                                        var362 = new double[2] {0.0625, 0.9375};
                                    } else {
                                        var362 = new double[2] {0.6666666666666666, 0.3333333333333333};
                                    }
                                }
                            } else {
                                var362 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 2.7992745637893677) {
                                if (input[4] <= 0.8884018957614899) {
                                    var362 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= 0.8946665525436401) {
                                        var362 = new double[2] {1.0, 0.0};
                                    } else {
                                        var362 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var362 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var362 = new double[2] {0.375, 0.625};
                    }
                } else {
                    if (input[1] <= -1.0518246293067932) {
                        var362 = new double[2] {0.6, 0.4};
                    } else {
                        var362 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var362 = new double[2] {1.0, 0.0};
            }
            double[] var363;
            if (input[4] <= 1.7611917853355408) {
                if (input[2] <= 2.1580482721328735) {
                    var363 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 2.0848039984703064) {
                        if (input[1] <= -0.42197951674461365) {
                            if (input[5] <= 1.1000142395496368) {
                                var363 = new double[2] {0.1, 0.9};
                            } else {
                                var363 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[0] <= -0.3421141058206558) {
                                var363 = new double[2] {0.0, 1.0};
                            } else {
                                var363 = new double[2] {0.2222222222222222, 0.7777777777777778};
                            }
                        }
                    } else {
                        var363 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var363 = new double[2] {1.0, 0.0};
            }
            double[] var364;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[5] <= 0.45364217460155487) {
                        if (input[4] <= 1.7611917853355408) {
                            var364 = new double[2] {0.0, 1.0};
                        } else {
                            var364 = new double[2] {0.5, 0.5};
                        }
                    } else {
                        var364 = new double[2] {0.06666666666666667, 0.9333333333333333};
                    }
                } else {
                    var364 = new double[2] {0.5714285714285714, 0.42857142857142855};
                }
            } else {
                var364 = new double[2] {0.7857142857142857, 0.21428571428571427};
            }
            double[] var365;
            if (input[1] <= 1.5263413786888123) {
                if (input[3] <= 0.777857780456543) {
                    if (input[4] <= 1.8199918866157532) {
                        if (input[3] <= -0.4148695170879364) {
                            if (input[4] <= 1.7368642091751099) {
                                var365 = new double[2] {0.0, 1.0};
                            } else {
                                var365 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var365 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var365 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= -1.3192665576934814) {
                        var365 = new double[2] {0.0, 1.0};
                    } else {
                        var365 = new double[2] {0.7, 0.3};
                    }
                }
            } else {
                var365 = new double[2] {0.8, 0.2};
            }
            double[] var366;
            if (input[5] <= 0.43870341777801514) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[0] <= 0.876292273402214) {
                        if (input[1] <= 3.389067828655243) {
                            var366 = new double[2] {0.0, 1.0};
                        } else {
                            var366 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= -1.4539178013801575) {
                            var366 = new double[2] {0.4, 0.6};
                        } else {
                            if (input[5] <= -0.016575143672525883) {
                                var366 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.007479939493350685) {
                                    var366 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[2] <= 0.989204429090023) {
                                        var366 = new double[2] {0.0, 1.0};
                                    } else {
                                        var366 = new double[2] {0.4, 0.6};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var366 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                if (input[1] <= 0.10030742920935154) {
                    if (input[4] <= 1.1982495486736298) {
                        if (input[5] <= 5.280320763587952) {
                            var366 = new double[2] {0.08333333333333333, 0.9166666666666666};
                        } else {
                            var366 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var366 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var366 = new double[2] {0.8461538461538461, 0.15384615384615385};
                }
            }
            double[] var367;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 2.034778654575348) {
                    if (input[2] <= 2.1532992124557495) {
                        var367 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.512775480747223) {
                            if (input[5] <= -0.12180617451667786) {
                                var367 = new double[2] {0.3, 0.7};
                            } else {
                                var367 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var367 = new double[2] {0.75, 0.25};
                        }
                    }
                } else {
                    var367 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var367 = new double[2] {0.0, 1.0};
                } else {
                    var367 = new double[2] {1.0, 0.0};
                }
            }
            double[] var368;
            if (input[1] <= 2.165230453014374) {
                if (input[4] <= 1.8059442043304443) {
                    if (input[1] <= -0.8615791201591492) {
                        if (input[5] <= 2.853314995765686) {
                            if (input[4] <= -0.33384813368320465) {
                                if (input[5] <= 1.2801275551319122) {
                                    var368 = new double[2] {0.0, 1.0};
                                } else {
                                    var368 = new double[2] {0.4, 0.6};
                                }
                            } else {
                                var368 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var368 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 0.05027569271624088) {
                            var368 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 3.6247063875198364) {
                                if (input[5] <= 3.5527032613754272) {
                                    if (input[5] <= 1.315471589565277) {
                                        var368 = new double[2] {0.0, 1.0};
                                    } else {
                                        var368 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                    }
                                } else {
                                    var368 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var368 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var368 = new double[2] {1.0, 0.0};
                }
            } else {
                var368 = new double[2] {1.0, 0.0};
            }
            double[] var369;
            if (input[3] <= 0.351572647690773) {
                if (input[5] <= 0.4007203280925751) {
                    if (input[4] <= 2.226238787174225) {
                        if (input[1] <= 1.9052174091339111) {
                            var369 = new double[2] {0.0, 1.0};
                        } else {
                            var369 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var369 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var369 = new double[2] {0.5, 0.5};
                }
            } else {
                if (input[1] <= 2.2559927105903625) {
                    if (input[3] <= 3.6247063875198364) {
                        if (input[3] <= 0.42614588141441345) {
                            var369 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 1.1352655291557312) {
                                if (input[5] <= 1.315471589565277) {
                                    var369 = new double[2] {0.0, 1.0};
                                } else {
                                    var369 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var369 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var369 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var369 = new double[2] {1.0, 0.0};
                }
            }
            double[] var370;
            if (input[3] <= 1.7416212558746338) {
                if (input[1] <= 1.6707212328910828) {
                    if (input[3] <= 0.476276159286499) {
                        if (input[5] <= 1.2366308271884918) {
                            if (input[5] <= 0.45364217460155487) {
                                if (input[3] <= -0.4148695170879364) {
                                    if (input[3] <= -0.41771379113197327) {
                                        var370 = new double[2] {0.0, 1.0};
                                    } else {
                                        var370 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var370 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var370 = new double[2] {0.1111111111111111, 0.8888888888888888};
                            }
                        } else {
                            var370 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var370 = new double[2] {0.13333333333333333, 0.8666666666666667};
                    }
                } else {
                    var370 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                var370 = new double[2] {0.8, 0.2};
            }
            double[] var371;
            if (input[4] <= 1.9012749791145325) {
                if (input[2] <= 2.066565155982971) {
                    var371 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        if (input[1] <= -1.3619022369384766) {
                            var371 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= 2.118072807788849) {
                                if (input[5] <= 0.6243304014205933) {
                                    if (input[1] <= 0.3622584044933319) {
                                        if (input[1] <= 0.33867958188056946) {
                                            var371 = new double[2] {0.0, 1.0};
                                        } else {
                                            var371 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var371 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var371 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var371 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var371 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var371 = new double[2] {1.0, 0.0};
            }
            double[] var372;
            if (input[4] <= 1.7611917853355408) {
                if (input[5] <= 3.5527032613754272) {
                    if (input[3] <= 0.3589499741792679) {
                        if (input[3] <= 0.1634063497185707) {
                            if (input[4] <= -0.8186227083206177) {
                                if (input[2] <= 1.6423460245132446) {
                                    var372 = new double[2] {0.0, 1.0};
                                } else {
                                    var372 = new double[2] {0.25, 0.75};
                                }
                            } else {
                                var372 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= 1.4200751781463623) {
                                var372 = new double[2] {0.0, 1.0};
                            } else {
                                var372 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= 0.42614588141441345) {
                            var372 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[0] <= 0.876292273402214) {
                                if (input[2] <= 1.8917299509048462) {
                                    var372 = new double[2] {0.0, 1.0};
                                } else {
                                    var372 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                var372 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var372 = new double[2] {1.0, 0.0};
                }
            } else {
                var372 = new double[2] {0.9, 0.1};
            }
            double[] var373;
            if (input[3] <= 0.7842573821544647) {
                if (input[3] <= 0.37566007673740387) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[5] <= 0.39676180481910706) {
                            if (input[2] <= 0.22188109252601862) {
                                var373 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.746689110994339) {
                                    var373 = new double[2] {0.2, 0.8};
                                } else {
                                    var373 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var373 = new double[2] {0.25, 0.75};
                        }
                    } else {
                        var373 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.05114172212779522) {
                        var373 = new double[2] {0.0, 1.0};
                    } else {
                        var373 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    }
                }
            } else {
                if (input[2] <= 1.636903703212738) {
                    var373 = new double[2] {0.25, 0.75};
                } else {
                    var373 = new double[2] {1.0, 0.0};
                }
            }
            double[] var374;
            if (input[5] <= 0.9407775104045868) {
                if (input[1] <= 2.230798900127411) {
                    if (input[2] <= 0.43158040940761566) {
                        var374 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.38713787496089935) {
                            var374 = new double[2] {0.6666666666666666, 0.3333333333333333};
                        } else {
                            if (input[2] <= 1.0061759054660797) {
                                var374 = new double[2] {0.5, 0.5};
                            } else {
                                if (input[1] <= -1.36287122964859) {
                                    var374 = new double[2] {1.0, 0.0};
                                } else {
                                    var374 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    var374 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.5534618198871613) {
                    if (input[4] <= -0.3699514716863632) {
                        var374 = new double[2] {0.2, 0.8};
                    } else {
                        var374 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var374 = new double[2] {0.2857142857142857, 0.7142857142857143};
                }
            }
            double[] var375;
            if (input[3] <= 0.49405285716056824) {
                if (input[3] <= 0.1634063497185707) {
                    if (input[1] <= 1.6529563665390015) {
                        if (input[4] <= 1.8199918866157532) {
                            if (input[4] <= 1.7611917853355408) {
                                var375 = new double[2] {0.0, 1.0};
                            } else {
                                var375 = new double[2] {0.2, 0.8};
                            }
                        } else {
                            var375 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var375 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= 1.9895713329315186) {
                        var375 = new double[2] {0.0, 1.0};
                    } else {
                        var375 = new double[2] {0.5454545454545454, 0.45454545454545453};
                    }
                }
            } else {
                if (input[2] <= 0.7718626856803894) {
                    var375 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -0.3683619350194931) {
                        if (input[4] <= -0.40009383857250214) {
                            var375 = new double[2] {0.0, 1.0};
                        } else {
                            var375 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        }
                    } else {
                        var375 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var376;
            if (input[1] <= 1.8961734771728516) {
                if (input[5] <= 1.3819655776023865) {
                    if (input[2] <= 0.9300557971000671) {
                        var376 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.5606600046157837) {
                            var376 = new double[2] {0.0, 1.0};
                        } else {
                            var376 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        }
                    }
                } else {
                    var376 = new double[2] {0.6363636363636364, 0.36363636363636365};
                }
            } else {
                var376 = new double[2] {0.8888888888888888, 0.1111111111111111};
            }
            double[] var377;
            if (input[3] <= 0.7309273183345795) {
                if (input[5] <= 1.2345573008060455) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[1] <= 1.6632922887802124) {
                            if (input[3] <= 0.379926472902298) {
                                if (input[4] <= 1.7611917853355408) {
                                    var377 = new double[2] {0.0, 1.0};
                                } else {
                                    var377 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var377 = new double[2] {0.1111111111111111, 0.8888888888888888};
                            }
                        } else {
                            var377 = new double[2] {0.2, 0.8};
                        }
                    } else {
                        var377 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var377 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var377 = new double[2] {0.25, 0.75};
                } else {
                    var377 = new double[2] {1.0, 0.0};
                }
            }
            double[] var378;
            if (input[1] <= 2.4045716524124146) {
                if (input[5] <= 1.2995903491973877) {
                    if (input[5] <= 0.43870341777801514) {
                        if (input[4] <= 1.7611917853355408) {
                            var378 = new double[2] {0.0, 1.0};
                        } else {
                            var378 = new double[2] {0.6666666666666666, 0.3333333333333333};
                        }
                    } else {
                        if (input[1] <= 0.5922326147556305) {
                            if (input[4] <= 1.606352299451828) {
                                var378 = new double[2] {0.0, 1.0};
                            } else {
                                var378 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var378 = new double[2] {0.75, 0.25};
                        }
                    }
                } else {
                    var378 = new double[2] {0.75, 0.25};
                }
            } else {
                var378 = new double[2] {1.0, 0.0};
            }
            double[] var379;
            if (input[1] <= 1.8961734771728516) {
                if (input[2] <= 0.43158040940761566) {
                    var379 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 0.37141549587249756) {
                        if (input[3] <= 1.5816310048103333) {
                            var379 = new double[2] {0.0, 1.0};
                        } else {
                            var379 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[0] <= -0.3421141058206558) {
                            var379 = new double[2] {0.6, 0.4};
                        } else {
                            var379 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var379 = new double[2] {0.875, 0.125};
            }
            double[] var380;
            if (input[4] <= 1.9012749791145325) {
                if (input[2] <= 2.066565155982971) {
                    var380 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 2.011483609676361) {
                        if (input[4] <= -0.3435094356536865) {
                            var380 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= 0.876292273402214) {
                                if (input[0] <= -0.3421141058206558) {
                                    if (input[4] <= -0.30540409684181213) {
                                        var380 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[3] <= 1.4184409081935883) {
                                            var380 = new double[2] {0.18181818181818182, 0.8181818181818182};
                                        } else {
                                            var380 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var380 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var380 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var380 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var380 = new double[2] {1.0, 0.0};
            }
            double[] var381;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[2] <= 2.175404667854309) {
                        var381 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.11035474017262459) {
                            var381 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.1396799385547638) {
                                var381 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= -0.07480135187506676) {
                                    var381 = new double[2] {1.0, 0.0};
                                } else {
                                    var381 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    var381 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 2.0495136380195618) {
                    var381 = new double[2] {1.0, 0.0};
                } else {
                    var381 = new double[2] {0.5, 0.5};
                }
            }
            double[] var382;
            if (input[4] <= 1.7611917853355408) {
                if (input[1] <= 1.5263413786888123) {
                    if (input[5] <= 1.2437467575073242) {
                        if (input[3] <= 0.37494900822639465) {
                            var382 = new double[2] {0.0, 1.0};
                        } else {
                            var382 = new double[2] {0.2222222222222222, 0.7777777777777778};
                        }
                    } else {
                        var382 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                } else {
                    if (input[4] <= 0.9116834700107574) {
                        var382 = new double[2] {0.8823529411764706, 0.11764705882352941};
                    } else {
                        var382 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                var382 = new double[2] {1.0, 0.0};
            }
            double[] var383;
            if (input[2] <= 0.43158040940761566) {
                var383 = new double[2] {0.0, 1.0};
            } else {
                if (input[1] <= 1.8638737201690674) {
                    if (input[3] <= 0.9975776970386505) {
                        if (input[5] <= 0.36683717370033264) {
                            if (input[4] <= 1.002549171447754) {
                                if (input[4] <= -0.02962404675781727) {
                                    var383 = new double[2] {0.0, 1.0};
                                } else {
                                    var383 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                }
                            } else {
                                var383 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var383 = new double[2] {0.36363636363636365, 0.6363636363636364};
                        }
                    } else {
                        if (input[2] <= 1.6334203481674194) {
                            var383 = new double[2] {0.2857142857142857, 0.7142857142857143};
                        } else {
                            var383 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var383 = new double[2] {1.0, 0.0};
                }
            }
            double[] var384;
            if (input[1] <= 2.1216257214546204) {
                if (input[2] <= 2.171961545944214) {
                    if (input[3] <= -0.4194025695323944) {
                        if (input[4] <= 2.1863789558410645) {
                            var384 = new double[2] {0.0, 1.0};
                        } else {
                            var384 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 2.0082016587257385) {
                            var384 = new double[2] {0.0, 1.0};
                        } else {
                            var384 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.4362176060676575) {
                        if (input[1] <= -1.2566050291061401) {
                            var384 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= 0.6243304014205933) {
                                if (input[5] <= -0.12684859335422516) {
                                    var384 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                } else {
                                    var384 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var384 = new double[2] {0.18181818181818182, 0.8181818181818182};
                            }
                        }
                    } else {
                        var384 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var384 = new double[2] {1.0, 0.0};
            }
            double[] var385;
            if (input[5] <= 5.3345149755477905) {
                if (input[2] <= 0.43158040940761566) {
                    var385 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.150134265422821) {
                        if (input[1] <= 2.0848039984703064) {
                            if (input[1] <= 1.461741864681244) {
                                var385 = new double[2] {0.0, 1.0};
                            } else {
                                var385 = new double[2] {0.2, 0.8};
                            }
                        } else {
                            var385 = new double[2] {0.7142857142857143, 0.2857142857142857};
                        }
                    } else {
                        var385 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var385 = new double[2] {1.0, 0.0};
            }
            double[] var386;
            if (input[4] <= 1.7611917853355408) {
                if (input[3] <= 1.4515056014060974) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[3] <= 0.37566007673740387) {
                            var386 = new double[2] {0.0, 1.0};
                        } else {
                            var386 = new double[2] {0.0625, 0.9375};
                        }
                    } else {
                        var386 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var386 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            } else {
                var386 = new double[2] {0.8571428571428571, 0.14285714285714285};
            }
            double[] var387;
            if (input[5] <= 1.315471589565277) {
                if (input[4] <= 2.020730972290039) {
                    if (input[1] <= 2.0848039984703064) {
                        if (input[3] <= 0.37566007673740387) {
                            if (input[5] <= 0.6243304014205933) {
                                if (input[3] <= -0.4102475792169571) {
                                    if (input[2] <= 1.4583256542682648) {
                                        var387 = new double[2] {0.0, 1.0};
                                    } else {
                                        var387 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var387 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var387 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var387 = new double[2] {0.125, 0.875};
                        }
                    } else {
                        var387 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var387 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var387 = new double[2] {0.25, 0.75};
                } else {
                    var387 = new double[2] {1.0, 0.0};
                }
            }
            double[] var388;
            if (input[3] <= 1.1131262183189392) {
                if (input[3] <= 0.30695316195487976) {
                    if (input[2] <= 0.4325118213891983) {
                        var388 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.5263413786888123) {
                            var388 = new double[2] {0.0, 1.0};
                        } else {
                            var388 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[4] <= 0.05114172212779522) {
                        if (input[4] <= -1.4453137516975403) {
                            var388 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= 2.226922929286957) {
                                var388 = new double[2] {0.0, 1.0};
                            } else {
                                var388 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var388 = new double[2] {0.7142857142857143, 0.2857142857142857};
                    }
                }
            } else {
                if (input[4] <= 0.3337600417435169) {
                    var388 = new double[2] {1.0, 0.0};
                } else {
                    var388 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            }
            double[] var389;
            if (input[2] <= 0.9300557971000671) {
                if (input[4] <= 2.2004266381263733) {
                    var389 = new double[2] {0.0, 1.0};
                } else {
                    var389 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.7641697227954865) {
                    if (input[4] <= 1.1713238656520844) {
                        if (input[3] <= 0.3429509550333023) {
                            if (input[5] <= -0.04631127417087555) {
                                if (input[5] <= -0.06388905085623264) {
                                    if (input[1] <= 3.2834476828575134) {
                                        var389 = new double[2] {0.0, 1.0};
                                    } else {
                                        var389 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var389 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var389 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var389 = new double[2] {0.36363636363636365, 0.6363636363636364};
                        }
                    } else {
                        var389 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var389 = new double[2] {1.0, 0.0};
                }
            }
            double[] var390;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.9071122407913208) {
                    if (input[3] <= 1.611495852470398) {
                        if (input[5] <= 0.6243304014205933) {
                            if (input[1] <= 2.4804760217666626) {
                                if (input[4] <= 0.04333620145916939) {
                                    var390 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[2] <= 1.5262488424777985) {
                                        var390 = new double[2] {0.0, 1.0};
                                    } else {
                                        var390 = new double[2] {0.5, 0.5};
                                    }
                                }
                            } else {
                                var390 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var390 = new double[2] {0.13333333333333333, 0.8666666666666667};
                        }
                    } else {
                        var390 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var390 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -1.0518246293067932) {
                    var390 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 1.8485819101333618) {
                        var390 = new double[2] {0.4, 0.6};
                    } else {
                        var390 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var391;
            if (input[4] <= 1.8199918866157532) {
                if (input[3] <= 0.777857780456543) {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[5] <= 0.532765731215477) {
                                if (input[4] <= 1.7611917853355408) {
                                    if (input[1] <= 2.011483609676361) {
                                        var391 = new double[2] {0.0, 1.0};
                                    } else {
                                        var391 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var391 = new double[2] {0.2, 0.8};
                                }
                            } else {
                                var391 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var391 = new double[2] {0.06666666666666667, 0.9333333333333333};
                        }
                    } else {
                        var391 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= 1.6531969904899597) {
                        var391 = new double[2] {0.0, 1.0};
                    } else {
                        var391 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var391 = new double[2] {1.0, 0.0};
            }
            double[] var392;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 2.034778654575348) {
                    if (input[5] <= -0.1849542260169983) {
                        var392 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.17901641875505447) {
                            var392 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= 2.0848039984703064) {
                                var392 = new double[2] {0.0, 1.0};
                            } else {
                                var392 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var392 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var392 = new double[2] {0.4, 0.6};
                } else {
                    var392 = new double[2] {1.0, 0.0};
                }
            }
            double[] var393;
            if (input[3] <= 3.6247063875198364) {
                if (input[5] <= 0.9428510367870331) {
                    if (input[1] <= 1.4950106143951416) {
                        if (input[3] <= 0.37566007673740387) {
                            var393 = new double[2] {0.0, 1.0};
                        } else {
                            var393 = new double[2] {0.3, 0.7};
                        }
                    } else {
                        var393 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    }
                } else {
                    var393 = new double[2] {0.38461538461538464, 0.6153846153846154};
                }
            } else {
                var393 = new double[2] {1.0, 0.0};
            }
            double[] var394;
            if (input[5] <= 1.118770182132721) {
                if (input[4] <= 1.7600333094596863) {
                    if (input[3] <= 0.3003757745027542) {
                        if (input[1] <= 2.230798900127411) {
                            if (input[1] <= 1.5263413786888123) {
                                var394 = new double[2] {0.0, 1.0};
                            } else {
                                var394 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            var394 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= -0.13551966845989227) {
                            var394 = new double[2] {0.5, 0.5};
                        } else {
                            var394 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var394 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.34956228733062744) {
                    var394 = new double[2] {0.9090909090909091, 0.09090909090909091};
                } else {
                    var394 = new double[2] {0.5, 0.5};
                }
            }
            double[] var395;
            if (input[1] <= 1.8961734771728516) {
                if (input[3] <= 1.8571697473526) {
                    if (input[4] <= 1.8199918866157532) {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[3] <= 1.1131262183189392) {
                                if (input[3] <= -0.4148695170879364) {
                                    if (input[3] <= -0.41744713485240936) {
                                        var395 = new double[2] {0.0, 1.0};
                                    } else {
                                        var395 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var395 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var395 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var395 = new double[2] {0.125, 0.875};
                        }
                    } else {
                        var395 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var395 = new double[2] {0.7272727272727273, 0.2727272727272727};
                }
            } else {
                var395 = new double[2] {0.9333333333333333, 0.06666666666666667};
            }
            double[] var396;
            if (input[5] <= 1.165518581867218) {
                if (input[3] <= 1.611495852470398) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[3] <= -0.1068882867693901) {
                            var396 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 2.0848039984703064) {
                                if (input[4] <= 0.04333620145916939) {
                                    var396 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= 0.05647286958992481) {
                                        var396 = new double[2] {1.0, 0.0};
                                    } else {
                                        var396 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var396 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var396 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var396 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var396 = new double[2] {0.25, 0.75};
                } else {
                    var396 = new double[2] {1.0, 0.0};
                }
            }
            double[] var397;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.9071122407913208) {
                    if (input[3] <= 0.30695316195487976) {
                        if (input[1] <= 2.1216257214546204) {
                            var397 = new double[2] {0.0, 1.0};
                        } else {
                            var397 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 2.4149075746536255) {
                            if (input[5] <= -0.16398341953754425) {
                                var397 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            } else {
                                var397 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var397 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var397 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.26204634085297585) {
                    var397 = new double[2] {0.0, 1.0};
                } else {
                    var397 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            }
            double[] var398;
            if (input[2] <= 0.40715569257736206) {
                var398 = new double[2] {0.0, 1.0};
            } else {
                if (input[1] <= 1.6842871308326721) {
                    if (input[5] <= 3.5527032613754272) {
                        if (input[4] <= 1.4407605528831482) {
                            if (input[2] <= 2.171961545944214) {
                                var398 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 1.1542792618274689) {
                                    if (input[1] <= -1.3619022369384766) {
                                        var398 = new double[2] {1.0, 0.0};
                                    } else {
                                        var398 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var398 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var398 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var398 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var398 = new double[2] {1.0, 0.0};
                }
            }
            double[] var399;
            if (input[4] <= 1.9012749791145325) {
                if (input[2] <= 2.175404667854309) {
                    if (input[2] <= 1.636903703212738) {
                        var399 = new double[2] {0.0, 1.0};
                    } else {
                        var399 = new double[2] {0.08333333333333333, 0.9166666666666666};
                    }
                } else {
                    if (input[1] <= 2.118072807788849) {
                        if (input[5] <= 1.273577094078064) {
                            if (input[3] <= 0.3167303279042244) {
                                var399 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.2107393741607666) {
                                    var399 = new double[2] {1.0, 0.0};
                                } else {
                                    var399 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var399 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var399 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var399 = new double[2] {1.0, 0.0};
            }
            double[] var400;
            if (input[4] <= 1.8872272968292236) {
                if (input[2] <= 2.175404667854309) {
                    var400 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= -0.16663679853081703) {
                        if (input[1] <= 3.163615584373474) {
                            if (input[5] <= 1.2801275551319122) {
                                var400 = new double[2] {0.0, 1.0};
                            } else {
                                var400 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var400 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 1.315471589565277) {
                            var400 = new double[2] {0.46153846153846156, 0.5384615384615384};
                        } else {
                            var400 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var400 = new double[2] {1.0, 0.0};
            }
            double[] var401;
            if (input[3] <= 0.3546835780143738) {
                if (input[4] <= 1.8059442043304443) {
                    if (input[4] <= -0.8651521503925323) {
                        if (input[1] <= 1.9352562427520752) {
                            var401 = new double[2] {0.0, 1.0};
                        } else {
                            var401 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= 2.1532992124557495) {
                            var401 = new double[2] {0.0, 1.0};
                        } else {
                            var401 = new double[2] {0.13333333333333333, 0.8666666666666667};
                        }
                    }
                } else {
                    var401 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= 2.118072807788849) {
                    if (input[4] <= 1.068716138601303) {
                        if (input[2] <= 1.6531969904899597) {
                            var401 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 1.4536904096603394) {
                                var401 = new double[2] {0.1, 0.9};
                            } else {
                                var401 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var401 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var401 = new double[2] {1.0, 0.0};
                }
            }
            double[] var402;
            if (input[3] <= 1.5816310048103333) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 1.4859262704849243) {
                        if (input[2] <= 0.43158040940761566) {
                            var402 = new double[2] {0.0, 1.0};
                        } else {
                            var402 = new double[2] {0.07142857142857142, 0.9285714285714286};
                        }
                    } else {
                        if (input[2] <= 2.09943163394928) {
                            var402 = new double[2] {0.6666666666666666, 0.3333333333333333};
                        } else {
                            if (input[1] <= 1.461741864681244) {
                                if (input[4] <= 1.002549171447754) {
                                    var402 = new double[2] {0.0, 1.0};
                                } else {
                                    var402 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var402 = new double[2] {0.6, 0.4};
                            }
                        }
                    }
                } else {
                    var402 = new double[2] {1.0, 0.0};
                }
            } else {
                var402 = new double[2] {0.8181818181818182, 0.18181818181818182};
            }
            double[] var403;
            if (input[1] <= 2.4045716524124146) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[2] <= 1.686274766921997) {
                        var403 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -1.36287122964859) {
                            var403 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.7294346988201141) {
                                if (input[4] <= 0.09287988767027855) {
                                    if (input[3] <= 1.4006642401218414) {
                                        var403 = new double[2] {0.0, 1.0};
                                    } else {
                                        var403 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var403 = new double[2] {0.25, 0.75};
                                }
                            } else {
                                var403 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var403 = new double[2] {1.0, 0.0};
                }
            } else {
                var403 = new double[2] {1.0, 0.0};
            }
            double[] var404;
            if (input[2] <= 0.40715569257736206) {
                var404 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 1.068716138601303) {
                    if (input[2] <= 2.171961545944214) {
                        var404 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 0.9808341264724731) {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[1] <= -1.2566050291061401) {
                                    var404 = new double[2] {1.0, 0.0};
                                } else {
                                    var404 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= -0.06388905085623264) {
                                    var404 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                } else {
                                    var404 = new double[2] {0.4, 0.6};
                                }
                            }
                        } else {
                            var404 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var404 = new double[2] {1.0, 0.0};
                }
            }
            double[] var405;
            if (input[1] <= 1.5263413786888123) {
                if (input[3] <= 1.1131262183189392) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[4] <= 1.7600783109664917) {
                            if (input[1] <= -1.4827032685279846) {
                                if (input[2] <= 0.9722183644771576) {
                                    var405 = new double[2] {0.0, 1.0};
                                } else {
                                    var405 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var405 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var405 = new double[2] {0.2, 0.8};
                        }
                    } else {
                        var405 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var405 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                var405 = new double[2] {0.8181818181818182, 0.18181818181818182};
            }
            double[] var406;
            if (input[4] <= 1.9012749791145325) {
                if (input[5] <= 4.369763493537903) {
                    if (input[3] <= 0.3589499741792679) {
                        if (input[4] <= 1.7611917853355408) {
                            if (input[1] <= 1.5053465366363525) {
                                var406 = new double[2] {0.0, 1.0};
                            } else {
                                var406 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var406 = new double[2] {0.2857142857142857, 0.7142857142857143};
                        }
                    } else {
                        if (input[4] <= -0.38663099706172943) {
                            var406 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -0.5460105687379837) {
                                var406 = new double[2] {0.8333333333333334, 0.16666666666666666};
                            } else {
                                var406 = new double[2] {0.15384615384615385, 0.8461538461538461};
                            }
                        }
                    }
                } else {
                    var406 = new double[2] {1.0, 0.0};
                }
            } else {
                var406 = new double[2] {1.0, 0.0};
            }
            double[] var407;
            if (input[5] <= 0.9808341264724731) {
                if (input[4] <= 2.034778654575348) {
                    if (input[2] <= 2.1580482721328735) {
                        var407 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.010825843550264835) {
                            if (input[5] <= -0.015444133430719376) {
                                if (input[1] <= 2.011483609676361) {
                                    if (input[0] <= -0.3421141058206558) {
                                        var407 = new double[2] {0.07142857142857142, 0.9285714285714286};
                                    } else {
                                        var407 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var407 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var407 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.4860239289700985) {
                                var407 = new double[2] {0.0, 1.0};
                            } else {
                                var407 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var407 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.7641697227954865) {
                    var407 = new double[2] {0.6, 0.4};
                } else {
                    if (input[5] <= 3.1940789222717285) {
                        var407 = new double[2] {1.0, 0.0};
                    } else {
                        var407 = new double[2] {0.8, 0.2};
                    }
                }
            }
            double[] var408;
            if (input[4] <= 1.9012749791145325) {
                if (input[3] <= 1.7416212558746338) {
                    if (input[5] <= 0.6243304014205933) {
                        if (input[4] <= -1.4582929611206055) {
                            if (input[0] <= 0.876292273402214) {
                                var408 = new double[2] {0.0, 1.0};
                            } else {
                                var408 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            if (input[1] <= 2.4804760217666626) {
                                if (input[3] <= 0.379926472902298) {
                                    var408 = new double[2] {0.0, 1.0};
                                } else {
                                    var408 = new double[2] {0.1111111111111111, 0.8888888888888888};
                                }
                            } else {
                                var408 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[1] <= 1.0208503007888794) {
                            var408 = new double[2] {0.0, 1.0};
                        } else {
                            var408 = new double[2] {0.5, 0.5};
                        }
                    }
                } else {
                    var408 = new double[2] {0.875, 0.125};
                }
            } else {
                var408 = new double[2] {1.0, 0.0};
            }
            double[] var409;
            if (input[5] <= 0.9808341264724731) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[5] <= 0.6243304014205933) {
                        if (input[1] <= 2.4149075746536255) {
                            if (input[3] <= 0.37566007673740387) {
                                if (input[4] <= 1.7611917853355408) {
                                    if (input[4] <= -0.8169131278991699) {
                                        if (input[4] <= -0.8219181299209595) {
                                            var409 = new double[2] {0.0, 1.0};
                                        } else {
                                            var409 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var409 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var409 = new double[2] {0.25, 0.75};
                                }
                            } else {
                                var409 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            var409 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var409 = new double[2] {0.2222222222222222, 0.7777777777777778};
                    }
                } else {
                    var409 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 1.862126350402832) {
                    var409 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= 1.6531969904899597) {
                        var409 = new double[2] {0.14285714285714285, 0.8571428571428571};
                    } else {
                        var409 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var410;
            if (input[5] <= 0.43870341777801514) {
                if (input[1] <= 1.790553331375122) {
                    var410 = new double[2] {0.0, 1.0};
                } else {
                    var410 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            } else {
                if (input[5] <= 0.9407775104045868) {
                    var410 = new double[2] {0.5, 0.5};
                } else {
                    if (input[2] <= 1.6334203481674194) {
                        var410 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        var410 = new double[2] {0.9285714285714286, 0.07142857142857142};
                    }
                }
            }
            double[] var411;
            if (input[5] <= 0.4139154553413391) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[1] <= -1.4827032685279846) {
                            if (input[3] <= 0.37494900822639465) {
                                var411 = new double[2] {0.0, 1.0};
                            } else {
                                var411 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var411 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var411 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var411 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                if (input[1] <= 0.5922326147556305) {
                    if (input[2] <= 1.6531969904899597) {
                        var411 = new double[2] {0.06666666666666667, 0.9333333333333333};
                    } else {
                        if (input[4] <= -0.40009383857250214) {
                            var411 = new double[2] {0.0, 1.0};
                        } else {
                            var411 = new double[2] {0.7222222222222222, 0.2777777777777778};
                        }
                    }
                } else {
                    var411 = new double[2] {0.9166666666666666, 0.08333333333333333};
                }
            }
            double[] var412;
            if (input[2] <= 0.9300557971000671) {
                var412 = new double[2] {0.0, 1.0};
            } else {
                if (input[3] <= 1.5816310048103333) {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[1] <= -1.2566050291061401) {
                            var412 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.5606600046157837) {
                                var412 = new double[2] {0.0, 1.0};
                            } else {
                                var412 = new double[2] {0.9, 0.1};
                            }
                        }
                    } else {
                        var412 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var412 = new double[2] {0.9285714285714286, 0.07142857142857142};
                }
            }
            double[] var413;
            if (input[2] <= 0.27639439702033997) {
                var413 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 1.315471589565277) {
                    if (input[2] <= 0.5217327326536179) {
                        var413 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= 2.0431366562843323) {
                            if (input[5] <= 0.10948532447218895) {
                                var413 = new double[2] {0.0, 1.0};
                            } else {
                                var413 = new double[2] {0.14285714285714285, 0.8571428571428571};
                            }
                        } else {
                            if (input[5] <= -0.12684859335422516) {
                                if (input[5] <= -0.3212409019470215) {
                                    var413 = new double[2] {0.0, 1.0};
                                } else {
                                    var413 = new double[2] {0.7, 0.3};
                                }
                            } else {
                                if (input[3] <= 1.3206691145896912) {
                                    if (input[1] <= 1.4578658938407898) {
                                        var413 = new double[2] {0.0, 1.0};
                                    } else {
                                        var413 = new double[2] {0.6666666666666666, 0.3333333333333333};
                                    }
                                } else {
                                    var413 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[3] <= 3.6247063875198364) {
                        var413 = new double[2] {0.625, 0.375};
                    } else {
                        var413 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var414;
            if (input[3] <= 1.5816310048103333) {
                if (input[2] <= 2.060991406440735) {
                    if (input[1] <= 1.8961734771728516) {
                        if (input[1] <= 0.6552171111106873) {
                            var414 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 2.2004266381263733) {
                                var414 = new double[2] {0.0, 1.0};
                            } else {
                                var414 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var414 = new double[2] {0.5, 0.5};
                    }
                } else {
                    if (input[4] <= 0.8806975781917572) {
                        if (input[3] <= -0.11035474017262459) {
                            var414 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= -0.8132353127002716) {
                                var414 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            } else {
                                if (input[1] <= -1.2566050291061401) {
                                    var414 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[1] <= 2.512775719165802) {
                                        var414 = new double[2] {0.0, 1.0};
                                    } else {
                                        var414 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var414 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var414 = new double[2] {0.8461538461538461, 0.15384615384615385};
            }
            double[] var415;
            if (input[3] <= 0.7842573821544647) {
                if (input[5] <= 1.2995903491973877) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[1] <= 2.1216257214546204) {
                            if (input[3] <= -0.4148695170879364) {
                                if (input[3] <= -0.41744713485240936) {
                                    var415 = new double[2] {0.0, 1.0};
                                } else {
                                    var415 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var415 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var415 = new double[2] {0.8571428571428571, 0.14285714285714285};
                        }
                    } else {
                        var415 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var415 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -1.0518246293067932) {
                    var415 = new double[2] {0.25, 0.75};
                } else {
                    if (input[5] <= 1.144736260175705) {
                        var415 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.8541556596755981) {
                            var415 = new double[2] {0.25, 0.75};
                        } else {
                            var415 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var416;
            if (input[3] <= 0.37566007673740387) {
                if (input[1] <= 1.790553331375122) {
                    if (input[2] <= 2.175404667854309) {
                        var416 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.3299857974052429) {
                            var416 = new double[2] {1.0, 0.0};
                        } else {
                            var416 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var416 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[0] <= -0.3421141058206558) {
                    if (input[5] <= 1.165518581867218) {
                        var416 = new double[2] {0.5454545454545454, 0.45454545454545453};
                    } else {
                        var416 = new double[2] {0.875, 0.125};
                    }
                } else {
                    var416 = new double[2] {0.125, 0.875};
                }
            }
            double[] var417;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8638737201690674) {
                    if (input[4] <= 2.034778654575348) {
                        if (input[1] <= -1.4827032685279846) {
                            if (input[4] <= -0.09058358334004879) {
                                var417 = new double[2] {0.0, 1.0};
                            } else {
                                var417 = new double[2] {0.09090909090909091, 0.9090909090909091};
                            }
                        } else {
                            if (input[4] <= 1.7611917853355408) {
                                var417 = new double[2] {0.0, 1.0};
                            } else {
                                var417 = new double[2] {0.25, 0.75};
                            }
                        }
                    } else {
                        var417 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var417 = new double[2] {0.7333333333333333, 0.26666666666666666};
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var417 = new double[2] {0.16666666666666666, 0.8333333333333334};
                } else {
                    var417 = new double[2] {1.0, 0.0};
                }
            }
            double[] var418;
            if (input[3] <= 0.49405285716056824) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[3] <= 0.379926472902298) {
                        if (input[3] <= 0.16162867844104767) {
                            var418 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.9081243872642517) {
                                var418 = new double[2] {0.0, 1.0};
                            } else {
                                var418 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var418 = new double[2] {0.25, 0.75};
                    }
                } else {
                    var418 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                if (input[3] <= 1.7416212558746338) {
                    if (input[4] <= 1.068716138601303) {
                        var418 = new double[2] {0.16666666666666666, 0.8333333333333334};
                    } else {
                        var418 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var418 = new double[2] {0.875, 0.125};
                }
            }
            double[] var419;
            if (input[5] <= 1.273577094078064) {
                if (input[4] <= 1.7611917853355408) {
                    if (input[1] <= 2.1216257214546204) {
                        var419 = new double[2] {0.0, 1.0};
                    } else {
                        var419 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var419 = new double[2] {0.75, 0.25};
                }
            } else {
                if (input[5] <= 1.862126350402832) {
                    var419 = new double[2] {1.0, 0.0};
                } else {
                    var419 = new double[2] {0.4, 0.6};
                }
            }
            double[] var420;
            if (input[2] <= 2.066565155982971) {
                if (input[4] <= 1.9211599230766296) {
                    var420 = new double[2] {0.0, 1.0};
                } else {
                    var420 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.06348920799791813) {
                    if (input[3] <= 1.4362176060676575) {
                        if (input[5] <= -0.06388905085623264) {
                            if (input[5] <= -0.3212409019470215) {
                                var420 = new double[2] {0.0, 1.0};
                            } else {
                                var420 = new double[2] {0.08333333333333333, 0.9166666666666666};
                            }
                        } else {
                            if (input[1] <= 1.7989512085914612) {
                                var420 = new double[2] {0.0, 1.0};
                            } else {
                                var420 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var420 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 0.29850921779870987) {
                        var420 = new double[2] {0.5, 0.5};
                    } else {
                        var420 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var421;
            if (input[3] <= 1.5816310048103333) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[4] <= 1.7611917853355408) {
                        if (input[2] <= 2.175404667854309) {
                            var421 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.26295583695173264) {
                                if (input[1] <= 2.011483609676361) {
                                    var421 = new double[2] {0.0, 1.0};
                                } else {
                                    var421 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.42614588141441345) {
                                    var421 = new double[2] {0.8333333333333334, 0.16666666666666666};
                                } else {
                                    var421 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                }
                            }
                        }
                    } else {
                        var421 = new double[2] {0.25, 0.75};
                    }
                } else {
                    var421 = new double[2] {1.0, 0.0};
                }
            } else {
                var421 = new double[2] {0.7692307692307693, 0.23076923076923078};
            }
            double[] var422;
            if (input[1] <= 1.8961734771728516) {
                if (input[5] <= 1.226828694343567) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[2] <= 0.9300557971000671) {
                            var422 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= 1.0241162478923798) {
                                var422 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= 1.4407605528831482) {
                                    var422 = new double[2] {0.0, 1.0};
                                } else {
                                    var422 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var422 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    if (input[4] <= -0.3684443533420563) {
                        var422 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.6334203481674194) {
                            var422 = new double[2] {0.0, 1.0};
                        } else {
                            var422 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var422 = new double[2] {1.0, 0.0};
            }
            double[] var423;
            if (input[4] <= 1.7611917853355408) {
                if (input[3] <= 1.0039772987365723) {
                    if (input[5] <= 0.6243304014205933) {
                        if (input[4] <= 0.0018342267721891403) {
                            if (input[4] <= -0.02324691228568554) {
                                if (input[3] <= -0.1068882867693901) {
                                    var423 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.8186227083206177) {
                                        if (input[3] <= -0.09062261134386063) {
                                            var423 = new double[2] {1.0, 0.0};
                                        } else {
                                            var423 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var423 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var423 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var423 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var423 = new double[2] {0.125, 0.875};
                    }
                } else {
                    if (input[5] <= 3.5527032613754272) {
                        var423 = new double[2] {0.5, 0.5};
                    } else {
                        var423 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var423 = new double[2] {0.9, 0.1};
            }
            double[] var424;
            if (input[1] <= 1.8961734771728516) {
                if (input[3] <= 1.5816310048103333) {
                    if (input[2] <= 0.43158040940761566) {
                        var424 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.5289958864450455) {
                            var424 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= 0.010082363151013851) {
                                if (input[0] <= 0.876292273402214) {
                                    var424 = new double[2] {0.0, 1.0};
                                } else {
                                    var424 = new double[2] {0.1, 0.9};
                                }
                            } else {
                                if (input[2] <= 1.5374759435653687) {
                                    var424 = new double[2] {0.5, 0.5};
                                } else {
                                    if (input[5] <= 3.2119393348693848) {
                                        if (input[1] <= 1.5263413786888123) {
                                            var424 = new double[2] {0.0, 1.0};
                                        } else {
                                            var424 = new double[2] {0.25, 0.75};
                                        }
                                    } else {
                                        var424 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var424 = new double[2] {0.75, 0.25};
                }
            } else {
                var424 = new double[2] {1.0, 0.0};
            }
            double[] var425;
            if (input[5] <= 1.273577094078064) {
                if (input[1] <= 2.549597442150116) {
                    if (input[1] <= 1.8638737201690674) {
                        if (input[5] <= -0.23891282081604004) {
                            if (input[5] <= -0.24197597056627274) {
                                var425 = new double[2] {0.0, 1.0};
                            } else {
                                var425 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            }
                        } else {
                            var425 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var425 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    var425 = new double[2] {1.0, 0.0};
                }
            } else {
                var425 = new double[2] {0.9, 0.1};
            }
            double[] var426;
            if (input[5] <= 0.9428510367870331) {
                if (input[2] <= 2.175404667854309) {
                    if (input[4] <= 2.034778654575348) {
                        var426 = new double[2] {0.0, 1.0};
                    } else {
                        var426 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.5557562410831451) {
                        if (input[3] <= 0.14740732312202454) {
                            var426 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.42614588141441345) {
                                var426 = new double[2] {0.5, 0.5};
                            } else {
                                var426 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var426 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[3] <= 0.5473829507827759) {
                    var426 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 2.394124984741211) {
                        var426 = new double[2] {1.0, 0.0};
                    } else {
                        var426 = new double[2] {0.6666666666666666, 0.3333333333333333};
                    }
                }
            }
            double[] var427;
            if (input[5] <= 1.055810660123825) {
                if (input[2] <= 0.43158040940761566) {
                    var427 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.5208013206720352) {
                        var427 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= -0.11035474017262459) {
                            var427 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.14892929047346115) {
                                if (input[3] <= -0.08315639942884445) {
                                    var427 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[5] <= -0.25295618921518326) {
                                        var427 = new double[2] {0.0, 1.0};
                                    } else {
                                        var427 = new double[2] {0.4166666666666667, 0.5833333333333334};
                                    }
                                }
                            } else {
                                if (input[4] <= 1.1749229691922665) {
                                    var427 = new double[2] {0.0, 1.0};
                                } else {
                                    var427 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= -0.9274705946445465) {
                    var427 = new double[2] {0.4, 0.6};
                } else {
                    var427 = new double[2] {1.0, 0.0};
                }
            }
            double[] var428;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[1] <= 0.14229710400104523) {
                        if (input[1] <= -1.4827032685279846) {
                            if (input[3] <= 0.37494900822639465) {
                                var428 = new double[2] {0.0, 1.0};
                            } else {
                                var428 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var428 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[5] <= 0.43870341777801514) {
                            if (input[4] <= 1.7600333094596863) {
                                var428 = new double[2] {0.0, 1.0};
                            } else {
                                var428 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var428 = new double[2] {0.5, 0.5};
                        }
                    }
                } else {
                    var428 = new double[2] {0.8571428571428571, 0.14285714285714285};
                }
            } else {
                if (input[1] <= -0.9655843079090118) {
                    var428 = new double[2] {0.2, 0.8};
                } else {
                    if (input[2] <= 1.8288052678108215) {
                        var428 = new double[2] {0.0, 1.0};
                    } else {
                        var428 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var429;
            if (input[2] <= 2.060991406440735) {
                if (input[4] <= 2.034778654575348) {
                    var429 = new double[2] {0.0, 1.0};
                } else {
                    var429 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 0.9808341264724731) {
                    if (input[5] <= -0.3212409019470215) {
                        var429 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[0] <= 0.876292273402214) {
                            if (input[1] <= 1.461741864681244) {
                                if (input[4] <= 1.002549171447754) {
                                    if (input[1] <= -1.2566050291061401) {
                                        var429 = new double[2] {1.0, 0.0};
                                    } else {
                                        var429 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var429 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var429 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var429 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        }
                    }
                } else {
                    var429 = new double[2] {1.0, 0.0};
                }
            }
            double[] var430;
            if (input[5] <= 1.273577094078064) {
                if (input[5] <= -0.290232390165329) {
                    var430 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 2.034778654575348) {
                        if (input[1] <= 2.4149075746536255) {
                            if (input[4] <= 1.7600783109664917) {
                                var430 = new double[2] {0.0, 1.0};
                            } else {
                                var430 = new double[2] {0.2, 0.8};
                            }
                        } else {
                            var430 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var430 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[5] <= 2.394124984741211) {
                    var430 = new double[2] {1.0, 0.0};
                } else {
                    var430 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            }
            double[] var431;
            if (input[4] <= 1.8199918866157532) {
                if (input[3] <= 0.777857780456543) {
                    if (input[2] <= 2.171961545944214) {
                        var431 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.14740732312202454) {
                            var431 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.19184906035661697) {
                                var431 = new double[2] {1.0, 0.0};
                            } else {
                                var431 = new double[2] {0.13333333333333333, 0.8666666666666667};
                            }
                        }
                    }
                } else {
                    var431 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                var431 = new double[2] {1.0, 0.0};
            }
            double[] var432;
            if (input[2] <= 0.43158040940761566) {
                var432 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 0.9808341264724731) {
                    if (input[4] <= 1.5741516947746277) {
                        if (input[3] <= 0.16162867844104767) {
                            if (input[5] <= -0.07911055721342564) {
                                var432 = new double[2] {0.0, 1.0};
                            } else {
                                var432 = new double[2] {0.09090909090909091, 0.9090909090909091};
                            }
                        } else {
                            if (input[4] <= -0.7735553681850433) {
                                var432 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            } else {
                                if (input[1] <= 2.7992745637893677) {
                                    var432 = new double[2] {0.05, 0.95};
                                } else {
                                    var432 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var432 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= -0.3684443533420563) {
                        var432 = new double[2] {0.5, 0.5};
                    } else {
                        if (input[2] <= 1.6334203481674194) {
                            var432 = new double[2] {0.5, 0.5};
                        } else {
                            var432 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var433;
            if (input[3] <= 0.7842573821544647) {
                if (input[5] <= 1.165518581867218) {
                    if (input[1] <= 1.8961734771728516) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[2] <= 2.175404667854309) {
                                var433 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.5606600046157837) {
                                    var433 = new double[2] {0.0, 1.0};
                                } else {
                                    var433 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var433 = new double[2] {0.125, 0.875};
                        }
                    } else {
                        var433 = new double[2] {0.75, 0.25};
                    }
                } else {
                    var433 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -1.0518246293067932) {
                    var433 = new double[2] {0.6666666666666666, 0.3333333333333333};
                } else {
                    var433 = new double[2] {1.0, 0.0};
                }
            }
            double[] var434;
            if (input[3] <= 1.4515056014060974) {
                if (input[2] <= 0.43158040940761566) {
                    var434 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 1.8638737201690674) {
                        if (input[2] <= 0.5208013206720352) {
                            var434 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= 1.273577094078064) {
                                if (input[5] <= 0.16122902184724808) {
                                    if (input[5] <= -0.17359700053930283) {
                                        var434 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= -0.3815382122993469) {
                                            var434 = new double[2] {1.0, 0.0};
                                        } else {
                                            var434 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.17087256163358688) {
                                        var434 = new double[2] {0.6666666666666666, 0.3333333333333333};
                                    } else {
                                        if (input[5] <= 0.17301037162542343) {
                                            var434 = new double[2] {1.0, 0.0};
                                        } else {
                                            var434 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var434 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var434 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var434 = new double[2] {0.9166666666666666, 0.08333333333333333};
            }
            double[] var435;
            if (input[5] <= 1.0937937498092651) {
                if (input[2] <= 1.4859262704849243) {
                    var435 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 0.4860239289700985) {
                        if (input[4] <= -1.4453137516975403) {
                            var435 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[0] <= -0.3421141058206558) {
                                var435 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= 2.1532992124557495) {
                                    var435 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= 0.40516938269138336) {
                                        var435 = new double[2] {0.36363636363636365, 0.6363636363636364};
                                    } else {
                                        var435 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var435 = new double[2] {0.8, 0.2};
                    }
                }
            } else {
                if (input[2] <= 1.6531969904899597) {
                    var435 = new double[2] {0.16666666666666666, 0.8333333333333334};
                } else {
                    var435 = new double[2] {1.0, 0.0};
                }
            }
            double[] var436;
            if (input[3] <= 0.3589499741792679) {
                if (input[5] <= 0.43870341777801514) {
                    if (input[2] <= 2.175404667854309) {
                        if (input[2] <= 0.4080871045589447) {
                            var436 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.6842871308326721) {
                                var436 = new double[2] {0.0, 1.0};
                            } else {
                                var436 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[0] <= -0.3421141058206558) {
                            var436 = new double[2] {0.1, 0.9};
                        } else {
                            var436 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    }
                } else {
                    var436 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            } else {
                if (input[5] <= 1.118770182132721) {
                    if (input[3] <= 0.42614588141441345) {
                        var436 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 1.4927335679531097) {
                            if (input[1] <= 2.4045716524124146) {
                                var436 = new double[2] {0.0, 1.0};
                            } else {
                                var436 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var436 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= -0.9833491444587708) {
                        var436 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    } else {
                        var436 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var437;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8638737201690674) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[4] <= 1.7600333094596863) {
                            if (input[5] <= -0.23801743984222412) {
                                if (input[5] <= -0.24197597056627274) {
                                    var437 = new double[2] {0.0, 1.0};
                                } else {
                                    var437 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                var437 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var437 = new double[2] {0.2, 0.8};
                        }
                    } else {
                        var437 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var437 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var437 = new double[2] {0.2, 0.8};
                } else {
                    var437 = new double[2] {1.0, 0.0};
                }
            }
            double[] var438;
            if (input[4] <= 1.7600783109664917) {
                if (input[3] <= 0.16162867844104767) {
                    if (input[4] <= -0.9245145916938782) {
                        if (input[3] <= -0.10777711868286133) {
                            var438 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= -0.9571088254451752) {
                                var438 = new double[2] {0.0, 1.0};
                            } else {
                                var438 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var438 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[0] <= 0.876292273402214) {
                        if (input[2] <= 1.9080232381820679) {
                            var438 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 1.201852262020111) {
                                var438 = new double[2] {0.16666666666666666, 0.8333333333333334};
                            } else {
                                var438 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[1] <= 2.4149075746536255) {
                            var438 = new double[2] {0.0, 1.0};
                        } else {
                            var438 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var438 = new double[2] {0.9230769230769231, 0.07692307692307693};
            }
            double[] var439;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[1] <= 1.5263413786888123) {
                        if (input[5] <= 0.43870341777801514) {
                            if (input[4] <= 1.9211599230766296) {
                                if (input[1] <= -1.4827032685279846) {
                                    if (input[1] <= -1.4946541786193848) {
                                        var439 = new double[2] {0.0, 1.0};
                                    } else {
                                        var439 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= -0.4137140214443207) {
                                        if (input[3] <= -0.41744713485240936) {
                                            var439 = new double[2] {0.0, 1.0};
                                        } else {
                                            var439 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var439 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var439 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var439 = new double[2] {0.1111111111111111, 0.8888888888888888};
                        }
                    } else {
                        var439 = new double[2] {0.3333333333333333, 0.6666666666666666};
                    }
                } else {
                    var439 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -1.0518246293067932) {
                    var439 = new double[2] {0.0, 1.0};
                } else {
                    var439 = new double[2] {1.0, 0.0};
                }
            }
            double[] var440;
            if (input[1] <= 1.5263413786888123) {
                if (input[3] <= 3.6247063875198364) {
                    if (input[4] <= 1.7934148907661438) {
                        if (input[3] <= 0.7842573821544647) {
                            if (input[3] <= 0.37566007673740387) {
                                var440 = new double[2] {0.0, 1.0};
                            } else {
                                var440 = new double[2] {0.125, 0.875};
                            }
                        } else {
                            var440 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var440 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var440 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.9895713329315186) {
                    var440 = new double[2] {0.25, 0.75};
                } else {
                    var440 = new double[2] {1.0, 0.0};
                }
            }
            double[] var441;
            if (input[3] <= 1.1131262183189392) {
                if (input[4] <= 1.9071122407913208) {
                    if (input[2] <= 2.175404667854309) {
                        var441 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.5918246805667877) {
                            if (input[1] <= 2.0848039984703064) {
                                if (input[5] <= -0.16902583837509155) {
                                    var441 = new double[2] {0.14285714285714285, 0.8571428571428571};
                                } else {
                                    var441 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var441 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var441 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var441 = new double[2] {1.0, 0.0};
                }
            } else {
                var441 = new double[2] {0.7777777777777778, 0.2222222222222222};
            }
            double[] var442;
            if (input[5] <= 0.9808341264724731) {
                if (input[5] <= 0.43870341777801514) {
                    if (input[3] <= 0.49405285716056824) {
                        if (input[4] <= 2.226238787174225) {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[2] <= 2.1580482721328735) {
                                    var442 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.08024745993316174) {
                                        var442 = new double[2] {0.0, 1.0};
                                    } else {
                                        var442 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var442 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var442 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var442 = new double[2] {0.4, 0.6};
                    }
                } else {
                    var442 = new double[2] {0.3, 0.7};
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var442 = new double[2] {0.42857142857142855, 0.5714285714285714};
                } else {
                    if (input[3] <= 0.6864855885505676) {
                        var442 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.6334203481674194) {
                            var442 = new double[2] {0.0, 1.0};
                        } else {
                            var442 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var443;
            if (input[3] <= 0.3589499741792679) {
                if (input[1] <= 2.011483609676361) {
                    if (input[5] <= 0.6243304014205933) {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[4] <= 1.7416442036628723) {
                                var443 = new double[2] {0.0, 1.0};
                            } else {
                                var443 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var443 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var443 = new double[2] {0.25, 0.75};
                    }
                } else {
                    var443 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.40516938269138336) {
                    var443 = new double[2] {1.0, 0.0};
                } else {
                    if (input[0] <= -0.3421141058206558) {
                        var443 = new double[2] {0.45454545454545453, 0.5454545454545454};
                    } else {
                        var443 = new double[2] {0.08333333333333333, 0.9166666666666666};
                    }
                }
            }
            double[] var444;
            if (input[1] <= 1.8961734771728516) {
                if (input[3] <= 0.37494900822639465) {
                    if (input[4] <= 1.8199918866157532) {
                        if (input[5] <= 0.4947826415300369) {
                            if (input[1] <= 0.33028164505958557) {
                                var444 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 0.34546253085136414) {
                                    var444 = new double[2] {1.0, 0.0};
                                } else {
                                    var444 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var444 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var444 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= 0.26535914838314056) {
                        if (input[4] <= -0.16663679853081703) {
                            var444 = new double[2] {0.14285714285714285, 0.8571428571428571};
                        } else {
                            var444 = new double[2] {0.8823529411764706, 0.11764705882352941};
                        }
                    } else {
                        var444 = new double[2] {0.16666666666666666, 0.8333333333333334};
                    }
                }
            } else {
                var444 = new double[2] {0.8181818181818182, 0.18181818181818182};
            }
            double[] var445;
            if (input[5] <= 0.9808341264724731) {
                if (input[4] <= 1.7600333094596863) {
                    if (input[2] <= 2.1532992124557495) {
                        var445 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 0.12216205149888992) {
                            if (input[3] <= 0.13851897791028023) {
                                var445 = new double[2] {0.0, 1.0};
                            } else {
                                var445 = new double[2] {0.6666666666666666, 0.3333333333333333};
                            }
                        } else {
                            var445 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var445 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                if (input[5] <= 2.5101007223129272) {
                    var445 = new double[2] {0.7142857142857143, 0.2857142857142857};
                } else {
                    var445 = new double[2] {1.0, 0.0};
                }
            }
            double[] var446;
            if (input[2] <= 2.060991406440735) {
                if (input[4] <= 2.1863789558410645) {
                    var446 = new double[2] {0.0, 1.0};
                } else {
                    var446 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.7309273183345795) {
                    if (input[1] <= 1.512775480747223) {
                        if (input[4] <= 1.034772276878357) {
                            var446 = new double[2] {0.0, 1.0};
                        } else {
                            var446 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var446 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var446 = new double[2] {1.0, 0.0};
                }
            }
            double[] var447;
            if (input[1] <= 2.1216257214546204) {
                if (input[4] <= 1.7600333094596863) {
                    if (input[3] <= 1.5816310048103333) {
                        if (input[5] <= 0.5672143995761871) {
                            if (input[3] <= 0.37494900822639465) {
                                var447 = new double[2] {0.0, 1.0};
                            } else {
                                var447 = new double[2] {0.125, 0.875};
                            }
                        } else {
                            var447 = new double[2] {0.1, 0.9};
                        }
                    } else {
                        var447 = new double[2] {0.8, 0.2};
                    }
                } else {
                    var447 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                var447 = new double[2] {0.9166666666666666, 0.08333333333333333};
            }
            double[] var448;
            if (input[4] <= 1.9211599230766296) {
                if (input[2] <= 2.066565155982971) {
                    if (input[1] <= -2.0456879138946533) {
                        var448 = new double[2] {1.0, 0.0};
                    } else {
                        var448 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= 2.0848039984703064) {
                        if (input[5] <= 1.4536904096603394) {
                            if (input[1] <= 0.33867958188056946) {
                                var448 = new double[2] {0.0, 1.0};
                            } else {
                                var448 = new double[2] {0.08333333333333333, 0.9166666666666666};
                            }
                        } else {
                            var448 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var448 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var448 = new double[2] {1.0, 0.0};
            }
            double[] var449;
            if (input[2] <= 0.40715569257736206) {
                var449 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 0.06575176492333412) {
                    if (input[3] <= 1.8571697473526) {
                        if (input[3] <= 0.16162867844104767) {
                            var449 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= -0.8083765506744385) {
                                var449 = new double[2] {0.75, 0.25};
                            } else {
                                var449 = new double[2] {0.09090909090909091, 0.9090909090909091};
                            }
                        }
                    } else {
                        var449 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.7532561421394348) {
                        var449 = new double[2] {0.5714285714285714, 0.42857142857142855};
                    } else {
                        var449 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var450;
            if (input[5] <= 0.9808341264724731) {
                if (input[1] <= 2.1171037554740906) {
                    if (input[2] <= 2.171961545944214) {
                        var450 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.14740732312202454) {
                            var450 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.1383879482746124) {
                                var450 = new double[2] {1.0, 0.0};
                            } else {
                                var450 = new double[2] {0.13333333333333333, 0.8666666666666667};
                            }
                        }
                    }
                } else {
                    var450 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var450 = new double[2] {0.16666666666666666, 0.8333333333333334};
                } else {
                    var450 = new double[2] {1.0, 0.0};
                }
            }
            double[] var451;
            if (input[5] <= 1.273577094078064) {
                if (input[2] <= 0.4325118213891983) {
                    var451 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 1.8638737201690674) {
                        if (input[4] <= 0.7294346988201141) {
                            if (input[3] <= 0.3639274537563324) {
                                var451 = new double[2] {0.0, 1.0};
                            } else {
                                var451 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            var451 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        }
                    } else {
                        var451 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var451 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 2.785557508468628) {
                        var451 = new double[2] {1.0, 0.0};
                    } else {
                        var451 = new double[2] {0.9090909090909091, 0.09090909090909091};
                    }
                }
            }
            double[] var452;
            if (input[4] <= 1.8199918866157532) {
                if (input[3] <= 0.7842573821544647) {
                    if (input[1] <= 2.1216257214546204) {
                        if (input[4] <= 0.05114172212779522) {
                            var452 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 0.05647286958992481) {
                                var452 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= 2.0124151706695557) {
                                    var452 = new double[2] {0.0, 1.0};
                                } else {
                                    var452 = new double[2] {0.125, 0.875};
                                }
                            }
                        }
                    } else {
                        var452 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var452 = new double[2] {0.5333333333333333, 0.4666666666666667};
                }
            } else {
                var452 = new double[2] {1.0, 0.0};
            }
            double[] var453;
            if (input[3] <= 1.5816310048103333) {
                if (input[4] <= 1.9211599230766296) {
                    if (input[2] <= 2.175404667854309) {
                        var453 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -0.06348920799791813) {
                            if (input[4] <= -1.4453137516975403) {
                                var453 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 0.2362907975912094) {
                                    if (input[0] <= -0.3421141058206558) {
                                        var453 = new double[2] {0.0, 1.0};
                                    } else {
                                        var453 = new double[2] {0.5, 0.5};
                                    }
                                } else {
                                    var453 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var453 = new double[2] {0.75, 0.25};
                        }
                    }
                } else {
                    var453 = new double[2] {1.0, 0.0};
                }
            } else {
                var453 = new double[2] {1.0, 0.0};
            }
            double[] var454;
            if (input[5] <= 4.369763493537903) {
                if (input[1] <= 1.5263413786888123) {
                    if (input[2] <= 0.40715569257736206) {
                        var454 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 1.4407605528831482) {
                            if (input[3] <= 1.5816310048103333) {
                                var454 = new double[2] {0.0, 1.0};
                            } else {
                                var454 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var454 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var454 = new double[2] {0.5, 0.5};
                }
            } else {
                var454 = new double[2] {1.0, 0.0};
            }
            double[] var455;
            if (input[3] <= 0.777857780456543) {
                if (input[5] <= 0.4139154553413391) {
                    if (input[2] <= 2.175404667854309) {
                        var455 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[0] <= 0.876292273402214) {
                            if (input[4] <= -1.0053140819072723) {
                                var455 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.03971371799707413) {
                                    var455 = new double[2] {0.7692307692307693, 0.23076923076923078};
                                } else {
                                    var455 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var455 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var455 = new double[2] {0.4166666666666667, 0.5833333333333334};
                }
            } else {
                var455 = new double[2] {0.6111111111111112, 0.3888888888888889};
            }
            double[] var456;
            if (input[3] <= 1.5816310048103333) {
                if (input[4] <= 1.8059442043304443) {
                    if (input[3] <= 1.1131262183189392) {
                        if (input[1] <= 2.4804760217666626) {
                            var456 = new double[2] {0.0, 1.0};
                        } else {
                            var456 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var456 = new double[2] {0.2, 0.8};
                    }
                } else {
                    var456 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= 1.6334203481674194) {
                    var456 = new double[2] {0.25, 0.75};
                } else {
                    var456 = new double[2] {1.0, 0.0};
                }
            }
            double[] var457;
            if (input[3] <= 0.3589499741792679) {
                if (input[2] <= 2.175404667854309) {
                    var457 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 0.5606600046157837) {
                        if (input[1] <= 2.1206567883491516) {
                            var457 = new double[2] {0.0, 1.0};
                        } else {
                            var457 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var457 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[5] <= 1.118770182132721) {
                    if (input[3] <= 0.42614588141441345) {
                        var457 = new double[2] {1.0, 0.0};
                    } else {
                        var457 = new double[2] {0.25, 0.75};
                    }
                } else {
                    if (input[4] <= -0.3699514716863632) {
                        var457 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 2.785557508468628) {
                            var457 = new double[2] {1.0, 0.0};
                        } else {
                            var457 = new double[2] {0.8333333333333334, 0.16666666666666666};
                        }
                    }
                }
            }
            double[] var458;
            if (input[1] <= 2.4149075746536255) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[2] <= 2.066565155982971) {
                        var458 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 1.2057636678218842) {
                            if (input[1] <= 1.512775480747223) {
                                var458 = new double[2] {0.0, 1.0};
                            } else {
                                var458 = new double[2] {0.5, 0.5};
                            }
                        } else {
                            var458 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var458 = new double[2] {1.0, 0.0};
                }
            } else {
                var458 = new double[2] {1.0, 0.0};
            }
            double[] var459;
            if (input[3] <= 1.1131262183189392) {
                if (input[1] <= 2.4149075746536255) {
                    if (input[4] <= 1.8199918866157532) {
                        if (input[5] <= 1.273577094078064) {
                            if (input[3] <= 0.379926472902298) {
                                var459 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.42614588141441345) {
                                    var459 = new double[2] {1.0, 0.0};
                                } else {
                                    var459 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var459 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var459 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var459 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.5534618198871613) {
                    var459 = new double[2] {0.9411764705882353, 0.058823529411764705};
                } else {
                    var459 = new double[2] {0.5454545454545454, 0.45454545454545453};
                }
            }
            double[] var460;
            if (input[5] <= 1.273577094078064) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 0.40715569257736206) {
                        var460 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.5289958864450455) {
                            var460 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 1.4407605528831482) {
                                if (input[4] <= 0.7294346988201141) {
                                    if (input[2] <= 2.175404667854309) {
                                        var460 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= 0.31948571652173996) {
                                            var460 = new double[2] {0.0, 1.0};
                                        } else {
                                            var460 = new double[2] {0.09090909090909091, 0.9090909090909091};
                                        }
                                    }
                                } else {
                                    var460 = new double[2] {0.3333333333333333, 0.6666666666666666};
                                }
                            } else {
                                var460 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var460 = new double[2] {0.8, 0.2};
                }
            } else {
                var460 = new double[2] {0.875, 0.125};
            }
            double[] var461;
            if (input[2] <= 1.686274766921997) {
                if (input[1] <= 0.6552171111106873) {
                    var461 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.43158040940761566) {
                        var461 = new double[2] {0.0, 1.0};
                    } else {
                        var461 = new double[2] {0.4, 0.6};
                    }
                }
            } else {
                if (input[2] <= 1.7347450852394104) {
                    var461 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 2.4045716524124146) {
                        if (input[4] <= 0.7294346988201141) {
                            if (input[5] <= 3.4416285157203674) {
                                if (input[1] <= 2.0848039984703064) {
                                    var461 = new double[2] {0.0, 1.0};
                                } else {
                                    var461 = new double[2] {0.5, 0.5};
                                }
                            } else {
                                var461 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var461 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var461 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var462;
            if (input[4] <= 1.9012749791145325) {
                if (input[5] <= 2.853314995765686) {
                    if (input[1] <= 2.4804760217666626) {
                        if (input[4] <= -0.340866357088089) {
                            var462 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= 2.0431366562843323) {
                                var462 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.16902583837509155) {
                                    var462 = new double[2] {0.75, 0.25};
                                } else {
                                    var462 = new double[2] {0.18181818181818182, 0.8181818181818182};
                                }
                            }
                        }
                    } else {
                        var462 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var462 = new double[2] {0.7777777777777778, 0.2222222222222222};
                }
            } else {
                var462 = new double[2] {1.0, 0.0};
            }
            double[] var463;
            if (input[1] <= 2.1216257214546204) {
                if (input[3] <= 3.702746033668518) {
                    if (input[4] <= 2.2004266381263733) {
                        var463 = new double[2] {0.0, 1.0};
                    } else {
                        var463 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var463 = new double[2] {1.0, 0.0};
                }
            } else {
                var463 = new double[2] {1.0, 0.0};
            }
            double[] var464;
            if (input[2] <= 0.40715569257736206) {
                var464 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 1.165518581867218) {
                    if (input[3] <= -0.5289958864450455) {
                        var464 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= 1.0061759054660797) {
                            var464 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 1.4407605528831482) {
                                if (input[0] <= -0.3421141058206558) {
                                    var464 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.7446052134037018) {
                                        if (input[1] <= 2.011483609676361) {
                                            var464 = new double[2] {0.0, 1.0};
                                        } else {
                                            var464 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var464 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var464 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var464 = new double[2] {0.7272727272727273, 0.2727272727272727};
                }
            }
            double[] var465;
            if (input[5] <= 1.118770182132721) {
                if (input[3] <= 1.611495852470398) {
                    if (input[4] <= 2.034778654575348) {
                        if (input[1] <= 1.5263413786888123) {
                            if (input[3] <= 0.379926472902298) {
                                var465 = new double[2] {0.0, 1.0};
                            } else {
                                var465 = new double[2] {0.08333333333333333, 0.9166666666666666};
                            }
                        } else {
                            var465 = new double[2] {0.8571428571428571, 0.14285714285714285};
                        }
                    } else {
                        var465 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var465 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.3684443533420563) {
                    var465 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 2.785557508468628) {
                        var465 = new double[2] {1.0, 0.0};
                    } else {
                        var465 = new double[2] {0.8333333333333334, 0.16666666666666666};
                    }
                }
            }
            double[] var466;
            if (input[2] <= 0.2773258090019226) {
                var466 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 1.226828694343567) {
                    if (input[5] <= -0.7097427845001221) {
                        var466 = new double[2] {0.6, 0.4};
                    } else {
                        if (input[3] <= 0.010082363151013851) {
                            if (input[1] <= 2.011483609676361) {
                                var466 = new double[2] {0.0, 1.0};
                            } else {
                                var466 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 2.4149075746536255) {
                                if (input[4] <= 1.4927335679531097) {
                                    if (input[1] <= 1.5263413786888123) {
                                        var466 = new double[2] {0.0, 1.0};
                                    } else {
                                        var466 = new double[2] {0.2, 0.8};
                                    }
                                } else {
                                    var466 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var466 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var466 = new double[2] {0.9230769230769231, 0.07692307692307693};
                }
            }
            double[] var467;
            if (input[5] <= 1.0937937498092651) {
                if (input[2] <= 2.175404667854309) {
                    if (input[3] <= -0.5628604888916016) {
                        if (input[4] <= 2.088450014591217) {
                            var467 = new double[2] {0.0, 1.0};
                        } else {
                            var467 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 2.034778654575348) {
                            var467 = new double[2] {0.0, 1.0};
                        } else {
                            var467 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[4] <= 0.5606600046157837) {
                        if (input[3] <= 0.42614588141441345) {
                            if (input[1] <= 1.8842226266860962) {
                                if (input[3] <= 0.3639274537563324) {
                                    var467 = new double[2] {0.0, 1.0};
                                } else {
                                    var467 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var467 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var467 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var467 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[3] <= 1.1131262183189392) {
                    var467 = new double[2] {0.8, 0.2};
                } else {
                    var467 = new double[2] {1.0, 0.0};
                }
            }
            double[] var468;
            if (input[1] <= 1.5263413786888123) {
                if (input[3] <= 0.7842573821544647) {
                    if (input[5] <= 1.2746139168739319) {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[1] <= 0.1745968535542488) {
                                if (input[4] <= 1.8702553510665894) {
                                    if (input[4] <= -0.009008022025227547) {
                                        var468 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[2] <= 1.151950642466545) {
                                            var468 = new double[2] {0.0, 1.0};
                                        } else {
                                            var468 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var468 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var468 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var468 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var468 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var468 = new double[2] {0.6666666666666666, 0.3333333333333333};
                }
            } else {
                if (input[2] <= 1.9895713329315186) {
                    var468 = new double[2] {0.0, 1.0};
                } else {
                    var468 = new double[2] {0.9230769230769231, 0.07692307692307693};
                }
            }
            double[] var469;
            if (input[2] <= 1.9892690777778625) {
                if (input[3] <= 0.49405285716056824) {
                    if (input[5] <= 0.4139154553413391) {
                        var469 = new double[2] {0.0, 1.0};
                    } else {
                        var469 = new double[2] {0.5, 0.5};
                    }
                } else {
                    var469 = new double[2] {0.2, 0.8};
                }
            } else {
                if (input[1] <= 1.461741864681244) {
                    if (input[4] <= 0.37141549587249756) {
                        if (input[4] <= -0.030490076169371605) {
                            var469 = new double[2] {0.0, 1.0};
                        } else {
                            var469 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var469 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var469 = new double[2] {1.0, 0.0};
                }
            }
            double[] var470;
            if (input[4] <= 1.8059442043304443) {
                if (input[5] <= 2.853314995765686) {
                    if (input[2] <= 2.175404667854309) {
                        var470 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 0.9428510367870331) {
                            if (input[5] <= -0.16398341953754425) {
                                if (input[4] <= -0.02962404675781727) {
                                    var470 = new double[2] {0.16666666666666666, 0.8333333333333334};
                                } else {
                                    var470 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 2.226922929286957) {
                                    var470 = new double[2] {0.0, 1.0};
                                } else {
                                    var470 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var470 = new double[2] {0.8, 0.2};
                        }
                    }
                } else {
                    var470 = new double[2] {0.8888888888888888, 0.1111111111111111};
                }
            } else {
                var470 = new double[2] {1.0, 0.0};
            }
            double[] var471;
            if (input[2] <= 1.4859262704849243) {
                var471 = new double[2] {0.0, 1.0};
            } else {
                if (input[1] <= 2.4045716524124146) {
                    if (input[3] <= 3.6247063875198364) {
                        if (input[4] <= 0.7532561421394348) {
                            if (input[1] <= -1.36287122964859) {
                                var471 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -0.8132353127002716) {
                                    if (input[4] <= -0.9143022000789642) {
                                        var471 = new double[2] {0.0, 1.0};
                                    } else {
                                        var471 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var471 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var471 = new double[2] {0.8, 0.2};
                        }
                    } else {
                        var471 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var471 = new double[2] {1.0, 0.0};
                }
            }
            double[] var472;
            if (input[5] <= 1.165518581867218) {
                if (input[2] <= 0.40715569257736206) {
                    var472 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 1.512775480747223) {
                        if (input[1] <= -1.36287122964859) {
                            var472 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -0.5066861361265182) {
                                var472 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= 1.0241162478923798) {
                                    var472 = new double[2] {0.125, 0.875};
                                } else {
                                    if (input[1] <= 0.33867958188056946) {
                                        var472 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= -0.38331587612628937) {
                                            var472 = new double[2] {0.5, 0.5};
                                        } else {
                                            var472 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var472 = new double[2] {0.7272727272727273, 0.2727272727272727};
                    }
                }
            } else {
                if (input[4] <= -0.3699514716863632) {
                    var472 = new double[2] {0.0, 1.0};
                } else {
                    var472 = new double[2] {1.0, 0.0};
                }
            }
            double[] var473;
            if (input[2] <= 0.22912395966704935) {
                var473 = new double[2] {0.0, 1.0};
            } else {
                if (input[5] <= 0.43870341777801514) {
                    if (input[3] <= 0.26020044833421707) {
                        if (input[1] <= 1.6842871308326721) {
                            if (input[4] <= 1.4407605528831482) {
                                var473 = new double[2] {0.0, 1.0};
                            } else {
                                var473 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var473 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var473 = new double[2] {0.5, 0.5};
                    }
                } else {
                    if (input[1] <= 0.5583178699016571) {
                        if (input[5] <= 1.226828694343567) {
                            var473 = new double[2] {0.25, 0.75};
                        } else {
                            var473 = new double[2] {0.8461538461538461, 0.15384615384615385};
                        }
                    } else {
                        var473 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var474;
            if (input[1] <= 1.8961734771728516) {
                if (input[2] <= 0.8235533237457275) {
                    var474 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 0.05027569271624088) {
                        if (input[3] <= 1.5517660975456238) {
                            var474 = new double[2] {0.0, 1.0};
                        } else {
                            var474 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 1.3808807730674744) {
                            var474 = new double[2] {0.5454545454545454, 0.45454545454545453};
                        } else {
                            var474 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var474 = new double[2] {0.9285714285714286, 0.07142857142857142};
            }
            double[] var475;
            if (input[2] <= 0.43158040940761566) {
                var475 = new double[2] {0.0, 1.0};
            } else {
                if (input[2] <= 0.5208013206720352) {
                    var475 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= 2.175404667854309) {
                        if (input[4] <= 1.2994626462459564) {
                            if (input[5] <= 4.143797218799591) {
                                var475 = new double[2] {0.0, 1.0};
                            } else {
                                var475 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var475 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 2.0848039984703064) {
                            if (input[3] <= 1.4362176060676575) {
                                if (input[1] <= -1.3619022369384766) {
                                    var475 = new double[2] {1.0, 0.0};
                                } else {
                                    var475 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var475 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var475 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var476;
            if (input[4] <= 1.874697983264923) {
                if (input[5] <= 1.165518581867218) {
                    if (input[4] <= -0.8186227083206177) {
                        if (input[2] <= 2.175404667854309) {
                            var476 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.4336410760879517) {
                                var476 = new double[2] {0.0, 1.0};
                            } else {
                                var476 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var476 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= -0.335093192756176) {
                        var476 = new double[2] {0.4166666666666667, 0.5833333333333334};
                    } else {
                        var476 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var476 = new double[2] {1.0, 0.0};
            }
            double[] var477;
            if (input[4] <= 1.8199918866157532) {
                if (input[2] <= 1.6531969904899597) {
                    var477 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 1.165518581867218) {
                        if (input[0] <= -0.3421141058206558) {
                            if (input[4] <= 0.05114172212779522) {
                                var477 = new double[2] {0.0, 1.0};
                            } else {
                                var477 = new double[2] {0.25, 0.75};
                            }
                        } else {
                            if (input[1] <= 2.011483609676361) {
                                if (input[1] <= 1.461741864681244) {
                                    var477 = new double[2] {0.0, 1.0};
                                } else {
                                    var477 = new double[2] {0.25, 0.75};
                                }
                            } else {
                                var477 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var477 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var477 = new double[2] {1.0, 0.0};
            }
            double[] var478;
            if (input[3] <= 0.3546835780143738) {
                if (input[2] <= 1.4859262704849243) {
                    var478 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 0.5606600046157837) {
                        if (input[1] <= 2.011483609676361) {
                            var478 = new double[2] {0.0, 1.0};
                        } else {
                            var478 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var478 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[5] <= 3.5527032613754272) {
                    if (input[3] <= 0.43503423035144806) {
                        var478 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= 1.9080232381820679) {
                            var478 = new double[2] {0.0, 1.0};
                        } else {
                            var478 = new double[2] {0.5384615384615384, 0.46153846153846156};
                        }
                    }
                } else {
                    var478 = new double[2] {1.0, 0.0};
                }
            }
            double[] var479;
            if (input[4] <= 1.8059442043304443) {
                if (input[2] <= 2.066565155982971) {
                    var479 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 0.8789961040019989) {
                        if (input[3] <= 0.15629567205905914) {
                            if (input[1] <= 3.2834476828575134) {
                                var479 = new double[2] {0.0, 1.0};
                            } else {
                                var479 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= -0.23966453038156033) {
                                var479 = new double[2] {0.16666666666666666, 0.8333333333333334};
                            } else {
                                var479 = new double[2] {0.8571428571428571, 0.14285714285714285};
                            }
                        }
                    } else {
                        var479 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var479 = new double[2] {1.0, 0.0};
            }
            double[] var480;
            if (input[2] <= 1.2749791145324707) {
                if (input[2] <= 0.4325118213891983) {
                    var480 = new double[2] {0.0, 1.0};
                } else {
                    var480 = new double[2] {0.08333333333333333, 0.9166666666666666};
                }
            } else {
                if (input[0] <= -0.3421141058206558) {
                    if (input[3] <= 1.611495852470398) {
                        if (input[4] <= 1.4407605528831482) {
                            if (input[5] <= 1.165518581867218) {
                                var480 = new double[2] {0.0, 1.0};
                            } else {
                                var480 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var480 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var480 = new double[2] {0.8, 0.2};
                    }
                } else {
                    if (input[5] <= -0.3212409019470215) {
                        var480 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 2.15210223197937) {
                            var480 = new double[2] {1.0, 0.0};
                        } else {
                            var480 = new double[2] {0.6428571428571429, 0.35714285714285715};
                        }
                    }
                }
            }
            double[] var481;
            if (input[1] <= 1.8638737201690674) {
                if (input[5] <= 1.315471589565277) {
                    if (input[5] <= 0.43870341777801514) {
                        if (input[4] <= 1.9211599230766296) {
                            if (input[4] <= 1.7611917853355408) {
                                var481 = new double[2] {0.0, 1.0};
                            } else {
                                var481 = new double[2] {0.3333333333333333, 0.6666666666666666};
                            }
                        } else {
                            var481 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 0.05870161997154355) {
                            var481 = new double[2] {1.0, 0.0};
                        } else {
                            var481 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= 1.8485819101333618) {
                        var481 = new double[2] {0.16666666666666666, 0.8333333333333334};
                    } else {
                        var481 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var481 = new double[2] {0.9, 0.1};
            }
            double[] var482;
            if (input[2] <= 1.4859262704849243) {
                if (input[1] <= -0.4888400137424469) {
                    if (input[4] <= 1.8456690907478333) {
                        var482 = new double[2] {0.0, 1.0};
                    } else {
                        var482 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var482 = new double[2] {0.0, 1.0};
                }
            } else {
                if (input[2] <= 1.53399258852005) {
                    var482 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= 2.060991406440735) {
                        var482 = new double[2] {0.08333333333333333, 0.9166666666666666};
                    } else {
                        if (input[4] <= -0.14648190699517727) {
                            if (input[4] <= -1.4453137516975403) {
                                var482 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -0.9739682972431183) {
                                    var482 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= 3.2772609293460846) {
                                        if (input[3] <= -0.07480135187506676) {
                                            var482 = new double[2] {0.36363636363636365, 0.6363636363636364};
                                        } else {
                                            var482 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var482 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.5473829507827759) {
                                var482 = new double[2] {0.6363636363636364, 0.36363636363636365};
                            } else {
                                var482 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var483;
            if (input[2] <= 0.43158040940761566) {
                var483 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 1.150134265422821) {
                    if (input[1] <= 2.011483609676361) {
                        if (input[4] <= -0.41461390256881714) {
                            var483 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.2618063688278198) {
                                if (input[3] <= 1.302892416715622) {
                                    var483 = new double[2] {0.0, 1.0};
                                } else {
                                    var483 = new double[2] {0.7142857142857143, 0.2857142857142857};
                                }
                            } else {
                                var483 = new double[2] {0.75, 0.25};
                            }
                        }
                    } else {
                        var483 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var483 = new double[2] {1.0, 0.0};
                }
            }
            double[] var484;
            if (input[1] <= 2.4045716524124146) {
                if (input[3] <= 0.7641697227954865) {
                    if (input[4] <= 2.020730972290039) {
                        if (input[1] <= 1.512775480747223) {
                            if (input[5] <= -0.23990245163440704) {
                                if (input[1] <= -1.4827032685279846) {
                                    var484 = new double[2] {0.42857142857142855, 0.5714285714285714};
                                } else {
                                    var484 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var484 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var484 = new double[2] {0.2222222222222222, 0.7777777777777778};
                        }
                    } else {
                        var484 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var484 = new double[2] {0.8181818181818182, 0.18181818181818182};
                }
            } else {
                var484 = new double[2] {1.0, 0.0};
            }
            double[] var485;
            if (input[1] <= 2.4045716524124146) {
                if (input[5] <= 1.273577094078064) {
                    if (input[4] <= 1.9211599230766296) {
                        if (input[3] <= 0.379926472902298) {
                            if (input[3] <= -0.413802906870842) {
                                if (input[3] <= -0.4202025234699249) {
                                    var485 = new double[2] {0.0, 1.0};
                                } else {
                                    var485 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var485 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var485 = new double[2] {0.21428571428571427, 0.7857142857142857};
                        }
                    } else {
                        var485 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= -0.3699514716863632) {
                        var485 = new double[2] {0.0, 1.0};
                    } else {
                        var485 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var485 = new double[2] {1.0, 0.0};
            }
            double[] var486;
            if (input[4] <= 1.7611917853355408) {
                if (input[1] <= 2.1216257214546204) {
                    if (input[3] <= 1.4515056014060974) {
                        if (input[1] <= 1.5263413786888123) {
                            var486 = new double[2] {0.0, 1.0};
                        } else {
                            var486 = new double[2] {0.16666666666666666, 0.8333333333333334};
                        }
                    } else {
                        var486 = new double[2] {0.8571428571428571, 0.14285714285714285};
                    }
                } else {
                    var486 = new double[2] {0.9, 0.1};
                }
            } else {
                var486 = new double[2] {1.0, 0.0};
            }
            double[] var487;
            if (input[1] <= 2.1216257214546204) {
                if (input[3] <= 1.9727182388305664) {
                    if (input[5] <= 1.226828694343567) {
                        if (input[1] <= 1.4933956265449524) {
                            if (input[5] <= -0.23990245163440704) {
                                if (input[5] <= -0.24197597056627274) {
                                    var487 = new double[2] {0.0, 1.0};
                                } else {
                                    var487 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var487 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var487 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var487 = new double[2] {0.42857142857142855, 0.5714285714285714};
                    }
                } else {
                    var487 = new double[2] {0.8333333333333334, 0.16666666666666666};
                }
            } else {
                var487 = new double[2] {1.0, 0.0};
            }
            double[] var488;
            if (input[1] <= 2.1216257214546204) {
                if (input[4] <= 1.8059442043304443) {
                    if (input[5] <= 1.315471589565277) {
                        if (input[4] <= 1.7611917853355408) {
                            if (input[0] <= -0.3421141058206558) {
                                if (input[4] <= 0.05178280919790268) {
                                    var488 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= 0.3605498820543289) {
                                        var488 = new double[2] {0.0, 1.0};
                                    } else {
                                        var488 = new double[2] {0.25, 0.75};
                                    }
                                }
                            } else {
                                var488 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var488 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var488 = new double[2] {0.9, 0.1};
                    }
                } else {
                    var488 = new double[2] {1.0, 0.0};
                }
            } else {
                var488 = new double[2] {1.0, 0.0};
            }
            double[] var489;
            if (input[5] <= 0.9808341264724731) {
                if (input[0] <= 0.876292273402214) {
                    if (input[0] <= -0.3421141058206558) {
                        var489 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 3.1561866402626038) {
                            var489 = new double[2] {0.0, 1.0};
                        } else {
                            var489 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 0.28953199088573456) {
                        if (input[4] <= -0.8789861500263214) {
                            if (input[4] <= -0.9329611957073212) {
                                var489 = new double[2] {0.0, 1.0};
                            } else {
                                var489 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var489 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var489 = new double[2] {0.2857142857142857, 0.7142857142857143};
                    }
                }
            } else {
                if (input[1] <= -0.9833491444587708) {
                    var489 = new double[2] {0.2, 0.8};
                } else {
                    if (input[5] <= 1.118770182132721) {
                        var489 = new double[2] {0.5, 0.5};
                    } else {
                        var489 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var490;
            if (input[3] <= 1.7416212558746338) {
                if (input[4] <= 1.8199918866157532) {
                    if (input[2] <= 1.9892690777778625) {
                        var490 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 1.165518581867218) {
                            if (input[4] <= -1.4453137516975403) {
                                var490 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= 0.18224695324897766) {
                                    if (input[4] <= -0.1141126211732626) {
                                        if (input[1] <= 2.011483609676361) {
                                            var490 = new double[2] {0.0, 1.0};
                                        } else {
                                            var490 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var490 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var490 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var490 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var490 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 4.369763493537903) {
                    var490 = new double[2] {0.8181818181818182, 0.18181818181818182};
                } else {
                    var490 = new double[2] {1.0, 0.0};
                }
            }
            double[] var491;
            if (input[1] <= 2.4045716524124146) {
                if (input[5] <= 1.201852262020111) {
                    if (input[4] <= 1.9071122407913208) {
                        if (input[1] <= 1.512775480747223) {
                            var491 = new double[2] {0.0, 1.0};
                        } else {
                            var491 = new double[2] {0.3333333333333333, 0.6666666666666666};
                        }
                    } else {
                        var491 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= 1.8288052678108215) {
                        var491 = new double[2] {0.0, 1.0};
                    } else {
                        var491 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var491 = new double[2] {1.0, 0.0};
            }
            double[] var492;
            if (input[3] <= 1.1131262183189392) {
                if (input[2] <= 0.40715569257736206) {
                    var492 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 1.6842871308326721) {
                        if (input[3] <= -0.5289958864450455) {
                            var492 = new double[2] {1.0, 0.0};
                        } else {
                            var492 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var492 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[5] <= 0.923718124628067) {
                    var492 = new double[2] {0.0, 1.0};
                } else {
                    var492 = new double[2] {0.9230769230769231, 0.07692307692307693};
                }
            }
            double[] var493;
            if (input[3] <= 1.5816310048103333) {
                if (input[3] <= 0.30695316195487976) {
                    if (input[1] <= 1.8961734771728516) {
                        if (input[4] <= 2.2004266381263733) {
                            var493 = new double[2] {0.0, 1.0};
                        } else {
                            var493 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var493 = new double[2] {0.75, 0.25};
                    }
                } else {
                    if (input[1] <= 2.4149075746536255) {
                        if (input[4] <= 1.068716138601303) {
                            if (input[4] <= 0.03569938801229) {
                                var493 = new double[2] {0.0, 1.0};
                            } else {
                                var493 = new double[2] {0.16666666666666666, 0.8333333333333334};
                            }
                        } else {
                            var493 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var493 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var493 = new double[2] {0.9090909090909091, 0.09090909090909091};
            }
            double[] var494;
            if (input[2] <= 0.4325118213891983) {
                var494 = new double[2] {0.0, 1.0};
            } else {
                if (input[4] <= 1.068716138601303) {
                    if (input[4] <= -0.3435094356536865) {
                        if (input[1] <= 2.0447524189949036) {
                            var494 = new double[2] {0.0, 1.0};
                        } else {
                            var494 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 1.4536904096603394) {
                            if (input[1] <= 2.7992745637893677) {
                                if (input[1] <= -1.2566050291061401) {
                                    var494 = new double[2] {1.0, 0.0};
                                } else {
                                    var494 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var494 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var494 = new double[2] {0.8888888888888888, 0.1111111111111111};
                        }
                    }
                } else {
                    var494 = new double[2] {1.0, 0.0};
                }
            }
            double[] var495;
            if (input[3] <= 1.7416212558746338) {
                if (input[2] <= 0.43158040940761566) {
                    var495 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.4729836583137512) {
                        if (input[1] <= 2.4149075746536255) {
                            if (input[1] <= -1.3619022369384766) {
                                var495 = new double[2] {1.0, 0.0};
                            } else {
                                var495 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var495 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var495 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var495 = new double[2] {0.7058823529411765, 0.29411764705882354};
            }
            double[] var496;
            if (input[1] <= 2.1216257214546204) {
                if (input[3] <= 1.4515056014060974) {
                    if (input[3] <= -0.562682718038559) {
                        if (input[5] <= 0.3953009098768234) {
                            var496 = new double[2] {0.0, 1.0};
                        } else {
                            var496 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= -0.3360621929168701) {
                            var496 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 1.3463387489318848) {
                                if (input[4] <= 1.9211599230766296) {
                                    if (input[2] <= 2.175404667854309) {
                                        var496 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[4] <= 1.1713238656520844) {
                                            var496 = new double[2] {0.0, 1.0};
                                        } else {
                                            var496 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var496 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var496 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var496 = new double[2] {0.875, 0.125};
                }
            } else {
                var496 = new double[2] {1.0, 0.0};
            }
            double[] var497;
            if (input[5] <= 1.165518581867218) {
                if (input[4] <= 1.7600783109664917) {
                    if (input[4] <= 0.8884468674659729) {
                        if (input[4] <= -0.8789861500263214) {
                            if (input[1] <= 1.905217468738556) {
                                var497 = new double[2] {0.0, 1.0};
                            } else {
                                var497 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= -1.4827032685279846) {
                                if (input[1] <= -1.496269166469574) {
                                    var497 = new double[2] {0.0, 1.0};
                                } else {
                                    var497 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var497 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[5] <= 0.4805978983640671) {
                            var497 = new double[2] {0.0, 1.0};
                        } else {
                            var497 = new double[2] {0.6, 0.4};
                        }
                    }
                } else {
                    var497 = new double[2] {0.8181818181818182, 0.18181818181818182};
                }
            } else {
                if (input[3] <= 1.5816310048103333) {
                    var497 = new double[2] {0.6666666666666666, 0.3333333333333333};
                } else {
                    var497 = new double[2] {1.0, 0.0};
                }
            }
            double[] var498;
            if (input[1] <= 1.5263413786888123) {
                if (input[3] <= 0.7641697227954865) {
                    if (input[4] <= 1.9211599230766296) {
                        var498 = new double[2] {0.0, 1.0};
                    } else {
                        var498 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 3.6247063875198364) {
                        var498 = new double[2] {0.5, 0.5};
                    } else {
                        var498 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var498 = new double[2] {0.7692307692307693, 0.23076923076923078};
            }
            double[] var499;
            if (input[5] <= 1.165518581867218) {
                if (input[1] <= 1.8961734771728516) {
                    if (input[2] <= 0.43158040940761566) {
                        var499 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.5289958864450455) {
                            var499 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.7294346988201141) {
                                var499 = new double[2] {0.0, 1.0};
                            } else {
                                var499 = new double[2] {0.8333333333333334, 0.16666666666666666};
                            }
                        }
                    }
                } else {
                    var499 = new double[2] {0.8181818181818182, 0.18181818181818182};
                }
            } else {
                var499 = new double[2] {0.875, 0.125};
            }
            return MulVectorNumber(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(var0, var1), var2), var3), var4), var5), var6), var7), var8), var9), var10), var11), var12), var13), var14), var15), var16), var17), var18), var19), var20), var21), var22), var23), var24), var25), var26), var27), var28), var29), var30), var31), var32), var33), var34), var35), var36), var37), var38), var39), var40), var41), var42), var43), var44), var45), var46), var47), var48), var49), var50), var51), var52), var53), var54), var55), var56), var57), var58), var59), var60), var61), var62), var63), var64), var65), var66), var67), var68), var69), var70), var71), var72), var73), var74), var75), var76), var77), var78), var79), var80), var81), var82), var83), var84), var85), var86), var87), var88), var89), var90), var91), var92), var93), var94), var95), var96), var97), var98), var99), var100), var101), var102), var103), var104), var105), var106), var107), var108), var109), var110), var111), var112), var113), var114), var115), var116), var117), var118), var119), var120), var121), var122), var123), var124), var125), var126), var127), var128), var129), var130), var131), var132), var133), var134), var135), var136), var137), var138), var139), var140), var141), var142), var143), var144), var145), var146), var147), var148), var149), var150), var151), var152), var153), var154), var155), var156), var157), var158), var159), var160), var161), var162), var163), var164), var165), var166), var167), var168), var169), var170), var171), var172), var173), var174), var175), var176), var177), var178), var179), var180), var181), var182), var183), var184), var185), var186), var187), var188), var189), var190), var191), var192), var193), var194), var195), var196), var197), var198), var199), var200), var201), var202), var203), var204), var205), var206), var207), var208), var209), var210), var211), var212), var213), var214), var215), var216), var217), var218), var219), var220), var221), var222), var223), var224), var225), var226), var227), var228), var229), var230), var231), var232), var233), var234), var235), var236), var237), var238), var239), var240), var241), var242), var243), var244), var245), var246), var247), var248), var249), var250), var251), var252), var253), var254), var255), var256), var257), var258), var259), var260), var261), var262), var263), var264), var265), var266), var267), var268), var269), var270), var271), var272), var273), var274), var275), var276), var277), var278), var279), var280), var281), var282), var283), var284), var285), var286), var287), var288), var289), var290), var291), var292), var293), var294), var295), var296), var297), var298), var299), var300), var301), var302), var303), var304), var305), var306), var307), var308), var309), var310), var311), var312), var313), var314), var315), var316), var317), var318), var319), var320), var321), var322), var323), var324), var325), var326), var327), var328), var329), var330), var331), var332), var333), var334), var335), var336), var337), var338), var339), var340), var341), var342), var343), var344), var345), var346), var347), var348), var349), var350), var351), var352), var353), var354), var355), var356), var357), var358), var359), var360), var361), var362), var363), var364), var365), var366), var367), var368), var369), var370), var371), var372), var373), var374), var375), var376), var377), var378), var379), var380), var381), var382), var383), var384), var385), var386), var387), var388), var389), var390), var391), var392), var393), var394), var395), var396), var397), var398), var399), var400), var401), var402), var403), var404), var405), var406), var407), var408), var409), var410), var411), var412), var413), var414), var415), var416), var417), var418), var419), var420), var421), var422), var423), var424), var425), var426), var427), var428), var429), var430), var431), var432), var433), var434), var435), var436), var437), var438), var439), var440), var441), var442), var443), var444), var445), var446), var447), var448), var449), var450), var451), var452), var453), var454), var455), var456), var457), var458), var459), var460), var461), var462), var463), var464), var465), var466), var467), var468), var469), var470), var471), var472), var473), var474), var475), var476), var477), var478), var479), var480), var481), var482), var483), var484), var485), var486), var487), var488), var489), var490), var491), var492), var493), var494), var495), var496), var497), var498), var499), 0.002);
        }
        private static double[] AddVectors(double[] v1, double[] v2) {
            double[] result = new double[v1.Length];
            for (int i = 0; i < v1.Length; ++i) {
                result[i] = v1[i] + v2[i];
            }
            return result;
        }
        private static double[] MulVectorNumber(double[] v1, double num) {
            double[] result = new double[v1.Length];
            for (int i = 0; i < v1.Length; ++i) {
                result[i] = v1[i] * num;
            }
            return result;
        }
    }
}

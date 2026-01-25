namespace ML {
    public static class RandomForestModel {
        public static double[] scaler_mean = new double[] { 0.2665, 7150.80, 47.00, 11.00, 116.77, 1, 1, 1, 1 }; 
        public static double[] scaler_scale = new double[] { 1.5, 200.5, 10.2, 5.5, 20.1, 1, 1, 1, 1 };
        public static double[] Score(double[] input) {
            double[] var0;
            if (input[2] <= -0.08034390211105347) {
                if (input[1] <= -1.4569376707077026) {
                    var0 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= -1.5863574147224426) {
                        var0 = new double[2] {0.0, 1.0};
                    } else {
                        var0 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[3] <= 0.5227826833724976) {
                    if (input[4] <= 0.8401710689067841) {
                        var0 = new double[2] {0.9462025316455697, 0.05379746835443039};
                    } else {
                        var0 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[4] <= -1.8147501349449158) {
                        var0 = new double[2] {0.7456359102244389, 0.25436408977556113};
                    } else {
                        var0 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var1;
            if (input[2] <= 0.03448438737541437) {
                if (input[2] <= -0.23821499198675156) {
                    if (input[2] <= -0.23894352465867996) {
                        if (input[3] <= 1.2324263453483582) {
                            if (input[3] <= -0.10846859216690063) {
                                if (input[4] <= -0.21608759462833405) {
                                    var1 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -1.4387269616127014) {
                                        var1 = new double[2] {1.0, 0.0};
                                    } else {
                                        var1 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[1] <= -1.5476825833320618) {
                                    var1 = new double[2] {1.0, 0.0};
                                } else {
                                    var1 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[3] <= 1.2745782732963562) {
                                var1 = new double[2] {1.0, 0.0};
                            } else {
                                var1 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        }
                    } else {
                        var1 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= -1.4168123602867126) {
                        var1 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        var1 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[1] <= -0.8470333218574524) {
                    var1 = new double[2] {1.0, 0.0};
                } else {
                    var1 = new double[2] {1.0, 0.0};
                }
            }
            double[] var2;
            if (input[5] <= -1.5950202941894531) {
                if (input[5] <= -1.773149013519287) {
                    var2 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= -1.645402729511261) {
                        var2 = new double[2] {0.0, 1.0};
                    } else {
                        var2 = new double[2] {0.9462025316455697, 0.053797468354430396};
                    }
                }
            } else {
                if (input[4] <= -1.394866406917572) {
                    if (input[0] <= -0.4615243822336197) {
                        var2 = new double[2] {0.661504424778761, 0.33849557522123896};
                    } else {
                        if (input[2] <= 2.417369693517685) {
                            var2 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        } else {
                            var2 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.145552158355713) {
                        if (input[4] <= -1.0131631195545197) {
                            var2 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.5496491193771362) {
                                if (input[2] <= -0.241805300116539) {
                                    if (input[1] <= -1.2140253782272339) {
                                        var2 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    } else {
                                        var2 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[0] <= -0.4615243822336197) {
                                        var2 = new double[2] {0.0, 1.0};
                                    } else {
                                        var2 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[2] <= -0.24436364322900772) {
                                    if (input[3] <= -0.1781221330165863) {
                                        if (input[1] <= -1.2572372257709503) {
                                            var2 = new double[2] {1.0, 0.0};
                                        } else {
                                            if (input[3] <= -1.2730449438095093) {
                                                var2 = new double[2] {0.0, 1.0};
                                            } else {
                                                var2 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        if (input[1] <= -1.5572509169578552) {
                                            var2 = new double[2] {1.0, 0.0};
                                        } else {
                                            var2 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= -1.5516951084136963) {
                                        var2 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.03032444277778268) {
                                            var2 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[5] <= -0.3641037344932556) {
                                                if (input[1] <= 1.3928835988044739) {
                                                    var2 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var2 = new double[2] {1.0, 0.0};
                                                }
                                            } else {
                                                var2 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.450764536857605) {
                            var2 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.17774097248911858) {
                                if (input[1] <= 0.2993152290582657) {
                                    var2 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= 1.2344825267791748) {
                                        var2 = new double[2] {0.0, 1.0};
                                    } else {
                                        var2 = new double[2] {0.9670116429495472, 0.03298835705045279};
                                    }
                                }
                            } else {
                                var2 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            }
            double[] var3;
            if (input[1] <= -1.474839687347412) {
                var3 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08034390211105347) {
                    if (input[1] <= -1.4421221613883972) {
                        var3 = new double[2] {0.0, 1.0};
                    } else {
                        var3 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[5] <= 1.8756120204925537) {
                        if (input[3] <= 1.0710151493549347) {
                            if (input[2] <= 0.09079494699835777) {
                                var3 = new double[2] {0.0, 1.0};
                            } else {
                                var3 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var3 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var3 = new double[2] {0.8865826538176427, 0.11341734618235731};
                    }
                }
            }
            double[] var4;
            if (input[0] <= -0.4615243822336197) {
                if (input[3] <= 1.2324263453483582) {
                    if (input[1] <= -1.4594069123268127) {
                        var4 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= 0.04717960301786661) {
                            var4 = new double[2] {0.0, 1.0};
                        } else {
                            var4 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.2140253484249115) {
                        var4 = new double[2] {1.0, 0.0};
                    } else {
                        var4 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[0] <= 0.7622144669294357) {
                    if (input[4] <= 0.16904239729046822) {
                        if (input[3] <= 1.0607341825962067) {
                            if (input[2] <= 0.12062934041023254) {
                                if (input[2] <= -0.25536438822746277) {
                                    var4 = new double[2] {0.0, 1.0};
                                } else {
                                    var4 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var4 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var4 = new double[2] {0.9591018444266239, 0.04089815557337611};
                        }
                    } else {
                        if (input[2] <= -0.18418829143047333) {
                            var4 = new double[2] {0.0, 1.0};
                        } else {
                            var4 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    }
                } else {
                    if (input[5] <= 0.4311456084251404) {
                        if (input[4] <= -0.7007341682910919) {
                            if (input[3] <= 0.12079694494605064) {
                                var4 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= 0.3320058137178421) {
                                    var4 = new double[2] {0.7786458333333333, 0.2213541666666667};
                                } else {
                                    var4 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[1] <= -1.437492311000824) {
                                var4 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.2589779943227768) {
                                    var4 = new double[2] {0.0, 1.0};
                                } else {
                                    var4 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var4 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var5;
            if (input[2] <= 0.07809973135590553) {
                if (input[1] <= -1.4708271622657776) {
                    var5 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.08070212975144386) {
                        var5 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 1.3061884045600891) {
                            var5 = new double[2] {0.0, 1.0};
                        } else {
                            var5 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.25183023512363434) {
                    var5 = new double[2] {1.0, 0.0};
                } else {
                    var5 = new double[2] {1.0, 0.0};
                }
            }
            double[] var6;
            if (input[3] <= 0.48037369549274445) {
                if (input[4] <= 0.31780022382736206) {
                    if (input[2] <= 0.2634885832667351) {
                        if (input[4] <= -0.21063324064016342) {
                            if (input[3] <= -1.3887057900428772) {
                                var6 = new double[2] {0.715311004784689, 0.28468899521531105};
                            } else {
                                if (input[2] <= -0.16799893975257874) {
                                    var6 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= -0.1541343778371811) {
                                        var6 = new double[2] {0.661504424778761, 0.33849557522123896};
                                    } else {
                                        var6 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= -1.4538511037826538) {
                                var6 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -0.1362289860844612) {
                                    var6 = new double[2] {0.0, 1.0};
                                } else {
                                    var6 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var6 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[5] <= -1.6662461757659912) {
                        var6 = new double[2] {0.9214175654853621, 0.07858243451463792};
                    } else {
                        if (input[4] <= 0.8420364856719971) {
                            if (input[0] <= -0.4615243822336197) {
                                if (input[3] <= -0.7587396502494812) {
                                    if (input[5] <= -0.11743450537323952) {
                                        var6 = new double[2] {0.0, 1.0};
                                    } else {
                                        var6 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                } else {
                                    var6 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= -0.2599114328622818) {
                                    var6 = new double[2] {0.0, 1.0};
                                } else {
                                    var6 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var6 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[2] <= -0.1483730971813202) {
                    if (input[5] <= -1.5271191000938416) {
                        var6 = new double[2] {0.8978978978978979, 0.10210210210210212};
                    } else {
                        if (input[1] <= -1.4763829708099365) {
                            var6 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.3044615983963013) {
                                var6 = new double[2] {0.0, 1.0};
                            } else {
                                var6 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[5] <= 1.522679328918457) {
                        if (input[2] <= 0.09079494699835777) {
                            var6 = new double[2] {0.5944333996023857, 0.4055666003976144};
                        } else {
                            var6 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 0.32894621789455414) {
                            var6 = new double[2] {1.0, 0.0};
                        } else {
                            var6 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var7;
            if (input[1] <= -1.2374832034111023) {
                if (input[1] <= -1.4634194374084473) {
                    var7 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= -0.8222405314445496) {
                        var7 = new double[2] {0.9670116429495472, 0.03298835705045279};
                    } else {
                        var7 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[2] <= 0.24132782220840454) {
                    if (input[4] <= -2.2020294666290283) {
                        var7 = new double[2] {0.0, 1.0};
                    } else {
                        var7 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= -0.5744900405406952) {
                        var7 = new double[2] {1.0, 0.0};
                    } else {
                        var7 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var8;
            if (input[2] <= 0.09079494699835777) {
                if (input[5] <= 0.6311407685279846) {
                    if (input[3] <= 1.145552158355713) {
                        if (input[1] <= -1.4594069123268127) {
                            var8 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -1.4424238204956055) {
                                var8 = new double[2] {0.0, 1.0};
                            } else {
                                var8 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[4] <= -0.7483533024787903) {
                            var8 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        } else {
                            if (input[4] <= 0.40172426402568817) {
                                var8 = new double[2] {0.0, 1.0};
                            } else {
                                var8 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[3] <= 1.2663534879684448) {
                        var8 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 1.079723298549652) {
                            var8 = new double[2] {0.0, 1.0};
                        } else {
                            var8 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.7062949687242508) {
                    var8 = new double[2] {1.0, 0.0};
                } else {
                    var8 = new double[2] {1.0, 0.0};
                }
            }
            double[] var9;
            if (input[1] <= -1.4634194374084473) {
                var9 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.4330089092254639) {
                    if (input[5] <= 1.5134724378585815) {
                        if (input[1] <= -1.2374832034111023) {
                            if (input[3] <= -0.0742843821644783) {
                                if (input[2] <= 0.009583339095115662) {
                                    if (input[5] <= 0.21721214801073074) {
                                        var9 = new double[2] {0.0, 1.0};
                                    } else {
                                        var9 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var9 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var9 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= 0.04717960301786661) {
                                var9 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= -0.6835600435733795) {
                                    var9 = new double[2] {1.0, 0.0};
                                } else {
                                    var9 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[2] <= -0.15893995389342308) {
                            var9 = new double[2] {0.0, 1.0};
                        } else {
                            var9 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[5] <= -0.597985565662384) {
                        var9 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 0.07809973135590553) {
                            var9 = new double[2] {0.0, 1.0};
                        } else {
                            var9 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var10;
            if (input[3] <= 1.1383554935455322) {
                if (input[4] <= -0.7093009352684021) {
                    if (input[4] <= -1.0240211188793182) {
                        if (input[1] <= -1.2384092211723328) {
                            var10 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            if (input[2] <= -0.259831041097641) {
                                var10 = new double[2] {0.0, 1.0};
                            } else {
                                var10 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            if (input[4] <= -0.9342980682849884) {
                                var10 = new double[2] {0.9791240278346296, 0.02087597216537045};
                            } else {
                                if (input[2] <= -0.2373599335551262) {
                                    var10 = new double[2] {0.0, 1.0};
                                } else {
                                    var10 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[4] <= -0.7825291752815247) {
                                if (input[5] <= -0.5128213912248611) {
                                    var10 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.8453860282897949) {
                                        var10 = new double[2] {0.9462025316455697, 0.05379746835443039};
                                    } else {
                                        var10 = new double[2] {0.661504424778761, 0.33849557522123896};
                                    }
                                }
                            } else {
                                var10 = new double[2] {0.9361302442078898, 0.06386975579211022};
                            }
                        }
                    }
                } else {
                    if (input[1] <= -1.4470607042312622) {
                        var10 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 1.6469730138778687) {
                            if (input[5] <= 0.47513431310653687) {
                                if (input[1] <= 0.059798143804073334) {
                                    var10 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= 0.4322964698076248) {
                                        if (input[2] <= 0.041617292910814285) {
                                            if (input[5] <= -1.5991122722625732) {
                                                var10 = new double[2] {0.0, 1.0};
                                            } else {
                                                var10 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var10 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var10 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                    }
                                }
                            } else {
                                if (input[4] <= -0.588605672121048) {
                                    var10 = new double[2] {0.0, 1.0};
                                } else {
                                    var10 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var10 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    }
                }
            } else {
                if (input[4] <= 0.6157721169292927) {
                    if (input[5] <= -0.32382339611649513) {
                        var10 = new double[2] {0.5944333996023856, 0.40556660039761433};
                    } else {
                        if (input[2] <= -0.2398388311266899) {
                            var10 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.405538558959961) {
                                if (input[1] <= -0.8470333218574524) {
                                    var10 = new double[2] {1.0, 0.0};
                                } else {
                                    var10 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var10 = new double[2] {0.9591018444266239, 0.04089815557337611};
                            }
                        }
                    }
                } else {
                    var10 = new double[2] {0.0, 1.0};
                }
            }
            double[] var11;
            if (input[2] <= 0.03448438737541437) {
                if (input[1] <= -1.4634194374084473) {
                    var11 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 1.6161553263664246) {
                        var11 = new double[2] {0.0, 1.0};
                    } else {
                        var11 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var11 = new double[2] {1.0, 0.0};
                } else {
                    var11 = new double[2] {1.0, 0.0};
                }
            }
            double[] var12;
            if (input[2] <= -0.08070212975144386) {
                if (input[5] <= -1.5950202941894531) {
                    if (input[1] <= -1.4165037274360657) {
                        var12 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= -0.9504887461662292) {
                            var12 = new double[2] {0.0, 1.0};
                        } else {
                            var12 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.472370445728302) {
                        var12 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= -1.5223583579063416) {
                            var12 = new double[2] {0.0, 1.0};
                        } else {
                            var12 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.5128213912248611) {
                    var12 = new double[2] {0.7962716378162449, 0.20372836218375498};
                } else {
                    if (input[4] <= 1.5429613292217255) {
                        if (input[3] <= 0.3295005336403847) {
                            var12 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        } else {
                            var12 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var12 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var13;
            if (input[2] <= 0.05875357799232006) {
                if (input[3] <= 1.1383554935455322) {
                    if (input[5] <= -1.482235312461853) {
                        if (input[1] <= -1.321437656879425) {
                            var13 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.2621701955795288) {
                                var13 = new double[2] {0.0, 1.0};
                            } else {
                                var13 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[5] <= -0.6357084512710571) {
                            var13 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.6204914152622223) {
                                var13 = new double[2] {0.9591018444266239, 0.04089815557337611};
                            } else {
                                if (input[4] <= 0.6485083699226379) {
                                    if (input[2] <= -0.23968537151813507) {
                                        if (input[3] <= -0.5202212631702423) {
                                            if (input[4] <= -0.21063324064016342) {
                                                var13 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[2] <= -0.24742744117975235) {
                                                    var13 = new double[2] {0.9670116429495472, 0.03298835705045279};
                                                } else {
                                                    if (input[2] <= -0.24180568754673004) {
                                                        var13 = new double[2] {0.0, 1.0};
                                                    } else {
                                                        var13 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                                    }
                                                }
                                            }
                                        } else {
                                            if (input[1] <= -1.0760561227798462) {
                                                var13 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                            } else {
                                                var13 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        var13 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[4] <= 0.674573689699173) {
                                        var13 = new double[2] {0.0, 1.0};
                                    } else {
                                        var13 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.5915925055742264) {
                        if (input[4] <= -0.7483533024787903) {
                            var13 = new double[2] {1.0, 0.0};
                        } else {
                            var13 = new double[2] {0.661504424778761, 0.33849557522123896};
                        }
                    } else {
                        var13 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[4] <= -1.8299574255943298) {
                    var13 = new double[2] {1.0, 0.0};
                } else {
                    var13 = new double[2] {1.0, 0.0};
                }
            }
            double[] var14;
            if (input[2] <= 0.04717960301786661) {
                if (input[5] <= -1.5345358848571777) {
                    if (input[1] <= -1.4165037274360657) {
                        var14 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -1.6826141476631165) {
                            var14 = new double[2] {0.0, 1.0};
                        } else {
                            var14 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[5] <= -0.638010174036026) {
                        if (input[1] <= -1.3368704915046692) {
                            var14 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        } else {
                            var14 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[3] <= 0.4834579974412918) {
                            if (input[3] <= -1.0851603150367737) {
                                if (input[1] <= -1.458480954170227) {
                                    var14 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[4] <= -1.042939007282257) {
                                        var14 = new double[2] {0.0, 1.0};
                                    } else {
                                        var14 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[1] <= -1.4763830304145813) {
                                    var14 = new double[2] {1.0, 0.0};
                                } else {
                                    var14 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[1] <= -1.531632423400879) {
                                var14 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[0] <= -0.4615243822336197) {
                                    if (input[2] <= -0.19109753519296646) {
                                        var14 = new double[2] {0.0, 1.0};
                                    } else {
                                        var14 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                } else {
                                    var14 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[3] <= -0.2166757509112358) {
                    var14 = new double[2] {1.0, 0.0};
                } else {
                    var14 = new double[2] {1.0, 0.0};
                }
            }
            double[] var15;
            if (input[1] <= -1.4634194374084473) {
                var15 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08034390211105347) {
                    if (input[5] <= -1.644379734992981) {
                        var15 = new double[2] {0.0, 1.0};
                    } else {
                        var15 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= 1.5922754406929016) {
                        if (input[5] <= -0.9437572360038757) {
                            var15 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var15 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= 2.346999818459153) {
                            var15 = new double[2] {0.0, 1.0};
                        } else {
                            var15 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var16;
            if (input[1] <= -1.4634194374084473) {
                var16 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08070212975144386) {
                    if (input[2] <= -0.27012933790683746) {
                        var16 = new double[2] {0.0, 1.0};
                    } else {
                        var16 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[2] <= 0.07809973135590553) {
                        var16 = new double[2] {0.53971119133574, 0.46028880866426};
                    } else {
                        var16 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var17;
            if (input[5] <= -0.2607814222574234) {
                if (input[5] <= -1.482235312461853) {
                    if (input[1] <= -1.3331665992736816) {
                        var17 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= -1.009776920080185) {
                            var17 = new double[2] {0.0, 1.0};
                        } else {
                            var17 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.2545438874512911) {
                        if (input[3] <= 1.1915594935417175) {
                            var17 = new double[2] {0.0, 1.0};
                        } else {
                            var17 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    } else {
                        var17 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[4] <= 0.2422807663679123) {
                    if (input[0] <= -0.4615243822336197) {
                        if (input[3] <= 0.4760042876005173) {
                            var17 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.2546714246273041) {
                                var17 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            } else {
                                if (input[4] <= -0.18281401693820953) {
                                    if (input[5] <= 1.315139651298523) {
                                        if (input[5] <= 0.6890677660703659) {
                                            var17 = new double[2] {1.0, 0.0};
                                        } else {
                                            var17 = new double[2] {0.7962716378162449, 0.20372836218375498};
                                        }
                                    } else {
                                        var17 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var17 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 1.1590052843093872) {
                            if (input[4] <= -1.2872899174690247) {
                                var17 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 1.0985207557678223) {
                                    if (input[2] <= 1.3312272652983665) {
                                        if (input[4] <= -0.9061341285705566) {
                                            var17 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[1] <= -1.443048119544983) {
                                                var17 = new double[2] {1.0, 0.0};
                                            } else {
                                                if (input[4] <= -0.6962125301361084) {
                                                    var17 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var17 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[3] <= 0.45801258832216263) {
                                            var17 = new double[2] {1.0, 0.0};
                                        } else {
                                            var17 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var17 = new double[2] {0.9361302442078898, 0.06386975579211022};
                                }
                            }
                        } else {
                            var17 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.4436654448509216) {
                        var17 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= 0.8093645870685577) {
                            var17 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= 0.7622144669294357) {
                                if (input[5] <= 0.8000625371932983) {
                                    var17 = new double[2] {0.0, 1.0};
                                } else {
                                    var17 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            } else {
                                var17 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            }
            double[] var18;
            if (input[2] <= -0.08034390211105347) {
                if (input[5] <= -1.482235312461853) {
                    if (input[1] <= -1.3331665992736816) {
                        var18 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 0.04714324697852135) {
                            var18 = new double[2] {0.0, 1.0};
                        } else {
                            var18 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.23650696128606796) {
                        if (input[5] <= -0.6357084512710571) {
                            if (input[1] <= -1.240569829940796) {
                                var18 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            } else {
                                var18 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= -0.5017155110836029) {
                                if (input[2] <= -0.2543247789144516) {
                                    var18 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -1.464345395565033) {
                                        var18 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[2] <= -0.2519923150539398) {
                                            var18 = new double[2] {0.0, 1.0};
                                        } else {
                                            var18 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= -1.3893420100212097) {
                                    var18 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[4] <= -1.2795443534851074) {
                                        var18 = new double[2] {0.0, 1.0};
                                    } else {
                                        var18 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.4486039280891418) {
                            var18 = new double[2] {0.9462025316455697, 0.053797468354430396};
                        } else {
                            var18 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.597985565662384) {
                    var18 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 1.5922754406929016) {
                        var18 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= 0.9093469679355621) {
                            var18 = new double[2] {0.9670116429495472, 0.03298835705045279};
                        } else {
                            var18 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    }
                }
            }
            double[] var19;
            if (input[2] <= 0.07809973135590553) {
                if (input[3] <= 1.145552158355713) {
                    if (input[2] <= -0.25295156240463257) {
                        if (input[5] <= -0.638010174036026) {
                            var19 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= 0.7622144669294357) {
                                if (input[2] <= -0.25412945449352264) {
                                    if (input[1] <= -1.4547770619392395) {
                                        var19 = new double[2] {1.0, 0.0};
                                    } else {
                                        var19 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var19 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[3] <= -1.1805163025856018) {
                                    var19 = new double[2] {0.0, 1.0};
                                } else {
                                    var19 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.4961369633674622) {
                            var19 = new double[2] {1.0, 0.0};
                        } else {
                            var19 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[5] <= -0.011043213307857513) {
                        var19 = new double[2] {0.0, 1.0};
                    } else {
                        var19 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[3] <= 0.3295005336403847) {
                    var19 = new double[2] {1.0, 0.0};
                } else {
                    var19 = new double[2] {1.0, 0.0};
                }
            }
            double[] var20;
            if (input[2] <= 0.07809973135590553) {
                if (input[2] <= -0.25295156240463257) {
                    if (input[2] <= -0.25322139263153076) {
                        if (input[1] <= -1.4547770619392395) {
                            var20 = new double[2] {1.0, 0.0};
                        } else {
                            var20 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var20 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.23449213802814484) {
                        if (input[1] <= -1.4069353938102722) {
                            var20 = new double[2] {1.0, 0.0};
                        } else {
                            var20 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= -1.5442873239517212) {
                            var20 = new double[2] {1.0, 0.0};
                        } else {
                            var20 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[1] <= -1.0856244266033173) {
                    var20 = new double[2] {1.0, 0.0};
                } else {
                    var20 = new double[2] {1.0, 0.0};
                }
            }
            double[] var21;
            if (input[3] <= 1.2324263453483582) {
                if (input[1] <= -1.4594069123268127) {
                    var21 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 1.4933961629867554) {
                        if (input[1] <= 1.5012218952178955) {
                            if (input[2] <= 0.010923627763986588) {
                                var21 = new double[2] {0.0, 1.0};
                            } else {
                                var21 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 2.2827389240264893) {
                                if (input[3] <= -0.4071306213736534) {
                                    var21 = new double[2] {0.8865826538176427, 0.11341734618235731};
                                } else {
                                    var21 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var21 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[1] <= 0.24869564920663834) {
                            var21 = new double[2] {0.0, 1.0};
                        } else {
                            var21 = new double[2] {0.9591018444266239, 0.04089815557337611};
                        }
                    }
                }
            } else {
                if (input[4] <= 0.6157721169292927) {
                    if (input[4] <= -0.5908360779285431) {
                        if (input[0] <= -0.4615243822336197) {
                            if (input[5] <= 1.019622415304184) {
                                var21 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var21 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var21 = new double[2] {0.5397111913357401, 0.46028880866426003};
                        }
                    } else {
                        var21 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var21 = new double[2] {0.0, 1.0};
                }
            }
            double[] var22;
            if (input[3] <= 0.5765007138252258) {
                if (input[1] <= -1.4569376707077026) {
                    var22 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 0.054227687418460846) {
                        var22 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -0.5225958228111267) {
                            if (input[3] <= 0.07299045100808144) {
                                var22 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 0.9851489961147308) {
                                    var22 = new double[2] {0.0, 1.0};
                                } else {
                                    var22 = new double[2] {0.5944333996023857, 0.4055666003976144};
                                }
                            }
                        } else {
                            if (input[2] <= -0.2611820250749588) {
                                var22 = new double[2] {0.0, 1.0};
                            } else {
                                var22 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= 0.2432844489812851) {
                    if (input[2] <= -0.1501554474234581) {
                        if (input[2] <= -0.23672106117010117) {
                            if (input[5] <= 1.1684679985046387) {
                                if (input[2] <= -0.25338082015514374) {
                                    if (input[0] <= 0.7622144669294357) {
                                        var22 = new double[2] {0.0, 1.0};
                                    } else {
                                        var22 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                } else {
                                    if (input[4] <= -0.8549666106700897) {
                                        if (input[4] <= -1.1382887959480286) {
                                            var22 = new double[2] {0.0, 1.0};
                                        } else {
                                            var22 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= 1.0990322828292847) {
                                            var22 = new double[2] {0.0, 1.0};
                                        } else {
                                            var22 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                        }
                                    }
                                }
                            } else {
                                var22 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= 0.8253000974655151) {
                                var22 = new double[2] {0.0, 1.0};
                            } else {
                                var22 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[4] <= -0.7825291752815247) {
                            if (input[1] <= 1.0400897711515427) {
                                var22 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 1.0710151493549347) {
                                    var22 = new double[2] {0.897897897897898, 0.10210210210210213};
                                } else {
                                    var22 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var22 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var22 = new double[2] {0.0, 1.0};
                }
            }
            double[] var23;
            if (input[1] <= -1.4634194374084473) {
                var23 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08070212975144386) {
                    var23 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.07809973135590553) {
                        if (input[5] <= 0.5459765940904617) {
                            var23 = new double[2] {0.0, 1.0};
                        } else {
                            var23 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    } else {
                        var23 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var24;
            if (input[3] <= 1.2324263453483582) {
                if (input[2] <= 0.07809973135590553) {
                    if (input[2] <= -0.23449213802814484) {
                        if (input[4] <= -0.2015392780303955) {
                            if (input[4] <= -0.9669734835624695) {
                                if (input[4] <= -1.0271133184432983) {
                                    var24 = new double[2] {0.0, 1.0};
                                } else {
                                    var24 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            } else {
                                if (input[0] <= -0.4615243822336197) {
                                    var24 = new double[2] {0.0, 1.0};
                                } else {
                                    var24 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[5] <= 0.6311407685279846) {
                                if (input[5] <= -0.2651291489601135) {
                                    if (input[3] <= -0.08585046790540218) {
                                        if (input[5] <= -1.472261130809784) {
                                            if (input[4] <= 0.7162416577339172) {
                                                var24 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                            } else {
                                                var24 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[5] <= -1.3599876165390015) {
                                                var24 = new double[2] {0.0, 1.0};
                                            } else {
                                                var24 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        if (input[4] <= 0.5975233316421509) {
                                            if (input[5] <= -1.4135668873786926) {
                                                var24 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                            } else {
                                                var24 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var24 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= -0.2595316469669342) {
                                        var24 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[5] <= -0.09748613834381104) {
                                            if (input[3] <= -1.1411916017532349) {
                                                var24 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                            } else {
                                                var24 = new double[2] {0.9591018444266239, 0.04089815557337611};
                                            }
                                        } else {
                                            if (input[3] <= -1.1581551432609558) {
                                                var24 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[2] <= -0.2557840496301651) {
                                                    var24 = new double[2] {0.9723577235772358, 0.027642276422764234};
                                                } else {
                                                    if (input[3] <= 0.5055620670318604) {
                                                        if (input[0] <= 0.15034502744674683) {
                                                            var24 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                                        } else {
                                                            var24 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                                        }
                                                    } else {
                                                        var24 = new double[2] {0.0, 1.0};
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            } else {
                                if (input[0] <= -0.4615243822336197) {
                                    var24 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.1403755024075508) {
                                        var24 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    } else {
                                        var24 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[3] <= -1.5413782000541687) {
                            var24 = new double[2] {0.0, 1.0};
                        } else {
                            var24 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var24 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.6639285758137703) {
                    if (input[5] <= -0.30080604925751686) {
                        var24 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        if (input[4] <= -1.2737250328063965) {
                            var24 = new double[2] {0.9591018444266239, 0.04089815557337611};
                        } else {
                            var24 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var24 = new double[2] {0.0, 1.0};
                }
            }
            double[] var25;
            if (input[4] <= 0.3585862070322037) {
                if (input[1] <= -1.474839687347412) {
                    var25 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 1.174355149269104) {
                        if (input[2] <= 0.07701399642974138) {
                            var25 = new double[2] {0.0, 1.0};
                        } else {
                            var25 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 0.08636536821722984) {
                            if (input[1] <= 1.4749861359596252) {
                                if (input[1] <= 1.2296045422554016) {
                                    var25 = new double[2] {0.661504424778761, 0.33849557522123896};
                                } else {
                                    var25 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[4] <= -0.7093009352684021) {
                                    if (input[2] <= 0.4192368686199188) {
                                        var25 = new double[2] {0.0, 1.0};
                                    } else {
                                        var25 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var25 = new double[2] {0.661504424778761, 0.33849557522123896};
                                }
                            }
                        } else {
                            var25 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[0] <= 0.7622144669294357) {
                    if (input[5] <= 1.3746010661125183) {
                        if (input[1] <= -1.4822474718093872) {
                            var25 = new double[2] {1.0, 0.0};
                        } else {
                            var25 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var25 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                } else {
                    if (input[1] <= -1.3612543046474457) {
                        var25 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= -0.2557387501001358) {
                            var25 = new double[2] {0.0, 1.0};
                        } else {
                            var25 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            }
            double[] var26;
            if (input[2] <= 0.09079494699835777) {
                if (input[2] <= -0.25273318588733673) {
                    if (input[0] <= 0.7622144669294357) {
                        if (input[1] <= -1.3877987265586853) {
                            var26 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -1.2640491127967834) {
                                var26 = new double[2] {0.0, 1.0};
                            } else {
                                var26 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[4] <= -1.2088506817817688) {
                            var26 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var26 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.23650696128606796) {
                        if (input[1] <= -1.4569376707077026) {
                            var26 = new double[2] {1.0, 0.0};
                        } else {
                            var26 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[3] <= 1.636468231678009) {
                            var26 = new double[2] {0.0, 1.0};
                        } else {
                            var26 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    }
                }
            } else {
                if (input[1] <= -0.8470333218574524) {
                    var26 = new double[2] {1.0, 0.0};
                } else {
                    var26 = new double[2] {1.0, 0.0};
                }
            }
            double[] var27;
            if (input[1] <= -1.2374832034111023) {
                if (input[3] <= -0.667753130197525) {
                    if (input[2] <= -0.2390330508351326) {
                        var27 = new double[2] {0.9462025316455697, 0.05379746835443039};
                    } else {
                        var27 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[3] <= -0.0370158813893795) {
                        var27 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 0.43749184161424637) {
                            if (input[1] <= -1.472370445728302) {
                                var27 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.25150398910045624) {
                                    var27 = new double[2] {0.0, 1.0};
                                } else {
                                    var27 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var27 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[4] <= 0.2432844489812851) {
                    if (input[3] <= 0.5765007138252258) {
                        if (input[1] <= 1.481159269809723) {
                            if (input[4] <= -0.5841448605060577) {
                                if (input[3] <= -1.4555320739746094) {
                                    var27 = new double[2] {0.0, 1.0};
                                } else {
                                    var27 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= 0.1645418182015419) {
                                    var27 = new double[2] {0.0, 1.0};
                                } else {
                                    var27 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var27 = new double[2] {0.9462025316455697, 0.05379746835443039};
                        }
                    } else {
                        if (input[1] <= 1.0845362544059753) {
                            if (input[5] <= 0.6189927160739899) {
                                var27 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= -0.2827158421278) {
                                    if (input[2] <= 0.247966468334198) {
                                        var27 = new double[2] {0.0, 1.0};
                                    } else {
                                        var27 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var27 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[1] <= 1.3080032467842102) {
                                var27 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[0] <= 0.7622144669294357) {
                                    var27 = new double[2] {0.5944333996023857, 0.4055666003976144};
                                } else {
                                    var27 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                }
                            }
                        }
                    }
                } else {
                    if (input[5] <= 1.7639778852462769) {
                        var27 = new double[2] {0.0, 1.0};
                    } else {
                        var27 = new double[2] {0.9214175654853621, 0.07858243451463792};
                    }
                }
            }
            double[] var28;
            if (input[0] <= -0.4615243822336197) {
                if (input[3] <= 1.2344825267791748) {
                    if (input[5] <= -1.0309674143791199) {
                        if (input[1] <= -1.2374832034111023) {
                            var28 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= -1.681207537651062) {
                                var28 = new double[2] {0.0, 1.0};
                            } else {
                                var28 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[4] <= -0.3040567636489868) {
                            var28 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 0.34040841460227966) {
                                if (input[1] <= -1.469283938407898) {
                                    var28 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[2] <= -0.19600427895784378) {
                                        var28 = new double[2] {0.0, 1.0};
                                    } else {
                                        var28 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                }
                            } else {
                                if (input[5] <= -0.2368689626455307) {
                                    if (input[3] <= -1.0887586772441864) {
                                        var28 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                    } else {
                                        var28 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var28 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[1] <= 0.3962332308292389) {
                        var28 = new double[2] {1.0, 0.0};
                    } else {
                        var28 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                }
            } else {
                if (input[5] <= 0.03384061623364687) {
                    if (input[5] <= -0.6428694128990173) {
                        if (input[1] <= -1.5924376845359802) {
                            var28 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -0.19739893823862076) {
                                if (input[3] <= -0.6309986710548401) {
                                    var28 = new double[2] {0.0, 1.0};
                                } else {
                                    var28 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            } else {
                                var28 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.25584207475185394) {
                            var28 = new double[2] {0.9670116429495471, 0.032988357050452784};
                        } else {
                            if (input[5] <= -0.5390355587005615) {
                                var28 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.06104200333356857) {
                                    if (input[1] <= 1.3928835988044739) {
                                        if (input[1] <= -1.1399478912353516) {
                                            var28 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                        } else {
                                            var28 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var28 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var28 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[5] <= 0.727046400308609) {
                        var28 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.5243248343467712) {
                            if (input[2] <= -0.25130516290664673) {
                                if (input[5] <= 1.1185970306396484) {
                                    var28 = new double[2] {0.0, 1.0};
                                } else {
                                    var28 = new double[2] {0.661504424778761, 0.33849557522123896};
                                }
                            } else {
                                if (input[4] <= -1.3636001944541931) {
                                    var28 = new double[2] {0.0, 1.0};
                                } else {
                                    var28 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[4] <= -0.7279349863529205) {
                                var28 = new double[2] {1.0, 0.0};
                            } else {
                                var28 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            }
            double[] var29;
            if (input[1] <= -1.4763829708099365) {
                var29 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.12508315965533257) {
                    if (input[3] <= 1.1486364603042603) {
                        if (input[3] <= 0.054227687418460846) {
                            if (input[4] <= -0.9499615728855133) {
                                if (input[4] <= -1.0228856801986694) {
                                    var29 = new double[2] {0.0, 1.0};
                                } else {
                                    var29 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            } else {
                                if (input[4] <= -0.936751514673233) {
                                    var29 = new double[2] {0.0, 1.0};
                                } else {
                                    var29 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= 1.3367895754054189) {
                                var29 = new double[2] {0.0, 1.0};
                            } else {
                                var29 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[1] <= -1.0208066999912262) {
                            var29 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.09518440067768097) {
                                var29 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            } else {
                                if (input[2] <= -0.09316971525549889) {
                                    var29 = new double[2] {0.0, 1.0};
                                } else {
                                    var29 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[3] <= 0.8093645870685577) {
                        var29 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 1.1721763014793396) {
                            var29 = new double[2] {0.0, 1.0};
                        } else {
                            var29 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    }
                }
            }
            double[] var30;
            if (input[2] <= 0.09079494699835777) {
                if (input[3] <= 1.2324263453483582) {
                    if (input[1] <= -1.4634194374084473) {
                        var30 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -1.668292224407196) {
                            var30 = new double[2] {0.0, 1.0};
                        } else {
                            var30 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.22771552950143814) {
                        if (input[5] <= 1.0343279242515564) {
                            var30 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        } else {
                            var30 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= -0.1371191143989563) {
                            var30 = new double[2] {0.0, 1.0};
                        } else {
                            var30 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    }
                }
            } else {
                if (input[3] <= -0.05603566765785217) {
                    var30 = new double[2] {1.0, 0.0};
                } else {
                    var30 = new double[2] {1.0, 0.0};
                }
            }
            double[] var31;
            if (input[2] <= 0.09079494699835777) {
                if (input[3] <= 1.145552158355713) {
                    if (input[1] <= -1.474839687347412) {
                        var31 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= -0.2702489346265793) {
                            var31 = new double[2] {0.0, 1.0};
                        } else {
                            var31 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.3205856084823608) {
                        if (input[4] <= -0.3587624952197075) {
                            var31 = new double[2] {0.9670116429495472, 0.03298835705045279};
                        } else {
                            var31 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var31 = new double[2] {0.0, 1.0};
                        } else {
                            var31 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var31 = new double[2] {1.0, 0.0};
                } else {
                    var31 = new double[2] {1.0, 0.0};
                }
            }
            double[] var32;
            if (input[1] <= -1.4634194374084473) {
                var32 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.2524290978908539) {
                    if (input[2] <= -0.08034390211105347) {
                        var32 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.597985565662384) {
                            var32 = new double[2] {0.661504424778761, 0.33849557522123896};
                        } else {
                            if (input[2] <= 0.09079494699835777) {
                                var32 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            } else {
                                var32 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[5] <= 1.7639778852462769) {
                        var32 = new double[2] {0.0, 1.0};
                    } else {
                        var32 = new double[2] {0.661504424778761, 0.33849557522123896};
                    }
                }
            }
            double[] var33;
            if (input[4] <= 0.8976546227931976) {
                if (input[2] <= -0.08034390211105347) {
                    if (input[4] <= 0.21378228068351746) {
                        if (input[3] <= 1.1064844727516174) {
                            if (input[3] <= 0.2544494867324829) {
                                var33 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.4945100247859955) {
                                    if (input[4] <= -1.0981820821762085) {
                                        var33 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[0] <= -0.4615243822336197) {
                                            if (input[1] <= -0.3176882043480873) {
                                                var33 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                            } else {
                                                var33 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var33 = new double[2] {0.796271637816245, 0.20372836218375504};
                                        }
                                    }
                                } else {
                                    if (input[0] <= -0.4615243822336197) {
                                        var33 = new double[2] {0.0, 1.0};
                                    } else {
                                        var33 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= -0.2540612444281578) {
                                var33 = new double[2] {0.9462025316455697, 0.053797468354430396};
                            } else {
                                if (input[1] <= -1.3621802926063538) {
                                    var33 = new double[2] {1.0, 0.0};
                                } else {
                                    var33 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[2] <= -0.23964782804250717) {
                            if (input[2] <= -0.25914961099624634) {
                                var33 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.3081654906272888) {
                                    var33 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[0] <= -0.4615243822336197) {
                                        var33 = new double[2] {0.0, 1.0};
                                    } else {
                                        var33 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            var33 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.1149663031101227) {
                        if (input[4] <= -0.7825291752815247) {
                            var33 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            if (input[1] <= 1.8163596391677856) {
                                var33 = new double[2] {1.0, 0.0};
                            } else {
                                var33 = new double[2] {0.9591018444266239, 0.04089815557337611};
                            }
                        }
                    } else {
                        var33 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var33 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= -0.13776934146881104) {
                        if (input[1] <= -1.5242246985435486) {
                            var33 = new double[2] {1.0, 0.0};
                        } else {
                            var33 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= -0.2554510831832886) {
                            var33 = new double[2] {0.0, 1.0};
                        } else {
                            var33 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            }
            double[] var34;
            if (input[4] <= -0.8343860805034637) {
                if (input[2] <= -0.17091213911771774) {
                    if (input[5] <= 0.16209838911890984) {
                        if (input[1] <= -1.3908852934837341) {
                            var34 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= -1.3804295659065247) {
                                var34 = new double[2] {0.0, 1.0};
                            } else {
                                var34 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -0.7494980096817017) {
                            var34 = new double[2] {0.0, 1.0};
                        } else {
                            var34 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[1] <= 1.5228278636932373) {
                        if (input[4] <= -1.2860530614852905) {
                            if (input[3] <= 0.8098786622285843) {
                                var34 = new double[2] {0.0, 1.0};
                            } else {
                                var34 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            if (input[1] <= -1.2152599692344666) {
                                var34 = new double[2] {1.0, 0.0};
                            } else {
                                var34 = new double[2] {0.9462025316455697, 0.053797468354430396};
                            }
                        }
                    } else {
                        if (input[2] <= 4.959321737289429) {
                            var34 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var34 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[1] <= -1.4634194374084473) {
                    var34 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.12769881263375282) {
                        if (input[2] <= -0.08378744497895241) {
                            var34 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.36529041826725006) {
                                var34 = new double[2] {0.661504424778761, 0.33849557522123896};
                            } else {
                                var34 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= -1.6211066246032715) {
                            var34 = new double[2] {0.0, 1.0};
                        } else {
                            var34 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            }
            double[] var35;
            if (input[4] <= 0.2535341680049896) {
                if (input[1] <= -1.4763829708099365) {
                    var35 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.1591744422912598) {
                        if (input[2] <= 0.09079494699835777) {
                            var35 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -0.013353288173675537) {
                                var35 = new double[2] {1.0, 0.0};
                            } else {
                                var35 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= -0.4265667796134949) {
                            if (input[5] <= -0.32382339611649513) {
                                var35 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= 1.2737224102020264) {
                                    var35 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var35 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var35 = new double[2] {0.7010550996483, 0.2989449003516999};
                        }
                    }
                }
            } else {
                if (input[2] <= -0.03944683261215687) {
                    if (input[5] <= -1.6662461757659912) {
                        var35 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        if (input[1] <= -1.4822474718093872) {
                            var35 = new double[2] {1.0, 0.0};
                        } else {
                            var35 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var35 = new double[2] {0.8542857142857143, 0.14571428571428574};
                }
            }
            double[] var36;
            if (input[3] <= 1.145552158355713) {
                if (input[2] <= 0.03448438737541437) {
                    if (input[5] <= -1.5950202941894531) {
                        if (input[3] <= -0.7538562119007111) {
                            var36 = new double[2] {0.9591018444266239, 0.04089815557337611};
                        } else {
                            var36 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[1] <= -1.4921244382858276) {
                            var36 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.2660684436559677) {
                                var36 = new double[2] {0.0, 1.0};
                            } else {
                                var36 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[5] <= -0.7062949687242508) {
                        var36 = new double[2] {1.0, 0.0};
                    } else {
                        var36 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[3] <= 1.9759971499443054) {
                    if (input[2] <= -0.09316971525549889) {
                        if (input[2] <= -0.23660050332546234) {
                            if (input[1] <= -1.0967360436916351) {
                                var36 = new double[2] {1.0, 0.0};
                            } else {
                                var36 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= 1.419796884059906) {
                                var36 = new double[2] {0.0, 1.0};
                            } else {
                                var36 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var36 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var36 = new double[2] {1.0, 0.0};
                }
            }
            double[] var37;
            if (input[1] <= -1.4708271622657776) {
                var37 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08745646104216576) {
                    var37 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 0.2715586647391319) {
                        if (input[3] <= 0.6266204416751862) {
                            var37 = new double[2] {1.0, 0.0};
                        } else {
                            var37 = new double[2] {0.8978978978978979, 0.10210210210210212};
                        }
                    } else {
                        if (input[1] <= -0.51553675532341) {
                            var37 = new double[2] {1.0, 0.0};
                        } else {
                            var37 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var38;
            if (input[1] <= -1.4683579206466675) {
                var38 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08034390211105347) {
                    if (input[0] <= -0.4615243822336197) {
                        var38 = new double[2] {0.0, 1.0};
                    } else {
                        var38 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[5] <= 1.8756120204925537) {
                        if (input[1] <= 1.5922754406929016) {
                            if (input[5] <= -0.7914591431617737) {
                                var38 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var38 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= -0.7375257015228271) {
                                var38 = new double[2] {1.0, 0.0};
                            } else {
                                var38 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var38 = new double[2] {0.7456359102244389, 0.25436408977556113};
                    }
                }
            }
            double[] var39;
            if (input[1] <= -1.4816301465034485) {
                var39 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= -0.5225958228111267) {
                    if (input[2] <= 0.12062934041023254) {
                        var39 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -0.81061190366745) {
                            var39 = new double[2] {1.0, 0.0};
                        } else {
                            var39 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[5] <= 2.0215163826942444) {
                        if (input[2] <= 0.027016911655664444) {
                            var39 = new double[2] {0.0, 1.0};
                        } else {
                            var39 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var39 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var40;
            if (input[1] <= -1.4708271622657776) {
                var40 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= -0.80052450299263) {
                    if (input[3] <= 1.1591744422912598) {
                        if (input[4] <= -1.9495881795883179) {
                            var40 = new double[2] {0.7010550996483002, 0.29894490035169996};
                        } else {
                            if (input[3] <= -0.1716965287923813) {
                                if (input[3] <= -0.28016071021556854) {
                                    var40 = new double[2] {0.0, 1.0};
                                } else {
                                    var40 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            } else {
                                if (input[0] <= -0.4615243822336197) {
                                    var40 = new double[2] {0.0, 1.0};
                                } else {
                                    var40 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var40 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.08070212975144386) {
                        if (input[4] <= -0.7666426002979279) {
                            var40 = new double[2] {0.0, 1.0};
                        } else {
                            var40 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[5] <= 2.0215163826942444) {
                            if (input[2] <= 0.0714487936347723) {
                                var40 = new double[2] {0.5397111913357401, 0.46028880866426003};
                            } else {
                                var40 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var40 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var41;
            if (input[2] <= 0.05875357799232006) {
                if (input[5] <= 0.6995534598827362) {
                    if (input[5] <= -0.260909304022789) {
                        if (input[4] <= -0.9722656011581421) {
                            if (input[0] <= 0.7622144669294357) {
                                if (input[1] <= -1.5442873239517212) {
                                    var41 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[0] <= -0.4615243822336197) {
                                        var41 = new double[2] {0.0, 1.0};
                                    } else {
                                        var41 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[1] <= -0.2874399200081825) {
                                    var41 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var41 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[1] <= -1.4143431186676025) {
                                var41 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var41 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[3] <= -0.5569757223129272) {
                            if (input[1] <= -1.4501472115516663) {
                                var41 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= -1.4709535241127014) {
                                    var41 = new double[2] {0.0, 1.0};
                                } else {
                                    var41 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.23622982949018478) {
                                if (input[2] <= -0.23876013606786728) {
                                    if (input[2] <= -0.25584207475185394) {
                                        if (input[5] <= 0.6081234216690063) {
                                            if (input[4] <= 0.9880874156951904) {
                                                var41 = new double[2] {0.0, 1.0};
                                            } else {
                                                var41 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                            }
                                        } else {
                                            var41 = new double[2] {0.9462025316455697, 0.05379746835443039};
                                        }
                                    } else {
                                        if (input[4] <= -0.6980272829532623) {
                                            var41 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                        } else {
                                            var41 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var41 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= -0.23463626205921173) {
                                    var41 = new double[2] {0.0, 1.0};
                                } else {
                                    var41 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[1] <= -1.4362577199935913) {
                        var41 = new double[2] {0.796271637816245, 0.20372836218375504};
                    } else {
                        if (input[3] <= 1.2265148162841797) {
                            var41 = new double[2] {0.0, 1.0};
                        } else {
                            var41 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    }
                }
            } else {
                if (input[2] <= 0.1470777951180935) {
                    var41 = new double[2] {1.0, 0.0};
                } else {
                    var41 = new double[2] {1.0, 0.0};
                }
            }
            double[] var42;
            if (input[2] <= 0.041617292910814285) {
                if (input[1] <= -1.4594069123268127) {
                    var42 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= -1.4260720610618591) {
                        var42 = new double[2] {0.0, 1.0};
                    } else {
                        var42 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[3] <= 0.3295005336403847) {
                    var42 = new double[2] {1.0, 0.0};
                } else {
                    var42 = new double[2] {1.0, 0.0};
                }
            }
            double[] var43;
            if (input[2] <= 0.10128318704664707) {
                if (input[2] <= -0.23862850666046143) {
                    if (input[1] <= -1.4387269616127014) {
                        var43 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var43 = new double[2] {0.0, 1.0};
                        } else {
                            var43 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.5482998490333557) {
                        var43 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 1.6161553263664246) {
                            var43 = new double[2] {0.0, 1.0};
                        } else {
                            var43 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.25183023512363434) {
                    var43 = new double[2] {1.0, 0.0};
                } else {
                    var43 = new double[2] {1.0, 0.0};
                }
            }
            double[] var44;
            if (input[2] <= -0.08070212975144386) {
                if (input[4] <= -1.053077220916748) {
                    var44 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= -0.23630979657173157) {
                        if (input[1] <= -1.4387269616127014) {
                            var44 = new double[2] {1.0, 0.0};
                        } else {
                            var44 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= -0.9681292176246643) {
                            var44 = new double[2] {0.5944333996023857, 0.4055666003976144};
                        } else {
                            var44 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.8585930615663528) {
                    var44 = new double[2] {0.7456359102244389, 0.25436408977556113};
                } else {
                    if (input[2] <= 0.028922077268362045) {
                        var44 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        var44 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var45;
            if (input[1] <= -1.4634194374084473) {
                var45 = new double[2] {1.0, 0.0};
            } else {
                if (input[0] <= 0.7622144669294357) {
                    if (input[3] <= 1.626701295375824) {
                        if (input[2] <= 0.07809973135590553) {
                            if (input[5] <= -1.6826141476631165) {
                                var45 = new double[2] {0.0, 1.0};
                            } else {
                                var45 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[4] <= -1.2683213651180267) {
                                var45 = new double[2] {1.0, 0.0};
                            } else {
                                var45 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= 0.6331591159105301) {
                            var45 = new double[2] {0.9791240278346296, 0.020875972165370453};
                        } else {
                            var45 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.1591744422912598) {
                        if (input[5] <= -0.5277826488018036) {
                            if (input[2] <= -0.14550935477018356) {
                                var45 = new double[2] {0.0, 1.0};
                            } else {
                                var45 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            }
                        } else {
                            if (input[2] <= -0.2582382708787918) {
                                var45 = new double[2] {0.0, 1.0};
                            } else {
                                var45 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[2] <= 3.6825491189956665) {
                            var45 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var45 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var46;
            if (input[3] <= 1.1383554935455322) {
                if (input[1] <= -1.4634194374084473) {
                    var46 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 1.2160237431526184) {
                        if (input[2] <= -0.056054855696856976) {
                            if (input[1] <= -1.4285413026809692) {
                                var46 = new double[2] {0.0, 1.0};
                            } else {
                                var46 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var46 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[5] <= -1.183265507221222) {
                            var46 = new double[2] {0.8978978978978979, 0.10210210210210212};
                        } else {
                            if (input[2] <= 0.07809973135590553) {
                                if (input[4] <= -0.8230819702148438) {
                                    var46 = new double[2] {0.0, 1.0};
                                } else {
                                    var46 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var46 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= -0.05624870955944061) {
                    if (input[0] <= -0.4615243822336197) {
                        if (input[2] <= 0.7608904540538788) {
                            var46 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        } else {
                            var46 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= -0.443385723978281) {
                            var46 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= -0.7402427494525909) {
                                var46 = new double[2] {1.0, 0.0};
                            } else {
                                var46 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        }
                    }
                } else {
                    if (input[5] <= -0.16078384593129158) {
                        var46 = new double[2] {0.0, 1.0};
                    } else {
                        var46 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var47;
            if (input[1] <= -1.4634194374084473) {
                var47 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.07809973135590553) {
                    if (input[4] <= -2.213181495666504) {
                        var47 = new double[2] {0.0, 1.0};
                    } else {
                        var47 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[5] <= -0.7914591431617737) {
                        var47 = new double[2] {1.0, 0.0};
                    } else {
                        var47 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var48;
            if (input[2] <= 0.05875357799232006) {
                if (input[2] <= -0.2344713732600212) {
                    if (input[1] <= -1.4569376707077026) {
                        var48 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= -1.3714399337768555) {
                            var48 = new double[2] {0.0, 1.0};
                        } else {
                            var48 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.1652749553322792) {
                        var48 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -1.5345358848571777) {
                            var48 = new double[2] {0.796271637816245, 0.20372836218375504};
                        } else {
                            if (input[3] <= 1.3349789381027222) {
                                var48 = new double[2] {0.0, 1.0};
                            } else {
                                var48 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        }
                    }
                }
            } else {
                if (input[3] <= -0.05603566765785217) {
                    var48 = new double[2] {1.0, 0.0};
                } else {
                    var48 = new double[2] {1.0, 0.0};
                }
            }
            double[] var49;
            if (input[4] <= -0.756169855594635) {
                if (input[5] <= 1.0614372491836548) {
                    if (input[2] <= -0.18888714164495468) {
                        if (input[2] <= -0.2607206106185913) {
                            var49 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= -1.3985263109207153) {
                                var49 = new double[2] {0.0, 1.0};
                            } else {
                                var49 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[5] <= 0.2838345840573311) {
                            if (input[4] <= -1.7001884579658508) {
                                var49 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= -0.9580721259117126) {
                                    var49 = new double[2] {0.8978978978978979, 0.10210210210210212};
                                } else {
                                    var49 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var49 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.1905314326286316) {
                        var49 = new double[2] {0.0, 1.0};
                    } else {
                        var49 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= -1.4634194374084473) {
                    var49 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.390239179134369) {
                        if (input[2] <= 0.0714487936347723) {
                            var49 = new double[2] {0.0, 1.0};
                        } else {
                            var49 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 1.717430830001831) {
                            var49 = new double[2] {0.8978978978978979, 0.10210210210210212};
                        } else {
                            if (input[3] <= 1.9713707566261292) {
                                var49 = new double[2] {0.0, 1.0};
                            } else {
                                var49 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            }
                        }
                    }
                }
            }
            double[] var50;
            if (input[1] <= -1.485642671585083) {
                var50 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.07809973135590553) {
                    if (input[1] <= 0.2548687681555748) {
                        var50 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 1.4401018023490906) {
                            var50 = new double[2] {0.0, 1.0};
                        } else {
                            var50 = new double[2] {0.661504424778761, 0.33849557522123896};
                        }
                    }
                } else {
                    if (input[3] <= -0.2102501466870308) {
                        var50 = new double[2] {1.0, 0.0};
                    } else {
                        var50 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var51;
            if (input[5] <= -0.12587419524788857) {
                if (input[1] <= -1.4569376707077026) {
                    var51 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 1.4749861359596252) {
                        if (input[1] <= -1.2374832034111023) {
                            if (input[3] <= -0.009514302015304565) {
                                var51 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            } else {
                                var51 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var51 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var51 = new double[2] {0.7962716378162449, 0.20372836218375498};
                    }
                }
            } else {
                if (input[1] <= -1.474839687347412) {
                    var51 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= -0.7500869333744049) {
                        if (input[2] <= 0.03708900511264801) {
                            if (input[0] <= -0.4615243822336197) {
                                var51 = new double[2] {0.0, 1.0};
                            } else {
                                var51 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var51 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= -0.08070212975144386) {
                            var51 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= 0.9450057689100504) {
                                var51 = new double[2] {0.53971119133574, 0.46028880866426};
                            } else {
                                var51 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var52;
            if (input[1] <= -1.4594069123268127) {
                var52 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08034390211105347) {
                    var52 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= -1.8299574255943298) {
                        var52 = new double[2] {1.0, 0.0};
                    } else {
                        var52 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var53;
            if (input[4] <= -0.80052450299263) {
                if (input[2] <= 0.2690508933737874) {
                    if (input[1] <= -1.482864797115326) {
                        var53 = new double[2] {1.0, 0.0};
                    } else {
                        var53 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var53 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= -1.5950202941894531) {
                    if (input[5] <= -1.6798008680343628) {
                        var53 = new double[2] {0.9462025316455697, 0.05379746835443039};
                    } else {
                        var53 = new double[2] {0.661504424778761, 0.338495575221239};
                    }
                } else {
                    if (input[4] <= 0.5479475259780884) {
                        if (input[3] <= 0.37113843858242035) {
                            if (input[1] <= -1.4569376707077026) {
                                var53 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.380699634552002) {
                                    var53 = new double[2] {0.0, 1.0};
                                } else {
                                    var53 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[5] <= 0.31618674099445343) {
                                var53 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= -0.25708647817373276) {
                                    if (input[1] <= -0.7294353693723679) {
                                        var53 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    } else {
                                        var53 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[0] <= -0.4615243822336197) {
                                        var53 = new double[2] {1.0, 0.0};
                                    } else {
                                        var53 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            if (input[4] <= 1.346695899963379) {
                                var53 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 1.3928348422050476) {
                                    var53 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    if (input[2] <= -0.2502451613545418) {
                                        var53 = new double[2] {0.0, 1.0};
                                    } else {
                                        var53 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= -1.482235312461853) {
                                var53 = new double[2] {0.0, 1.0};
                            } else {
                                var53 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            }
            double[] var54;
            if (input[5] <= -0.18137158453464508) {
                if (input[5] <= -1.3495019674301147) {
                    if (input[3] <= -1.0877305269241333) {
                        var54 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -1.358785092830658) {
                            var54 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= -1.6142014265060425) {
                                var54 = new double[2] {0.0, 1.0};
                            } else {
                                var54 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.22543518245220184) {
                        if (input[3] <= 0.47112083435058594) {
                            var54 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.2589235156774521) {
                                var54 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                if (input[4] <= -1.2533776760101318) {
                                    var54 = new double[2] {0.0, 1.0};
                                } else {
                                    var54 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var54 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= -1.474839687347412) {
                    var54 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.1591744422912598) {
                        if (input[0] <= 0.7622144669294357) {
                            if (input[2] <= 0.041617292910814285) {
                                var54 = new double[2] {0.0, 1.0};
                            } else {
                                var54 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var54 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= 0.6573387272655964) {
                            if (input[2] <= 0.33340640366077423) {
                                var54 = new double[2] {0.0, 1.0};
                            } else {
                                var54 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var54 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            }
            double[] var55;
            if (input[3] <= 0.4834579974412918) {
                if (input[1] <= -1.469283938407898) {
                    var55 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= 0.19771247822791338) {
                        var55 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -0.8746144771575928) {
                            var55 = new double[2] {1.0, 0.0};
                        } else {
                            var55 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[4] <= 0.5975233316421509) {
                    if (input[2] <= 0.09079494699835777) {
                        if (input[1] <= -1.4763829708099365) {
                            var55 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= 1.6161553263664246) {
                                var55 = new double[2] {0.0, 1.0};
                            } else {
                                var55 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        }
                    } else {
                        var55 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var55 = new double[2] {0.0, 1.0};
                }
            }
            double[] var56;
            if (input[1] <= -1.474839687347412) {
                var56 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.04717960301786661) {
                    var56 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= -1.2683213651180267) {
                        var56 = new double[2] {1.0, 0.0};
                    } else {
                        var56 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var57;
            if (input[2] <= -0.08034390211105347) {
                if (input[0] <= -0.4615243822336197) {
                    if (input[3] <= 1.2324263453483582) {
                        if (input[1] <= -1.4594069123268127) {
                            var57 = new double[2] {1.0, 0.0};
                        } else {
                            var57 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var57 = new double[2] {0.8865826538176427, 0.11341734618235731};
                    }
                } else {
                    if (input[2] <= -0.23399034142494202) {
                        if (input[1] <= -1.443048119544983) {
                            var57 = new double[2] {1.0, 0.0};
                        } else {
                            var57 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= -0.8343860805034637) {
                            if (input[3] <= 0.09715071320533752) {
                                var57 = new double[2] {0.0, 1.0};
                            } else {
                                var57 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            var57 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[2] <= 0.014321696013212204) {
                    var57 = new double[2] {0.7456359102244389, 0.25436408977556113};
                } else {
                    var57 = new double[2] {1.0, 0.0};
                }
            }
            double[] var58;
            if (input[5] <= -0.260909304022789) {
                if (input[2] <= 0.18320547230541706) {
                    if (input[3] <= 1.2331973910331726) {
                        if (input[4] <= 0.883025199174881) {
                            if (input[5] <= -1.5145875215530396) {
                                if (input[2] <= -0.23606330156326294) {
                                    var58 = new double[2] {0.0, 1.0};
                                } else {
                                    var58 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                }
                            } else {
                                var58 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[5] <= -1.6662461757659912) {
                                var58 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= -1.5092167854309082) {
                                    var58 = new double[2] {0.0, 1.0};
                                } else {
                                    var58 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var58 = new double[2] {0.7456359102244389, 0.25436408977556113};
                    }
                } else {
                    var58 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= -0.08070212975144386) {
                    if (input[2] <= -0.23642007261514664) {
                        if (input[2] <= -0.23744266480207443) {
                            if (input[0] <= 0.7622144669294357) {
                                if (input[5] <= 0.7117014825344086) {
                                    if (input[4] <= -0.956612229347229) {
                                        var58 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= -1.3877987265586853) {
                                            var58 = new double[2] {1.0, 0.0};
                                        } else {
                                            if (input[1] <= -1.005373865365982) {
                                                var58 = new double[2] {0.0, 1.0};
                                            } else {
                                                var58 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    }
                                } else {
                                    if (input[4] <= -0.165842667222023) {
                                        if (input[3] <= -0.7019373029470444) {
                                            var58 = new double[2] {0.796271637816245, 0.20372836218375504};
                                        } else {
                                            if (input[3] <= 1.201069414615631) {
                                                var58 = new double[2] {0.0, 1.0};
                                            } else {
                                                var58 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                            }
                                        }
                                    } else {
                                        if (input[3] <= -1.0872164964675903) {
                                            var58 = new double[2] {0.0, 1.0};
                                        } else {
                                            var58 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var58 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var58 = new double[2] {0.8978978978978979, 0.10210210210210212};
                        }
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var58 = new double[2] {0.0, 1.0};
                        } else {
                            var58 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[1] <= 1.5441250801086426) {
                        var58 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= 2.234341949224472) {
                            var58 = new double[2] {0.0, 1.0};
                        } else {
                            var58 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var59;
            if (input[1] <= -1.4594069123268127) {
                var59 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.155833125114441) {
                    if (input[1] <= 1.2197275757789612) {
                        if (input[2] <= -0.056054855696856976) {
                            if (input[5] <= -1.6906701922416687) {
                                var59 = new double[2] {0.0, 1.0};
                            } else {
                                var59 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var59 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[3] <= -0.30946145951747894) {
                            var59 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= 0.07809973135590553) {
                                if (input[5] <= -0.5399307161569595) {
                                    var59 = new double[2] {0.0, 1.0};
                                } else {
                                    var59 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var59 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.09316971525549889) {
                        var59 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 1.3285533785820007) {
                            var59 = new double[2] {1.0, 0.0};
                        } else {
                            var59 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var60;
            if (input[1] <= -1.474839687347412) {
                var60 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= -0.5225958228111267) {
                    if (input[1] <= 1.1237355470657349) {
                        if (input[2] <= 0.22912590205669403) {
                            var60 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= -0.9481468498706818) {
                                var60 = new double[2] {1.0, 0.0};
                            } else {
                                var60 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= 1.1288456320762634) {
                            if (input[5] <= 0.01555461436510086) {
                                if (input[2] <= 0.18320547230541706) {
                                    var60 = new double[2] {0.0, 1.0};
                                } else {
                                    var60 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var60 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var60 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.636468231678009) {
                        if (input[5] <= 0.15544893592596054) {
                            var60 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.1941091418266296) {
                                var60 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 1.3160282373428345) {
                                    var60 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var60 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var60 = new double[2] {0.4942148760330578, 0.5057851239669422};
                    }
                }
            }
            double[] var61;
            if (input[4] <= 0.2432844489812851) {
                if (input[3] <= 1.1591744422912598) {
                    if (input[3] <= 0.054227687418460846) {
                        if (input[3] <= -0.5269038677215576) {
                            if (input[0] <= -0.4615243822336197) {
                                var61 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= -1.1116337776184082) {
                                    if (input[4] <= -0.7581975162029266) {
                                        var61 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                    } else {
                                        var61 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[0] <= 0.7622144669294357) {
                                        if (input[3] <= -0.8571798801422119) {
                                            if (input[1] <= 0.20486649870872498) {
                                                var61 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                            } else {
                                                var61 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                            }
                                        } else {
                                            if (input[2] <= -0.24698197841644287) {
                                                var61 = new double[2] {0.0, 1.0};
                                            } else {
                                                var61 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                            }
                                        }
                                    } else {
                                        if (input[2] <= -0.25213392078876495) {
                                            var61 = new double[2] {0.0, 1.0};
                                        } else {
                                            var61 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var61 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= 0.04717960301786661) {
                            if (input[1] <= -1.5482998490333557) {
                                var61 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -1.3954848647117615) {
                                    var61 = new double[2] {0.0, 1.0};
                                } else {
                                    var61 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[5] <= 0.273476779460907) {
                                var61 = new double[2] {1.0, 0.0};
                            } else {
                                var61 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[1] <= 1.936118245124817) {
                        var61 = new double[2] {1.0, 0.0};
                    } else {
                        var61 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                }
            } else {
                if (input[2] <= -0.018777696415781975) {
                    if (input[1] <= -1.4387269616127014) {
                        var61 = new double[2] {1.0, 0.0};
                    } else {
                        var61 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var61 = new double[2] {0.9214175654853621, 0.07858243451463792};
                }
            }
            double[] var62;
            if (input[2] <= -0.08378744497895241) {
                if (input[5] <= -0.2607814222574234) {
                    if (input[5] <= -1.3495019674301147) {
                        if (input[1] <= -1.4569376707077026) {
                            var62 = new double[2] {1.0, 0.0};
                        } else {
                            var62 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var62 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= -1.485642671585083) {
                        var62 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var62 = new double[2] {0.0, 1.0};
                        } else {
                            var62 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[2] <= 0.24132782220840454) {
                    if (input[0] <= -0.4615243822336197) {
                        var62 = new double[2] {0.9462025316455697, 0.053797468354430396};
                    } else {
                        var62 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var62 = new double[2] {1.0, 0.0};
                }
            }
            double[] var63;
            if (input[2] <= -0.08070212975144386) {
                if (input[1] <= -1.4634194374084473) {
                    var63 = new double[2] {1.0, 0.0};
                } else {
                    var63 = new double[2] {0.0, 1.0};
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    if (input[2] <= 0.04717960301786661) {
                        var63 = new double[2] {0.7456359102244389, 0.25436408977556113};
                    } else {
                        var63 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var63 = new double[2] {1.0, 0.0};
                }
            }
            double[] var64;
            if (input[1] <= -1.474839687347412) {
                var64 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= -0.45210491120815277) {
                    if (input[2] <= 0.2690508933737874) {
                        var64 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -1.489699125289917) {
                            var64 = new double[2] {1.0, 0.0};
                        } else {
                            var64 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.05875357799232006) {
                        var64 = new double[2] {0.0, 1.0};
                    } else {
                        var64 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var65;
            if (input[3] <= 1.1591744422912598) {
                if (input[1] <= -1.485642671585083) {
                    var65 = new double[2] {1.0, 0.0};
                } else {
                    if (input[0] <= 0.7622144669294357) {
                        if (input[5] <= 1.4933961629867554) {
                            if (input[2] <= 0.12062934041023254) {
                                var65 = new double[2] {0.0, 1.0};
                            } else {
                                var65 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var65 = new double[2] {0.9591018444266239, 0.04089815557337611};
                        }
                    } else {
                        if (input[1] <= 1.1894792914390564) {
                            var65 = new double[2] {0.0, 1.0};
                        } else {
                            var65 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.32382339611649513) {
                    if (input[0] <= 0.7622144669294357) {
                        var65 = new double[2] {0.0, 1.0};
                    } else {
                        var65 = new double[2] {0.9214175654853621, 0.07858243451463792};
                    }
                } else {
                    if (input[0] <= 0.7622144669294357) {
                        if (input[2] <= -0.11612814292311668) {
                            if (input[3] <= 1.3205856084823608) {
                                var65 = new double[2] {0.9670116429495471, 0.032988357050452784};
                            } else {
                                var65 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var65 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var65 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var66;
            if (input[4] <= -1.3829843997955322) {
                if (input[4] <= -1.6271933913230896) {
                    if (input[1] <= 1.5166547298431396) {
                        var66 = new double[2] {0.0, 1.0};
                    } else {
                        var66 = new double[2] {0.9723577235772358, 0.027642276422764234};
                    }
                } else {
                    var66 = new double[2] {0.9462025316455697, 0.05379746835443039};
                }
            } else {
                if (input[5] <= 1.522679328918457) {
                    if (input[3] <= 1.600998878479004) {
                        if (input[3] <= -0.14805030822753906) {
                            if (input[3] <= -0.2408360168337822) {
                                if (input[2] <= -0.254158154129982) {
                                    var66 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[2] <= -0.2534421384334564) {
                                        var66 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                    } else {
                                        if (input[5] <= 0.19317181408405304) {
                                            if (input[3] <= -0.9134681820869446) {
                                                if (input[4] <= 1.270405888557434) {
                                                    if (input[4] <= -0.7310777902603149) {
                                                        var66 = new double[2] {0.0, 1.0};
                                                    } else {
                                                        var66 = new double[2] {0.0, 1.0};
                                                    }
                                                } else {
                                                    var66 = new double[2] {0.5944333996023857, 0.4055666003976144};
                                                }
                                            } else {
                                                if (input[3] <= -0.5269038677215576) {
                                                    if (input[1] <= -0.9812986999750137) {
                                                        var66 = new double[2] {1.0, 0.0};
                                                    } else {
                                                        if (input[2] <= -0.210362009704113) {
                                                            var66 = new double[2] {0.0, 1.0};
                                                        } else {
                                                            var66 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                                        }
                                                    }
                                                } else {
                                                    var66 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        } else {
                                            var66 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= -0.6596790812909603) {
                                    var66 = new double[2] {1.0, 0.0};
                                } else {
                                    var66 = new double[2] {0.661504424778761, 0.33849557522123896};
                                }
                            }
                        } else {
                            if (input[3] <= 0.5487421452999115) {
                                var66 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 0.39278335869312286) {
                                    if (input[3] <= 1.2686667442321777) {
                                        if (input[3] <= 1.145552158355713) {
                                            if (input[4] <= 0.5975233316421509) {
                                                if (input[3] <= 0.9093469679355621) {
                                                    if (input[1] <= -1.4396529793739319) {
                                                        var66 = new double[2] {1.0, 0.0};
                                                    } else {
                                                        if (input[5] <= -0.23226549662649632) {
                                                            var66 = new double[2] {0.0, 1.0};
                                                        } else {
                                                            var66 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                                        }
                                                    }
                                                } else {
                                                    var66 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var66 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            if (input[2] <= -0.23257656395435333) {
                                                var66 = new double[2] {0.45579268292682923, 0.5442073170731707};
                                            } else {
                                                var66 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                            }
                                        }
                                    } else {
                                        var66 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[2] <= -0.2590133100748062) {
                                        var66 = new double[2] {0.0, 1.0};
                                    } else {
                                        var66 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -0.3788021057844162) {
                            var66 = new double[2] {1.0, 0.0};
                        } else {
                            var66 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.15893995389342308) {
                        var66 = new double[2] {0.0, 1.0};
                    } else {
                        var66 = new double[2] {0.9670116429495471, 0.032988357050452784};
                    }
                }
            }
            double[] var67;
            if (input[5] <= -1.667141318321228) {
                if (input[3] <= -0.491177536547184) {
                    var67 = new double[2] {1.0, 0.0};
                } else {
                    var67 = new double[2] {0.7456359102244389, 0.25436408977556113};
                }
            } else {
                if (input[2] <= 0.0714487936347723) {
                    if (input[4] <= 0.7136259973049164) {
                        if (input[1] <= -1.4634194374084473) {
                            var67 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.062185756862163544) {
                                var67 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 1.5073344707489014) {
                                    var67 = new double[2] {0.0, 1.0};
                                } else {
                                    var67 = new double[2] {0.661504424778761, 0.33849557522123896};
                                }
                            }
                        }
                    } else {
                        var67 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[3] <= -0.2102501466870308) {
                        var67 = new double[2] {1.0, 0.0};
                    } else {
                        var67 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var68;
            if (input[2] <= 0.05875357799232006) {
                if (input[2] <= -0.23650696128606796) {
                    if (input[1] <= -1.4433568120002747) {
                        var68 = new double[2] {1.0, 0.0};
                    } else {
                        var68 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[4] <= -0.8343860805034637) {
                        if (input[3] <= 0.8448339402675629) {
                            var68 = new double[2] {0.0, 1.0};
                        } else {
                            var68 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    } else {
                        var68 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[5] <= 0.04573291167616844) {
                    var68 = new double[2] {1.0, 0.0};
                } else {
                    var68 = new double[2] {1.0, 0.0};
                }
            }
            double[] var69;
            if (input[1] <= -1.4594069123268127) {
                var69 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08070212975144386) {
                    var69 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 0.47240595519542694) {
                        if (input[3] <= 0.17528606206178665) {
                            if (input[5] <= 0.21350380033254623) {
                                var69 = new double[2] {1.0, 0.0};
                            } else {
                                var69 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            }
                        } else {
                            var69 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var69 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var70;
            if (input[3] <= 1.145552158355713) {
                if (input[5] <= -1.482235312461853) {
                    if (input[2] <= -0.2563207298517227) {
                        var70 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.2719271332025528) {
                            if (input[5] <= -1.7650929689407349) {
                                var70 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.23357348889112473) {
                                    var70 = new double[2] {0.9361302442078898, 0.06386975579211022};
                                } else {
                                    var70 = new double[2] {0.7010550996483002, 0.29894490035169996};
                                }
                            }
                        } else {
                            var70 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.07809973135590553) {
                        if (input[4] <= 1.3479631543159485) {
                            if (input[5] <= -0.6415906548500061) {
                                var70 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.4834579974412918) {
                                    if (input[1] <= -1.458480954170227) {
                                        var70 = new double[2] {1.0, 0.0};
                                    } else {
                                        var70 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[4] <= 0.3443116247653961) {
                                        if (input[5] <= 0.06504190899431705) {
                                            if (input[3] <= 0.6847078800201416) {
                                                var70 = new double[2] {1.0, 0.0};
                                            } else {
                                                var70 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            if (input[2] <= -0.18790872395038605) {
                                                if (input[2] <= -0.25819313526153564) {
                                                    var70 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                                } else {
                                                    var70 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var70 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                            }
                                        }
                                    } else {
                                        if (input[2] <= -0.255933552980423) {
                                            var70 = new double[2] {0.0, 1.0};
                                        } else {
                                            var70 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= -0.14033958688378334) {
                                if (input[5] <= 0.029876516200602055) {
                                    var70 = new double[2] {0.9591018444266239, 0.04089815557337611};
                                } else {
                                    var70 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[0] <= -0.4615243822336197) {
                                    var70 = new double[2] {0.0, 1.0};
                                } else {
                                    var70 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[5] <= -0.25183023512363434) {
                            var70 = new double[2] {1.0, 0.0};
                        } else {
                            var70 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[2] <= -0.09316971525549889) {
                    if (input[1] <= -1.3955150842666626) {
                        var70 = new double[2] {1.0, 0.0};
                    } else {
                        var70 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[5] <= 0.15263570472598076) {
                        var70 = new double[2] {1.0, 0.0};
                    } else {
                        var70 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var71;
            if (input[2] <= 0.07809973135590553) {
                if (input[2] <= -0.23650696128606796) {
                    if (input[3] <= 1.145552158355713) {
                        if (input[5] <= -1.482235312461853) {
                            if (input[4] <= 0.31859100237488747) {
                                var71 = new double[2] {0.0, 1.0};
                            } else {
                                var71 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= -0.25480248034000397) {
                                var71 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.443048119544983) {
                                    var71 = new double[2] {1.0, 0.0};
                                } else {
                                    var71 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.3445868492126465) {
                            var71 = new double[2] {1.0, 0.0};
                        } else {
                            var71 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.5319411158561707) {
                        var71 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= 1.636468231678009) {
                            var71 = new double[2] {0.0, 1.0};
                        } else {
                            var71 = new double[2] {0.661504424778761, 0.33849557522123896};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.7914591431617737) {
                    var71 = new double[2] {1.0, 0.0};
                } else {
                    var71 = new double[2] {1.0, 0.0};
                }
            }
            double[] var72;
            if (input[2] <= 0.05875357799232006) {
                if (input[3] <= 1.2591568231582642) {
                    if (input[5] <= -1.525968313217163) {
                        if (input[1] <= -1.4165037274360657) {
                            var72 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.26604151725769043) {
                                var72 = new double[2] {0.0, 1.0};
                            } else {
                                var72 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[5] <= -0.6357084512710571) {
                            var72 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= -0.4615243822336197) {
                                if (input[2] <= -0.23839838057756424) {
                                    if (input[1] <= -1.2881028056144714) {
                                        var72 = new double[2] {1.0, 0.0};
                                    } else {
                                        var72 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var72 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= -0.23620092868804932) {
                                    if (input[5] <= 0.1853714883327484) {
                                        if (input[5] <= 0.02015808131545782) {
                                            if (input[1] <= -0.7464114725589752) {
                                                var72 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                            } else {
                                                var72 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            if (input[1] <= -0.4781893193721771) {
                                                var72 = new double[2] {1.0, 0.0};
                                            } else {
                                                var72 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        if (input[5] <= 1.1680843234062195) {
                                            if (input[5] <= 1.0868842005729675) {
                                                if (input[1] <= -1.3069308400154114) {
                                                    var72 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                                } else {
                                                    var72 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var72 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                            }
                                        } else {
                                            if (input[3] <= -1.1496734023094177) {
                                                var72 = new double[2] {0.0, 1.0};
                                            } else {
                                                var72 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    }
                                } else {
                                    var72 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.5915925055742264) {
                        var72 = new double[2] {0.9214175654853621, 0.07858243451463792};
                    } else {
                        var72 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[5] <= -0.7062949687242508) {
                    var72 = new double[2] {1.0, 0.0};
                } else {
                    var72 = new double[2] {1.0, 0.0};
                }
            }
            double[] var73;
            if (input[4] <= -0.7500869333744049) {
                if (input[2] <= 0.2545438874512911) {
                    if (input[5] <= -0.08214123733341694) {
                        var73 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= 0.14266151562333107) {
                            var73 = new double[2] {0.9462025316455697, 0.05379746835443039};
                        } else {
                            if (input[3] <= 1.0363169312477112) {
                                var73 = new double[2] {0.0, 1.0};
                            } else {
                                var73 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        }
                    }
                } else {
                    if (input[3] <= 0.3295005187392235) {
                        var73 = new double[2] {1.0, 0.0};
                    } else {
                        var73 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= -1.4569376707077026) {
                    var73 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.610765814781189) {
                        if (input[1] <= 1.2160237431526184) {
                            if (input[0] <= -0.4615243822336197) {
                                var73 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= -0.5091322958469391) {
                                    if (input[2] <= -0.1933765634894371) {
                                        var73 = new double[2] {0.0, 1.0};
                                    } else {
                                        var73 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                } else {
                                    var73 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[4] <= 1.007664293050766) {
                                if (input[2] <= 0.028922077268362045) {
                                    var73 = new double[2] {0.0, 1.0};
                                } else {
                                    var73 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var73 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var73 = new double[2] {0.9670116429495471, 0.032988357050452784};
                    }
                }
            }
            double[] var74;
            if (input[1] <= -1.4569376707077026) {
                var74 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08070212975144386) {
                    var74 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= 0.07809973135590553) {
                        if (input[3] <= 0.7170929312705994) {
                            var74 = new double[2] {0.0, 1.0};
                        } else {
                            var74 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    } else {
                        var74 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var75;
            if (input[1] <= -1.4634194374084473) {
                var75 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.31266623735427856) {
                    if (input[3] <= 1.636468231678009) {
                        var75 = new double[2] {0.0, 1.0};
                    } else {
                        var75 = new double[2] {0.53971119133574, 0.46028880866426};
                    }
                } else {
                    if (input[1] <= -0.7880800366401672) {
                        var75 = new double[2] {1.0, 0.0};
                    } else {
                        var75 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var76;
            if (input[2] <= 0.05875357799232006) {
                if (input[3] <= 1.2324263453483582) {
                    if (input[1] <= -1.4683579206466675) {
                        var76 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var76 = new double[2] {0.0, 1.0};
                        } else {
                            var76 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.4529529809951782) {
                        var76 = new double[2] {0.9361302442078898, 0.06386975579211022};
                    } else {
                        if (input[5] <= 0.008777283132076263) {
                            var76 = new double[2] {0.0, 1.0};
                        } else {
                            var76 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[2] <= 0.3689490854740143) {
                    var76 = new double[2] {1.0, 0.0};
                } else {
                    var76 = new double[2] {1.0, 0.0};
                }
            }
            double[] var77;
            if (input[3] <= 1.2324263453483582) {
                if (input[1] <= -1.3087828159332275) {
                    if (input[5] <= 0.6205272376537323) {
                        if (input[4] <= 0.22573521733283997) {
                            if (input[4] <= -0.6844218075275421) {
                                var77 = new double[2] {0.9670116429495472, 0.03298835705045279};
                            } else {
                                var77 = new double[2] {0.661504424778761, 0.33849557522123896};
                            }
                        } else {
                            if (input[1] <= -1.496445655822754) {
                                var77 = new double[2] {1.0, 0.0};
                            } else {
                                var77 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            }
                        }
                    } else {
                        if (input[1] <= -1.5023101568222046) {
                            var77 = new double[2] {1.0, 0.0};
                        } else {
                            var77 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[4] <= -0.8072765469551086) {
                        if (input[4] <= -0.8313547372817993) {
                            if (input[2] <= -0.012081284075975418) {
                                if (input[0] <= -0.4615243822336197) {
                                    var77 = new double[2] {0.0, 1.0};
                                } else {
                                    var77 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var77 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            var77 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    } else {
                        var77 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[2] <= -0.11619627848267555) {
                    if (input[5] <= 1.019622415304184) {
                        if (input[2] <= -0.2540612444281578) {
                            var77 = new double[2] {1.0, 0.0};
                        } else {
                            var77 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var77 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[0] <= -0.4615243822336197) {
                        var77 = new double[2] {1.0, 0.0};
                    } else {
                        var77 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var78;
            if (input[2] <= 0.05875357799232006) {
                if (input[3] <= 1.145552158355713) {
                    if (input[5] <= -1.6798008680343628) {
                        var78 = new double[2] {0.9318788958147818, 0.06812110418521818};
                    } else {
                        if (input[5] <= 0.4383065551519394) {
                            if (input[0] <= 0.7622144669294357) {
                                if (input[5] <= -0.1926245093345642) {
                                    if (input[2] <= -0.2628088593482971) {
                                        var78 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    } else {
                                        var78 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[1] <= -1.4143431186676025) {
                                        var78 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[4] <= -1.298888087272644) {
                                            var78 = new double[2] {0.0, 1.0};
                                        } else {
                                            var78 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[4] <= 0.030960099771618843) {
                                    if (input[4] <= -0.2305852174758911) {
                                        if (input[2] <= -0.2570166289806366) {
                                            var78 = new double[2] {0.0, 1.0};
                                        } else {
                                            var78 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var78 = new double[2] {0.5944333996023857, 0.4055666003976144};
                                    }
                                } else {
                                    if (input[5] <= -1.148995280265808) {
                                        var78 = new double[2] {0.0, 1.0};
                                    } else {
                                        var78 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= -0.19740288704633713) {
                                if (input[4] <= -0.20205631852149963) {
                                    var78 = new double[2] {0.0, 1.0};
                                } else {
                                    var78 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            } else {
                                var78 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[3] <= 1.717430830001831) {
                        if (input[2] <= -0.24642299860715866) {
                            if (input[2] <= -0.2574799656867981) {
                                var78 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            } else {
                                var78 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= -1.450764536857605) {
                                var78 = new double[2] {1.0, 0.0};
                            } else {
                                var78 = new double[2] {0.661504424778761, 0.33849557522123896};
                            }
                        }
                    } else {
                        var78 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[4] <= -1.182004690170288) {
                    var78 = new double[2] {1.0, 0.0};
                } else {
                    var78 = new double[2] {1.0, 0.0};
                }
            }
            double[] var79;
            if (input[2] <= 0.07809973135590553) {
                if (input[3] <= 1.2591568231582642) {
                    if (input[0] <= 0.7622144669294357) {
                        if (input[1] <= -1.4569376707077026) {
                            var79 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.4115652441978455) {
                                var79 = new double[2] {0.0, 1.0};
                            } else {
                                var79 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[3] <= 0.32564516365528107) {
                            if (input[4] <= 1.3335466384887695) {
                                if (input[1] <= -0.6374558806419373) {
                                    var79 = new double[2] {0.0, 1.0};
                                } else {
                                    var79 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[1] <= -1.087167739868164) {
                                    var79 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var79 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[4] <= -0.0030535683035850525) {
                                if (input[1] <= -1.4411962032318115) {
                                    var79 = new double[2] {1.0, 0.0};
                                } else {
                                    var79 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= -0.25523822009563446) {
                                    var79 = new double[2] {0.0, 1.0};
                                } else {
                                    var79 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[3] <= 1.3205856084823608) {
                        var79 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var79 = new double[2] {0.0, 1.0};
                        } else {
                            var79 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[4] <= -1.4766512513160706) {
                    var79 = new double[2] {1.0, 0.0};
                } else {
                    var79 = new double[2] {1.0, 0.0};
                }
            }
            double[] var80;
            if (input[5] <= 1.522679328918457) {
                if (input[3] <= 1.1383554935455322) {
                    if (input[1] <= -1.4634194374084473) {
                        var80 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= 0.04717960301786661) {
                            if (input[4] <= -1.9931824803352356) {
                                var80 = new double[2] {0.0, 1.0};
                            } else {
                                var80 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= -0.24237816035747528) {
                                var80 = new double[2] {1.0, 0.0};
                            } else {
                                var80 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.8750983327627182) {
                        if (input[0] <= -0.4615243822336197) {
                            var80 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= 0.7622144669294357) {
                                if (input[5] <= -0.2373804710805416) {
                                    var80 = new double[2] {0.0, 1.0};
                                } else {
                                    var80 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                }
                            } else {
                                if (input[5] <= -1.1530872583389282) {
                                    var80 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var80 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var80 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[3] <= 0.5479710549116135) {
                    var80 = new double[2] {0.0, 1.0};
                } else {
                    var80 = new double[2] {1.0, 0.0};
                }
            }
            double[] var81;
            if (input[2] <= 0.09079494699835777) {
                if (input[4] <= -1.0131631195545197) {
                    var81 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= -0.8550173342227936) {
                        if (input[1] <= -1.33285790681839) {
                            var81 = new double[2] {1.0, 0.0};
                        } else {
                            var81 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= -0.19970425963401794) {
                            if (input[2] <= -0.2580808252096176) {
                                var81 = new double[2] {0.49421487603305775, 0.5057851239669422};
                            } else {
                                if (input[5] <= -1.5110069513320923) {
                                    var81 = new double[2] {0.0, 1.0};
                                } else {
                                    var81 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[4] <= -0.16543713957071304) {
                                var81 = new double[2] {0.9462025316455697, 0.053797468354430396};
                            } else {
                                if (input[0] <= -0.4615243822336197) {
                                    if (input[1] <= -1.4609501957893372) {
                                        var81 = new double[2] {1.0, 0.0};
                                    } else {
                                        var81 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[5] <= -1.6211066246032715) {
                                        var81 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    } else {
                                        if (input[2] <= -0.23584363609552383) {
                                            if (input[1] <= -1.5791654586791992) {
                                                var81 = new double[2] {1.0, 0.0};
                                            } else {
                                                if (input[3] <= -1.263278067111969) {
                                                    var81 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var81 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        } else {
                                            var81 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[2] <= 0.29761067032814026) {
                    var81 = new double[2] {1.0, 0.0};
                } else {
                    var81 = new double[2] {1.0, 0.0};
                }
            }
            double[] var82;
            if (input[3] <= 1.145552158355713) {
                if (input[2] <= 0.07809973135590553) {
                    if (input[1] <= -1.4594069123268127) {
                        var82 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -1.8351680040359497) {
                            var82 = new double[2] {0.0, 1.0};
                        } else {
                            var82 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.1470777951180935) {
                        var82 = new double[2] {1.0, 0.0};
                    } else {
                        var82 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[5] <= -0.32382339611649513) {
                    if (input[5] <= -1.3087100982666016) {
                        var82 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        var82 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[3] <= 2.0212334394454956) {
                        if (input[3] <= 1.4948479533195496) {
                            if (input[3] <= 1.1591744422912598) {
                                var82 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            } else {
                                var82 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var82 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var82 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var83;
            if (input[2] <= 0.07809973135590553) {
                if (input[1] <= -1.4594069123268127) {
                    var83 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.08745646104216576) {
                        var83 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.7170929312705994) {
                            var83 = new double[2] {0.0, 1.0};
                        } else {
                            var83 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var83 = new double[2] {1.0, 0.0};
                } else {
                    var83 = new double[2] {1.0, 0.0};
                }
            }
            double[] var84;
            if (input[2] <= -0.08034390211105347) {
                if (input[2] <= -0.23650696128606796) {
                    if (input[5] <= 0.6232125759124756) {
                        if (input[1] <= -1.4569376707077026) {
                            var84 = new double[2] {1.0, 0.0};
                        } else {
                            var84 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[5] <= 0.6950778365135193) {
                            var84 = new double[2] {0.0, 1.0};
                        } else {
                            var84 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[3] <= 0.8934114873409271) {
                        var84 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -0.9834592938423157) {
                            var84 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var84 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[4] <= 1.5429613292217255) {
                    if (input[2] <= 0.03448438737541437) {
                        var84 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        var84 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var84 = new double[2] {0.0, 1.0};
                }
            }
            double[] var85;
            if (input[2] <= 0.07809973135590553) {
                if (input[0] <= -0.4615243822336197) {
                    if (input[3] <= -1.2514549493789673) {
                        var85 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -1.030742734670639) {
                            var85 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.23839838057756424) {
                                if (input[2] <= -0.25914961099624634) {
                                    var85 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -1.4029228687286377) {
                                        var85 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[2] <= -0.2583359330892563) {
                                            var85 = new double[2] {0.0, 1.0};
                                        } else {
                                            var85 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[4] <= 0.18901465833187103) {
                                    if (input[5] <= 0.8531303107738495) {
                                        if (input[4] <= -0.9530030190944672) {
                                            var85 = new double[2] {0.796271637816245, 0.20372836218375504};
                                        } else {
                                            var85 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var85 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                    }
                                } else {
                                    if (input[3] <= -0.9545920491218567) {
                                        var85 = new double[2] {0.0, 1.0};
                                    } else {
                                        var85 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[1] <= -1.4563204050064087) {
                        var85 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -1.6211066246032715) {
                            var85 = new double[2] {0.0, 1.0};
                        } else {
                            var85 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[1] <= -0.8470333218574524) {
                    var85 = new double[2] {1.0, 0.0};
                } else {
                    var85 = new double[2] {1.0, 0.0};
                }
            }
            double[] var86;
            if (input[3] <= 1.2324263453483582) {
                if (input[5] <= -0.2607814222574234) {
                    if (input[3] <= 0.487827405333519) {
                        if (input[4] <= -1.0981820821762085) {
                            var86 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -1.431627869606018) {
                                var86 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 1.4191193580627441) {
                                    if (input[2] <= -0.2591986060142517) {
                                        var86 = new double[2] {0.0, 1.0};
                                    } else {
                                        var86 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var86 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            }
                        }
                    } else {
                        var86 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= -1.3087828159332275) {
                        if (input[5] <= 0.878321498632431) {
                            if (input[4] <= 0.81437948346138) {
                                if (input[5] <= 0.15353082120418549) {
                                    var86 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                } else {
                                    if (input[5] <= 0.6783263385295868) {
                                        if (input[3] <= -0.6806043088436127) {
                                            var86 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                        } else {
                                            var86 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var86 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                }
                            } else {
                                var86 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var86 = new double[2] {0.661504424778761, 0.33849557522123896};
                        }
                    } else {
                        if (input[5] <= 0.7411125600337982) {
                            if (input[2] <= 0.09079494699835777) {
                                var86 = new double[2] {0.0, 1.0};
                            } else {
                                var86 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[5] <= 1.4933961629867554) {
                                var86 = new double[2] {0.0, 1.0};
                            } else {
                                var86 = new double[2] {0.661504424778761, 0.33849557522123896};
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= 0.6639285758137703) {
                    if (input[5] <= -0.30080604925751686) {
                        var86 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        if (input[3] <= 1.390239179134369) {
                            if (input[1] <= -1.340574324131012) {
                                var86 = new double[2] {1.0, 0.0};
                            } else {
                                var86 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            if (input[1] <= -0.19329982995986938) {
                                var86 = new double[2] {1.0, 0.0};
                            } else {
                                var86 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[1] <= -0.1371244117617607) {
                        var86 = new double[2] {0.0, 1.0};
                    } else {
                        var86 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var87;
            if (input[4] <= 0.2525304853916168) {
                if (input[3] <= 1.1383554935455322) {
                    if (input[3] <= 0.05165744572877884) {
                        if (input[2] <= 0.1649000458419323) {
                            if (input[1] <= -1.404466152191162) {
                                var87 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var87 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var87 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= -0.6496467292308807) {
                            if (input[5] <= -1.4950227737426758) {
                                var87 = new double[2] {0.661504424778761, 0.33849557522123896};
                            } else {
                                var87 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= -1.566819190979004) {
                                var87 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 0.07299045100808144) {
                                    var87 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                } else {
                                    if (input[2] <= 0.4192368686199188) {
                                        if (input[5] <= -0.5142279863357544) {
                                            var87 = new double[2] {0.0, 1.0};
                                        } else {
                                            var87 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var87 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[1] <= -1.3955150842666626) {
                        var87 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= -1.0544501841068268) {
                            var87 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.0721670538187027) {
                                var87 = new double[2] {0.796271637816245, 0.20372836218375504};
                            } else {
                                if (input[0] <= 0.7622144669294357) {
                                    if (input[3] <= 1.2344825267791748) {
                                        var87 = new double[2] {0.0, 1.0};
                                    } else {
                                        var87 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var87 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= -1.4387269616127014) {
                    var87 = new double[2] {1.0, 0.0};
                } else {
                    var87 = new double[2] {0.0, 1.0};
                }
            }
            double[] var88;
            if (input[2] <= -0.08034390211105347) {
                if (input[0] <= 0.7622144669294357) {
                    if (input[1] <= -1.456320345401764) {
                        var88 = new double[2] {1.0, 0.0};
                    } else {
                        var88 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[5] <= -1.3495019674301147) {
                        if (input[1] <= -1.3550812005996704) {
                            var88 = new double[2] {1.0, 0.0};
                        } else {
                            var88 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= -1.3180424571037292) {
                            var88 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var88 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[4] <= 1.2466926723718643) {
                    if (input[5] <= -0.597985565662384) {
                        var88 = new double[2] {0.7456359102244389, 0.25436408977556113};
                    } else {
                        if (input[2] <= 0.1470777951180935) {
                            var88 = new double[2] {1.0, 0.0};
                        } else {
                            var88 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var88 = new double[2] {0.0, 1.0};
                }
            }
            double[] var89;
            if (input[2] <= 0.07809973135590553) {
                if (input[1] <= -1.4763829708099365) {
                    var89 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 0.25517742335796356) {
                        var89 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 1.4331621527671814) {
                            var89 = new double[2] {0.0, 1.0};
                        } else {
                            var89 = new double[2] {0.5944333996023857, 0.4055666003976144};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.7914591431617737) {
                    var89 = new double[2] {1.0, 0.0};
                } else {
                    var89 = new double[2] {1.0, 0.0};
                }
            }
            double[] var90;
            if (input[3] <= 1.2535023093223572) {
                if (input[2] <= 0.09079494699835777) {
                    if (input[5] <= 0.11913267150521278) {
                        if (input[0] <= 0.7622144669294357) {
                            if (input[3] <= -0.4564792662858963) {
                                if (input[1] <= -1.443048119544983) {
                                    var90 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[4] <= -1.3332971334457397) {
                                        var90 = new double[2] {0.0, 1.0};
                                    } else {
                                        var90 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[2] <= -0.25526806712150574) {
                                    var90 = new double[2] {0.661504424778761, 0.33849557522123896};
                                } else {
                                    if (input[3] <= 0.26858581602573395) {
                                        if (input[3] <= -0.13442802801728249) {
                                            var90 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[4] <= -1.0787166953086853) {
                                                var90 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[1] <= -1.4569376707077026) {
                                                    var90 = new double[2] {1.0, 0.0};
                                                } else {
                                                    var90 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[0] <= -0.4615243822336197) {
                                            var90 = new double[2] {0.0, 1.0};
                                        } else {
                                            var90 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= -1.3470561504364014) {
                                var90 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= -1.349895179271698) {
                                    var90 = new double[2] {0.0, 1.0};
                                } else {
                                    var90 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[2] <= -0.150268092751503) {
                            if (input[5] <= 1.1354764103889465) {
                                var90 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -0.922036737203598) {
                                    var90 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var90 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.1283562034368515) {
                                var90 = new double[2] {0.796271637816245, 0.20372836218375504};
                            } else {
                                var90 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= -0.9449127614498138) {
                        var90 = new double[2] {1.0, 0.0};
                    } else {
                        var90 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= -0.09316971525549889) {
                    var90 = new double[2] {0.796271637816245, 0.20372836218375504};
                } else {
                    var90 = new double[2] {1.0, 0.0};
                }
            }
            double[] var91;
            if (input[2] <= 0.09079494699835777) {
                if (input[4] <= -1.0697241425514221) {
                    var91 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= -0.23650696128606796) {
                        if (input[3] <= -1.0080530643463135) {
                            if (input[3] <= -1.100581705570221) {
                                if (input[3] <= -1.2344913482666016) {
                                    if (input[4] <= 1.346695899963379) {
                                        if (input[1] <= -1.272670030593872) {
                                            var91 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                        } else {
                                            var91 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var91 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                    }
                                } else {
                                    var91 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= 0.6472529321908951) {
                                    var91 = new double[2] {1.0, 0.0};
                                } else {
                                    var91 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            }
                        } else {
                            if (input[1] <= -1.4751483798027039) {
                                var91 = new double[2] {1.0, 0.0};
                            } else {
                                var91 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -1.5482998490333557) {
                            var91 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= 1.636468231678009) {
                                var91 = new double[2] {0.0, 1.0};
                            } else {
                                var91 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            }
                        }
                    }
                }
            } else {
                if (input[5] <= -0.4493957906961441) {
                    var91 = new double[2] {1.0, 0.0};
                } else {
                    var91 = new double[2] {1.0, 0.0};
                }
            }
            double[] var92;
            if (input[1] <= -1.4634194374084473) {
                var92 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.07809973135590553) {
                    if (input[0] <= -0.4615243822336197) {
                        var92 = new double[2] {0.0, 1.0};
                    } else {
                        var92 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var92 = new double[2] {1.0, 0.0};
                }
            }
            double[] var93;
            if (input[2] <= 0.09079494699835777) {
                if (input[1] <= -1.4634194374084473) {
                    var93 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= -2.0722604393959045) {
                        var93 = new double[2] {0.0, 1.0};
                    } else {
                        var93 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[5] <= -0.7914591431617737) {
                    var93 = new double[2] {1.0, 0.0};
                } else {
                    var93 = new double[2] {1.0, 0.0};
                }
            }
            double[] var94;
            if (input[1] <= -1.4634194374084473) {
                var94 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= -0.45210491120815277) {
                    if (input[5] <= -0.37970438599586487) {
                        if (input[2] <= -0.08100691251456738) {
                            var94 = new double[2] {0.0, 1.0};
                        } else {
                            var94 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[1] <= 1.4580100774765015) {
                            if (input[3] <= 1.2031255960464478) {
                                if (input[4] <= -0.5368501245975494) {
                                    var94 = new double[2] {0.0, 1.0};
                                } else {
                                    var94 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                }
                            } else {
                                var94 = new double[2] {0.9591018444266239, 0.04089815557337611};
                            }
                        } else {
                            if (input[5] <= 0.05161512270569801) {
                                var94 = new double[2] {1.0, 0.0};
                            } else {
                                var94 = new double[2] {0.9462025316455697, 0.053797468354430396};
                            }
                        }
                    }
                } else {
                    if (input[0] <= 0.7622144669294357) {
                        if (input[1] <= 1.1941091418266296) {
                            if (input[1] <= 0.25949861109256744) {
                                var94 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 1.3915242552757263) {
                                    var94 = new double[2] {0.0, 1.0};
                                } else {
                                    var94 = new double[2] {0.661504424778761, 0.33849557522123896};
                                }
                            }
                        } else {
                            if (input[2] <= 0.014321696013212204) {
                                var94 = new double[2] {0.0, 1.0};
                            } else {
                                var94 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.2600344568490982) {
                            var94 = new double[2] {0.0, 1.0};
                        } else {
                            var94 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            }
            double[] var95;
            if (input[3] <= 1.2324263453483582) {
                if (input[1] <= -1.4634194374084473) {
                    var95 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= -0.5225958228111267) {
                        if (input[4] <= -0.9580721259117126) {
                            if (input[2] <= 0.020731148310005665) {
                                var95 = new double[2] {0.0, 1.0};
                            } else {
                                var95 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            }
                        } else {
                            if (input[5] <= 0.5398386418819427) {
                                if (input[4] <= -0.5748785436153412) {
                                    if (input[4] <= -0.7072226107120514) {
                                        if (input[3] <= -0.956134170293808) {
                                            var95 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[2] <= 0.2545438874512911) {
                                                var95 = new double[2] {0.0, 1.0};
                                            } else {
                                                var95 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    } else {
                                        if (input[0] <= 0.7622144669294357) {
                                            var95 = new double[2] {0.0, 1.0};
                                        } else {
                                            var95 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var95 = new double[2] {0.9462025316455697, 0.05379746835443039};
                                }
                            } else {
                                if (input[4] <= -0.8972530663013458) {
                                    var95 = new double[2] {0.0, 1.0};
                                } else {
                                    var95 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 0.14764861017465591) {
                            var95 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.1941091418266296) {
                                if (input[1] <= -1.3739091753959656) {
                                    var95 = new double[2] {0.0, 1.0};
                                } else {
                                    var95 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= 0.5094045847654343) {
                                    var95 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                } else {
                                    var95 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[5] <= -0.15362289175391197) {
                    var95 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= 0.973204106092453) {
                        if (input[5] <= 0.6491710245609283) {
                            if (input[3] <= 1.600998878479004) {
                                var95 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            } else {
                                var95 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var95 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    } else {
                        var95 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var96;
            if (input[1] <= -1.4683579206466675) {
                var96 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.1591744422912598) {
                    if (input[4] <= -1.5075626373291016) {
                        var96 = new double[2] {0.8147138964577656, 0.18528610354223435};
                    } else {
                        if (input[0] <= 0.7622144669294357) {
                            if (input[2] <= 0.0714487936347723) {
                                if (input[5] <= -1.6826141476631165) {
                                    var96 = new double[2] {0.0, 1.0};
                                } else {
                                    var96 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= 0.009672403335571289) {
                                    var96 = new double[2] {1.0, 0.0};
                                } else {
                                    var96 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= 0.3320058137178421) {
                                var96 = new double[2] {0.0, 1.0};
                            } else {
                                var96 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.09316971525549889) {
                        var96 = new double[2] {0.0, 1.0};
                    } else {
                        var96 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var97;
            if (input[1] <= -1.4634194374084473) {
                var97 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.481159269809723) {
                    if (input[5] <= 1.4933961629867554) {
                        if (input[3] <= 1.2344825267791748) {
                            if (input[1] <= -1.2374832034111023) {
                                if (input[1] <= -1.2816210985183716) {
                                    var97 = new double[2] {0.0, 1.0};
                                } else {
                                    var97 = new double[2] {0.8147138964577656, 0.18528610354223435};
                                }
                            } else {
                                if (input[3] <= 0.5765007138252258) {
                                    var97 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= 0.10698463022708893) {
                                        var97 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= 0.9650863707065582) {
                                            var97 = new double[2] {0.0, 1.0};
                                        } else {
                                            var97 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 1.4485836029052734) {
                                var97 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            } else {
                                if (input[4] <= -0.48084672540426254) {
                                    var97 = new double[2] {1.0, 0.0};
                                } else {
                                    var97 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                }
                            }
                        }
                    } else {
                        if (input[2] <= -0.16034113988280296) {
                            var97 = new double[2] {0.0, 1.0};
                        } else {
                            var97 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[4] <= -0.7093009352684021) {
                        if (input[0] <= 0.7622144669294357) {
                            var97 = new double[2] {0.8978978978978979, 0.10210210210210212};
                        } else {
                            var97 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 0.34854940325021744) {
                            var97 = new double[2] {0.0, 1.0};
                        } else {
                            var97 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            }
            double[] var98;
            if (input[5] <= 1.6361037492752075) {
                if (input[3] <= 1.1591744422912598) {
                    if (input[2] <= 0.09079494699835777) {
                        if (input[3] <= 0.6821376383304596) {
                            if (input[5] <= -1.4787827134132385) {
                                if (input[3] <= -0.8433006107807159) {
                                    if (input[4] <= -0.084503885358572) {
                                        var98 = new double[2] {0.0, 1.0};
                                    } else {
                                        var98 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                } else {
                                    if (input[5] <= -1.6446354389190674) {
                                        var98 = new double[2] {1.0, 0.0};
                                    } else {
                                        var98 = new double[2] {0.8865826538176427, 0.11341734618235731};
                                    }
                                }
                            } else {
                                if (input[1] <= -1.469283938407898) {
                                    var98 = new double[2] {1.0, 0.0};
                                } else {
                                    var98 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var98 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= 0.29761067032814026) {
                            var98 = new double[2] {1.0, 0.0};
                        } else {
                            var98 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= 0.7780407667160034) {
                        if (input[2] <= 0.8521399050951004) {
                            if (input[4] <= -0.856487363576889) {
                                var98 = new double[2] {0.9462025316455697, 0.053797468354430396};
                            } else {
                                if (input[4] <= 0.40172426402568817) {
                                    var98 = new double[2] {0.0, 1.0};
                                } else {
                                    var98 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var98 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= -0.5147995501756668) {
                            var98 = new double[2] {1.0, 0.0};
                        } else {
                            var98 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    }
                }
            } else {
                var98 = new double[2] {1.0, 0.0};
            }
            double[] var99;
            if (input[3] <= 1.145552158355713) {
                if (input[3] <= 0.26344533264636993) {
                    if (input[2] <= 0.07145168632268906) {
                        if (input[2] <= -0.23862850666046143) {
                            if (input[1] <= -1.4538511037826538) {
                                var99 = new double[2] {1.0, 0.0};
                            } else {
                                var99 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= -1.4997402429580688) {
                                var99 = new double[2] {0.0, 1.0};
                            } else {
                                var99 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var99 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.1652749553322792) {
                        if (input[4] <= 0.2299121618270874) {
                            if (input[1] <= -1.5467565655708313) {
                                var99 = new double[2] {1.0, 0.0};
                            } else {
                                var99 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= 0.33489803969860077) {
                                var99 = new double[2] {0.0, 1.0};
                            } else {
                                var99 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[4] <= 1.012733370065689) {
                            if (input[5] <= 0.49482692033052444) {
                                if (input[2] <= 0.09079494699835777) {
                                    if (input[4] <= -0.9722656011581421) {
                                        var99 = new double[2] {0.8865826538176427, 0.11341734618235731};
                                    } else {
                                        var99 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var99 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var99 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var99 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[4] <= 0.17774097248911858) {
                    if (input[1] <= 0.20702707767486572) {
                        if (input[2] <= -0.24650438129901886) {
                            if (input[1] <= -1.3510686755180359) {
                                var99 = new double[2] {1.0, 0.0};
                            } else {
                                var99 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[5] <= 0.216061282902956) {
                                var99 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            } else {
                                var99 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[1] <= 1.936118245124817) {
                            var99 = new double[2] {1.0, 0.0};
                        } else {
                            var99 = new double[2] {0.9462025316455697, 0.053797468354430396};
                        }
                    }
                } else {
                    var99 = new double[2] {0.0, 1.0};
                }
            }
            double[] var100;
            if (input[1] <= -1.4634194374084473) {
                var100 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 0.5765007138252258) {
                    if (input[3] <= -0.23209719359874725) {
                        if (input[3] <= -0.2570285350084305) {
                            if (input[2] <= -0.0919526033103466) {
                                var100 = new double[2] {0.0, 1.0};
                            } else {
                                var100 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            var100 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[2] <= -0.2602119594812393) {
                            var100 = new double[2] {0.0, 1.0};
                        } else {
                            var100 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[5] <= -0.0793280079960823) {
                        var100 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.2432844489812851) {
                            if (input[3] <= 1.1607165932655334) {
                                if (input[2] <= 0.09079494699835777) {
                                    if (input[2] <= -0.25497327744960785) {
                                        var100 = new double[2] {0.0, 1.0};
                                    } else {
                                        var100 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var100 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[5] <= 0.7991673946380615) {
                                    var100 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[5] <= 1.0573452711105347) {
                                        var100 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= 1.405538558959961) {
                                            var100 = new double[2] {1.0, 0.0};
                                        } else {
                                            var100 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= -0.1852235272526741) {
                                if (input[3] <= 0.6695434749126434) {
                                    var100 = new double[2] {0.0, 1.0};
                                } else {
                                    var100 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var100 = new double[2] {0.9462025316455697, 0.053797468354430396};
                            }
                        }
                    }
                }
            }
            double[] var101;
            if (input[2] <= 0.07809973135590553) {
                if (input[1] <= -1.4868773221969604) {
                    var101 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 0.24684371054172516) {
                        var101 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 0.271536186337471) {
                            var101 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var101 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[3] <= -0.2166757509112358) {
                    var101 = new double[2] {1.0, 0.0};
                } else {
                    var101 = new double[2] {1.0, 0.0};
                }
            }
            double[] var102;
            if (input[1] <= -1.4569376707077026) {
                var102 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.1746638417243958) {
                    if (input[5] <= 1.4877697229385376) {
                        if (input[4] <= -0.5223626494407654) {
                            if (input[5] <= 0.026935413479804993) {
                                var102 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= 0.03708900511264801) {
                                    if (input[1] <= -1.2461256384849548) {
                                        var102 = new double[2] {0.0, 1.0};
                                    } else {
                                        var102 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var102 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var102 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var102 = new double[2] {0.9591018444266239, 0.04089815557337611};
                    }
                } else {
                    if (input[1] <= 2.312678575515747) {
                        if (input[2] <= 0.07809973135590553) {
                            if (input[2] <= -0.2552834451198578) {
                                var102 = new double[2] {0.0, 1.0};
                            } else {
                                var102 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var102 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var102 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var103;
            if (input[4] <= 0.2422807663679123) {
                if (input[4] <= -0.5225958228111267) {
                    if (input[5] <= -1.5406737923622131) {
                        var103 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            if (input[1] <= -0.6124547272920609) {
                                if (input[2] <= 0.2690508933737874) {
                                    var103 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var103 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= 0.29342594742774963) {
                                    if (input[5] <= -0.8787972033023834) {
                                        var103 = new double[2] {0.0, 1.0};
                                    } else {
                                        var103 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var103 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= -0.26551033556461334) {
                                if (input[3] <= -0.8448427319526672) {
                                    if (input[3] <= -1.4280304908752441) {
                                        var103 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[5] <= -0.20157569646835327) {
                                            var103 = new double[2] {0.0, 1.0};
                                        } else {
                                            var103 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var103 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= 0.24132782220840454) {
                                    if (input[3] <= 0.4837150275707245) {
                                        var103 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[2] <= -0.12645314633846283) {
                                            if (input[1] <= -1.490889847278595) {
                                                var103 = new double[2] {1.0, 0.0};
                                            } else {
                                                var103 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var103 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var103 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[3] <= 0.7019285261631012) {
                        if (input[1] <= -1.498606264591217) {
                            var103 = new double[2] {1.0, 0.0};
                        } else {
                            var103 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= -0.24335746467113495) {
                            var103 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= 0.7622144669294357) {
                                var103 = new double[2] {1.0, 0.0};
                            } else {
                                var103 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            }
                        }
                    }
                }
            } else {
                if (input[5] <= -1.5962990522384644) {
                    if (input[2] <= -0.23357348889112473) {
                        var103 = new double[2] {0.8978978978978979, 0.10210210210210212};
                    } else {
                        var103 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[5] <= 1.7639778852462769) {
                        if (input[1] <= -1.4609501957893372) {
                            var103 = new double[2] {1.0, 0.0};
                        } else {
                            var103 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var103 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                }
            }
            double[] var104;
            if (input[1] <= -1.4634194374084473) {
                var104 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.342432677745819) {
                    if (input[5] <= 0.47513431310653687) {
                        if (input[4] <= -0.5225958228111267) {
                            if (input[4] <= -0.5999401807785034) {
                                if (input[4] <= -1.5106040835380554) {
                                    if (input[2] <= 0.12062934041023254) {
                                        var104 = new double[2] {0.0, 1.0};
                                    } else {
                                        var104 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[4] <= -0.778017669916153) {
                                        var104 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= 0.2747544050216675) {
                                            var104 = new double[2] {0.0, 1.0};
                                        } else {
                                            var104 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                        }
                                    }
                                }
                            } else {
                                var104 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var104 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[5] <= 0.5008370280265808) {
                            var104 = new double[2] {0.0, 1.0};
                        } else {
                            var104 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.09316971525549889) {
                        var104 = new double[2] {0.0, 1.0};
                    } else {
                        var104 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var105;
            if (input[1] <= -1.4594069123268127) {
                var105 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.07809973135590553) {
                    if (input[4] <= -2.2020294666290283) {
                        var105 = new double[2] {0.0, 1.0};
                    } else {
                        var105 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[0] <= -0.4615243822336197) {
                        var105 = new double[2] {1.0, 0.0};
                    } else {
                        var105 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var106;
            if (input[5] <= -0.6357084512710571) {
                if (input[2] <= -0.1652749553322792) {
                    if (input[0] <= 0.7622144669294357) {
                        if (input[1] <= -1.380699634552002) {
                            var106 = new double[2] {0.0, 1.0};
                        } else {
                            var106 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= 1.2713285088539124) {
                            var106 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= 1.4710814952850342) {
                                var106 = new double[2] {1.0, 0.0};
                            } else {
                                var106 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[0] <= -0.4615243822336197) {
                        var106 = new double[2] {0.9214175654853621, 0.07858243451463792};
                    } else {
                        var106 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[1] <= -1.458480954170227) {
                    var106 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= 0.07809973135590553) {
                        if (input[1] <= -1.401996910572052) {
                            var106 = new double[2] {0.0, 1.0};
                        } else {
                            var106 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= 0.1470777951180935) {
                            var106 = new double[2] {1.0, 0.0};
                        } else {
                            var106 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var107;
            if (input[5] <= -0.260909304022789) {
                if (input[5] <= -1.482235312461853) {
                    if (input[2] <= -0.24629145115613937) {
                        var107 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= -0.23357348889112473) {
                            var107 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -0.4991779401898384) {
                                var107 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var107 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= -0.5406519770622253) {
                        if (input[0] <= 0.7622144669294357) {
                            if (input[2] <= 0.13217681646347046) {
                                var107 = new double[2] {0.0, 1.0};
                            } else {
                                var107 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var107 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var107 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[2] <= 0.07809973135590553) {
                    if (input[3] <= 1.2663534879684448) {
                        if (input[1] <= -1.458480954170227) {
                            var107 = new double[2] {1.0, 0.0};
                        } else {
                            var107 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= 0.6639285758137703) {
                            var107 = new double[2] {0.9361302442078898, 0.06386975579211022};
                        } else {
                            var107 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[5] <= -0.09518440067768097) {
                        var107 = new double[2] {1.0, 0.0};
                    } else {
                        var107 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var108;
            if (input[2] <= 0.09079494699835777) {
                if (input[1] <= -1.4594069123268127) {
                    var108 = new double[2] {1.0, 0.0};
                } else {
                    var108 = new double[2] {0.0, 1.0};
                }
            } else {
                if (input[4] <= -1.997237741947174) {
                    var108 = new double[2] {1.0, 0.0};
                } else {
                    var108 = new double[2] {1.0, 0.0};
                }
            }
            double[] var109;
            if (input[5] <= 1.522679328918457) {
                if (input[2] <= 0.04717960301786661) {
                    if (input[2] <= -0.23650696128606796) {
                        if (input[5] <= 0.6232125759124756) {
                            if (input[0] <= -0.4615243822336197) {
                                if (input[1] <= -1.4387269616127014) {
                                    var109 = new double[2] {1.0, 0.0};
                                } else {
                                    var109 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[3] <= -0.258056640625) {
                                    if (input[5] <= 0.06107780896127224) {
                                        var109 = new double[2] {0.0, 1.0};
                                    } else {
                                        var109 = new double[2] {0.53971119133574, 0.46028880866426};
                                    }
                                } else {
                                    if (input[4] <= 1.5897389650344849) {
                                        if (input[5] <= 0.37539248168468475) {
                                            if (input[1] <= -1.4029229283332825) {
                                                var109 = new double[2] {1.0, 0.0};
                                            } else {
                                                if (input[5] <= -1.6763482689857483) {
                                                    var109 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var109 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        } else {
                                            var109 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                        }
                                    } else {
                                        var109 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= 1.1405913829803467) {
                                if (input[1] <= -1.1862463355064392) {
                                    var109 = new double[2] {0.0, 1.0};
                                } else {
                                    var109 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= 1.1703860759735107) {
                                    var109 = new double[2] {1.0, 0.0};
                                } else {
                                    var109 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.4486039280891418) {
                            var109 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var109 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[4] <= -1.109840989112854) {
                        var109 = new double[2] {1.0, 0.0};
                    } else {
                        var109 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= -0.07692409679293633) {
                    var109 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= 0.4135179668664932) {
                        var109 = new double[2] {1.0, 0.0};
                    } else {
                        var109 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var110;
            if (input[4] <= -0.44507914781570435) {
                if (input[2] <= 0.12062934041023254) {
                    if (input[2] <= -0.2607206106185913) {
                        var110 = new double[2] {0.5944333996023857, 0.4055666003976144};
                    } else {
                        if (input[3] <= 1.0607341825962067) {
                            if (input[2] <= -0.16799893975257874) {
                                var110 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[0] <= -0.4615243822336197) {
                                    var110 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                } else {
                                    var110 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var110 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    }
                } else {
                    if (input[3] <= -0.24237816035747528) {
                        var110 = new double[2] {1.0, 0.0};
                    } else {
                        var110 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[3] <= 1.3005377054214478) {
                    if (input[2] <= -0.23449213802814484) {
                        if (input[3] <= 0.3821904808282852) {
                            if (input[1] <= -1.4714444875717163) {
                                var110 = new double[2] {1.0, 0.0};
                            } else {
                                var110 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var110 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= 1.1944178342819214) {
                            if (input[3] <= -1.46452796459198) {
                                var110 = new double[2] {0.0, 1.0};
                            } else {
                                var110 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= -0.018777696415781975) {
                                var110 = new double[2] {0.0, 1.0};
                            } else {
                                var110 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            }
                        }
                    }
                } else {
                    if (input[5] <= 0.14547475054860115) {
                        var110 = new double[2] {0.0, 1.0};
                    } else {
                        var110 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var111;
            if (input[2] <= 0.07809973135590553) {
                if (input[1] <= -1.4634194374084473) {
                    var111 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= -1.5444624423980713) {
                        var111 = new double[2] {0.0, 1.0};
                    } else {
                        var111 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[1] <= -0.8470333218574524) {
                    var111 = new double[2] {1.0, 0.0};
                } else {
                    var111 = new double[2] {1.0, 0.0};
                }
            }
            double[] var112;
            if (input[2] <= 0.09079494699835777) {
                if (input[1] <= -1.4708271622657776) {
                    var112 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.636468231678009) {
                        if (input[2] <= -0.27012933790683746) {
                            var112 = new double[2] {0.0, 1.0};
                        } else {
                            var112 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var112 = new double[2] {0.661504424778761, 0.33849557522123896};
                    }
                }
            } else {
                if (input[5] <= -0.25183023512363434) {
                    var112 = new double[2] {1.0, 0.0};
                } else {
                    var112 = new double[2] {1.0, 0.0};
                }
            }
            double[] var113;
            if (input[1] <= -1.4594069123268127) {
                var113 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08378744497895241) {
                    if (input[4] <= -2.1989879608154297) {
                        var113 = new double[2] {0.0, 1.0};
                    } else {
                        var113 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[5] <= -0.597985565662384) {
                        var113 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        if (input[5] <= 1.8756120204925537) {
                            if (input[1] <= 1.5922754406929016) {
                                if (input[5] <= 0.14278939366340637) {
                                    var113 = new double[2] {1.0, 0.0};
                                } else {
                                    var113 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= 4.4276745319366455) {
                                    var113 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var113 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var113 = new double[2] {0.9591018444266239, 0.04089815557337611};
                        }
                    }
                }
            }
            double[] var114;
            if (input[1] <= -1.4634194374084473) {
                var114 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.9230501651763916) {
                    if (input[2] <= 0.07809973135590553) {
                        var114 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.24237816035747528) {
                            var114 = new double[2] {1.0, 0.0};
                        } else {
                            var114 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var114 = new double[2] {1.0, 0.0};
                }
            }
            double[] var115;
            if (input[1] <= -1.4594069123268127) {
                var115 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.2432844489812851) {
                    if (input[3] <= 0.5765007138252258) {
                        if (input[2] <= 0.07701399642974138) {
                            var115 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= -0.08173807710409164) {
                                var115 = new double[2] {1.0, 0.0};
                            } else {
                                var115 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.1130671314895153) {
                            if (input[4] <= -1.3237570524215698) {
                                var115 = new double[2] {0.0, 1.0};
                            } else {
                                var115 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= 0.09079494699835777) {
                                var115 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var115 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[1] <= 1.370968997478485) {
                        var115 = new double[2] {0.0, 1.0};
                    } else {
                        var115 = new double[2] {0.53971119133574, 0.46028880866426};
                    }
                }
            }
            double[] var116;
            if (input[5] <= -0.18137158453464508) {
                if (input[2] <= 0.19771247822791338) {
                    if (input[5] <= -1.5950202941894531) {
                        if (input[4] <= 0.49107222259044647) {
                            var116 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= -0.4615243822336197) {
                                var116 = new double[2] {1.0, 0.0};
                            } else {
                                var116 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            }
                        }
                    } else {
                        if (input[3] <= -0.10307108238339424) {
                            if (input[1] <= -1.3103260397911072) {
                                var116 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var116 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[4] <= -1.3950285911560059) {
                                var116 = new double[2] {0.0, 1.0};
                            } else {
                                var116 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var116 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -1.474839687347412) {
                    var116 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= 0.05875357799232006) {
                        if (input[3] <= 1.5220925211906433) {
                            var116 = new double[2] {0.0, 1.0};
                        } else {
                            var116 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[1] <= -0.729744017124176) {
                            var116 = new double[2] {1.0, 0.0};
                        } else {
                            var116 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var117;
            if (input[1] <= -1.4594069123268127) {
                var117 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.09171809628605843) {
                    if (input[4] <= -2.213181495666504) {
                        var117 = new double[2] {0.0, 1.0};
                    } else {
                        var117 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= 1.5922754406929016) {
                        if (input[4] <= -1.0964889824390411) {
                            var117 = new double[2] {1.0, 0.0};
                        } else {
                            var117 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= 2.234341949224472) {
                            var117 = new double[2] {0.0, 1.0};
                        } else {
                            var117 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var118;
            if (input[1] <= -1.4569376707077026) {
                var118 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.2344825267791748) {
                    if (input[5] <= 1.7639778852462769) {
                        if (input[5] <= -0.5390355587005615) {
                            var118 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= 1.481159269809723) {
                                if (input[5] <= 0.47513431310653687) {
                                    if (input[3] <= -0.011827513575553894) {
                                        if (input[0] <= -0.4615243822336197) {
                                            var118 = new double[2] {0.0, 1.0};
                                        } else {
                                            var118 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[2] <= 0.0015150383114814758) {
                                            var118 = new double[2] {0.0, 1.0};
                                        } else {
                                            var118 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var118 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[3] <= 0.3464641273021698) {
                                    if (input[2] <= 0.37005921453237534) {
                                        var118 = new double[2] {0.0, 1.0};
                                    } else {
                                        var118 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var118 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var118 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                } else {
                    if (input[1] <= -0.9399388134479523) {
                        var118 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 1.717430830001831) {
                            var118 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= -0.45661642402410507) {
                                var118 = new double[2] {1.0, 0.0};
                            } else {
                                var118 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            }
            double[] var119;
            if (input[1] <= -1.4569376707077026) {
                var119 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.1591744422912598) {
                    if (input[1] <= 1.209233283996582) {
                        if (input[4] <= -0.5225958228111267) {
                            if (input[0] <= -0.4615243822336197) {
                                var119 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= 0.03339828550815582) {
                                    var119 = new double[2] {0.0, 1.0};
                                } else {
                                    var119 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var119 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= 0.8486060202121735) {
                            if (input[2] <= 0.028922077268362045) {
                                if (input[5] <= -1.0296887159347534) {
                                    var119 = new double[2] {0.0, 1.0};
                                } else {
                                    var119 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var119 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= -0.24762027710676193) {
                                var119 = new double[2] {0.0, 1.0};
                            } else {
                                var119 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.5147246494889259) {
                        if (input[3] <= 1.3624805808067322) {
                            if (input[3] <= 1.2686667442321777) {
                                var119 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            } else {
                                var119 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[0] <= -0.4615243822336197) {
                                var119 = new double[2] {1.0, 0.0};
                            } else {
                                var119 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            }
                        }
                    } else {
                        var119 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var120;
            if (input[1] <= -1.4433568120002747) {
                var120 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= -0.44507914781570435) {
                    if (input[4] <= -1.5075626373291016) {
                        if (input[4] <= -1.9495881795883179) {
                            var120 = new double[2] {1.0, 0.0};
                        } else {
                            var120 = new double[2] {0.8242591316333563, 0.17574086836664374};
                        }
                    } else {
                        if (input[4] <= -1.0834106802940369) {
                            var120 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 1.390239179134369) {
                                if (input[2] <= 0.19215016812086105) {
                                    if (input[3] <= -1.4316288232803345) {
                                        var120 = new double[2] {0.0, 1.0};
                                    } else {
                                        var120 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var120 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= -0.7177967727184296) {
                                    var120 = new double[2] {1.0, 0.0};
                                } else {
                                    var120 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.08378744497895241) {
                        var120 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 0.0714487936347723) {
                            var120 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        } else {
                            var120 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var121;
            if (input[3] <= 1.2324263453483582) {
                if (input[1] <= -1.4594069123268127) {
                    var121 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= -0.2827158421278) {
                        if (input[5] <= -0.37970438599586487) {
                            var121 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= -0.8972756564617157) {
                                var121 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 0.5398386418819427) {
                                    if (input[2] <= -0.016296766698360443) {
                                        var121 = new double[2] {0.0, 1.0};
                                    } else {
                                        var121 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[2] <= -0.11376384645700455) {
                                        var121 = new double[2] {0.0, 1.0};
                                    } else {
                                        var121 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[3] <= -1.3804810643196106) {
                            var121 = new double[2] {0.0, 1.0};
                        } else {
                            var121 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[5] <= 0.315035879611969) {
                    var121 = new double[2] {0.661504424778761, 0.33849557522123896};
                } else {
                    if (input[4] <= -1.2737250328063965) {
                        var121 = new double[2] {0.8978978978978979, 0.10210210210210212};
                    } else {
                        if (input[3] <= 1.717430830001831) {
                            var121 = new double[2] {1.0, 0.0};
                        } else {
                            var121 = new double[2] {0.9462025316455697, 0.05379746835443039};
                        }
                    }
                }
            }
            double[] var122;
            if (input[2] <= -0.08070212975144386) {
                if (input[5] <= -1.482235312461853) {
                    if (input[0] <= -0.4615243822336197) {
                        if (input[4] <= -1.0370994210243225) {
                            var122 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -0.3460845649242401) {
                                var122 = new double[2] {1.0, 0.0};
                            } else {
                                var122 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -0.14082828164100647) {
                            var122 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        } else {
                            var122 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.145552158355713) {
                        if (input[1] <= -1.4683579206466675) {
                            var122 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.26915326714515686) {
                                var122 = new double[2] {0.0, 1.0};
                            } else {
                                var122 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -1.4060094356536865) {
                            var122 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[0] <= -0.4615243822336197) {
                                var122 = new double[2] {0.0, 1.0};
                            } else {
                                var122 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            } else {
                if (input[2] <= 0.07809973135590553) {
                    var122 = new double[2] {0.8799293702177752, 0.12007062978222487};
                } else {
                    var122 = new double[2] {1.0, 0.0};
                }
            }
            double[] var123;
            if (input[4] <= -0.45210491120815277) {
                if (input[4] <= -1.0834106802940369) {
                    if (input[3] <= 0.5780428647994995) {
                        var123 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.3781067952513695) {
                            var123 = new double[2] {0.0, 1.0};
                        } else {
                            var123 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.19215016812086105) {
                        if (input[5] <= -0.06129775382578373) {
                            var123 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.5806131064891815) {
                                if (input[5] <= 0.16900359466671944) {
                                    var123 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var123 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[1] <= -1.531632423400879) {
                                    var123 = new double[2] {1.0, 0.0};
                                } else {
                                    var123 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 0.7953255027532578) {
                            var123 = new double[2] {1.0, 0.0};
                        } else {
                            var123 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[2] <= 0.014321696013212204) {
                    if (input[3] <= -0.5870475471019745) {
                        if (input[1] <= -1.469283938407898) {
                            var123 = new double[2] {1.0, 0.0};
                        } else {
                            var123 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= -1.4433568120002747) {
                            var123 = new double[2] {1.0, 0.0};
                        } else {
                            var123 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var123 = new double[2] {1.0, 0.0};
                }
            }
            double[] var124;
            if (input[2] <= 0.09079494699835777) {
                if (input[2] <= -0.238062784075737) {
                    if (input[3] <= 1.145552158355713) {
                        if (input[1] <= -1.4387269616127014) {
                            var124 = new double[2] {1.0, 0.0};
                        } else {
                            var124 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[5] <= 0.8274275958538055) {
                            var124 = new double[2] {1.0, 0.0};
                        } else {
                            var124 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    }
                } else {
                    if (input[1] <= -1.5482998490333557) {
                        var124 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= -1.4421221613883972) {
                            var124 = new double[2] {0.0, 1.0};
                        } else {
                            var124 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.7914591431617737) {
                    var124 = new double[2] {1.0, 0.0};
                } else {
                    var124 = new double[2] {1.0, 0.0};
                }
            }
            double[] var125;
            if (input[4] <= 1.3873196840286255) {
                if (input[3] <= 1.1591744422912598) {
                    if (input[1] <= -1.4594069123268127) {
                        var125 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 1.7639778852462769) {
                            if (input[3] <= 0.5765007138252258) {
                                if (input[2] <= 0.2690508933737874) {
                                    var125 = new double[2] {0.0, 1.0};
                                } else {
                                    var125 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= 0.09079494699835777) {
                                    var125 = new double[2] {0.0, 1.0};
                                } else {
                                    var125 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var125 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    }
                } else {
                    if (input[2] <= -0.09316971525549889) {
                        if (input[2] <= -0.24269021302461624) {
                            if (input[1] <= -1.3550812005996704) {
                                var125 = new double[2] {1.0, 0.0};
                            } else {
                                var125 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var125 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var125 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var125 = new double[2] {0.0, 1.0};
            }
            double[] var126;
            if (input[1] <= -1.4763829708099365) {
                var126 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.07809973135590553) {
                    if (input[5] <= 1.6161553263664246) {
                        var126 = new double[2] {0.0, 1.0};
                    } else {
                        var126 = new double[2] {0.661504424778761, 0.33849557522123896};
                    }
                } else {
                    if (input[4] <= -1.8299574255943298) {
                        var126 = new double[2] {1.0, 0.0};
                    } else {
                        var126 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var127;
            if (input[2] <= 0.05875357799232006) {
                if (input[4] <= -1.053077220916748) {
                    var127 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= -0.9722656011581421) {
                        if (input[1] <= -0.7399296760559082) {
                            var127 = new double[2] {1.0, 0.0};
                        } else {
                            var127 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            if (input[4] <= 0.5479475259780884) {
                                if (input[4] <= 0.1698230430483818) {
                                    if (input[2] <= -0.2567361295223236) {
                                        var127 = new double[2] {0.0, 1.0};
                                    } else {
                                        var127 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[5] <= 0.5962311327457428) {
                                        if (input[1] <= -1.1402565836906433) {
                                            var127 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                        } else {
                                            var127 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var127 = new double[2] {0.661504424778761, 0.33849557522123896};
                                    }
                                }
                            } else {
                                var127 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= -1.4655800461769104) {
                                var127 = new double[2] {1.0, 0.0};
                            } else {
                                var127 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            } else {
                if (input[2] <= 0.1470777951180935) {
                    var127 = new double[2] {1.0, 0.0};
                } else {
                    var127 = new double[2] {1.0, 0.0};
                }
            }
            double[] var128;
            if (input[4] <= -0.44507914781570435) {
                if (input[2] <= 0.12062934041023254) {
                    if (input[3] <= 1.1064844727516174) {
                        if (input[4] <= -1.0039677917957306) {
                            var128 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.2523817718029022) {
                                if (input[4] <= -0.7581975162029266) {
                                    var128 = new double[2] {1.0, 0.0};
                                } else {
                                    var128 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[1] <= -1.4461346864700317) {
                                    var128 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var128 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 1.2946261763572693) {
                            var128 = new double[2] {0.9723577235772358, 0.027642276422764234};
                        } else {
                            var128 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[5] <= -0.7914591431617737) {
                        var128 = new double[2] {1.0, 0.0};
                    } else {
                        var128 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    if (input[2] <= -0.08836329728364944) {
                        if (input[1] <= -1.4387269616127014) {
                            var128 = new double[2] {1.0, 0.0};
                        } else {
                            var128 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var128 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= -1.488111972808838) {
                        var128 = new double[2] {1.0, 0.0};
                    } else {
                        var128 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var129;
            if (input[1] <= -1.4470607042312622) {
                var129 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08070212975144386) {
                    var129 = new double[2] {0.0, 1.0};
                } else {
                    if (input[3] <= 0.5227826833724976) {
                        var129 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        var129 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var130;
            if (input[2] <= 0.05875357799232006) {
                if (input[4] <= 0.8976546227931976) {
                    if (input[2] <= -0.2364140972495079) {
                        if (input[1] <= -1.418355643749237) {
                            var130 = new double[2] {1.0, 0.0};
                        } else {
                            var130 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= -0.1447928249835968) {
                            if (input[2] <= -0.23578337579965591) {
                                var130 = new double[2] {0.0, 1.0};
                            } else {
                                var130 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= 0.7666985988616943) {
                                var130 = new double[2] {0.0, 1.0};
                            } else {
                                var130 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var130 = new double[2] {0.0, 1.0};
                }
            } else {
                if (input[2] <= 0.4896475672721863) {
                    var130 = new double[2] {1.0, 0.0};
                } else {
                    var130 = new double[2] {1.0, 0.0};
                }
            }
            double[] var131;
            if (input[1] <= -1.474839687347412) {
                var131 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.1746638417243958) {
                    if (input[3] <= 1.610765814781189) {
                        if (input[1] <= 0.2925248146057129) {
                            if (input[5] <= 1.4933961629867554) {
                                if (input[4] <= -0.4584919810295105) {
                                    if (input[4] <= -0.5474749803543091) {
                                        if (input[2] <= -0.13935693353414536) {
                                            var131 = new double[2] {0.0, 1.0};
                                        } else {
                                            var131 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                        }
                                    } else {
                                        var131 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                    }
                                } else {
                                    var131 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var131 = new double[2] {0.796271637816245, 0.20372836218375504};
                            }
                        } else {
                            if (input[3] <= -1.3306183815002441) {
                                var131 = new double[2] {0.0, 1.0};
                            } else {
                                var131 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.11619627848267555) {
                            var131 = new double[2] {0.0, 1.0};
                        } else {
                            var131 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[0] <= -0.4615243822336197) {
                        if (input[1] <= 1.4607879519462585) {
                            var131 = new double[2] {0.0, 1.0};
                        } else {
                            var131 = new double[2] {0.661504424778761, 0.33849557522123896};
                        }
                    } else {
                        if (input[2] <= 0.22198166884481907) {
                            if (input[4] <= -1.0344128012657166) {
                                var131 = new double[2] {0.0, 1.0};
                            } else {
                                var131 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var131 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var132;
            if (input[2] <= 0.07809973135590553) {
                if (input[3] <= 1.2591568231582642) {
                    if (input[2] <= -0.23449213802814484) {
                        if (input[4] <= -0.048989757895469666) {
                            if (input[1] <= -1.3760697841644287) {
                                var132 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var132 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[5] <= 0.6311407685279846) {
                                if (input[1] <= -1.4387269616127014) {
                                    var132 = new double[2] {1.0, 0.0};
                                } else {
                                    var132 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var132 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[5] <= -1.6659904718399048) {
                            var132 = new double[2] {0.0, 1.0};
                        } else {
                            var132 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.340574324131012) {
                        var132 = new double[2] {1.0, 0.0};
                    } else {
                        var132 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[4] <= -1.997237741947174) {
                    var132 = new double[2] {1.0, 0.0};
                } else {
                    var132 = new double[2] {1.0, 0.0};
                }
            }
            double[] var133;
            if (input[3] <= 1.2535023093223572) {
                if (input[2] <= 0.07809973135590553) {
                    if (input[2] <= -0.2589235454797745) {
                        if (input[1] <= -1.4387269616127014) {
                            var133 = new double[2] {1.0, 0.0};
                        } else {
                            var133 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= -1.4634194374084473) {
                            var133 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= -1.6826141476631165) {
                                var133 = new double[2] {0.0, 1.0};
                            } else {
                                var133 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[5] <= -0.4493957906961441) {
                        var133 = new double[2] {1.0, 0.0};
                    } else {
                        var133 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[5] <= -0.15848210826516151) {
                    var133 = new double[2] {0.7456359102244389, 0.25436408977556113};
                } else {
                    if (input[5] <= 0.7810092866420746) {
                        var133 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 0.17262118682265282) {
                            var133 = new double[2] {1.0, 0.0};
                        } else {
                            var133 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    }
                }
            }
            double[] var134;
            if (input[2] <= -0.08034390211105347) {
                if (input[2] <= -0.23650696128606796) {
                    if (input[3] <= -1.2555673122406006) {
                        var134 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -1.4433568120002747) {
                            var134 = new double[2] {1.0, 0.0};
                        } else {
                            var134 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[5] <= -1.525968313217163) {
                        var134 = new double[2] {0.661504424778761, 0.33849557522123896};
                    } else {
                        if (input[1] <= -1.4486039280891418) {
                            var134 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        } else {
                            var134 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var134 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 1.5922754406929016) {
                        var134 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= 2.234341949224472) {
                            var134 = new double[2] {0.0, 1.0};
                        } else {
                            var134 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var135;
            if (input[1] <= -1.4634194374084473) {
                var135 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.2535023093223572) {
                    if (input[2] <= 0.019977381452918053) {
                        var135 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= 1.5573862493038177) {
                            var135 = new double[2] {1.0, 0.0};
                        } else {
                            var135 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.09316971525549889) {
                        var135 = new double[2] {0.0, 1.0};
                    } else {
                        var135 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var136;
            if (input[2] <= 0.09079494699835777) {
                if (input[1] <= -1.4763829708099365) {
                    var136 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 0.25949861109256744) {
                        if (input[0] <= -0.4615243822336197) {
                            var136 = new double[2] {0.0, 1.0};
                        } else {
                            var136 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[5] <= 1.6161553263664246) {
                            var136 = new double[2] {0.0, 1.0};
                        } else {
                            var136 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    }
                }
            } else {
                if (input[2] <= 0.4896475672721863) {
                    var136 = new double[2] {1.0, 0.0};
                } else {
                    var136 = new double[2] {1.0, 0.0};
                }
            }
            double[] var137;
            if (input[4] <= -0.7107101678848267) {
                if (input[0] <= 0.7622144669294357) {
                    if (input[4] <= -1.0834106802940369) {
                        if (input[5] <= 1.2849613428115845) {
                            if (input[5] <= 0.1750136762857437) {
                                if (input[5] <= -0.5839194059371948) {
                                    var137 = new double[2] {0.0, 1.0};
                                } else {
                                    var137 = new double[2] {0.661504424778761, 0.33849557522123896};
                                }
                            } else {
                                if (input[2] <= -0.25409069657325745) {
                                    var137 = new double[2] {0.0, 1.0};
                                } else {
                                    var137 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var137 = new double[2] {0.7962716378162449, 0.20372836218375498};
                        }
                    } else {
                        if (input[5] <= -1.0799432396888733) {
                            var137 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -0.13162853196263313) {
                                if (input[3] <= 0.5587660670280457) {
                                    if (input[3] <= 0.024669911712408066) {
                                        var137 = new double[2] {0.9462025316455697, 0.053797468354430396};
                                    } else {
                                        var137 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var137 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= 0.010311771184206009) {
                                    var137 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[2] <= 0.2752317041158676) {
                                        if (input[4] <= -0.88934525847435) {
                                            if (input[3] <= 0.10049203038215637) {
                                                var137 = new double[2] {0.0, 1.0};
                                            } else {
                                                var137 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                            }
                                        } else {
                                            var137 = new double[2] {0.8978978978978979, 0.10210210210210212};
                                        }
                                    } else {
                                        var137 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[5] <= -1.401163101196289) {
                        var137 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.008486196398735046) {
                            var137 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.6546360552310944) {
                                var137 = new double[2] {0.9462025316455697, 0.053797468354430396};
                            } else {
                                var137 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= -1.4634194374084473) {
                    var137 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 1.522679328918457) {
                        if (input[4] <= -0.45210491120815277) {
                            if (input[2] <= 0.12363101541996002) {
                                var137 = new double[2] {0.0, 1.0};
                            } else {
                                var137 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 1.610765814781189) {
                                if (input[2] <= -0.10024148225784302) {
                                    var137 = new double[2] {0.0, 1.0};
                                } else {
                                    var137 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                }
                            } else {
                                var137 = new double[2] {0.5944333996023857, 0.4055666003976144};
                            }
                        }
                    } else {
                        if (input[2] <= -0.15893995389342308) {
                            var137 = new double[2] {0.0, 1.0};
                        } else {
                            var137 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var138;
            if (input[1] <= -1.4683579206466675) {
                var138 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.09079494699835777) {
                    if (input[0] <= -0.4615243822336197) {
                        var138 = new double[2] {0.0, 1.0};
                    } else {
                        var138 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[0] <= -0.4615243822336197) {
                        var138 = new double[2] {1.0, 0.0};
                    } else {
                        var138 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var139;
            if (input[2] <= 0.38323079980909824) {
                if (input[4] <= -0.8343860805034637) {
                    if (input[4] <= -1.082701027393341) {
                        var139 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= -0.25857962667942047) {
                            var139 = new double[2] {0.8865826538176427, 0.11341734618235731};
                        } else {
                            if (input[5] <= 1.0694933533668518) {
                                if (input[1] <= -1.3896506428718567) {
                                    var139 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[4] <= -0.9874019622802734) {
                                        var139 = new double[2] {0.0, 1.0};
                                    } else {
                                        var139 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var139 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[1] <= -1.485642671585083) {
                        var139 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= -1.4997402429580688) {
                            var139 = new double[2] {0.0, 1.0};
                        } else {
                            var139 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.25183023512363434) {
                    var139 = new double[2] {1.0, 0.0};
                } else {
                    var139 = new double[2] {1.0, 0.0};
                }
            }
            double[] var140;
            if (input[3] <= 0.7376548647880554) {
                if (input[1] <= -1.4791609048843384) {
                    var140 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 0.4806329011917114) {
                        if (input[4] <= -0.5225958228111267) {
                            if (input[4] <= -0.9580721259117126) {
                                var140 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -1.3620336055755615) {
                                    var140 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[2] <= 0.19215016812086105) {
                                        if (input[0] <= 0.7622144669294357) {
                                            var140 = new double[2] {0.0, 1.0};
                                        } else {
                                            var140 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var140 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            var140 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= -0.2635444402694702) {
                            var140 = new double[2] {0.0, 1.0};
                        } else {
                            var140 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[2] <= -0.15033183246850967) {
                    if (input[1] <= -1.4763829708099365) {
                        var140 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -1.6685479879379272) {
                            var140 = new double[2] {0.0, 1.0};
                        } else {
                            var140 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var140 = new double[2] {1.0, 0.0};
                }
            }
            double[] var141;
            if (input[2] <= 0.05875357799232006) {
                if (input[3] <= 1.225486695766449) {
                    if (input[5] <= 0.8272997140884399) {
                        if (input[5] <= -1.6798008680343628) {
                            var141 = new double[2] {0.8978978978978979, 0.10210210210210212};
                        } else {
                            if (input[5] <= -0.638010174036026) {
                                if (input[0] <= -0.4615243822336197) {
                                    if (input[4] <= 0.26828524796292186) {
                                        if (input[5] <= -1.6088306903839111) {
                                            var141 = new double[2] {0.0, 1.0};
                                        } else {
                                            var141 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.6797238886356354) {
                                            var141 = new double[2] {0.9591018444266239, 0.04089815557337611};
                                        } else {
                                            if (input[2] <= -0.2521226331591606) {
                                                var141 = new double[2] {0.0, 1.0};
                                            } else {
                                                var141 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    }
                                } else {
                                    var141 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= -0.23642007261514664) {
                                    if (input[1] <= -1.443048119544983) {
                                        var141 = new double[2] {1.0, 0.0};
                                    } else {
                                        var141 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[1] <= -1.2893374562263489) {
                                        var141 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                    } else {
                                        if (input[2] <= -0.23581592738628387) {
                                            var141 = new double[2] {0.0, 1.0};
                                        } else {
                                            var141 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var141 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= -0.9825333207845688) {
                        var141 = new double[2] {1.0, 0.0};
                    } else {
                        var141 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var141 = new double[2] {1.0, 0.0};
                } else {
                    var141 = new double[2] {1.0, 0.0};
                }
            }
            double[] var142;
            if (input[3] <= 0.4834579974412918) {
                if (input[2] <= 0.10128318704664707) {
                    if (input[1] <= -1.4594069123268127) {
                        var142 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= -0.2696029394865036) {
                            var142 = new double[2] {0.0, 1.0};
                        } else {
                            var142 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var142 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.8545774221420288) {
                    if (input[2] <= -0.09114718064665794) {
                        if (input[3] <= 0.487827405333519) {
                            var142 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.23767469823360443) {
                                if (input[1] <= -1.4109479784965515) {
                                    var142 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[5] <= -1.2355660796165466) {
                                        var142 = new double[2] {0.0, 1.0};
                                    } else {
                                        var142 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[2] <= -0.15033183246850967) {
                                    var142 = new double[2] {0.0, 1.0};
                                } else {
                                    var142 = new double[2] {0.5944333996023857, 0.4055666003976144};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -0.060577720403671265) {
                            var142 = new double[2] {1.0, 0.0};
                        } else {
                            var142 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var142 = new double[2] {0.0, 1.0};
                }
            }
            double[] var143;
            if (input[5] <= -0.260909304022789) {
                if (input[3] <= -1.0877305269241333) {
                    var143 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -1.4594069123268127) {
                        var143 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= -0.5406519770622253) {
                            if (input[3] <= -0.1716965287923813) {
                                if (input[3] <= -0.26808057725429535) {
                                    var143 = new double[2] {0.0, 1.0};
                                } else {
                                    var143 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 0.908293604850769) {
                                    var143 = new double[2] {0.0, 1.0};
                                } else {
                                    var143 = new double[2] {0.661504424778761, 0.33849557522123896};
                                }
                            }
                        } else {
                            var143 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[2] <= -0.08034390211105347) {
                    if (input[5] <= 0.11913267150521278) {
                        if (input[2] <= -0.23816919326782227) {
                            if (input[2] <= -0.2554410845041275) {
                                var143 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.2350139617919922) {
                                    var143 = new double[2] {1.0, 0.0};
                                } else {
                                    var143 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[1] <= 0.41506125405430794) {
                                var143 = new double[2] {0.0, 1.0};
                            } else {
                                var143 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.24178706109523773) {
                            if (input[4] <= 0.6485083699226379) {
                                if (input[1] <= -1.4177383184432983) {
                                    var143 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[2] <= -0.2620016634464264) {
                                        var143 = new double[2] {0.0, 1.0};
                                    } else {
                                        var143 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var143 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var143 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[4] <= 0.5369577258825302) {
                        if (input[0] <= -0.4615243822336197) {
                            var143 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= 1.38040491938591) {
                                var143 = new double[2] {0.0, 1.0};
                            } else {
                                var143 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var143 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                }
            }
            double[] var144;
            if (input[1] <= -1.4763829708099365) {
                var144 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 0.5765007138252258) {
                    if (input[1] <= -1.30754816532135) {
                        if (input[2] <= -0.2445518523454666) {
                            var144 = new double[2] {0.0, 1.0};
                        } else {
                            var144 = new double[2] {0.5944333996023857, 0.4055666003976144};
                        }
                    } else {
                        if (input[3] <= -1.4619576930999756) {
                            var144 = new double[2] {0.0, 1.0};
                        } else {
                            var144 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.1591744422912598) {
                        if (input[2] <= -0.006347440183162689) {
                            if (input[1] <= -1.165257751941681) {
                                var144 = new double[2] {0.0, 1.0};
                            } else {
                                var144 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var144 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= 0.28257541358470917) {
                            var144 = new double[2] {0.0, 1.0};
                        } else {
                            var144 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var145;
            if (input[2] <= 0.0714487936347723) {
                if (input[5] <= -1.773149013519287) {
                    var145 = new double[2] {0.9535307517084283, 0.046469248291571764};
                } else {
                    if (input[3] <= -1.1039230227470398) {
                        var145 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -0.2015392780303955) {
                            if (input[2] <= -0.25273318588733673) {
                                if (input[3] <= 0.4837150275707245) {
                                    if (input[5] <= -0.8438875675201416) {
                                        var145 = new double[2] {0.0, 1.0};
                                    } else {
                                        var145 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[5] <= 0.08895437605679035) {
                                        var145 = new double[2] {1.0, 0.0};
                                    } else {
                                        var145 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.8846726715564728) {
                                    var145 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[2] <= -0.1820293515920639) {
                                        var145 = new double[2] {0.0, 1.0};
                                    } else {
                                        var145 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                    }
                                }
                            }
                        } else {
                            if (input[0] <= -0.4615243822336197) {
                                if (input[1] <= -1.456320345401764) {
                                    var145 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[2] <= -0.2586345970630646) {
                                        var145 = new double[2] {0.0, 1.0};
                                    } else {
                                        var145 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[3] <= -1.0453215539455414) {
                                    var145 = new double[2] {0.9462025316455697, 0.053797468354430396};
                                } else {
                                    if (input[4] <= -0.024333651876077056) {
                                        var145 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    } else {
                                        if (input[5] <= 0.1853714883327484) {
                                            if (input[1] <= -1.0899456143379211) {
                                                var145 = new double[2] {1.0, 0.0};
                                            } else {
                                                if (input[5] <= -1.3919561505317688) {
                                                    var145 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var145 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        } else {
                                            var145 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var145 = new double[2] {1.0, 0.0};
                } else {
                    var145 = new double[2] {1.0, 0.0};
                }
            }
            double[] var146;
            if (input[2] <= 0.07809973135590553) {
                if (input[3] <= -1.100581705570221) {
                    var146 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -1.4791609048843384) {
                        var146 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 1.6161553263664246) {
                            if (input[0] <= -0.4615243822336197) {
                                var146 = new double[2] {0.0, 1.0};
                            } else {
                                var146 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var146 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    }
                }
            } else {
                if (input[5] <= -0.7914591431617737) {
                    var146 = new double[2] {1.0, 0.0};
                } else {
                    var146 = new double[2] {1.0, 0.0};
                }
            }
            double[] var147;
            if (input[2] <= 0.07809973135590553) {
                if (input[3] <= 1.2324263453483582) {
                    if (input[3] <= -1.0448075532913208) {
                        if (input[1] <= -1.458480954170227) {
                            var147 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.3961324095726013) {
                                var147 = new double[2] {0.0, 1.0};
                            } else {
                                var147 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[3] <= 0.9067767560482025) {
                            if (input[0] <= 0.7622144669294357) {
                                if (input[2] <= -0.2562938928604126) {
                                    if (input[3] <= 0.4505589008331299) {
                                        var147 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= 0.5603082180023193) {
                                            var147 = new double[2] {1.0, 0.0};
                                        } else {
                                            var147 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= -1.4681691527366638) {
                                        var147 = new double[2] {0.7010550996483, 0.2989449003516999};
                                    } else {
                                        if (input[3] <= -0.5181650519371033) {
                                            if (input[3] <= -0.5430963933467865) {
                                                var147 = new double[2] {0.0, 1.0};
                                            } else {
                                                var147 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                            }
                                        } else {
                                            var147 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= -1.437492311000824) {
                                    var147 = new double[2] {1.0, 0.0};
                                } else {
                                    var147 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var147 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[5] <= 0.46746186912059784) {
                        var147 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 1.3205856084823608) {
                            var147 = new double[2] {1.0, 0.0};
                        } else {
                            var147 = new double[2] {0.796271637816245, 0.20372836218375504};
                        }
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var147 = new double[2] {1.0, 0.0};
                } else {
                    var147 = new double[2] {1.0, 0.0};
                }
            }
            double[] var148;
            if (input[0] <= -0.4615243822336197) {
                if (input[1] <= -1.485642671585083) {
                    var148 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.2650917172431946) {
                        if (input[5] <= 0.00212782621383667) {
                            var148 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.5749585926532745) {
                                if (input[4] <= -1.3210197687149048) {
                                    var148 = new double[2] {0.0, 1.0};
                                } else {
                                    var148 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[1] <= -0.8498112261295319) {
                                    var148 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= 1.2031255960464478) {
                                        var148 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                    } else {
                                        var148 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var148 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[2] <= 0.05875357799232006) {
                    if (input[1] <= -1.4442827701568604) {
                        var148 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= -1.5450739860534668) {
                            var148 = new double[2] {0.0, 1.0};
                        } else {
                            var148 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= 2.8052749633789062) {
                        var148 = new double[2] {1.0, 0.0};
                    } else {
                        var148 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var149;
            if (input[1] <= -1.4470607042312622) {
                var149 = new double[2] {1.0, 0.0};
            } else {
                if (input[5] <= 1.4933961629867554) {
                    if (input[1] <= 1.1425635814666748) {
                        if (input[1] <= -0.3788021057844162) {
                            if (input[2] <= 0.07701399642974138) {
                                var149 = new double[2] {0.0, 1.0};
                            } else {
                                var149 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= -1.9201874136924744) {
                                var149 = new double[2] {0.0, 1.0};
                            } else {
                                var149 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[2] <= 0.041617292910814285) {
                            if (input[4] <= -1.3390859961509705) {
                                var149 = new double[2] {0.0, 1.0};
                            } else {
                                var149 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var149 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.05875357799232006) {
                        var149 = new double[2] {0.0, 1.0};
                    } else {
                        var149 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var150;
            if (input[2] <= -0.08034390211105347) {
                if (input[2] <= -0.25295156240463257) {
                    if (input[3] <= 0.6821376383304596) {
                        if (input[4] <= 0.2070910707116127) {
                            if (input[2] <= -0.2543761432170868) {
                                if (input[1] <= -1.2658795714378357) {
                                    var150 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    if (input[4] <= -1.263850450515747) {
                                        var150 = new double[2] {0.0, 1.0};
                                    } else {
                                        var150 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var150 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            if (input[2] <= -0.2564520537853241) {
                                if (input[5] <= 0.5962311327457428) {
                                    var150 = new double[2] {0.0, 1.0};
                                } else {
                                    var150 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                }
                            } else {
                                if (input[1] <= -1.2516814172267914) {
                                    var150 = new double[2] {1.0, 0.0};
                                } else {
                                    var150 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var150 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= -1.4594069123268127) {
                        var150 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= -1.519274115562439) {
                            var150 = new double[2] {0.0, 1.0};
                        } else {
                            var150 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[2] <= 0.05875357799232006) {
                    var150 = new double[2] {0.661504424778761, 0.33849557522123896};
                } else {
                    var150 = new double[2] {1.0, 0.0};
                }
            }
            double[] var151;
            if (input[2] <= 0.0714487936347723) {
                if (input[3] <= 1.2324263453483582) {
                    if (input[5] <= 0.8192436397075653) {
                        if (input[1] <= -1.4594069123268127) {
                            var151 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -1.4555320739746094) {
                                var151 = new double[2] {0.0, 1.0};
                            } else {
                                var151 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[3] <= -1.364802598953247) {
                            var151 = new double[2] {0.0, 1.0};
                        } else {
                            var151 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.23251181840896606) {
                        if (input[2] <= -0.2540612444281578) {
                            var151 = new double[2] {1.0, 0.0};
                        } else {
                            var151 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[1] <= 0.2255464419722557) {
                            var151 = new double[2] {0.0, 1.0};
                        } else {
                            var151 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    }
                }
            } else {
                if (input[2] <= 0.5795582830905914) {
                    var151 = new double[2] {1.0, 0.0};
                } else {
                    var151 = new double[2] {1.0, 0.0};
                }
            }
            double[] var152;
            if (input[3] <= 1.2324263453483582) {
                if (input[1] <= -1.4634194374084473) {
                    var152 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= 0.24132782220840454) {
                        var152 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var152 = new double[2] {1.0, 0.0};
                        } else {
                            var152 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[3] <= 1.9592905640602112) {
                    if (input[4] <= 0.8409516885876656) {
                        if (input[3] <= 1.691728413105011) {
                            if (input[5] <= 0.6890677660703659) {
                                if (input[1] <= -0.748263418674469) {
                                    var152 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var152 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var152 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            var152 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var152 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[5] <= 0.864383190870285) {
                        var152 = new double[2] {1.0, 0.0};
                    } else {
                        var152 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var153;
            if (input[2] <= -0.08034390211105347) {
                if (input[3] <= -1.2511979341506958) {
                    var153 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= -0.23650696128606796) {
                        if (input[2] <= -0.24034304171800613) {
                            if (input[4] <= -1.082701027393341) {
                                var153 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= -0.2528524547815323) {
                                    if (input[2] <= -0.2566361576318741) {
                                        if (input[0] <= -0.4615243822336197) {
                                            var153 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[3] <= 0.21229753457009792) {
                                                var153 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[5] <= -0.7635825872421265) {
                                                    var153 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var153 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[3] <= 0.5831833779811859) {
                                            if (input[4] <= -0.2567417845129967) {
                                                var153 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[2] <= -0.2540271729230881) {
                                                    if (input[1] <= -1.263410359621048) {
                                                        var153 = new double[2] {1.0, 0.0};
                                                    } else {
                                                        var153 = new double[2] {0.0, 1.0};
                                                    }
                                                } else {
                                                    var153 = new double[2] {0.5397111913357401, 0.46028880866426003};
                                                }
                                            }
                                        } else {
                                            if (input[1] <= 0.07307035103440285) {
                                                var153 = new double[2] {0.0, 1.0};
                                            } else {
                                                var153 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    }
                                } else {
                                    if (input[4] <= -1.0271133184432983) {
                                        var153 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    } else {
                                        if (input[5] <= 0.44342152774333954) {
                                            if (input[0] <= -0.4615243822336197) {
                                                if (input[1] <= -1.201679140329361) {
                                                    var153 = new double[2] {1.0, 0.0};
                                                } else {
                                                    if (input[1] <= -0.4689296633005142) {
                                                        var153 = new double[2] {0.0, 1.0};
                                                    } else {
                                                        var153 = new double[2] {0.0, 1.0};
                                                    }
                                                }
                                            } else {
                                                if (input[1] <= -1.0313010215759277) {
                                                    var153 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var153 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        } else {
                                            if (input[0] <= -0.4615243822336197) {
                                                var153 = new double[2] {0.0, 1.0};
                                            } else {
                                                var153 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= -0.2811134159564972) {
                                if (input[0] <= 0.7622144669294357) {
                                    var153 = new double[2] {0.0, 1.0};
                                } else {
                                    var153 = new double[2] {0.8978978978978979, 0.10210210210210212};
                                }
                            } else {
                                if (input[1] <= -1.4544684290885925) {
                                    var153 = new double[2] {1.0, 0.0};
                                } else {
                                    var153 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.5482998490333557) {
                            var153 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.236000195145607) {
                                var153 = new double[2] {0.0, 1.0};
                            } else {
                                var153 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= 1.5441250801086426) {
                    if (input[4] <= -0.8964217305183411) {
                        var153 = new double[2] {1.0, 0.0};
                    } else {
                        var153 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[0] <= 0.7622144669294357) {
                        if (input[5] <= 0.01555461436510086) {
                            var153 = new double[2] {0.9462025316455697, 0.05379746835443039};
                        } else {
                            var153 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    } else {
                        var153 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var154;
            if (input[2] <= 0.09079494699835777) {
                if (input[4] <= 0.2514254152774811) {
                    if (input[2] <= -0.2364140972495079) {
                        if (input[4] <= -0.048989757895469666) {
                            if (input[1] <= -1.4803955554962158) {
                                var154 = new double[2] {1.0, 0.0};
                            } else {
                                var154 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= -0.6670868322253227) {
                                var154 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= 0.07071198732592165) {
                                    var154 = new double[2] {0.0, 1.0};
                                } else {
                                    var154 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 0.8934114873409271) {
                            var154 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.1501554474234581) {
                                var154 = new double[2] {0.0, 1.0};
                            } else {
                                var154 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        }
                    }
                } else {
                    if (input[0] <= 0.7622144669294357) {
                        if (input[1] <= -1.4736050963401794) {
                            var154 = new double[2] {1.0, 0.0};
                        } else {
                            var154 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= 1.3017836213111877) {
                            var154 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= -0.3896529972553253) {
                                var154 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var154 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            } else {
                if (input[3] <= -0.2102501466870308) {
                    var154 = new double[2] {1.0, 0.0};
                } else {
                    var154 = new double[2] {1.0, 0.0};
                }
            }
            double[] var155;
            if (input[1] <= -1.4634194374084473) {
                var155 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.1746638417243958) {
                    if (input[3] <= 1.626701295375824) {
                        if (input[5] <= 1.4877697229385376) {
                            if (input[2] <= -0.06280918698757887) {
                                var155 = new double[2] {0.0, 1.0};
                            } else {
                                var155 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            var155 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    } else {
                        if (input[4] <= 0.6331591159105301) {
                            if (input[0] <= -0.4615243822336197) {
                                var155 = new double[2] {1.0, 0.0};
                            } else {
                                var155 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            }
                        } else {
                            var155 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[3] <= 0.5338347256183624) {
                        if (input[1] <= 1.2434940934181213) {
                            var155 = new double[2] {0.796271637816245, 0.20372836218375504};
                        } else {
                            if (input[2] <= 2.346999818459153) {
                                var155 = new double[2] {0.0, 1.0};
                            } else {
                                var155 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[1] <= 1.2259007096290588) {
                            var155 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[0] <= -0.4615243822336197) {
                                var155 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= 2.234341949224472) {
                                    var155 = new double[2] {0.0, 1.0};
                                } else {
                                    var155 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                }
            }
            double[] var156;
            if (input[1] <= -1.4634194374084473) {
                var156 = new double[2] {1.0, 0.0};
            } else {
                if (input[5] <= 1.6361037492752075) {
                    if (input[4] <= -0.5225958228111267) {
                        if (input[2] <= 0.24132782220840454) {
                            var156 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -0.6707907319068909) {
                                var156 = new double[2] {1.0, 0.0};
                            } else {
                                var156 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[2] <= 0.027016911655664444) {
                            if (input[2] <= -0.2625639736652374) {
                                var156 = new double[2] {0.0, 1.0};
                            } else {
                                var156 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var156 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.07692409679293633) {
                        var156 = new double[2] {0.0, 1.0};
                    } else {
                        var156 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var157;
            if (input[2] <= 0.07809973135590553) {
                if (input[4] <= -1.082701027393341) {
                    var157 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= -0.82612344622612) {
                        if (input[5] <= -0.08214123733341694) {
                            if (input[1] <= -1.4063180685043335) {
                                var157 = new double[2] {1.0, 0.0};
                            } else {
                                var157 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[5] <= 0.20749371871352196) {
                                var157 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.4010709524154663) {
                                    var157 = new double[2] {1.0, 0.0};
                                } else {
                                    var157 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.4569376707077026) {
                            var157 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= -1.6809517741203308) {
                                var157 = new double[2] {0.0, 1.0};
                            } else {
                                var157 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            } else {
                if (input[2] <= 0.1470777951180935) {
                    var157 = new double[2] {1.0, 0.0};
                } else {
                    var157 = new double[2] {1.0, 0.0};
                }
            }
            double[] var158;
            if (input[1] <= -1.4634194374084473) {
                var158 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= -0.2827158421278) {
                    if (input[3] <= 1.1486364603042603) {
                        if (input[3] <= -0.27193593978881836) {
                            if (input[2] <= -0.12657082825899124) {
                                if (input[4] <= -1.3540094494819641) {
                                    var158 = new double[2] {0.0, 1.0};
                                } else {
                                    var158 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var158 = new double[2] {0.661504424778761, 0.33849557522123896};
                            }
                        } else {
                            if (input[4] <= -0.327516570687294) {
                                if (input[0] <= -0.4615243822336197) {
                                    if (input[2] <= -0.15660935640335083) {
                                        var158 = new double[2] {0.0, 1.0};
                                    } else {
                                        var158 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                } else {
                                    if (input[2] <= 0.12062934041023254) {
                                        if (input[0] <= 0.7622144669294357) {
                                            var158 = new double[2] {0.0, 1.0};
                                        } else {
                                            var158 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var158 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var158 = new double[2] {0.9462025316455697, 0.053797468354430396};
                            }
                        }
                    } else {
                        if (input[5] <= -0.0721670538187027) {
                            var158 = new double[2] {1.0, 0.0};
                        } else {
                            var158 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= 1.1845408082008362) {
                        if (input[2] <= -0.09688668325543404) {
                            var158 = new double[2] {0.0, 1.0};
                        } else {
                            var158 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[4] <= 0.3849455267190933) {
                            var158 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        } else {
                            var158 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            }
            double[] var159;
            if (input[2] <= -0.08034390211105347) {
                if (input[1] <= -1.4634194374084473) {
                    var159 = new double[2] {1.0, 0.0};
                } else {
                    var159 = new double[2] {0.0, 1.0};
                }
            } else {
                if (input[2] <= 0.07809973135590553) {
                    if (input[5] <= 1.3061884045600891) {
                        if (input[2] <= -0.04295351170003414) {
                            var159 = new double[2] {0.0, 1.0};
                        } else {
                            var159 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var159 = new double[2] {0.9591018444266239, 0.04089815557337611};
                    }
                } else {
                    var159 = new double[2] {1.0, 0.0};
                }
            }
            double[] var160;
            if (input[1] <= -1.4634194374084473) {
                var160 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08070212975144386) {
                    var160 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= -0.5128213912248611) {
                        var160 = new double[2] {0.7962716378162449, 0.20372836218375498};
                    } else {
                        if (input[1] <= 1.405538558959961) {
                            var160 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= 0.6512947380542755) {
                                var160 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            } else {
                                var160 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var161;
            if (input[5] <= -0.18137158453464508) {
                if (input[5] <= -1.482235312461853) {
                    if (input[1] <= -1.3331665992736816) {
                        var161 = new double[2] {1.0, 0.0};
                    } else {
                        var161 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[2] <= 0.15409676730632782) {
                        if (input[2] <= -0.26244038343429565) {
                            var161 = new double[2] {0.661504424778761, 0.33849557522123896};
                        } else {
                            var161 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var161 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[4] <= 0.8426751792430878) {
                    if (input[5] <= 0.18332549929618835) {
                        if (input[2] <= -0.25435952842235565) {
                            var161 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= 0.010923627763986588) {
                                if (input[1] <= -1.464345395565033) {
                                    var161 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[0] <= -0.4615243822336197) {
                                        var161 = new double[2] {0.0, 1.0};
                                    } else {
                                        var161 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.16886045038700104) {
                                    var161 = new double[2] {1.0, 0.0};
                                } else {
                                    var161 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 0.4760042876005173) {
                            if (input[3] <= -1.0715380311012268) {
                                if (input[3] <= -1.120115578174591) {
                                    var161 = new double[2] {0.0, 1.0};
                                } else {
                                    var161 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                }
                            } else {
                                if (input[4] <= -0.5218557417392731) {
                                    if (input[2] <= -0.061258938163518906) {
                                        var161 = new double[2] {0.0, 1.0};
                                    } else {
                                        var161 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                    }
                                } else {
                                    if (input[4] <= -0.36904263496398926) {
                                        var161 = new double[2] {0.0, 1.0};
                                    } else {
                                        var161 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= -1.4763829708099365) {
                                var161 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.09316971525549889) {
                                    if (input[1] <= -1.3516859412193298) {
                                        var161 = new double[2] {0.0, 1.0};
                                    } else {
                                        var161 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var161 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.2557840496301651) {
                        var161 = new double[2] {0.9214175654853621, 0.07858243451463792};
                    } else {
                        var161 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var162;
            if (input[1] <= -1.474839687347412) {
                var162 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.174355149269104) {
                    if (input[5] <= 1.4933961629867554) {
                        if (input[1] <= -1.2374832034111023) {
                            if (input[5] <= 0.23421940952539444) {
                                if (input[2] <= -0.026860184967517853) {
                                    var162 = new double[2] {0.0, 1.0};
                                } else {
                                    var162 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var162 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= 1.600998878479004) {
                                if (input[5] <= -1.6906701922416687) {
                                    var162 = new double[2] {0.0, 1.0};
                                } else {
                                    var162 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[3] <= 1.9713707566261292) {
                                    var162 = new double[2] {0.661504424778761, 0.33849557522123896};
                                } else {
                                    var162 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            }
                        }
                    } else {
                        var162 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= 0.09079494699835777) {
                        if (input[3] <= -1.207246720790863) {
                            var162 = new double[2] {0.0, 1.0};
                        } else {
                            var162 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var162 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var163;
            if (input[2] <= 0.05875357799232006) {
                if (input[5] <= -1.482235312461853) {
                    if (input[2] <= -0.2571091055870056) {
                        var163 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= -0.2541647255420685) {
                            var163 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.2445802241563797) {
                                var163 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[0] <= 0.15034502744674683) {
                                    var163 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                } else {
                                    var163 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.23650696128606796) {
                        if (input[1] <= -1.4683579206466675) {
                            var163 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.3760697841644287) {
                                var163 = new double[2] {0.0, 1.0};
                            } else {
                                var163 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.1447928249835968) {
                            var163 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.12306610867381096) {
                                var163 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var163 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            } else {
                if (input[5] <= -0.4493957906961441) {
                    var163 = new double[2] {1.0, 0.0};
                } else {
                    var163 = new double[2] {1.0, 0.0};
                }
            }
            double[] var164;
            if (input[2] <= 0.05875357799232006) {
                if (input[5] <= -1.773149013519287) {
                    var164 = new double[2] {0.9214175654853621, 0.07858243451463792};
                } else {
                    if (input[5] <= -0.6357084512710571) {
                        if (input[2] <= -0.2346711829304695) {
                            if (input[5] <= -1.5759670734405518) {
                                var164 = new double[2] {0.0, 1.0};
                            } else {
                                var164 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[5] <= -1.5345358848571777) {
                                if (input[3] <= 0.26858581602573395) {
                                    var164 = new double[2] {0.7010550996483, 0.2989449003516999};
                                } else {
                                    var164 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var164 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[4] <= 0.7263494431972504) {
                            if (input[1] <= -1.4763829708099365) {
                                var164 = new double[2] {1.0, 0.0};
                            } else {
                                var164 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[5] <= -0.24761039018630981) {
                                var164 = new double[2] {0.661504424778761, 0.33849557522123896};
                            } else {
                                var164 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            } else {
                if (input[5] <= -0.7062949687242508) {
                    var164 = new double[2] {1.0, 0.0};
                } else {
                    var164 = new double[2] {1.0, 0.0};
                }
            }
            double[] var165;
            if (input[1] <= -1.4634194374084473) {
                var165 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.1366990804672241) {
                    if (input[4] <= -0.7877503335475922) {
                        if (input[2] <= 0.03708900511264801) {
                            if (input[1] <= -1.2384092211723328) {
                                var165 = new double[2] {0.0, 1.0};
                            } else {
                                var165 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var165 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 0.25517742335796356) {
                            var165 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= -0.4615243822336197) {
                                if (input[5] <= 1.3166741132736206) {
                                    var165 = new double[2] {0.0, 1.0};
                                } else {
                                    var165 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            } else {
                                var165 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.05875357799232006) {
                        if (input[5] <= -1.4699593782424927) {
                            var165 = new double[2] {0.0, 1.0};
                        } else {
                            var165 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var165 = new double[2] {1.0, 0.0};
                        } else {
                            var165 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var166;
            if (input[1] <= -1.4594069123268127) {
                var166 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.2535023093223572) {
                    if (input[3] <= 0.054227687418460846) {
                        if (input[5] <= -1.3014212250709534) {
                            if (input[3] <= -0.37988606095314026) {
                                var166 = new double[2] {0.0, 1.0};
                            } else {
                                var166 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            }
                        } else {
                            var166 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[3] <= 0.07427556812763214) {
                            var166 = new double[2] {0.9361302442078898, 0.06386975579211022};
                        } else {
                            if (input[5] <= 1.479202151298523) {
                                if (input[2] <= 0.09079494699835777) {
                                    var166 = new double[2] {0.0, 1.0};
                                } else {
                                    var166 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var166 = new double[2] {0.9670116429495471, 0.032988357050452784};
                            }
                        }
                    }
                } else {
                    if (input[2] <= 0.31332336366176605) {
                        var166 = new double[2] {0.0, 1.0};
                    } else {
                        var166 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var167;
            if (input[2] <= 0.07809973135590553) {
                if (input[3] <= -1.0985255241394043) {
                    var167 = new double[2] {0.0, 1.0};
                } else {
                    if (input[2] <= -0.23650696128606796) {
                        if (input[5] <= 0.7117014825344086) {
                            if (input[1] <= -1.4791609048843384) {
                                var167 = new double[2] {1.0, 0.0};
                            } else {
                                var167 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var167 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= -0.1447928249835968) {
                            var167 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.06769416108727455) {
                                if (input[3] <= 0.6957599371671677) {
                                    var167 = new double[2] {0.0, 1.0};
                                } else {
                                    var167 = new double[2] {0.9462025316455697, 0.05379746835443039};
                                }
                            } else {
                                if (input[4] <= -0.8789941370487213) {
                                    var167 = new double[2] {0.0, 1.0};
                                } else {
                                    var167 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[2] <= 0.2677762769162655) {
                    var167 = new double[2] {1.0, 0.0};
                } else {
                    var167 = new double[2] {1.0, 0.0};
                }
            }
            double[] var168;
            if (input[2] <= 0.0714487936347723) {
                if (input[2] <= -0.23650696128606796) {
                    if (input[2] <= -0.2590998113155365) {
                        var168 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -1.4069353938102722) {
                            var168 = new double[2] {1.0, 0.0};
                        } else {
                            var168 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[5] <= 1.6161553263664246) {
                        if (input[0] <= 0.7622144669294357) {
                            var168 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= -0.7635808885097504) {
                                if (input[3] <= 0.4333382844924927) {
                                    var168 = new double[2] {0.0, 1.0};
                                } else {
                                    var168 = new double[2] {0.9462025316455697, 0.053797468354430396};
                                }
                            } else {
                                var168 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var168 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var168 = new double[2] {1.0, 0.0};
                } else {
                    var168 = new double[2] {1.0, 0.0};
                }
            }
            double[] var169;
            if (input[1] <= -1.4594069123268127) {
                var169 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.03448438737541437) {
                    if (input[4] <= -2.213181495666504) {
                        var169 = new double[2] {0.0, 1.0};
                    } else {
                        var169 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[0] <= -0.4615243822336197) {
                        var169 = new double[2] {1.0, 0.0};
                    } else {
                        var169 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var170;
            if (input[4] <= -0.7107101678848267) {
                if (input[2] <= 0.31266623735427856) {
                    if (input[5] <= -0.08214123733341694) {
                        if (input[2] <= -0.17091213911771774) {
                            var170 = new double[2] {0.0, 1.0};
                        } else {
                            var170 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[3] <= 0.5286942273378372) {
                            if (input[4] <= -0.8930355906486511) {
                                var170 = new double[2] {0.0, 1.0};
                            } else {
                                var170 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            }
                        } else {
                            if (input[3] <= 0.9221982061862946) {
                                var170 = new double[2] {0.9462025316455697, 0.05379746835443039};
                            } else {
                                if (input[3] <= 1.1383554935455322) {
                                    var170 = new double[2] {0.0, 1.0};
                                } else {
                                    var170 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[4] <= -1.8299574255943298) {
                        var170 = new double[2] {1.0, 0.0};
                    } else {
                        var170 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= -0.08070212975144386) {
                    if (input[1] <= -1.4763829708099365) {
                        var170 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -1.6809517741203308) {
                            var170 = new double[2] {0.0, 1.0};
                        } else {
                            var170 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[4] <= 0.5369577258825302) {
                        if (input[3] <= 0.6636319160461426) {
                            var170 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        } else {
                            var170 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var170 = new double[2] {0.661504424778761, 0.33849557522123896};
                    }
                }
            }
            double[] var171;
            if (input[2] <= 0.07809973135590553) {
                if (input[2] <= -0.23650696128606796) {
                    if (input[5] <= -1.329937219619751) {
                        if (input[4] <= -0.017520785331726074) {
                            if (input[2] <= -0.25607433915138245) {
                                var171 = new double[2] {0.9214175654853621, 0.07858243451463792};
                            } else {
                                var171 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= -0.3769501745700836) {
                                var171 = new double[2] {1.0, 0.0};
                            } else {
                                var171 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.25920815765857697) {
                            var171 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.2588135898113251) {
                                var171 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.443048119544983) {
                                    var171 = new double[2] {1.0, 0.0};
                                } else {
                                    var171 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[1] <= -1.5729923248291016) {
                        var171 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= 1.636468231678009) {
                            var171 = new double[2] {0.0, 1.0};
                        } else {
                            var171 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    }
                }
            } else {
                if (input[4] <= -1.6484836339950562) {
                    var171 = new double[2] {1.0, 0.0};
                } else {
                    var171 = new double[2] {1.0, 0.0};
                }
            }
            double[] var172;
            if (input[2] <= -0.08034390211105347) {
                if (input[2] <= -0.23650696128606796) {
                    if (input[4] <= 0.8976546227931976) {
                        if (input[3] <= -1.100581705570221) {
                            var172 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= -1.038638949394226) {
                                var172 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.4868773221969604) {
                                    var172 = new double[2] {1.0, 0.0};
                                } else {
                                    var172 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var172 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[2] <= -0.1652749553322792) {
                        if (input[5] <= -1.6798008680343628) {
                            var172 = new double[2] {0.5944333996023857, 0.4055666003976144};
                        } else {
                            var172 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= -0.15904340147972107) {
                            var172 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            if (input[3] <= 0.7957423329353333) {
                                if (input[4] <= -1.51161789894104) {
                                    var172 = new double[2] {0.0, 1.0};
                                } else {
                                    var172 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var172 = new double[2] {0.5944333996023856, 0.40556660039761433};
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= -1.5962820053100586) {
                    var172 = new double[2] {0.8542857142857143, 0.14571428571428574};
                } else {
                    if (input[5] <= -1.2006564140319824) {
                        var172 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    } else {
                        if (input[2] <= 0.24888820201158524) {
                            var172 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        } else {
                            var172 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var173;
            if (input[2] <= 0.07809973135590553) {
                if (input[2] <= -0.2344713732600212) {
                    if (input[4] <= -0.048989757895469666) {
                        if (input[4] <= -1.0464468598365784) {
                            if (input[1] <= -1.1742087602615356) {
                                var173 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            } else {
                                var173 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var173 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= -0.24034304171800613) {
                            if (input[4] <= 0.8418742716312408) {
                                if (input[5] <= 0.7047962844371796) {
                                    if (input[3] <= -1.1082925200462341) {
                                        var173 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= 0.5983477830886841) {
                                            if (input[1] <= -1.437492311000824) {
                                                var173 = new double[2] {1.0, 0.0};
                                            } else {
                                                var173 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var173 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= -0.9180946052074432) {
                                        var173 = new double[2] {0.0, 1.0};
                                    } else {
                                        var173 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[1] <= -0.960927426815033) {
                                    var173 = new double[2] {0.0, 1.0};
                                } else {
                                    var173 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[5] <= -1.5390114188194275) {
                                var173 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.23650696128606796) {
                                    if (input[0] <= -0.4615243822336197) {
                                        var173 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[4] <= 0.4141232818365097) {
                                            var173 = new double[2] {1.0, 0.0};
                                        } else {
                                            var173 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var173 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[5] <= 1.586872160434723) {
                        var173 = new double[2] {0.0, 1.0};
                    } else {
                        var173 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var173 = new double[2] {1.0, 0.0};
                } else {
                    var173 = new double[2] {1.0, 0.0};
                }
            }
            double[] var174;
            if (input[2] <= -0.08745646104216576) {
                if (input[3] <= -1.100581705570221) {
                    var174 = new double[2] {0.0, 1.0};
                } else {
                    if (input[5] <= -1.5226435661315918) {
                        if (input[4] <= 0.49107222259044647) {
                            if (input[3] <= 0.053456611931324005) {
                                var174 = new double[2] {0.0, 1.0};
                            } else {
                                var174 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            var174 = new double[2] {0.8865826538176427, 0.11341734618235733};
                        }
                    } else {
                        if (input[5] <= -0.18137158453464508) {
                            if (input[1] <= -1.3121780157089233) {
                                var174 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var174 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= -0.2364140972495079) {
                                if (input[3] <= -1.0633132457733154) {
                                    var174 = new double[2] {0.9670116429495471, 0.032988357050452784};
                                } else {
                                    if (input[1] <= -1.4445914030075073) {
                                        var174 = new double[2] {1.0, 0.0};
                                    } else {
                                        var174 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[0] <= 0.7622144669294357) {
                                    var174 = new double[2] {0.0, 1.0};
                                } else {
                                    var174 = new double[2] {0.5944333996023856, 0.40556660039761433};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= 0.5369577258825302) {
                    var174 = new double[2] {1.0, 0.0};
                } else {
                    var174 = new double[2] {0.8542857142857143, 0.14571428571428574};
                }
            }
            double[] var175;
            if (input[3] <= 0.4834579974412918) {
                if (input[3] <= -1.0743653178215027) {
                    var175 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -1.4594069123268127) {
                        var175 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 0.49111858010292053) {
                            if (input[2] <= 0.19771247822791338) {
                                var175 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.7914591431617737) {
                                    var175 = new double[2] {1.0, 0.0};
                                } else {
                                    var175 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var175 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[2] <= 0.07809973135590553) {
                    if (input[2] <= -0.25638023018836975) {
                        if (input[1] <= -1.4310105443000793) {
                            var175 = new double[2] {1.0, 0.0};
                        } else {
                            var175 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= -0.23767469823360443) {
                            if (input[5] <= -0.17229251377284527) {
                                var175 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.2720527052879333) {
                                    var175 = new double[2] {1.0, 0.0};
                                } else {
                                    var175 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.23555029183626175) {
                                var175 = new double[2] {0.0, 1.0};
                            } else {
                                var175 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= -1.3874249458312988) {
                        var175 = new double[2] {1.0, 0.0};
                    } else {
                        var175 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var176;
            if (input[2] <= 0.24132782220840454) {
                if (input[1] <= -1.4634194374084473) {
                    var176 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.08034390211105347) {
                        if (input[4] <= -2.004334509372711) {
                            var176 = new double[2] {0.0, 1.0};
                        } else {
                            var176 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var176 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var176 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[3] <= 0.021071583032608032) {
                    var176 = new double[2] {1.0, 0.0};
                } else {
                    var176 = new double[2] {1.0, 0.0};
                }
            }
            double[] var177;
            if (input[2] <= 0.09079494699835777) {
                if (input[2] <= -0.238062784075737) {
                    if (input[2] <= -0.2564520537853241) {
                        if (input[1] <= -1.4282326698303223) {
                            var177 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.2693464905023575) {
                                var177 = new double[2] {0.0, 1.0};
                            } else {
                                var177 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -1.431627869606018) {
                            var177 = new double[2] {1.0, 0.0};
                        } else {
                            var177 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.1652749553322792) {
                        var177 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= -1.4711358547210693) {
                            var177 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= 0.29869793355464935) {
                                if (input[3] <= 1.3709623217582703) {
                                    var177 = new double[2] {0.0, 1.0};
                                } else {
                                    var177 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            } else {
                                if (input[2] <= -0.15573786944150925) {
                                    var177 = new double[2] {0.0, 1.0};
                                } else {
                                    var177 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[2] <= 0.5795582830905914) {
                    var177 = new double[2] {1.0, 0.0};
                } else {
                    var177 = new double[2] {1.0, 0.0};
                }
            }
            double[] var178;
            if (input[2] <= 0.07809973135590553) {
                if (input[1] <= -1.4594069123268127) {
                    var178 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.08034390211105347) {
                        var178 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 0.7170929312705994) {
                            var178 = new double[2] {0.0, 1.0};
                        } else {
                            var178 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var178 = new double[2] {1.0, 0.0};
                } else {
                    var178 = new double[2] {1.0, 0.0};
                }
            }
            double[] var179;
            if (input[1] <= -1.4816301465034485) {
                var179 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= -0.45210491120815277) {
                    if (input[2] <= 0.12062934041023254) {
                        var179 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -0.2102501466870308) {
                            var179 = new double[2] {1.0, 0.0};
                        } else {
                            var179 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.027016911655664444) {
                        if (input[4] <= -0.41853733360767365) {
                            var179 = new double[2] {0.0, 1.0};
                        } else {
                            var179 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var179 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var180;
            if (input[3] <= 1.1591744422912598) {
                if (input[2] <= 0.0714487936347723) {
                    if (input[2] <= -0.25295156240463257) {
                        if (input[5] <= -0.6601324081420898) {
                            var180 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= 0.7622144669294357) {
                                if (input[2] <= -0.25474631786346436) {
                                    if (input[4] <= 0.2070910707116127) {
                                        if (input[5] <= -0.2912154644727707) {
                                            var180 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                        } else {
                                            var180 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[5] <= 0.5517309308052063) {
                                            var180 = new double[2] {0.0, 1.0};
                                        } else {
                                            var180 = new double[2] {0.9462025316455697, 0.053797468354430396};
                                        }
                                    }
                                } else {
                                    if (input[1] <= -1.3877987265586853) {
                                        var180 = new double[2] {1.0, 0.0};
                                    } else {
                                        var180 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[4] <= -0.5275635570287704) {
                                    var180 = new double[2] {0.0, 1.0};
                                } else {
                                    var180 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.7622144669294357) {
                            if (input[2] <= -0.23989951610565186) {
                                if (input[1] <= -1.3368704915046692) {
                                    var180 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                } else {
                                    var180 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= -1.6809517741203308) {
                                    var180 = new double[2] {0.0, 1.0};
                                } else {
                                    var180 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[1] <= -1.43440580368042) {
                                var180 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.2581631541252136) {
                                    var180 = new double[2] {0.0, 1.0};
                                } else {
                                    var180 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[0] <= -0.4615243822336197) {
                        var180 = new double[2] {1.0, 0.0};
                    } else {
                        var180 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[3] <= 1.2535023093223572) {
                    if (input[5] <= -0.5262481607496738) {
                        var180 = new double[2] {0.0, 1.0};
                    } else {
                        var180 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= 1.405538558959961) {
                        if (input[5] <= 1.0573452711105347) {
                            if (input[4] <= 0.5147246494889259) {
                                if (input[5] <= 0.8274275958538055) {
                                    var180 = new double[2] {1.0, 0.0};
                                } else {
                                    var180 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var180 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= 1.8459429144859314) {
                                var180 = new double[2] {1.0, 0.0};
                            } else {
                                var180 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var180 = new double[2] {0.796271637816245, 0.20372836218375504};
                    }
                }
            }
            double[] var181;
            if (input[1] <= -1.4708271622657776) {
                var181 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.390239179134369) {
                    if (input[5] <= 1.4933961629867554) {
                        if (input[1] <= 1.5228278636932373) {
                            if (input[1] <= -1.2374832034111023) {
                                if (input[2] <= 0.0023235157132148743) {
                                    var181 = new double[2] {0.0, 1.0};
                                } else {
                                    var181 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 1.2055294513702393) {
                                    if (input[5] <= 0.4626026451587677) {
                                        if (input[2] <= -0.26610177755355835) {
                                            var181 = new double[2] {0.0, 1.0};
                                        } else {
                                            var181 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[0] <= -0.4615243822336197) {
                                            var181 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[2] <= -0.10024148225784302) {
                                                if (input[1] <= -0.9803727567195892) {
                                                    var181 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var181 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var181 = new double[2] {0.661504424778761, 0.33849557522123896};
                                            }
                                        }
                                    }
                                } else {
                                    if (input[1] <= 1.24164217710495) {
                                        var181 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                    } else {
                                        var181 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= -0.3873768486082554) {
                                var181 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 0.4944433122873306) {
                                    var181 = new double[2] {0.5944333996023856, 0.40556660039761433};
                                } else {
                                    var181 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 0.8928608000278473) {
                            var181 = new double[2] {0.5397111913357401, 0.46028880866426003};
                        } else {
                            var181 = new double[2] {0.7456359102244389, 0.25436408977556113};
                        }
                    }
                } else {
                    if (input[2] <= -0.12391766533255577) {
                        var181 = new double[2] {0.0, 1.0};
                    } else {
                        var181 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var182;
            if (input[1] <= -1.4634194374084473) {
                var182 = new double[2] {1.0, 0.0};
            } else {
                if (input[5] <= 1.3847031593322754) {
                    if (input[2] <= 0.07701399642974138) {
                        if (input[4] <= -1.6403731107711792) {
                            var182 = new double[2] {0.0, 1.0};
                        } else {
                            var182 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= -1.7833216786384583) {
                            var182 = new double[2] {1.0, 0.0};
                        } else {
                            var182 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[0] <= -0.4615243822336197) {
                        if (input[1] <= 0.44747012853622437) {
                            var182 = new double[2] {1.0, 0.0};
                        } else {
                            var182 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[2] <= -0.04425325058400631) {
                            var182 = new double[2] {0.0, 1.0};
                        } else {
                            var182 = new double[2] {0.8978978978978979, 0.10210210210210212};
                        }
                    }
                }
            }
            double[] var183;
            if (input[2] <= 0.12062934041023254) {
                if (input[1] <= -1.474839687347412) {
                    var183 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= -1.5863574147224426) {
                        var183 = new double[2] {0.0, 1.0};
                    } else {
                        var183 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[4] <= -1.862399697303772) {
                    var183 = new double[2] {1.0, 0.0};
                } else {
                    var183 = new double[2] {1.0, 0.0};
                }
            }
            double[] var184;
            if (input[3] <= 1.145552158355713) {
                if (input[3] <= -1.0964693427085876) {
                    if (input[3] <= -1.3887057900428772) {
                        if (input[3] <= -1.4069545269012451) {
                            if (input[3] <= -1.519274115562439) {
                                var184 = new double[2] {0.0, 1.0};
                            } else {
                                var184 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var184 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        var184 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= -1.4634194374084473) {
                        var184 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= -0.20125430822372437) {
                            var184 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.07299045100808144) {
                                if (input[3] <= 0.054227687418460846) {
                                    if (input[5] <= -1.018691509962082) {
                                        var184 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                    } else {
                                        var184 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var184 = new double[2] {0.9462025316455697, 0.05379746835443039};
                                }
                            } else {
                                if (input[5] <= 1.6469730138778687) {
                                    if (input[0] <= -0.4615243822336197) {
                                        if (input[3] <= 0.5765007138252258) {
                                            var184 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[2] <= -0.18220573663711548) {
                                                var184 = new double[2] {0.0, 1.0};
                                            } else {
                                                var184 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                            }
                                        }
                                    } else {
                                        var184 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var184 = new double[2] {0.7010550996483002, 0.29894490035169996};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= -1.3955150842666626) {
                    var184 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.15356136113405228) {
                        if (input[3] <= 1.390239179134369) {
                            if (input[1] <= 1.077437162399292) {
                                if (input[4] <= -1.2131087183952332) {
                                    var184 = new double[2] {0.0, 1.0};
                                } else {
                                    var184 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var184 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var184 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var184 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var185;
            if (input[2] <= 0.12062934041023254) {
                if (input[1] <= -1.485642671585083) {
                    var185 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 1.6161553263664246) {
                        var185 = new double[2] {0.0, 1.0};
                    } else {
                        var185 = new double[2] {0.661504424778761, 0.33849557522123896};
                    }
                }
            } else {
                if (input[3] <= -0.2102501466870308) {
                    var185 = new double[2] {1.0, 0.0};
                } else {
                    var185 = new double[2] {1.0, 0.0};
                }
            }
            double[] var186;
            if (input[3] <= 1.145552158355713) {
                if (input[1] <= -1.4634194374084473) {
                    var186 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= -0.5225958228111267) {
                        if (input[1] <= 0.05702023766934872) {
                            if (input[1] <= -1.2177292108535767) {
                                if (input[4] <= -0.8222405314445496) {
                                    var186 = new double[2] {0.4942148760330578, 0.5057851239669422};
                                } else {
                                    var186 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[3] <= -1.2977192997932434) {
                                    var186 = new double[2] {0.0, 1.0};
                                } else {
                                    var186 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= 0.24132782220840454) {
                                if (input[5] <= -1.5223877429962158) {
                                    var186 = new double[2] {0.0, 1.0};
                                } else {
                                    var186 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var186 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= 1.4877697229385376) {
                            if (input[0] <= -0.4615243822336197) {
                                if (input[1] <= 1.1623175740242004) {
                                    if (input[4] <= -0.4663693755865097) {
                                        var186 = new double[2] {0.0, 1.0};
                                    } else {
                                        var186 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var186 = new double[2] {0.7962716378162449, 0.20372836218375498};
                                }
                            } else {
                                var186 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= -0.07692409679293633) {
                                var186 = new double[2] {0.0, 1.0};
                            } else {
                                var186 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[2] <= -0.11619627848267555) {
                    if (input[3] <= 1.3221277594566345) {
                        if (input[4] <= -1.153131127357483) {
                            var186 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var186 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    } else {
                        var186 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var186 = new double[2] {1.0, 0.0};
                }
            }
            double[] var187;
            if (input[1] <= -1.4634194374084473) {
                var187 = new double[2] {1.0, 0.0};
            } else {
                if (input[5] <= -0.5390355587005615) {
                    if (input[2] <= -0.11866655200719833) {
                        var187 = new double[2] {0.0, 1.0};
                    } else {
                        var187 = new double[2] {0.661504424778761, 0.33849557522123896};
                    }
                } else {
                    if (input[1] <= 1.4172674417495728) {
                        if (input[5] <= 1.4933961629867554) {
                            if (input[2] <= 0.010923627763986588) {
                                var187 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[0] <= -0.4615243822336197) {
                                    var187 = new double[2] {1.0, 0.0};
                                } else {
                                    var187 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.16034113988280296) {
                                var187 = new double[2] {0.0, 1.0};
                            } else {
                                var187 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= -0.209051676094532) {
                            if (input[4] <= -1.8147501349449158) {
                                var187 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var187 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var187 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            }
            double[] var188;
            if (input[1] <= -1.4634194374084473) {
                var188 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08070212975144386) {
                    var188 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 0.5369577258825302) {
                        if (input[3] <= 0.6859930157661438) {
                            if (input[3] <= 0.588066816329956) {
                                var188 = new double[2] {0.9462025316455697, 0.05379746835443039};
                            } else {
                                var188 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            }
                        } else {
                            var188 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var188 = new double[2] {0.661504424778761, 0.33849557522123896};
                    }
                }
            }
            double[] var189;
            if (input[2] <= 0.12062934041023254) {
                if (input[5] <= 0.1775711625814438) {
                    if (input[2] <= -0.23839838057756424) {
                        if (input[4] <= -1.0697241425514221) {
                            var189 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= 0.7622144669294357) {
                                if (input[3] <= 0.7147797048091888) {
                                    if (input[5] <= -0.7226628661155701) {
                                        if (input[0] <= -0.4615243822336197) {
                                            var189 = new double[2] {0.661504424778761, 0.33849557522123896};
                                        } else {
                                            var189 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[2] <= -0.25521552562713623) {
                                            if (input[1] <= -1.5063226222991943) {
                                                var189 = new double[2] {1.0, 0.0};
                                            } else {
                                                var189 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            if (input[2] <= -0.24367530643939972) {
                                                var189 = new double[2] {1.0, 0.0};
                                            } else {
                                                var189 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                            }
                                        }
                                    }
                                } else {
                                    var189 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[4] <= 0.5785142183303833) {
                                    var189 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -1.1242064535617828) {
                                        var189 = new double[2] {1.0, 0.0};
                                    } else {
                                        var189 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.4421221613883972) {
                            var189 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            if (input[0] <= -0.4615243822336197) {
                                var189 = new double[2] {0.0, 1.0};
                            } else {
                                var189 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[3] <= 1.2090371251106262) {
                        if (input[1] <= -1.4822474718093872) {
                            var189 = new double[2] {1.0, 0.0};
                        } else {
                            var189 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[3] <= 1.717430830001831) {
                            var189 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        } else {
                            var189 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[1] <= -1.0856244266033173) {
                    var189 = new double[2] {1.0, 0.0};
                } else {
                    var189 = new double[2] {1.0, 0.0};
                }
            }
            double[] var190;
            if (input[1] <= -1.469901204109192) {
                var190 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.08070212975144386) {
                    var190 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 1.5429613292217255) {
                        if (input[2] <= 0.07809973135590553) {
                            var190 = new double[2] {0.897897897897898, 0.10210210210210213};
                        } else {
                            if (input[3] <= -0.2166757509112358) {
                                var190 = new double[2] {1.0, 0.0};
                            } else {
                                var190 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var190 = new double[2] {0.0, 1.0};
                    }
                }
            }
            double[] var191;
            if (input[2] <= 0.06250699050724506) {
                if (input[3] <= 1.145552158355713) {
                    if (input[2] <= -0.25295156240463257) {
                        if (input[1] <= -1.4501472115516663) {
                            var191 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.3334752321243286) {
                                var191 = new double[2] {0.0, 1.0};
                            } else {
                                var191 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -1.4594069123268127) {
                            var191 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.41557776927948) {
                                var191 = new double[2] {0.0, 1.0};
                            } else {
                                var191 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[5] <= 1.1684679985046387) {
                        if (input[4] <= 0.2258974313735962) {
                            if (input[1] <= -1.3445868492126465) {
                                var191 = new double[2] {1.0, 0.0};
                            } else {
                                var191 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var191 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var191 = new double[2] {0.0, 1.0};
                    }
                }
            } else {
                if (input[5] <= -0.4493957906961441) {
                    var191 = new double[2] {1.0, 0.0};
                } else {
                    var191 = new double[2] {1.0, 0.0};
                }
            }
            double[] var192;
            if (input[4] <= 0.8976546227931976) {
                if (input[0] <= -0.4615243822336197) {
                    if (input[3] <= 1.201069414615631) {
                        if (input[1] <= -1.4634194374084473) {
                            var192 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.08841985743492842) {
                                var192 = new double[2] {0.0, 1.0};
                            } else {
                                var192 = new double[2] {0.9462025316455697, 0.053797468354430396};
                            }
                        }
                    } else {
                        if (input[3] <= 1.2866584062576294) {
                            var192 = new double[2] {1.0, 0.0};
                        } else {
                            var192 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.4550857543945312) {
                        var192 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 1.1589223742485046) {
                            var192 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.794971227645874) {
                                if (input[2] <= 2.317168317735195) {
                                    var192 = new double[2] {0.0, 1.0};
                                } else {
                                    var192 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.08636536821722984) {
                                    if (input[1] <= 2.250021457672119) {
                                        var192 = new double[2] {0.661504424778761, 0.33849557522123896};
                                    } else {
                                        var192 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var192 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                if (input[5] <= -1.5974499583244324) {
                    var192 = new double[2] {0.661504424778761, 0.33849557522123896};
                } else {
                    if (input[3] <= -1.229607880115509) {
                        if (input[1] <= -1.1022918820381165) {
                            var192 = new double[2] {0.661504424778761, 0.33849557522123896};
                        } else {
                            var192 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var192 = new double[2] {0.0, 1.0};
                        } else {
                            var192 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            }
            double[] var193;
            if (input[3] <= 1.2324263453483582) {
                if (input[4] <= -1.053077220916748) {
                    if (input[2] <= -0.012081284075975418) {
                        var193 = new double[2] {0.0, 1.0};
                    } else {
                        var193 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                } else {
                    if (input[5] <= -1.5345358848571777) {
                        if (input[1] <= -1.3837862014770508) {
                            var193 = new double[2] {1.0, 0.0};
                        } else {
                            var193 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= -0.7093009352684021) {
                            if (input[1] <= -1.33285790681839) {
                                var193 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.037391201592981815) {
                                    if (input[1] <= -0.7927098572254181) {
                                        var193 = new double[2] {0.0, 1.0};
                                    } else {
                                        var193 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var193 = new double[2] {0.9462025316455697, 0.053797468354430396};
                                }
                            }
                        } else {
                            if (input[2] <= 0.05875357799232006) {
                                if (input[4] <= -0.2015392780303955) {
                                    var193 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= -0.5837062299251556) {
                                        if (input[1] <= -1.4538511037826538) {
                                            var193 = new double[2] {1.0, 0.0};
                                        } else {
                                            if (input[1] <= -1.105995774269104) {
                                                var193 = new double[2] {0.0, 1.0};
                                            } else {
                                                var193 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        var193 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var193 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                if (input[1] <= 1.936118245124817) {
                    if (input[1] <= 0.2255464419722557) {
                        if (input[2] <= 0.823279932141304) {
                            if (input[5] <= 0.46746186912059784) {
                                var193 = new double[2] {0.7456359102244389, 0.25436408977556113};
                            } else {
                                var193 = new double[2] {0.8978978978978979, 0.10210210210210212};
                            }
                        } else {
                            var193 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var193 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var193 = new double[2] {0.53971119133574, 0.46028880866426};
                }
            }
            double[] var194;
            if (input[2] <= 0.07701399642974138) {
                if (input[4] <= -1.053077220916748) {
                    if (input[3] <= 1.0771837830543518) {
                        var194 = new double[2] {0.0, 1.0};
                    } else {
                        var194 = new double[2] {0.8542857142857143, 0.14571428571428574};
                    }
                } else {
                    if (input[2] <= -0.23642007261514664) {
                        if (input[3] <= -1.100581705570221) {
                            if (input[4] <= -0.687483549118042) {
                                var194 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                var194 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[5] <= 1.160923421382904) {
                                if (input[2] <= -0.2481662482023239) {
                                    if (input[0] <= 0.7622144669294357) {
                                        if (input[3] <= 0.5603082180023193) {
                                            if (input[4] <= 0.5306923091411591) {
                                                if (input[0] <= -0.4615243822336197) {
                                                    if (input[2] <= -0.2588294446468353) {
                                                        var194 = new double[2] {0.7456359102244389, 0.25436408977556113};
                                                    } else {
                                                        var194 = new double[2] {0.0, 1.0};
                                                    }
                                                } else {
                                                    if (input[1] <= -1.263410359621048) {
                                                        var194 = new double[2] {1.0, 0.0};
                                                    } else {
                                                        var194 = new double[2] {0.0, 1.0};
                                                    }
                                                }
                                            } else {
                                                if (input[2] <= -0.2571091055870056) {
                                                    var194 = new double[2] {0.0, 1.0};
                                                } else {
                                                    if (input[4] <= 0.7343485057353973) {
                                                        var194 = new double[2] {1.0, 0.0};
                                                    } else {
                                                        if (input[5] <= 0.029876516200602055) {
                                                            var194 = new double[2] {0.9214175654853621, 0.07858243451463792};
                                                        } else {
                                                            var194 = new double[2] {0.0, 1.0};
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if (input[2] <= -0.2616935819387436) {
                                                var194 = new double[2] {0.0, 1.0};
                                            } else {
                                                var194 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        var194 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[3] <= -0.5202212631702423) {
                                        if (input[1] <= -0.9812986999750137) {
                                            var194 = new double[2] {1.0, 0.0};
                                        } else {
                                            var194 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[1] <= -1.4198989272117615) {
                                            var194 = new double[2] {1.0, 0.0};
                                        } else {
                                            var194 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var194 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[4] <= -0.8343860805034637) {
                            if (input[4] <= -0.9722656011581421) {
                                var194 = new double[2] {0.8542857142857143, 0.14571428571428574};
                            } else {
                                if (input[0] <= -0.4615243822336197) {
                                    var194 = new double[2] {0.0, 1.0};
                                } else {
                                    var194 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            }
                        } else {
                            if (input[1] <= -1.4362577199935913) {
                                var194 = new double[2] {0.53971119133574, 0.46028880866426};
                            } else {
                                var194 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                }
            } else {
                if (input[0] <= -0.4615243822336197) {
                    var194 = new double[2] {1.0, 0.0};
                } else {
                    var194 = new double[2] {1.0, 0.0};
                }
            }
            double[] var195;
            if (input[1] <= -1.4708271622657776) {
                var195 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.1425635814666748) {
                    if (input[5] <= 1.4933961629867554) {
                        if (input[3] <= 1.600998878479004) {
                            var195 = new double[2] {0.0, 1.0};
                        } else {
                            var195 = new double[2] {0.8978978978978979, 0.10210210210210212};
                        }
                    } else {
                        if (input[0] <= -0.4615243822336197) {
                            var195 = new double[2] {1.0, 0.0};
                        } else {
                            var195 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.09079494699835777) {
                        var195 = new double[2] {0.0, 1.0};
                    } else {
                        var195 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var196;
            if (input[1] <= -1.4594069123268127) {
                var196 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= 0.24132782220840454) {
                    var196 = new double[2] {0.0, 1.0};
                } else {
                    if (input[1] <= -0.0010071098804473877) {
                        var196 = new double[2] {1.0, 0.0};
                    } else {
                        var196 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var197;
            if (input[1] <= -1.474839687347412) {
                var197 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.12508315965533257) {
                    if (input[2] <= 0.12062934041023254) {
                        var197 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.7914591431617737) {
                            var197 = new double[2] {1.0, 0.0};
                        } else {
                            var197 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[2] <= 0.05875357799232006) {
                        var197 = new double[2] {0.0, 1.0};
                    } else {
                        var197 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var198;
            if (input[1] <= -1.4763829708099365) {
                var198 = new double[2] {1.0, 0.0};
            } else {
                if (input[5] <= -0.14697343111038208) {
                    if (input[2] <= 0.19771247822791338) {
                        var198 = new double[2] {0.0, 1.0};
                    } else {
                        var198 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= 0.05875357799232006) {
                        if (input[3] <= 1.626701295375824) {
                            var198 = new double[2] {0.0, 1.0};
                        } else {
                            var198 = new double[2] {0.8542857142857143, 0.14571428571428574};
                        }
                    } else {
                        if (input[3] <= 0.16886045038700104) {
                            var198 = new double[2] {1.0, 0.0};
                        } else {
                            var198 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var199;
            if (input[1] <= -1.474839687347412) {
                var199 = new double[2] {1.0, 0.0};
            } else {
                if (input[5] <= 1.522679328918457) {
                    if (input[5] <= -1.0543684363365173) {
                        var199 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= -0.44507914781570435) {
                            if (input[1] <= 1.481159269809723) {
                                if (input[2] <= 0.23623846098780632) {
                                    if (input[0] <= -0.4615243822336197) {
                                        var199 = new double[2] {0.0, 1.0};
                                    } else {
                                        var199 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var199 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[0] <= 0.7622144669294357) {
                                    if (input[1] <= 1.906178593635559) {
                                        var199 = new double[2] {0.8978978978978979, 0.10210210210210212};
                                    } else {
                                        var199 = new double[2] {0.9462025316455697, 0.053797468354430396};
                                    }
                                } else {
                                    var199 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[1] <= -0.3713943660259247) {
                                if (input[3] <= 1.2136635780334473) {
                                    var199 = new double[2] {0.0, 1.0};
                                } else {
                                    var199 = new double[2] {0.8542857142857143, 0.14571428571428574};
                                }
                            } else {
                                if (input[4] <= -0.41144058108329773) {
                                    var199 = new double[2] {0.0, 1.0};
                                } else {
                                    var199 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.16034113988280296) {
                        var199 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.3157196044921875) {
                            var199 = new double[2] {1.0, 0.0};
                        } else {
                            var199 = new double[2] {0.9214175654853621, 0.07858243451463792};
                        }
                    }
                }
            }
            return MulVectorNumber(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(AddVectors(var0, var1), var2), var3), var4), var5), var6), var7), var8), var9), var10), var11), var12), var13), var14), var15), var16), var17), var18), var19), var20), var21), var22), var23), var24), var25), var26), var27), var28), var29), var30), var31), var32), var33), var34), var35), var36), var37), var38), var39), var40), var41), var42), var43), var44), var45), var46), var47), var48), var49), var50), var51), var52), var53), var54), var55), var56), var57), var58), var59), var60), var61), var62), var63), var64), var65), var66), var67), var68), var69), var70), var71), var72), var73), var74), var75), var76), var77), var78), var79), var80), var81), var82), var83), var84), var85), var86), var87), var88), var89), var90), var91), var92), var93), var94), var95), var96), var97), var98), var99), var100), var101), var102), var103), var104), var105), var106), var107), var108), var109), var110), var111), var112), var113), var114), var115), var116), var117), var118), var119), var120), var121), var122), var123), var124), var125), var126), var127), var128), var129), var130), var131), var132), var133), var134), var135), var136), var137), var138), var139), var140), var141), var142), var143), var144), var145), var146), var147), var148), var149), var150), var151), var152), var153), var154), var155), var156), var157), var158), var159), var160), var161), var162), var163), var164), var165), var166), var167), var168), var169), var170), var171), var172), var173), var174), var175), var176), var177), var178), var179), var180), var181), var182), var183), var184), var185), var186), var187), var188), var189), var190), var191), var192), var193), var194), var195), var196), var197), var198), var199), 0.005);
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

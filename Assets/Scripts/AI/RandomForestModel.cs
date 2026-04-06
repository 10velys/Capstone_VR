namespace ML {
    public static class RandomForestModel {
        // Tambahkan di sini
        public static double[] scaler_mean = new double[]
        {
            1.9114285714285715, 0.4348234285714286, 6328.115462571428,
            33.63382857142857, 12.353024857142856, 122.25865714285715
        };
        
        public static double[] scaler_scale = new double[]
        {
            0.8110914792765993, 0.16094430951539654, 23655.277362148627,
            20.68596264341831, 4.940201088438677, 40.28946389987824
        };

        public static double[] Standardize(double[] rawInput)
        {
            double[] scaled = new double[rawInput.Length];
            for (int i = 0; i < rawInput.Length; i++)
            {
                scaled[i] = (rawInput[i] - scaler_mean[i]) / scaler_scale[i];
            }
            return scaled;
        }

        public static double[] Score(double[] input) {
            double[] var0;
            if (input[1] <= -1.188755452632904) {
                if (input[4] <= -1.2214532494544983) {
                    if (input[4] <= -1.401749610900879) {
                        var0 = new double[2] {0.8054298642533937, 0.1945701357466063};
                    } else {
                        var0 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[1] <= -1.3530980348587036) {
                        var0 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= -1.2950034141540527) {
                            var0 = new double[2] {0.3409961685823755, 0.6590038314176245};
                        } else {
                            var0 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[4] <= 0.5460759997367859) {
                    if (input[2] <= -0.11664692685008049) {
                        if (input[4] <= -2.2869564294815063) {
                            var0 = new double[2] {0.0, 1.0};
                        } else {
                            var0 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var0 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var0 = new double[2] {1.0, 0.0};
                }
            }
            double[] var1;
            if (input[2] <= -0.14371255785226822) {
                if (input[4] <= 0.5511365234851837) {
                    if (input[4] <= -1.4650466442108154) {
                        if (input[0] <= 0.7256535552442074) {
                            var1 = new double[2] {0.0, 1.0};
                        } else {
                            var1 = new double[2] {0.7563739376770539, 0.24362606232294617};
                        }
                    } else {
                        if (input[0] <= 0.7256535552442074) {
                            if (input[5] <= -0.6810380220413208) {
                                if (input[3] <= 0.5052301287651062) {
                                    var1 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= 0.5303679406642914) {
                                        var1 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    } else {
                                        var1 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.4525373876094818) {
                                    if (input[4] <= 0.13675053417682648) {
                                        if (input[5] <= -0.24630898982286453) {
                                            if (input[2] <= -0.23275303095579147) {
                                                var1 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            } else {
                                                var1 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var1 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[5] <= 0.09286156669259071) {
                                            var1 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var1 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= -1.3515446782112122) {
                                        var1 = new double[2] {1.0, 0.0};
                                    } else {
                                        var1 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            var1 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var1 = new double[2] {1.0, 0.0};
                }
            } else {
                var1 = new double[2] {1.0, 0.0};
            }
            double[] var2;
            if (input[4] <= 0.5460759997367859) {
                if (input[5] <= -0.08758262917399406) {
                    if (input[3] <= 0.9949342012405396) {
                        if (input[2] <= -0.1390100121498108) {
                            if (input[1] <= -1.4205126762390137) {
                                var2 = new double[2] {0.6082004555808657, 0.3917995444191344};
                            } else {
                                var2 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var2 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var2 = new double[2] {0.3409961685823755, 0.6590038314176245};
                    }
                } else {
                    if (input[3] <= 1.0372334122657776) {
                        if (input[2] <= -0.13955513387918472) {
                            if (input[3] <= 0.4194231480360031) {
                                if (input[3] <= -0.4794956296682358) {
                                    if (input[1] <= -1.514023244380951) {
                                        var2 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[0] <= -0.5072529651224613) {
                                            var2 = new double[2] {0.0, 1.0};
                                        } else {
                                            var2 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var2 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= -0.24427209794521332) {
                                    if (input[1] <= -1.508120596408844) {
                                        var2 = new double[2] {1.0, 0.0};
                                    } else {
                                        var2 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[1] <= -0.7364250868558884) {
                                        var2 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    } else {
                                        var2 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= 0.3538479134440422) {
                                var2 = new double[2] {1.0, 0.0};
                            } else {
                                var2 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.2364112213253975) {
                            var2 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.22979753464460373) {
                                var2 = new double[2] {0.8380414312617702, 0.16195856873822975};
                            } else {
                                var2 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                var2 = new double[2] {1.0, 0.0};
            }
            double[] var3;
            if (input[2] <= -0.13962869346141815) {
                if (input[3] <= -1.3390156626701355) {
                    var3 = new double[2] {0.8380414312617703, 0.16195856873822975};
                } else {
                    if (input[4] <= 0.5509138405323029) {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[1] <= -1.465869963169098) {
                                var3 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= -1.507432758808136) {
                                    var3 = new double[2] {0.0, 1.0};
                                } else {
                                    var3 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[4] <= -1.1242204308509827) {
                                if (input[1] <= -1.4894806146621704) {
                                    var3 = new double[2] {1.0, 0.0};
                                } else {
                                    var3 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var3 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var3 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var3 = new double[2] {1.0, 0.0};
            }
            double[] var4;
            if (input[5] <= -0.16464991867542267) {
                if (input[2] <= -0.14375081658363342) {
                    if (input[2] <= -0.22069381177425385) {
                        if (input[1] <= -1.4587246775627136) {
                            var4 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= 0.4784003347158432) {
                                if (input[4] <= 0.5841108560562134) {
                                    var4 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -0.7970050573348999) {
                                        var4 = new double[2] {1.0, 0.0};
                                    } else {
                                        var4 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[2] <= -0.2277468889951706) {
                                    if (input[1] <= 0.36892618238925934) {
                                        if (input[1] <= -0.9616582691669464) {
                                            var4 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                        } else {
                                            if (input[2] <= -0.24338285624980927) {
                                                var4 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                            } else {
                                                if (input[4] <= -0.9489947259426117) {
                                                    var4 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var4 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        }
                                    } else {
                                        var4 = new double[2] {0.7836477987421383, 0.2163522012578616};
                                    }
                                } else {
                                    var4 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 1.2872563004493713) {
                            var4 = new double[2] {0.0, 1.0};
                        } else {
                            var4 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        }
                    }
                } else {
                    var4 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.5157128572463989) {
                    if (input[5] <= 0.2714442312717438) {
                        if (input[5] <= 0.23545467853546143) {
                            if (input[2] <= -0.14545994624495506) {
                                if (input[0] <= 0.7256535552442074) {
                                    if (input[4] <= -1.2452479004859924) {
                                        var4 = new double[2] {0.0, 1.0};
                                    } else {
                                        var4 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                } else {
                                    var4 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var4 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var4 = new double[2] {0.8612903225806452, 0.13870967741935483};
                        }
                    } else {
                        if (input[2] <= -0.15149813890457153) {
                            if (input[1] <= -1.3515446782112122) {
                                var4 = new double[2] {1.0, 0.0};
                            } else {
                                var4 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= -0.12874338403344154) {
                                var4 = new double[2] {1.0, 0.0};
                            } else {
                                var4 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var4 = new double[2] {1.0, 0.0};
                }
            }
            double[] var5;
            if (input[1] <= -1.461210012435913) {
                var5 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.14335492253303528) {
                    if (input[2] <= -0.2155148833990097) {
                        if (input[4] <= 0.5460759997367859) {
                            if (input[3] <= -1.4013767838478088) {
                                var5 = new double[2] {0.0, 1.0};
                            } else {
                                var5 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var5 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 0.5115126073360443) {
                            if (input[1] <= -0.8811956644058228) {
                                var5 = new double[2] {0.0, 1.0};
                            } else {
                                var5 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var5 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var5 = new double[2] {1.0, 0.0};
                }
            }
            double[] var6;
            if (input[4] <= 0.55467888712883) {
                if (input[4] <= -1.5875922441482544) {
                    if (input[0] <= -0.5072529651224613) {
                        var6 = new double[2] {0.7563739376770539, 0.24362606232294617};
                    } else {
                        var6 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[5] <= 2.0882964730262756) {
                        if (input[1] <= -1.465869963169098) {
                            var6 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= 1.3439631462097168) {
                                if (input[3] <= 1.1293248534202576) {
                                    if (input[1] <= 1.3804562091827393) {
                                        if (input[5] <= -1.38084876537323) {
                                            if (input[5] <= -1.424160361289978) {
                                                if (input[3] <= -0.654251828789711) {
                                                    var6 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var6 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var6 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[2] <= -0.13955513387918472) {
                                                if (input[5] <= -1.331208050251007) {
                                                    var6 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var6 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var6 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    } else {
                                        if (input[3] <= -0.29724644124507904) {
                                            var6 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                        } else {
                                            var6 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var6 = new double[2] {0.4369885433715221, 0.5630114566284778};
                                }
                            } else {
                                var6 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var6 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var6 = new double[2] {1.0, 0.0};
            }
            double[] var7;
            if (input[5] <= -1.2528996467590332) {
                if (input[4] <= 0.5878759026527405) {
                    if (input[1] <= -1.1505435109138489) {
                        if (input[1] <= -1.1990074515342712) {
                            var7 = new double[2] {0.1714836223506744, 0.8285163776493256};
                        } else {
                            var7 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        }
                    } else {
                        var7 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var7 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.48172637820243835) {
                    if (input[5] <= -0.02664858289062977) {
                        if (input[3] <= -1.2273457646369934) {
                            if (input[5] <= -0.8681837320327759) {
                                var7 = new double[2] {0.7563739376770539, 0.24362606232294617};
                            } else {
                                var7 = new double[2] {0.20554272517321018, 0.7944572748267898};
                            }
                        } else {
                            if (input[3] <= 1.0812246203422546) {
                                if (input[4] <= 0.2855096682906151) {
                                    var7 = new double[2] {0.0, 1.0};
                                } else {
                                    var7 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                }
                            } else {
                                var7 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            }
                        }
                    } else {
                        if (input[3] <= 1.0372334122657776) {
                            if (input[1] <= -1.5295565724372864) {
                                var7 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 1.3587095141410828) {
                                    if (input[0] <= -0.5072529651224613) {
                                        if (input[2] <= -0.15241484716534615) {
                                            var7 = new double[2] {0.0, 1.0};
                                        } else {
                                            var7 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= -0.5655285716056824) {
                                            if (input[5] <= 0.6233972907066345) {
                                                if (input[1] <= 0.06043438985943794) {
                                                    var7 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var7 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                                }
                                            } else {
                                                var7 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var7 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var7 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                }
                            }
                        } else {
                            if (input[2] <= -0.22914449125528336) {
                                var7 = new double[2] {0.7212317666126418, 0.2787682333873582};
                            } else {
                                var7 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var7 = new double[2] {1.0, 0.0};
                }
            }
            double[] var8;
            if (input[4] <= 0.5516729354858398) {
                if (input[3] <= 1.0000101029872894) {
                    if (input[1] <= -1.461210012435913) {
                        var8 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 0.23657159507274628) {
                            if (input[2] <= -0.13586653023958206) {
                                if (input[4] <= -2.288980722427368) {
                                    var8 = new double[2] {0.0, 1.0};
                                } else {
                                    var8 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var8 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 1.470549464225769) {
                                if (input[1] <= -1.1673194766044617) {
                                    var8 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                } else {
                                    if (input[2] <= -0.11968303844332695) {
                                        var8 = new double[2] {0.0, 1.0};
                                    } else {
                                        var8 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var8 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.2361653372645378) {
                        var8 = new double[2] {0.2564841498559078, 0.7435158501440922};
                    } else {
                        if (input[1] <= 0.7373766303062439) {
                            var8 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= 2.056975368410349) {
                                var8 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            } else {
                                var8 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                var8 = new double[2] {1.0, 0.0};
            }
            double[] var9;
            if (input[4] <= 0.5511365234851837) {
                if (input[3] <= 1.0000101029872894) {
                    if (input[1] <= -1.461210012435913) {
                        var9 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -0.43531621992588043) {
                            if (input[5] <= -1.39065283536911) {
                                if (input[2] <= -0.18694134801626205) {
                                    var9 = new double[2] {0.0, 1.0};
                                } else {
                                    var9 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                }
                            } else {
                                var9 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[4] <= -1.3794529438018799) {
                                if (input[4] <= -2.025833487510681) {
                                    var9 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                } else {
                                    if (input[2] <= -0.06337086856365204) {
                                        var9 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var9 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= 0.04332268424332142) {
                                    if (input[5] <= -0.08869954571127892) {
                                        if (input[3] <= -0.6322562098503113) {
                                            var9 = new double[2] {0.0, 1.0};
                                        } else {
                                            var9 = new double[2] {0.1714836223506744, 0.8285163776493256};
                                        }
                                    } else {
                                        if (input[1] <= -1.2418794631958008) {
                                            var9 = new double[2] {0.0, 1.0};
                                        } else {
                                            var9 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= -0.17035165056586266) {
                                        var9 = new double[2] {0.0, 1.0};
                                    } else {
                                        var9 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.22979753464460373) {
                        if (input[2] <= -0.2361653372645378) {
                            var9 = new double[2] {0.3409961685823755, 0.6590038314176245};
                        } else {
                            var9 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    } else {
                        if (input[2] <= -0.15688615292310715) {
                            var9 = new double[2] {0.8054298642533937, 0.1945701357466063};
                        } else {
                            var9 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var9 = new double[2] {1.0, 0.0};
            }
            double[] var10;
            if (input[4] <= 0.5473714768886566) {
                if (input[3] <= 0.9949342012405396) {
                    if (input[2] <= -0.14371255785226822) {
                        if (input[3] <= -1.4369081258773804) {
                            var10 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            if (input[1] <= -1.461210012435913) {
                                var10 = new double[2] {1.0, 0.0};
                            } else {
                                var10 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var10 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.2364112213253975) {
                        var10 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[5] <= -0.6828995645046234) {
                            var10 = new double[2] {0.0, 1.0};
                        } else {
                            var10 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var10 = new double[2] {1.0, 0.0};
            }
            double[] var11;
            if (input[1] <= -1.4587246775627136) {
                var11 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5460759997367859) {
                    if (input[5] <= 1.428570568561554) {
                        if (input[1] <= 1.3804562091827393) {
                            if (input[2] <= -0.1394634023308754) {
                                if (input[2] <= -0.2546585351228714) {
                                    var11 = new double[2] {0.0, 1.0};
                                } else {
                                    var11 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var11 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= -0.11492553725838661) {
                                var11 = new double[2] {0.0, 1.0};
                            } else {
                                var11 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= 1.534925937652588) {
                            var11 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -0.046124208718538284) {
                                var11 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= 1.9087209701538086) {
                                    var11 = new double[2] {1.0, 0.0};
                                } else {
                                    var11 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                }
                            }
                        }
                    }
                } else {
                    var11 = new double[2] {1.0, 0.0};
                }
            }
            double[] var12;
            if (input[2] <= -0.14339318126440048) {
                if (input[2] <= -0.2539795935153961) {
                    if (input[2] <= -0.2574715316295624) {
                        var12 = new double[2] {0.2564841498559078, 0.7435158501440922};
                    } else {
                        var12 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[2] <= -0.2518240213394165) {
                        var12 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= -1.46711266040802) {
                            var12 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.22254417091608047) {
                                if (input[1] <= 1.1163896918296814) {
                                    if (input[3] <= 0.5680746734142303) {
                                        if (input[4] <= 0.5128688216209412) {
                                            if (input[5] <= -1.458040177822113) {
                                                var12 = new double[2] {0.0, 1.0};
                                            } else {
                                                var12 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var12 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.5220992267131805) {
                                            var12 = new double[2] {0.0, 1.0};
                                        } else {
                                            var12 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= -0.5072529651224613) {
                                        var12 = new double[2] {0.20554272517321018, 0.7944572748267898};
                                    } else {
                                        if (input[3] <= -0.0018770471215248108) {
                                            var12 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                        } else {
                                            var12 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[4] <= 0.5399527549743652) {
                                    if (input[2] <= -0.2218211442232132) {
                                        var12 = new double[2] {0.0, 1.0};
                                    } else {
                                        var12 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[5] <= -1.208223044872284) {
                                        var12 = new double[2] {1.0, 0.0};
                                    } else {
                                        var12 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                var12 = new double[2] {1.0, 0.0};
            }
            double[] var13;
            if (input[2] <= -0.14371255785226822) {
                if (input[4] <= 0.544588178396225) {
                    if (input[3] <= 0.4525373876094818) {
                        if (input[1] <= -1.465869963169098) {
                            var13 = new double[2] {1.0, 0.0};
                        } else {
                            var13 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= -1.4494046568870544) {
                            var13 = new double[2] {1.0, 0.0};
                        } else {
                            var13 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var13 = new double[2] {1.0, 0.0};
                }
            } else {
                var13 = new double[2] {1.0, 0.0};
            }
            double[] var14;
            if (input[2] <= -0.14371255785226822) {
                if (input[3] <= 1.149628460407257) {
                    if (input[2] <= -0.24112878739833832) {
                        if (input[4] <= 0.5570573210716248) {
                            if (input[0] <= -0.5072529651224613) {
                                if (input[3] <= 0.23088949592784047) {
                                    var14 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.042614638805389404) {
                                        var14 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                    } else {
                                        var14 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= -1.3228211402893066) {
                                    var14 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var14 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var14 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 1.035663902759552) {
                            if (input[1] <= -1.465869963169098) {
                                var14 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= 0.5438999533653259) {
                                    if (input[1] <= -1.4105713367462158) {
                                        var14 = new double[2] {0.0, 1.0};
                                    } else {
                                        var14 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var14 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[4] <= 0.5147007405757904) {
                                if (input[2] <= -0.2360856682062149) {
                                    var14 = new double[2] {0.0, 1.0};
                                } else {
                                    var14 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var14 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.43719376623630524) {
                        var14 = new double[2] {0.3409961685823755, 0.6590038314176245};
                    } else {
                        var14 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var14 = new double[2] {1.0, 0.0};
            }
            double[] var15;
            if (input[4] <= 0.538991242647171) {
                if (input[1] <= -1.4789179563522339) {
                    var15 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.13955513387918472) {
                        if (input[5] <= -1.7001630067825317) {
                            var15 = new double[2] {0.0, 1.0};
                        } else {
                            var15 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var15 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var15 = new double[2] {1.0, 0.0};
            }
            double[] var16;
            if (input[3] <= 0.9927587807178497) {
                if (input[4] <= 0.5423109531402588) {
                    if (input[4] <= -0.783141165971756) {
                        if (input[1] <= 1.4177361726760864) {
                            if (input[3] <= 0.627293586730957) {
                                if (input[1] <= -1.1825421452522278) {
                                    if (input[2] <= -0.24072165042161942) {
                                        var16 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[1] <= -1.26921808719635) {
                                            var16 = new double[2] {0.0, 1.0};
                                        } else {
                                            var16 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var16 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var16 = new double[2] {0.6082004555808657, 0.3917995444191344};
                            }
                        } else {
                            if (input[0] <= 0.7256535552442074) {
                                var16 = new double[2] {1.0, 0.0};
                            } else {
                                var16 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[1] <= -1.4534432888031006) {
                                var16 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= 0.2522084340453148) {
                                    if (input[4] <= 0.21969250589609146) {
                                        if (input[4] <= -0.03183571808040142) {
                                            if (input[1] <= 0.379799522459507) {
                                                var16 = new double[2] {0.0, 1.0};
                                            } else {
                                                var16 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                            }
                                        } else {
                                            var16 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                        }
                                    } else {
                                        var16 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var16 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[0] <= 0.7256535552442074) {
                                if (input[1] <= 0.16947832703590393) {
                                    if (input[2] <= -0.15338967740535736) {
                                        if (input[3] <= -1.186013400554657) {
                                            var16 = new double[2] {0.0, 1.0};
                                        } else {
                                            var16 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var16 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= -0.8982163965702057) {
                                        var16 = new double[2] {0.0, 1.0};
                                    } else {
                                        var16 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var16 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var16 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= -0.8258649706840515) {
                    var16 = new double[2] {0.20554272517321018, 0.7944572748267898};
                } else {
                    if (input[4] <= -0.460107758641243) {
                        var16 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[0] <= 0.7256535552442074) {
                            if (input[2] <= -0.22071759402751923) {
                                var16 = new double[2] {1.0, 0.0};
                            } else {
                                var16 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            var16 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var17;
            if (input[3] <= 0.9927587807178497) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[0] <= 0.7256535552442074) {
                        if (input[3] <= 0.2388659194111824) {
                            if (input[1] <= -1.4633846282958984) {
                                var17 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= -1.2575594782829285) {
                                    if (input[3] <= -1.3552102446556091) {
                                        var17 = new double[2] {0.0, 1.0};
                                    } else {
                                        var17 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                    }
                                } else {
                                    if (input[4] <= -1.5875922441482544) {
                                        var17 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        if (input[5] <= -1.3864333629608154) {
                                            var17 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            if (input[3] <= 0.1383146345615387) {
                                                var17 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[2] <= -0.2157183140516281) {
                                                    var17 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var17 = new double[2] {0.20554272517321018, 0.7944572748267898};
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= -0.14375081658363342) {
                                if (input[2] <= -0.242063969373703) {
                                    if (input[0] <= -0.5072529651224613) {
                                        var17 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var17 = new double[2] {0.14710743801652895, 0.8528925619834711};
                                    }
                                } else {
                                    var17 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var17 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[1] <= 1.2916055917739868) {
                            var17 = new double[2] {0.0, 1.0};
                        } else {
                            var17 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        }
                    }
                } else {
                    var17 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= -0.2277468889951706) {
                    if (input[5] <= 0.6886749118566513) {
                        var17 = new double[2] {0.6742424242424242, 0.32575757575757575};
                    } else {
                        var17 = new double[2] {0.4369885433715221, 0.5630114566284778};
                    }
                } else {
                    if (input[4] <= -0.33590228855609894) {
                        if (input[1] <= 1.401270866394043) {
                            var17 = new double[2] {1.0, 0.0};
                        } else {
                            var17 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            var17 = new double[2] {1.0, 0.0};
                        } else {
                            var17 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var18;
            if (input[4] <= 0.5473714768886566) {
                if (input[2] <= -0.14371255785226822) {
                    if (input[1] <= -1.461210012435913) {
                        var18 = new double[2] {1.0, 0.0};
                    } else {
                        var18 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var18 = new double[2] {1.0, 0.0};
                }
            } else {
                var18 = new double[2] {1.0, 0.0};
            }
            double[] var19;
            if (input[2] <= -0.14371255785226822) {
                if (input[3] <= -1.3503760695457458) {
                    var19 = new double[2] {0.0, 1.0};
                } else {
                    if (input[4] <= 0.5460759997367859) {
                        if (input[1] <= -1.465869963169098) {
                            var19 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -1.296233057975769) {
                                var19 = new double[2] {0.0, 1.0};
                            } else {
                                var19 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var19 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var19 = new double[2] {1.0, 0.0};
            }
            double[] var20;
            if (input[1] <= -1.461210012435913) {
                var20 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.1163896918296814) {
                    if (input[4] <= 0.5460759997367859) {
                        if (input[5] <= 1.428570568561554) {
                            if (input[3] <= 1.41647607088089) {
                                if (input[1] <= -1.1825421452522278) {
                                    if (input[3] <= 0.2441835254430771) {
                                        if (input[1] <= -1.3316620588302612) {
                                            var20 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[2] <= -0.1857939511537552) {
                                                var20 = new double[2] {0.0, 1.0};
                                            } else {
                                                var20 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    } else {
                                        var20 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[5] <= -0.578033447265625) {
                                        if (input[5] <= -0.6956820487976074) {
                                            if (input[2] <= -0.1390100121498108) {
                                                var20 = new double[2] {0.0, 1.0};
                                            } else {
                                                var20 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var20 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    } else {
                                        if (input[2] <= -0.14909211546182632) {
                                            var20 = new double[2] {0.0, 1.0};
                                        } else {
                                            var20 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                        }
                                    }
                                }
                            } else {
                                var20 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.9813984334468842) {
                                if (input[4] <= -1.1189878582954407) {
                                    var20 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                } else {
                                    var20 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var20 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var20 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 0.026402998249977827) {
                        if (input[4] <= 0.6615065038204193) {
                            if (input[3] <= -0.4410637617111206) {
                                if (input[2] <= -0.1393158622086048) {
                                    var20 = new double[2] {0.0, 1.0};
                                } else {
                                    var20 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var20 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var20 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 0.8661028444766998) {
                            if (input[5] <= -0.3477002680301666) {
                                var20 = new double[2] {1.0, 0.0};
                            } else {
                                var20 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 1.2332600951194763) {
                                var20 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            } else {
                                var20 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var21;
            if (input[3] <= 0.9598862528800964) {
                if (input[5] <= -0.18922210484743118) {
                    if (input[4] <= 0.5555087924003601) {
                        if (input[1] <= -1.461210012435913) {
                            var21 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.13997770100831985) {
                                var21 = new double[2] {0.0, 1.0};
                            } else {
                                var21 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var21 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.203975647687912) {
                        if (input[1] <= -1.4021833539009094) {
                            if (input[4] <= -0.074040487408638) {
                                var21 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            } else {
                                var21 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.5018875002861023) {
                                if (input[5] <= -0.05370280332863331) {
                                    var21 = new double[2] {0.0, 1.0};
                                } else {
                                    var21 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var21 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= 1.1277475357055664) {
                            var21 = new double[2] {1.0, 0.0};
                        } else {
                            var21 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    }
                }
            } else {
                if (input[2] <= -0.14093896746635437) {
                    if (input[2] <= -0.18543940037488937) {
                        if (input[3] <= 1.0783240795135498) {
                            var21 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.4982236921787262) {
                                if (input[1] <= -1.1924834549427032) {
                                    var21 = new double[2] {1.0, 0.0};
                                } else {
                                    var21 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var21 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var21 = new double[2] {0.20554272517321018, 0.7944572748267898};
                    }
                } else {
                    if (input[2] <= -0.1350054144859314) {
                        var21 = new double[2] {1.0, 0.0};
                    } else {
                        var21 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var22;
            if (input[4] <= 0.5440517663955688) {
                if (input[2] <= -0.13962869346141815) {
                    if (input[3] <= 1.046901822090149) {
                        if (input[4] <= 0.13346119225025177) {
                            if (input[1] <= -1.4587246775627136) {
                                var22 = new double[2] {1.0, 0.0};
                            } else {
                                var22 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= -0.2289505898952484) {
                                if (input[2] <= -0.24087683856487274) {
                                    if (input[1] <= -0.9163009524345398) {
                                        var22 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    } else {
                                        var22 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var22 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var22 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -0.5174052268266678) {
                            var22 = new double[2] {1.0, 0.0};
                        } else {
                            var22 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var22 = new double[2] {1.0, 0.0};
                }
            } else {
                var22 = new double[2] {1.0, 0.0};
            }
            double[] var23;
            if (input[1] <= -1.4587246775627136) {
                var23 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.1163896918296814) {
                    if (input[3] <= 1.4036654829978943) {
                        if (input[2] <= -0.14335492253303528) {
                            if (input[1] <= 1.0023751258850098) {
                                if (input[2] <= -0.24967949092388153) {
                                    if (input[1] <= -0.038668212306220084) {
                                        if (input[0] <= 0.7256535552442074) {
                                            if (input[4] <= 0.6098284423351288) {
                                                var23 = new double[2] {0.0, 1.0};
                                            } else {
                                                var23 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var23 = new double[2] {0.8787023977433004, 0.12129760225669957};
                                        }
                                    } else {
                                        if (input[3] <= -1.155557930469513) {
                                            var23 = new double[2] {1.0, 0.0};
                                        } else {
                                            var23 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= -1.411129653453827) {
                                        var23 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[4] <= 0.5511365234851837) {
                                            if (input[4] <= -1.4770704507827759) {
                                                var23 = new double[2] {0.0, 1.0};
                                            } else {
                                                var23 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var23 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var23 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var23 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var23 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.5894244015216827) {
                        if (input[3] <= -0.8159556686878204) {
                            var23 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.16925349086523056) {
                                if (input[4] <= -0.5266738831996918) {
                                    var23 = new double[2] {0.408256880733945, 0.591743119266055};
                                } else {
                                    var23 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            } else {
                                if (input[2] <= -0.12972652539610863) {
                                    var23 = new double[2] {0.0, 1.0};
                                } else {
                                    var23 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 1.1300590634346008) {
                            var23 = new double[2] {1.0, 0.0};
                        } else {
                            var23 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var24;
            if (input[3] <= 0.956985741853714) {
                if (input[1] <= -1.461210012435913) {
                    var24 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.14335492253303528) {
                        if (input[4] <= 0.55467888712883) {
                            if (input[1] <= -1.4105713367462158) {
                                var24 = new double[2] {0.0, 1.0};
                            } else {
                                var24 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var24 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var24 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= -0.6721171438694) {
                    if (input[3] <= 1.2066720128059387) {
                        if (input[5] <= -1.0076742768287659) {
                            var24 = new double[2] {0.8054298642533937, 0.1945701357466063};
                        } else {
                            var24 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 0.8640309274196625) {
                            var24 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        } else {
                            var24 = new double[2] {0.3409961685823755, 0.6590038314176245};
                        }
                    }
                } else {
                    if (input[0] <= -0.5072529651224613) {
                        if (input[2] <= -0.15494853258132935) {
                            var24 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            var24 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= -0.14880464598536491) {
                            var24 = new double[2] {1.0, 0.0};
                        } else {
                            var24 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var25;
            if (input[3] <= 0.9876828789710999) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[1] <= -1.461210012435913) {
                        var25 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= -1.6169432401657104) {
                            if (input[0] <= -0.5072529651224613) {
                                var25 = new double[2] {0.0, 1.0};
                            } else {
                                var25 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= -0.13493400812149048) {
                                if (input[5] <= -1.507432758808136) {
                                    var25 = new double[2] {0.0, 1.0};
                                } else {
                                    var25 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var25 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var25 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= -0.8488238155841827) {
                    var25 = new double[2] {0.5085714285714286, 0.4914285714285714};
                } else {
                    if (input[3] <= 1.4280781745910645) {
                        if (input[0] <= 0.7256535552442074) {
                            if (input[2] <= -0.24102193862199783) {
                                var25 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 1.2397862076759338) {
                                    var25 = new double[2] {0.8922305764411028, 0.10776942355889725};
                                } else {
                                    var25 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var25 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= -1.246523141860962) {
                            var25 = new double[2] {1.0, 0.0};
                        } else {
                            var25 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var26;
            if (input[2] <= -0.14339318126440048) {
                if (input[1] <= -1.465869963169098) {
                    var26 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= -1.0403131246566772) {
                        if (input[3] <= 0.8018080592155457) {
                            if (input[0] <= 0.7256535552442074) {
                                if (input[2] <= -0.24830412864685059) {
                                    var26 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var26 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[4] <= 0.2667452394962311) {
                                    var26 = new double[2] {0.0, 1.0};
                                } else {
                                    var26 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.23878923803567886) {
                                var26 = new double[2] {0.0, 1.0};
                            } else {
                                var26 = new double[2] {0.6082004555808657, 0.3917995444191344};
                            }
                        }
                    } else {
                        if (input[4] <= 0.5423109531402588) {
                            if (input[1] <= -1.3701847195625305) {
                                var26 = new double[2] {0.0, 1.0};
                            } else {
                                var26 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var26 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var26 = new double[2] {1.0, 0.0};
            }
            double[] var27;
            if (input[4] <= 0.5349428355693817) {
                if (input[5] <= 1.428570568561554) {
                    if (input[2] <= -0.14371255785226822) {
                        if (input[4] <= 0.4553306847810745) {
                            if (input[1] <= -1.4894806146621704) {
                                var27 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.25881578028202057) {
                                    var27 = new double[2] {0.0, 1.0};
                                } else {
                                    var27 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[1] <= -1.0178889036178589) {
                                var27 = new double[2] {1.0, 0.0};
                            } else {
                                var27 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var27 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 1.281601995229721) {
                        var27 = new double[2] {0.3409961685823755, 0.6590038314176245};
                    } else {
                        var27 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var27 = new double[2] {1.0, 0.0};
            }
            double[] var28;
            if (input[3] <= 0.9062266945838928) {
                if (input[1] <= -1.461210012435913) {
                    var28 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.5460759997367859) {
                        if (input[1] <= 1.921637237071991) {
                            if (input[2] <= -0.13955513387918472) {
                                var28 = new double[2] {0.0, 1.0};
                            } else {
                                var28 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var28 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var28 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= -0.2277468889951706) {
                    if (input[1] <= 0.9554644525051117) {
                        if (input[3] <= 1.1070875525474548) {
                            var28 = new double[2] {1.0, 0.0};
                        } else {
                            var28 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var28 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[3] <= 1.039408802986145) {
                        if (input[4] <= 0.5337789058685303) {
                            var28 = new double[2] {0.408256880733945, 0.591743119266055};
                        } else {
                            var28 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 1.1109549403190613) {
                            var28 = new double[2] {1.0, 0.0};
                        } else {
                            var28 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var29;
            if (input[4] <= 0.5440517663955688) {
                if (input[4] <= -1.4611297845840454) {
                    if (input[0] <= -0.5072529651224613) {
                        var29 = new double[2] {0.5085714285714286, 0.4914285714285714};
                    } else {
                        if (input[3] <= 0.4230487793684006) {
                            var29 = new double[2] {0.3409961685823755, 0.6590038314176245};
                        } else {
                            var29 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.0372334122657776) {
                        if (input[2] <= -0.14371255785226822) {
                            if (input[1] <= -1.461210012435913) {
                                var29 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= -1.5431740880012512) {
                                    var29 = new double[2] {0.0, 1.0};
                                } else {
                                    var29 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var29 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= -0.2361653372645378) {
                            var29 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.22979753464460373) {
                                var29 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            } else {
                                var29 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                var29 = new double[2] {1.0, 0.0};
            }
            double[] var30;
            if (input[4] <= 0.5349428355693817) {
                if (input[2] <= -0.13966695219278336) {
                    if (input[3] <= 1.0372334122657776) {
                        if (input[3] <= 0.4525373876094818) {
                            if (input[1] <= -1.4229980111122131) {
                                var30 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                var30 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= -1.4450553059577942) {
                                var30 = new double[2] {1.0, 0.0};
                            } else {
                                var30 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -1.3503020405769348) {
                            var30 = new double[2] {1.0, 0.0};
                        } else {
                            var30 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var30 = new double[2] {1.0, 0.0};
                }
            } else {
                var30 = new double[2] {1.0, 0.0};
            }
            double[] var31;
            if (input[3] <= 0.8496665954589844) {
                if (input[1] <= 1.1157683730125427) {
                    if (input[3] <= -1.3503760695457458) {
                        var31 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= -0.1983807012438774) {
                            if (input[4] <= 0.5460759997367859) {
                                if (input[3] <= -1.3228211402893066) {
                                    var31 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    if (input[2] <= -0.2483716905117035) {
                                        if (input[1] <= -1.5149552822113037) {
                                            var31 = new double[2] {1.0, 0.0};
                                        } else {
                                            var31 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[1] <= -1.465869963169098) {
                                            var31 = new double[2] {1.0, 0.0};
                                        } else {
                                            var31 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var31 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.3283216878771782) {
                                if (input[2] <= -0.1514245793223381) {
                                    var31 = new double[2] {0.0, 1.0};
                                } else {
                                    var31 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var31 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.17378728091716766) {
                        if (input[3] <= -0.5227616727352142) {
                            var31 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= 0.03075377270579338) {
                                var31 = new double[2] {0.2927631578947369, 0.7072368421052632};
                            } else {
                                var31 = new double[2] {0.8612903225806452, 0.13870967741935486};
                            }
                        }
                    } else {
                        var31 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= -0.23983244597911835) {
                    if (input[2] <= -0.24928683787584305) {
                        var31 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 0.8753242194652557) {
                            var31 = new double[2] {0.0, 1.0};
                        } else {
                            var31 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.15622054785490036) {
                        if (input[1] <= -0.9293489754199982) {
                            var31 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.5446489155292511) {
                                var31 = new double[2] {0.0, 1.0};
                            } else {
                                var31 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[1] <= 0.13406234607100487) {
                            var31 = new double[2] {1.0, 0.0};
                        } else {
                            var31 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var32;
            if (input[1] <= -1.4587246775627136) {
                var32 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.14093896746635437) {
                    if (input[5] <= 0.2374403029680252) {
                        if (input[5] <= -0.2166486233472824) {
                            if (input[1] <= -1.1101568341255188) {
                                var32 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -1.3675698637962341) {
                                    if (input[4] <= 0.5499725639820099) {
                                        var32 = new double[2] {0.0, 1.0};
                                    } else {
                                        var32 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= -1.136119782924652) {
                                        var32 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[4] <= 0.571247011423111) {
                                            if (input[0] <= -0.5072529651224613) {
                                                var32 = new double[2] {0.0, 1.0};
                                            } else {
                                                var32 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            if (input[5] <= -1.1227167844772339) {
                                                var32 = new double[2] {1.0, 0.0};
                                            } else {
                                                var32 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= -0.06487197801470757) {
                                if (input[4] <= 0.08222848176956177) {
                                    var32 = new double[2] {0.0, 1.0};
                                } else {
                                    var32 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[5] <= -0.013617880875244737) {
                                    var32 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -0.21015610918402672) {
                                        if (input[5] <= 0.07399807684123516) {
                                            var32 = new double[2] {0.20554272517321018, 0.7944572748267898};
                                        } else {
                                            var32 = new double[2] {0.5085714285714287, 0.4914285714285714};
                                        }
                                    } else {
                                        if (input[5] <= 0.15776687860488892) {
                                            if (input[1] <= 0.246212936937809) {
                                                var32 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                            } else {
                                                var32 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var32 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 1.3131557703018188) {
                            if (input[5] <= 1.1214183568954468) {
                                if (input[5] <= 0.863658607006073) {
                                    if (input[2] <= -0.20717112720012665) {
                                        if (input[2] <= -0.2247423380613327) {
                                            if (input[4] <= 0.5347606539726257) {
                                                var32 = new double[2] {0.0, 1.0};
                                            } else {
                                                var32 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[1] <= -0.35834401100873947) {
                                                var32 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[4] <= 0.5590309202671051) {
                                                    var32 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var32 = new double[2] {1.0, 0.0};
                                                }
                                            }
                                        }
                                    } else {
                                        var32 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[2] <= -0.2227599322795868) {
                                        if (input[1] <= 0.5286087393760681) {
                                            if (input[1] <= -0.7491624057292938) {
                                                var32 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            } else {
                                                var32 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var32 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                        }
                                    } else {
                                        var32 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[2] <= -0.2385980486869812) {
                                    var32 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                } else {
                                    var32 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[3] <= 0.43368400633335114) {
                                if (input[2] <= -0.22856705635786057) {
                                    var32 = new double[2] {0.408256880733945, 0.591743119266055};
                                } else {
                                    if (input[3] <= -0.6996932625770569) {
                                        var32 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                    } else {
                                        var32 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var32 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var32 = new double[2] {1.0, 0.0};
                }
            }
            double[] var33;
            if (input[1] <= -1.4587246775627136) {
                var33 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5511365234851837) {
                    if (input[1] <= 1.641416072845459) {
                        if (input[2] <= -0.13959339261054993) {
                            if (input[2] <= -0.2555154860019684) {
                                var33 = new double[2] {0.0, 1.0};
                            } else {
                                var33 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var33 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 1.921637237071991) {
                            if (input[3] <= 1.0050860345363617) {
                                var33 = new double[2] {0.7563739376770539, 0.24362606232294617};
                            } else {
                                var33 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            }
                        } else {
                            var33 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var33 = new double[2] {1.0, 0.0};
                }
            }
            double[] var34;
            if (input[4] <= 0.5423109531402588) {
                if (input[1] <= -1.4534432888031006) {
                    var34 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.41647607088089) {
                        if (input[1] <= 1.1319230198860168) {
                            if (input[1] <= -1.1694941520690918) {
                                if (input[2] <= -0.15106821432709694) {
                                    var34 = new double[2] {0.0, 1.0};
                                } else {
                                    var34 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= -0.13966695219278336) {
                                    if (input[5] <= -1.5523576140403748) {
                                        var34 = new double[2] {0.0, 1.0};
                                    } else {
                                        var34 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var34 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[5] <= -0.43531621992588043) {
                                var34 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= -0.13096297159790993) {
                                    var34 = new double[2] {0.0, 1.0};
                                } else {
                                    var34 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var34 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var34 = new double[2] {1.0, 0.0};
            }
            double[] var35;
            if (input[1] <= -1.46711266040802) {
                var35 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.1163896918296814) {
                    if (input[3] <= 1.4036654829978943) {
                        if (input[4] <= 0.5460759997367859) {
                            if (input[1] <= -1.188755452632904) {
                                if (input[3] <= 0.1525755152106285) {
                                    if (input[0] <= -0.5072529651224613) {
                                        var35 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                    } else {
                                        if (input[3] <= -0.5358140021562576) {
                                            var35 = new double[2] {0.0, 1.0};
                                        } else {
                                            var35 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    }
                                } else {
                                    var35 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[3] <= 0.9949342012405396) {
                                    if (input[2] <= -0.14723016321659088) {
                                        var35 = new double[2] {0.0, 1.0};
                                    } else {
                                        var35 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                } else {
                                    if (input[1] <= 0.5130754262208939) {
                                        var35 = new double[2] {0.0, 1.0};
                                    } else {
                                        var35 = new double[2] {0.408256880733945, 0.591743119266055};
                                    }
                                }
                            }
                        } else {
                            var35 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var35 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.1372602991759777) {
                        if (input[4] <= 0.5119882822036743) {
                            if (input[1] <= 1.1884642839431763) {
                                var35 = new double[2] {0.0, 1.0};
                            } else {
                                var35 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var35 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= -2.025833487510681) {
                            var35 = new double[2] {1.0, 0.0};
                        } else {
                            var35 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var36;
            if (input[1] <= -1.46711266040802) {
                var36 = new double[2] {1.0, 0.0};
            } else {
                if (input[5] <= -0.269143745303154) {
                    if (input[2] <= -0.24443994462490082) {
                        if (input[2] <= -0.2538330405950546) {
                            var36 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.5277091264724731) {
                                if (input[2] <= -0.24809630215168) {
                                    if (input[4] <= 0.6091300845146179) {
                                        var36 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var36 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var36 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            } else {
                                if (input[2] <= -0.24895895272493362) {
                                    var36 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var36 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                }
                            }
                        }
                    } else {
                        if (input[4] <= 0.551743745803833) {
                            if (input[3] <= 1.0000101029872894) {
                                if (input[1] <= 1.487636148929596) {
                                    if (input[2] <= -0.13586653023958206) {
                                        var36 = new double[2] {0.0, 1.0};
                                    } else {
                                        var36 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var36 = new double[2] {0.408256880733945, 0.591743119266055};
                                }
                            } else {
                                var36 = new double[2] {0.408256880733945, 0.591743119266055};
                            }
                        } else {
                            var36 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[0] <= 0.7256535552442074) {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[2] <= -0.17240721732378006) {
                                if (input[1] <= 0.9051365256309509) {
                                    if (input[5] <= 0.3851215988397598) {
                                        var36 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[3] <= -0.46499304473400116) {
                                            if (input[4] <= 0.3208827171474695) {
                                                var36 = new double[2] {0.0, 1.0};
                                            } else {
                                                var36 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[3] <= 0.14194027706980705) {
                                                var36 = new double[2] {0.0, 1.0};
                                            } else {
                                                var36 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                            }
                                        }
                                    }
                                } else {
                                    var36 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var36 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[5] <= -0.1294049769639969) {
                                var36 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.20160619169473648) {
                                    if (input[4] <= 0.33835165202617645) {
                                        var36 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= -1.0483342409133911) {
                                            var36 = new double[2] {1.0, 0.0};
                                        } else {
                                            var36 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 1.2642669081687927) {
                                        var36 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[1] <= 1.5572254061698914) {
                                            var36 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var36 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[4] <= 0.5507012903690338) {
                            if (input[4] <= -1.2169190645217896) {
                                var36 = new double[2] {0.7563739376770539, 0.24362606232294617};
                            } else {
                                if (input[2] <= 2.06598462164402) {
                                    var36 = new double[2] {0.0, 1.0};
                                } else {
                                    var36 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= -0.6424080431461334) {
                                var36 = new double[2] {1.0, 0.0};
                            } else {
                                var36 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var37;
            if (input[4] <= 0.5479078888893127) {
                if (input[2] <= -0.13955513387918472) {
                    if (input[4] <= 0.3310442417860031) {
                        if (input[3] <= 1.020313709974289) {
                            if (input[2] <= -0.24466286599636078) {
                                if (input[1] <= -1.388824701309204) {
                                    var37 = new double[2] {1.0, 0.0};
                                } else {
                                    var37 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[3] <= 0.8151021003723145) {
                                    if (input[4] <= 0.1458088681101799) {
                                        if (input[4] <= -1.9185503721237183) {
                                            var37 = new double[2] {0.0, 1.0};
                                        } else {
                                            var37 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.21262801438570023) {
                                            var37 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                        } else {
                                            var37 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 0.22329269349575043) {
                                        var37 = new double[2] {0.0, 1.0};
                                    } else {
                                        var37 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= -0.23883775621652603) {
                                var37 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                var37 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.2411791980266571) {
                            var37 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[0] <= -0.5072529651224613) {
                                if (input[4] <= 0.46747593581676483) {
                                    var37 = new double[2] {1.0, 0.0};
                                } else {
                                    var37 = new double[2] {0.4369885433715221, 0.5630114566284778};
                                }
                            } else {
                                var37 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var37 = new double[2] {1.0, 0.0};
                }
            } else {
                var37 = new double[2] {1.0, 0.0};
            }
            double[] var38;
            if (input[4] <= 0.5511365234851837) {
                if (input[3] <= 1.0000101029872894) {
                    if (input[4] <= -1.5875922441482544) {
                        if (input[4] <= -2.163479804992676) {
                            var38 = new double[2] {0.0, 1.0};
                        } else {
                            var38 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= -1.240398108959198) {
                            if (input[0] <= 0.7256535552442074) {
                                if (input[2] <= -0.22485560178756714) {
                                    if (input[3] <= -1.3552102446556091) {
                                        var38 = new double[2] {0.0, 1.0};
                                    } else {
                                        var38 = new double[2] {0.408256880733945, 0.591743119266055};
                                    }
                                } else {
                                    var38 = new double[2] {0.8054298642533937, 0.1945701357466063};
                                }
                            } else {
                                var38 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= -1.465869963169098) {
                                var38 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.11664692685008049) {
                                    if (input[2] <= -0.2535204440355301) {
                                        var38 = new double[2] {0.0, 1.0};
                                    } else {
                                        var38 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var38 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.15494853258132935) {
                        if (input[5] <= 0.11321428418159485) {
                            var38 = new double[2] {0.0, 1.0};
                        } else {
                            var38 = new double[2] {0.6082004555808657, 0.3917995444191344};
                        }
                    } else {
                        var38 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var38 = new double[2] {1.0, 0.0};
            }
            double[] var39;
            if (input[4] <= 0.5511365234851837) {
                if (input[1] <= -1.477053940296173) {
                    var39 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.0174131989479065) {
                        if (input[2] <= -0.13955513387918472) {
                            if (input[1] <= -1.386650025844574) {
                                var39 = new double[2] {0.0, 1.0};
                            } else {
                                var39 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var39 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 0.17464473843574524) {
                            var39 = new double[2] {0.2564841498559078, 0.7435158501440922};
                        } else {
                            var39 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var39 = new double[2] {1.0, 0.0};
            }
            double[] var40;
            if (input[4] <= 0.5423109531402588) {
                if (input[1] <= -1.4894806146621704) {
                    var40 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 1.428570568561554) {
                        if (input[5] <= -0.6215932071208954) {
                            if (input[2] <= -0.13586653023958206) {
                                var40 = new double[2] {0.0, 1.0};
                            } else {
                                var40 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 1.1325443387031555) {
                                if (input[4] <= -0.4758763462305069) {
                                    if (input[2] <= -0.14291485399007797) {
                                        var40 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[4] <= -1.0897278785705566) {
                                            var40 = new double[2] {1.0, 0.0};
                                        } else {
                                            var40 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var40 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[0] <= -0.5072529651224613) {
                                    if (input[2] <= -0.13196676596999168) {
                                        var40 = new double[2] {0.0, 1.0};
                                    } else {
                                        var40 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= -0.018313314765691757) {
                                        var40 = new double[2] {0.4369885433715221, 0.563011456628478};
                                    } else {
                                        var40 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[2] <= -0.15149813890457153) {
                            var40 = new double[2] {0.0, 1.0};
                        } else {
                            var40 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var40 = new double[2] {1.0, 0.0};
            }
            double[] var41;
            if (input[4] <= 0.5473714768886566) {
                if (input[2] <= -0.13955513387918472) {
                    if (input[4] <= 0.12440285831689835) {
                        if (input[4] <= -1.4611297845840454) {
                            var41 = new double[2] {0.3409961685823755, 0.6590038314176245};
                        } else {
                            if (input[1] <= -1.5419832468032837) {
                                var41 = new double[2] {1.0, 0.0};
                            } else {
                                var41 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -1.3990767002105713) {
                            var41 = new double[2] {1.0, 0.0};
                        } else {
                            var41 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var41 = new double[2] {1.0, 0.0};
                }
            } else {
                var41 = new double[2] {1.0, 0.0};
            }
            double[] var42;
            if (input[3] <= 1.306498110294342) {
                if (input[4] <= 0.5423109531402588) {
                    if (input[2] <= -0.14689429849386215) {
                        if (input[3] <= 1.0372334122657776) {
                            if (input[1] <= -1.461210012435913) {
                                var42 = new double[2] {1.0, 0.0};
                            } else {
                                var42 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[1] <= -1.100836843252182) {
                                var42 = new double[2] {1.0, 0.0};
                            } else {
                                var42 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var42 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var42 = new double[2] {1.0, 0.0};
                }
            } else {
                var42 = new double[2] {1.0, 0.0};
            }
            double[] var43;
            if (input[2] <= -0.14375081658363342) {
                if (input[4] <= 0.5089722275733948) {
                    if (input[2] <= -0.2546776980161667) {
                        var43 = new double[2] {0.8612903225806452, 0.13870967741935483};
                    } else {
                        if (input[1] <= -1.4379099607467651) {
                            var43 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.359622061252594) {
                                var43 = new double[2] {0.0, 1.0};
                            } else {
                                var43 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.5440517663955688) {
                        var43 = new double[2] {0.6742424242424242, 0.32575757575757575};
                    } else {
                        var43 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var43 = new double[2] {1.0, 0.0};
            }
            double[] var44;
            if (input[2] <= -0.14375081658363342) {
                if (input[4] <= 0.5516729354858398) {
                    if (input[1] <= -1.461210012435913) {
                        var44 = new double[2] {1.0, 0.0};
                    } else {
                        var44 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var44 = new double[2] {1.0, 0.0};
                }
            } else {
                var44 = new double[2] {1.0, 0.0};
            }
            double[] var45;
            if (input[1] <= -1.4587246775627136) {
                var45 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.4280781745910645) {
                    if (input[2] <= -0.13959339261054993) {
                        if (input[4] <= 0.5460759997367859) {
                            if (input[3] <= -1.4692972898483276) {
                                var45 = new double[2] {0.0, 1.0};
                            } else {
                                var45 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var45 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var45 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var45 = new double[2] {1.0, 0.0};
                }
            }
            double[] var46;
            if (input[1] <= -1.461210012435913) {
                var46 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.1465366631746292) {
                    if (input[3] <= -1.1045571565628052) {
                        if (input[4] <= 0.4586099088191986) {
                            var46 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.25241391360759735) {
                                var46 = new double[2] {1.0, 0.0};
                            } else {
                                var46 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[1] <= -1.1070501804351807) {
                            if (input[4] <= 0.46905482560396194) {
                                if (input[0] <= -0.5072529651224613) {
                                    var46 = new double[2] {0.0, 1.0};
                                } else {
                                    var46 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var46 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.690621554851532) {
                                if (input[4] <= 0.5555087924003601) {
                                    if (input[0] <= -0.5072529651224613) {
                                        var46 = new double[2] {0.0, 1.0};
                                    } else {
                                        var46 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var46 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.5337789058685303) {
                                    var46 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -0.8454690277576447) {
                                        var46 = new double[2] {1.0, 0.0};
                                    } else {
                                        var46 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var46 = new double[2] {1.0, 0.0};
                }
            }
            double[] var47;
            if (input[1] <= -1.3509233593940735) {
                if (input[2] <= -0.22740191966295242) {
                    var47 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.2238156497478485) {
                        var47 = new double[2] {0.6742424242424242, 0.32575757575757575};
                    } else {
                        var47 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= -0.14335492253303528) {
                    if (input[2] <= -0.23311058431863785) {
                        if (input[2] <= -0.23782726377248764) {
                            if (input[4] <= 0.5473714768886566) {
                                var47 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -1.3315802812576294) {
                                    var47 = new double[2] {1.0, 0.0};
                                } else {
                                    var47 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.2365684136748314) {
                                var47 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 0.5813687145709991) {
                                    var47 = new double[2] {0.0, 1.0};
                                } else {
                                    var47 = new double[2] {0.8922305764411028, 0.10776942355889724};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -0.2682507187128067) {
                            if (input[2] <= -0.2051476389169693) {
                                if (input[4] <= 0.41811560094356537) {
                                    var47 = new double[2] {0.0, 1.0};
                                } else {
                                    var47 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                }
                            } else {
                                if (input[2] <= -0.18185626715421677) {
                                    var47 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[5] <= 0.4878779947757721) {
                                        var47 = new double[2] {0.0, 1.0};
                                    } else {
                                        var47 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= -1.134630560874939) {
                                var47 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= 0.7078633010387421) {
                                    if (input[5] <= 0.3580673784017563) {
                                        if (input[2] <= -0.23103339225053787) {
                                            var47 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[4] <= 0.45019931346178055) {
                                                var47 = new double[2] {0.0, 1.0};
                                            } else {
                                                var47 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    } else {
                                        if (input[2] <= -0.1750960424542427) {
                                            if (input[3] <= -0.8539040982723236) {
                                                var47 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            } else {
                                                var47 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var47 = new double[2] {0.8054298642533937, 0.1945701357466063};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.5871674120426178) {
                                        var47 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[0] <= -0.5072529651224613) {
                                            var47 = new double[2] {1.0, 0.0};
                                        } else {
                                            var47 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var47 = new double[2] {1.0, 0.0};
                }
            }
            double[] var48;
            if (input[4] <= 0.5511365234851837) {
                if (input[4] <= -1.333321213722229) {
                    if (input[0] <= 0.7256535552442074) {
                        if (input[5] <= 0.2000856250524521) {
                            var48 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[4] <= -1.5934624671936035) {
                                var48 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -1.4174068570137024) {
                                    var48 = new double[2] {0.0, 1.0};
                                } else {
                                    var48 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            }
                        }
                    } else {
                        var48 = new double[2] {0.8787023977433005, 0.12129760225669957};
                    }
                } else {
                    if (input[2] <= -0.13955513387918472) {
                        if (input[1] <= -1.4633846282958984) {
                            var48 = new double[2] {1.0, 0.0};
                        } else {
                            var48 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var48 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var48 = new double[2] {1.0, 0.0};
            }
            double[] var49;
            if (input[5] <= -0.3027753680944443) {
                if (input[3] <= 1.0000101029872894) {
                    if (input[2] <= -0.13497226685285568) {
                        if (input[4] <= 0.5570573210716248) {
                            if (input[2] <= -0.24814705550670624) {
                                if (input[1] <= -0.8836810030043125) {
                                    var49 = new double[2] {1.0, 0.0};
                                } else {
                                    var49 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var49 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var49 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var49 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var49 = new double[2] {0.8054298642533937, 0.1945701357466063};
                }
            } else {
                if (input[4] <= 0.5400033593177795) {
                    if (input[3] <= 0.9956593215465546) {
                        if (input[1] <= -1.1673194766044617) {
                            if (input[3] <= 0.4385182112455368) {
                                if (input[1] <= -1.3586900234222412) {
                                    var49 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var49 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var49 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[4] <= -1.4537211656570435) {
                                var49 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                if (input[5] <= 0.469635009765625) {
                                    if (input[5] <= 0.0264670392498374) {
                                        var49 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= 0.8541871905326843) {
                                            var49 = new double[2] {0.0, 1.0};
                                        } else {
                                            var49 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    }
                                } else {
                                    if (input[3] <= -1.189155638217926) {
                                        var49 = new double[2] {0.0, 1.0};
                                    } else {
                                        var49 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[2] <= -0.22914449125528336) {
                            var49 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            var49 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var49 = new double[2] {1.0, 0.0};
                }
            }
            double[] var50;
            if (input[4] <= 0.55467888712883) {
                if (input[3] <= 1.0372334122657776) {
                    if (input[0] <= 0.7256535552442074) {
                        if (input[1] <= -1.461210012435913) {
                            var50 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.13959339261054993) {
                                if (input[2] <= -0.2555154860019684) {
                                    var50 = new double[2] {0.0, 1.0};
                                } else {
                                    var50 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= -0.9025599658489227) {
                                    var50 = new double[2] {1.0, 0.0};
                                } else {
                                    var50 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[2] <= 0.3749120756983757) {
                            if (input[1] <= -1.3235847353935242) {
                                var50 = new double[2] {0.20554272517321018, 0.7944572748267898};
                            } else {
                                var50 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var50 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.1924834549427032) {
                        var50 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= 1.444031000137329) {
                            if (input[2] <= -0.15494853258132935) {
                                var50 = new double[2] {0.0, 1.0};
                            } else {
                                var50 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var50 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var50 = new double[2] {1.0, 0.0};
            }
            double[] var51;
            if (input[4] <= 0.5423109531402588) {
                if (input[2] <= -0.13962869346141815) {
                    if (input[4] <= 0.1271962672472) {
                        if (input[0] <= -0.5072529651224613) {
                            var51 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.2546776980161667) {
                                var51 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                if (input[4] <= -0.9248054325580597) {
                                    if (input[3] <= 0.691346675157547) {
                                        if (input[4] <= -1.1784388422966003) {
                                            var51 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[1] <= -0.5947611778974533) {
                                                var51 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                            } else {
                                                var51 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        var51 = new double[2] {0.8054298642533937, 0.1945701357466063};
                                    }
                                } else {
                                    var51 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.3670780062675476) {
                            var51 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.0896528959274292) {
                                var51 = new double[2] {0.0, 1.0};
                            } else {
                                var51 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var51 = new double[2] {1.0, 0.0};
                }
            } else {
                var51 = new double[2] {1.0, 0.0};
            }
            double[] var52;
            if (input[3] <= 0.9062266945838928) {
                if (input[3] <= 0.7172096073627472) {
                    if (input[5] <= 1.1436325907707214) {
                        if (input[5] <= 1.1091322302818298) {
                            if (input[2] <= -0.14371255785226822) {
                                if (input[3] <= -1.340224266052246) {
                                    if (input[2] <= -0.22549985349178314) {
                                        var52 = new double[2] {0.0, 1.0};
                                    } else {
                                        var52 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    }
                                } else {
                                    if (input[1] <= -1.465869963169098) {
                                        var52 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[4] <= 0.55467888712883) {
                                            if (input[1] <= -1.359622061252594) {
                                                var52 = new double[2] {0.0, 1.0};
                                            } else {
                                                var52 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var52 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var52 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var52 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[1] <= 0.18687564134597778) {
                                var52 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            } else {
                                var52 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.11390194296836853) {
                                var52 = new double[2] {0.0, 1.0};
                            } else {
                                var52 = new double[2] {0.2564841498559078, 0.7435158501440922};
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.22864419966936111) {
                        if (input[4] <= 0.4579823911190033) {
                            var52 = new double[2] {0.0, 1.0};
                        } else {
                            var52 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        }
                    } else {
                        var52 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[1] <= -0.9293489754199982) {
                    if (input[4] <= -1.1079558730125427) {
                        var52 = new double[2] {0.5085714285714286, 0.4914285714285714};
                    } else {
                        var52 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.14093896746635437) {
                        if (input[2] <= -0.24102193862199783) {
                            var52 = new double[2] {0.7212317666126418, 0.2787682333873582};
                        } else {
                            if (input[0] <= 0.7256535552442074) {
                                var52 = new double[2] {0.0, 1.0};
                            } else {
                                var52 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.1350054144859314) {
                            var52 = new double[2] {1.0, 0.0};
                        } else {
                            var52 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var53;
            if (input[2] <= -0.14090070873498917) {
                if (input[5] <= -0.16464991867542267) {
                    if (input[4] <= 0.5793236196041107) {
                        if (input[4] <= -1.099221408367157) {
                            if (input[1] <= -1.4894806146621704) {
                                var53 = new double[2] {1.0, 0.0};
                            } else {
                                var53 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[4] <= 0.32863543927669525) {
                                var53 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[1] <= -1.3990767002105713) {
                                    var53 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[1] <= -1.0318689048290253) {
                                        var53 = new double[2] {0.0, 1.0};
                                    } else {
                                        var53 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var53 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= -1.3751553893089294) {
                        var53 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 0.5157128572463989) {
                            if (input[0] <= -0.5072529651224613) {
                                var53 = new double[2] {0.0, 1.0};
                            } else {
                                var53 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var53 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var53 = new double[2] {1.0, 0.0};
            }
            double[] var54;
            if (input[2] <= -0.14371255785226822) {
                if (input[5] <= 1.2590473294258118) {
                    if (input[4] <= 0.5511365234851837) {
                        if (input[3] <= 1.0372334122657776) {
                            if (input[3] <= -1.4794490933418274) {
                                var54 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            } else {
                                if (input[4] <= 0.1458088681101799) {
                                    if (input[5] <= 1.0227573215961456) {
                                        if (input[3] <= 0.6294689774513245) {
                                            var54 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[1] <= -0.4037013202905655) {
                                                var54 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            } else {
                                                var54 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        if (input[3] <= 0.7694189250469208) {
                                            var54 = new double[2] {0.0, 1.0};
                                        } else {
                                            var54 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    }
                                } else {
                                    if (input[1] <= -1.3990767002105713) {
                                        var54 = new double[2] {1.0, 0.0};
                                    } else {
                                        var54 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= -0.5349427759647369) {
                                if (input[4] <= -1.1079558730125427) {
                                    var54 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                } else {
                                    var54 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var54 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var54 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[5] <= 1.4154157638549805) {
                        if (input[3] <= -0.23150135576725006) {
                            var54 = new double[2] {1.0, 0.0};
                        } else {
                            var54 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    } else {
                        var54 = new double[2] {0.2564841498559078, 0.7435158501440922};
                    }
                }
            } else {
                var54 = new double[2] {1.0, 0.0};
            }
            double[] var55;
            if (input[1] <= -1.461210012435913) {
                var55 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.3439631462097168) {
                    if (input[2] <= -0.13966695219278336) {
                        if (input[5] <= -1.128177285194397) {
                            if (input[1] <= 0.7218433022499084) {
                                if (input[1] <= 0.14431433379650116) {
                                    var55 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[2] <= -0.24378838390111923) {
                                        var55 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var55 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var55 = new double[2] {0.4250238777459408, 0.5749761222540593};
                            }
                        } else {
                            if (input[1] <= 0.4907074421644211) {
                                if (input[4] <= 0.5490616858005524) {
                                    if (input[0] <= -0.5072529651224613) {
                                        var55 = new double[2] {0.0, 1.0};
                                    } else {
                                        var55 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var55 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 0.9051365256309509) {
                                    if (input[2] <= -0.19340337812900543) {
                                        if (input[3] <= 0.6956974565982819) {
                                            if (input[4] <= 0.5945355296134949) {
                                                if (input[5] <= -0.5595422461628914) {
                                                    var55 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var55 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var55 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[4] <= 0.6185325384140015) {
                                                var55 = new double[2] {1.0, 0.0};
                                            } else {
                                                var55 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    } else {
                                        var55 = new double[2] {0.1714836223506744, 0.8285163776493256};
                                    }
                                } else {
                                    if (input[5] <= 0.1913985013961792) {
                                        if (input[5] <= -0.18227239698171616) {
                                            if (input[2] <= -0.20702126622200012) {
                                                if (input[4] <= 0.6093122661113739) {
                                                    var55 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var55 = new double[2] {1.0, 0.0};
                                                }
                                            } else {
                                                var55 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            if (input[2] <= -0.22178324311971664) {
                                                var55 = new double[2] {0.8612903225806452, 0.13870967741935486};
                                            } else {
                                                var55 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                            }
                                        }
                                    } else {
                                        if (input[1] <= 1.2655096054077148) {
                                            var55 = new double[2] {0.0, 1.0};
                                        } else {
                                            var55 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var55 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var55 = new double[2] {1.0, 0.0};
                }
            }
            double[] var56;
            if (input[4] <= 0.5516729354858398) {
                if (input[5] <= 1.4218690395355225) {
                    if (input[2] <= -0.1487562507390976) {
                        if (input[1] <= -1.465869963169098) {
                            var56 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.2546585351228714) {
                                var56 = new double[2] {0.0, 1.0};
                            } else {
                                var56 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var56 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= 0.3956435024738312) {
                        if (input[4] <= -0.2692248448729515) {
                            var56 = new double[2] {0.0, 1.0};
                        } else {
                            var56 = new double[2] {0.7563739376770539, 0.24362606232294617};
                        }
                    } else {
                        var56 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var56 = new double[2] {1.0, 0.0};
            }
            double[] var57;
            if (input[1] <= -1.461210012435913) {
                var57 = new double[2] {1.0, 0.0};
            } else {
                if (input[5] <= -0.32908497750759125) {
                    if (input[1] <= -0.3878573179244995) {
                        if (input[2] <= -0.07561802864074707) {
                            if (input[4] <= 0.6259816288948059) {
                                var57 = new double[2] {0.0, 1.0};
                            } else {
                                var57 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var57 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= -0.1394634023308754) {
                            if (input[2] <= -0.24502374976873398) {
                                if (input[4] <= 0.5570573210716248) {
                                    var57 = new double[2] {0.0, 1.0};
                                } else {
                                    var57 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.5119882822036743) {
                                    var57 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[0] <= -0.5072529651224613) {
                                        var57 = new double[2] {1.0, 0.0};
                                    } else {
                                        var57 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            var57 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[4] <= 0.49239397048950195) {
                        if (input[1] <= 1.470549464225769) {
                            if (input[1] <= 1.1325443387031555) {
                                if (input[2] <= -0.1429884135723114) {
                                    if (input[4] <= -1.4537211656570435) {
                                        var57 = new double[2] {0.0, 1.0};
                                    } else {
                                        var57 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var57 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= -0.13096297159790993) {
                                    if (input[1] <= 1.2102109789848328) {
                                        var57 = new double[2] {0.0, 1.0};
                                    } else {
                                        var57 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var57 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var57 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var57 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var58;
            if (input[4] <= 0.5460759997367859) {
                if (input[5] <= 2.0882964730262756) {
                    if (input[4] <= -2.4033485651016235) {
                        var58 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= -0.39480678737163544) {
                            if (input[2] <= -0.14273687452077866) {
                                if (input[2] <= -0.24468830227851868) {
                                    if (input[2] <= -0.24518388509750366) {
                                        if (input[3] <= 0.4455278068780899) {
                                            var58 = new double[2] {0.0, 1.0};
                                        } else {
                                            var58 = new double[2] {0.408256880733945, 0.591743119266055};
                                        }
                                    } else {
                                        var58 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 1.0438546538352966) {
                                        var58 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[5] <= 1.0867938995361328) {
                                            var58 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                        } else {
                                            var58 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var58 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= -0.13493400812149048) {
                                if (input[1] <= -1.4509579539299011) {
                                    var58 = new double[2] {1.0, 0.0};
                                } else {
                                    var58 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var58 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var58 = new double[2] {1.0, 0.0};
                }
            } else {
                var58 = new double[2] {1.0, 0.0};
            }
            double[] var59;
            if (input[1] <= 1.2642669081687927) {
                if (input[3] <= -1.1139838695526123) {
                    if (input[3] <= -1.362703263759613) {
                        var59 = new double[2] {0.1714836223506744, 0.8285163776493256};
                    } else {
                        if (input[4] <= 0.44815486669540405) {
                            if (input[2] <= -0.21239283680915833) {
                                if (input[1] <= -1.2707714438438416) {
                                    var59 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var59 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var59 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            if (input[3] <= -1.3416745066642761) {
                                var59 = new double[2] {1.0, 0.0};
                            } else {
                                var59 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[3] <= 0.9927587807178497) {
                        if (input[2] <= -0.13323667272925377) {
                            if (input[1] <= -1.465869963169098) {
                                var59 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.24999899417161942) {
                                    if (input[3] <= -0.583430826663971) {
                                        if (input[4] <= -0.15414857864379883) {
                                            var59 = new double[2] {0.0, 1.0};
                                        } else {
                                            var59 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= -0.06942419335246086) {
                                            var59 = new double[2] {0.1714836223506744, 0.8285163776493256};
                                        } else {
                                            var59 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.5650225877761841) {
                                        if (input[5] <= -1.507432758808136) {
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
                            var59 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 1.2066720128059387) {
                            if (input[5] <= 1.1538088917732239) {
                                var59 = new double[2] {1.0, 0.0};
                            } else {
                                var59 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            var59 = new double[2] {0.3409961685823755, 0.6590038314176245};
                        }
                    }
                }
            } else {
                if (input[0] <= -0.5072529651224613) {
                    var59 = new double[2] {0.5085714285714286, 0.4914285714285714};
                } else {
                    if (input[3] <= -1.255384087562561) {
                        var59 = new double[2] {0.0, 1.0};
                    } else {
                        var59 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var60;
            if (input[4] <= 0.5460759997367859) {
                if (input[2] <= -0.13962869346141815) {
                    if (input[1] <= -1.4587246775627136) {
                        var60 = new double[2] {1.0, 0.0};
                    } else {
                        var60 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var60 = new double[2] {1.0, 0.0};
                }
            } else {
                var60 = new double[2] {1.0, 0.0};
            }
            double[] var61;
            if (input[3] <= 1.4280781745910645) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[1] <= -1.461210012435913) {
                        var61 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= -1.6169432401657104) {
                            if (input[5] <= 0.5265977829694748) {
                                var61 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                var61 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 1.2269870042800903) {
                                if (input[4] <= -0.601255863904953) {
                                    if (input[2] <= -0.14291485399007797) {
                                        var61 = new double[2] {0.0, 1.0};
                                    } else {
                                        var61 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= -1.2106677889823914) {
                                        var61 = new double[2] {0.0, 1.0};
                                    } else {
                                        var61 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[3] <= -0.8159556686878204) {
                                    var61 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= 0.6246347725391388) {
                                        if (input[2] <= -0.05913682281970978) {
                                            var61 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var61 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var61 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var61 = new double[2] {1.0, 0.0};
                }
            } else {
                var61 = new double[2] {1.0, 0.0};
            }
            double[] var62;
            if (input[2] <= -0.14335492253303528) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[4] <= 0.48172637820243835) {
                        if (input[2] <= -0.2518213093280792) {
                            if (input[2] <= -0.2608177065849304) {
                                var62 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= -0.25472357869148254) {
                                    var62 = new double[2] {1.0, 0.0};
                                } else {
                                    var62 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                }
                            }
                        } else {
                            if (input[4] <= -0.6370033919811249) {
                                if (input[4] <= -0.6577920019626617) {
                                    if (input[4] <= -1.162639856338501) {
                                        var62 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= -1.388824701309204) {
                                            var62 = new double[2] {1.0, 0.0};
                                        } else {
                                            var62 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var62 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            } else {
                                if (input[4] <= 0.1458088681101799) {
                                    var62 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -1.1449515223503113) {
                                        var62 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var62 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var62 = new double[2] {0.408256880733945, 0.591743119266055};
                    }
                } else {
                    var62 = new double[2] {1.0, 0.0};
                }
            } else {
                var62 = new double[2] {1.0, 0.0};
            }
            double[] var63;
            if (input[2] <= -0.14335492253303528) {
                if (input[1] <= -1.4049793481826782) {
                    var63 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.5400033593177795) {
                        var63 = new double[2] {0.0, 1.0};
                    } else {
                        var63 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var63 = new double[2] {1.0, 0.0};
            }
            double[] var64;
            if (input[1] <= -1.3962806463241577) {
                if (input[1] <= -1.4487833380699158) {
                    var64 = new double[2] {1.0, 0.0};
                } else {
                    var64 = new double[2] {0.7563739376770539, 0.24362606232294617};
                }
            } else {
                if (input[1] <= 1.2655096054077148) {
                    if (input[4] <= 0.5511365234851837) {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[2] <= -0.14281043410301208) {
                                if (input[3] <= -1.2894651889801025) {
                                    var64 = new double[2] {0.0, 1.0};
                                } else {
                                    var64 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[1] <= -0.9706676304340363) {
                                    var64 = new double[2] {1.0, 0.0};
                                } else {
                                    var64 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.1394251435995102) {
                                if (input[5] <= -1.538458228111267) {
                                    var64 = new double[2] {0.0, 1.0};
                                } else {
                                    var64 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var64 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var64 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[5] <= 0.167074516415596) {
                        if (input[0] <= -0.5072529651224613) {
                            var64 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= -1.2268623113632202) {
                                var64 = new double[2] {0.0, 1.0};
                            } else {
                                var64 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var64 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var65;
            if (input[3] <= 0.9927587807178497) {
                if (input[1] <= -1.4587246775627136) {
                    var65 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.5423109531402588) {
                        if (input[2] <= -0.13955513387918472) {
                            if (input[2] <= -0.25967273116111755) {
                                var65 = new double[2] {0.0, 1.0};
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
            } else {
                if (input[3] <= 1.4005232453346252) {
                    if (input[4] <= 0.6434505432844162) {
                        if (input[3] <= 1.070831060409546) {
                            var65 = new double[2] {1.0, 0.0};
                        } else {
                            var65 = new double[2] {0.2564841498559078, 0.7435158501440922};
                        }
                    } else {
                        var65 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var65 = new double[2] {1.0, 0.0};
                }
            }
            double[] var66;
            if (input[1] <= -1.461210012435913) {
                var66 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5460759997367859) {
                    if (input[3] <= 1.0879924893379211) {
                        if (input[1] <= 1.4177361726760864) {
                            if (input[1] <= -1.1788141131401062) {
                                if (input[2] <= -0.17621376365423203) {
                                    var66 = new double[2] {0.0, 1.0};
                                } else {
                                    var66 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= -2.317319631576538) {
                                    var66 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    if (input[2] <= -0.13582827150821686) {
                                        var66 = new double[2] {0.0, 1.0};
                                    } else {
                                        var66 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= -2.025833487510681) {
                                var66 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                var66 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= 1.3790110349655151) {
                            if (input[4] <= -0.46294166147708893) {
                                var66 = new double[2] {0.8380414312617703, 0.16195856873822975};
                            } else {
                                var66 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var66 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var66 = new double[2] {1.0, 0.0};
                }
            }
            double[] var67;
            if (input[3] <= 0.956985741853714) {
                if (input[4] <= 0.5423109531402588) {
                    if (input[2] <= -0.14371255785226822) {
                        if (input[1] <= -1.4633846282958984) {
                            var67 = new double[2] {1.0, 0.0};
                        } else {
                            var67 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var67 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var67 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[0] <= -0.5072529651224613) {
                    if (input[2] <= 0.3788716718554497) {
                        if (input[4] <= 0.39873379468917847) {
                            var67 = new double[2] {0.0, 1.0};
                        } else {
                            var67 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var67 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= -1.2079113125801086) {
                        var67 = new double[2] {0.8380414312617703, 0.16195856873822975};
                    } else {
                        var67 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var68;
            if (input[1] <= -1.4978686571121216) {
                var68 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.13962869346141815) {
                    if (input[4] <= 0.5460759997367859) {
                        var68 = new double[2] {0.0, 1.0};
                    } else {
                        var68 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var68 = new double[2] {1.0, 0.0};
                }
            }
            double[] var69;
            if (input[4] <= 0.544588178396225) {
                if (input[2] <= -0.14375081658363342) {
                    if (input[1] <= -1.4764326214790344) {
                        var69 = new double[2] {1.0, 0.0};
                    } else {
                        var69 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var69 = new double[2] {1.0, 0.0};
                }
            } else {
                var69 = new double[2] {1.0, 0.0};
            }
            double[] var70;
            if (input[1] <= -1.461210012435913) {
                var70 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.14090070873498917) {
                    if (input[4] <= 0.5473714768886566) {
                        var70 = new double[2] {0.0, 1.0};
                    } else {
                        var70 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var70 = new double[2] {1.0, 0.0};
                }
            }
            double[] var71;
            if (input[1] <= -1.465869963169098) {
                var71 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5460759997367859) {
                    if (input[2] <= -0.13955513387918472) {
                        if (input[2] <= -0.2555154860019684) {
                            var71 = new double[2] {0.0, 1.0};
                        } else {
                            var71 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var71 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var71 = new double[2] {1.0, 0.0};
                }
            }
            double[] var72;
            if (input[2] <= -0.14335492253303528) {
                if (input[5] <= -0.013617880875244737) {
                    if (input[5] <= -0.466714009642601) {
                        if (input[2] <= -0.24443994462490082) {
                            if (input[2] <= -0.253568172454834) {
                                var72 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.09201550483703613) {
                                    var72 = new double[2] {0.0, 1.0};
                                } else {
                                    var72 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.19407997280359268) {
                                if (input[4] <= 0.551743745803833) {
                                    if (input[1] <= -1.4484726786613464) {
                                        var72 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        if (input[4] <= -1.32135808467865) {
                                            var72 = new double[2] {0.0, 1.0};
                                        } else {
                                            var72 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= -0.5072529651224613) {
                                        var72 = new double[2] {1.0, 0.0};
                                    } else {
                                        var72 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var72 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -1.0023555755615234) {
                            var72 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= -0.11687067896127701) {
                                if (input[5] <= -0.32908497750759125) {
                                    var72 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= 0.11635435558855534) {
                                        var72 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var72 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[4] <= 0.08222848176956177) {
                                    var72 = new double[2] {0.0, 1.0};
                                } else {
                                    var72 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[1] <= -1.2045994400978088) {
                        var72 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= -0.29869604110717773) {
                            if (input[1] <= -0.5096385776996613) {
                                if (input[3] <= -0.5877816081047058) {
                                    if (input[2] <= -0.23644563555717468) {
                                        var72 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    } else {
                                        var72 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= -0.6196145117282867) {
                                        if (input[2] <= -0.24418922513723373) {
                                            var72 = new double[2] {1.0, 0.0};
                                        } else {
                                            var72 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var72 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[1] <= -0.4969012588262558) {
                                    var72 = new double[2] {0.0, 1.0};
                                } else {
                                    var72 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.2248346135020256) {
                                if (input[5] <= 0.5171660482883453) {
                                    if (input[4] <= 0.45767876505851746) {
                                        var72 = new double[2] {0.0, 1.0};
                                    } else {
                                        var72 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[4] <= 0.3800807148218155) {
                                        var72 = new double[2] {0.0, 1.0};
                                    } else {
                                        var72 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[4] <= 0.5580188035964966) {
                                    var72 = new double[2] {0.0, 1.0};
                                } else {
                                    var72 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                var72 = new double[2] {1.0, 0.0};
            }
            double[] var73;
            if (input[2] <= -0.14375081658363342) {
                if (input[4] <= 0.5423109531402588) {
                    if (input[3] <= 1.1641311049461365) {
                        if (input[1] <= -1.461210012435913) {
                            var73 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.4360460042953491) {
                                var73 = new double[2] {0.0, 1.0};
                            } else {
                                var73 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var73 = new double[2] {0.29276315789473684, 0.7072368421052632};
                    }
                } else {
                    var73 = new double[2] {1.0, 0.0};
                }
            } else {
                var73 = new double[2] {1.0, 0.0};
            }
            double[] var74;
            if (input[2] <= -0.14371255785226822) {
                if (input[1] <= -1.461210012435913) {
                    var74 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 0.09746568277478218) {
                        if (input[2] <= -0.2504676431417465) {
                            if (input[1] <= 0.44783546030521393) {
                                if (input[4] <= 0.17026132345199585) {
                                    var74 = new double[2] {0.0, 1.0};
                                } else {
                                    var74 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= -0.251740038394928) {
                                    var74 = new double[2] {1.0, 0.0};
                                } else {
                                    var74 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                }
                            }
                        } else {
                            if (input[2] <= -0.2360413298010826) {
                                if (input[1] <= -0.6165078282356262) {
                                    if (input[4] <= 0.514619767665863) {
                                        var74 = new double[2] {0.0, 1.0};
                                    } else {
                                        var74 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[3] <= -0.5196194350719452) {
                                        var74 = new double[2] {0.0, 1.0};
                                    } else {
                                        var74 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    }
                                }
                            } else {
                                if (input[4] <= 0.530995637178421) {
                                    var74 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= -1.2437819838523865) {
                                        var74 = new double[2] {1.0, 0.0};
                                    } else {
                                        var74 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[5] <= -1.351312518119812) {
                            if (input[4] <= 0.4153626561164856) {
                                var74 = new double[2] {0.0, 1.0};
                            } else {
                                var74 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            if (input[1] <= -0.062278863042593) {
                                if (input[3] <= 0.5787099003791809) {
                                    if (input[2] <= -0.21808412671089172) {
                                        if (input[3] <= 0.31500450521707535) {
                                            var74 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var74 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[1] <= -0.6121585071086884) {
                                            var74 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                        } else {
                                            var74 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 1.030575692653656) {
                                        if (input[4] <= 0.5112292170524597) {
                                            var74 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[0] <= 0.10920029878616333) {
                                                var74 = new double[2] {1.0, 0.0};
                                            } else {
                                                var74 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    } else {
                                        var74 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[2] <= -0.19548768550157547) {
                                    if (input[5] <= 0.5122019648551941) {
                                        if (input[1] <= 1.0023751258850098) {
                                            if (input[4] <= 0.08679305016994476) {
                                                var74 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[1] <= -0.01754289196105674) {
                                                    var74 = new double[2] {1.0, 0.0};
                                                } else {
                                                    var74 = new double[2] {1.0, 0.0};
                                                }
                                            }
                                        } else {
                                            if (input[0] <= 0.7256535552442074) {
                                                var74 = new double[2] {0.8380414312617702, 0.16195856873822975};
                                            } else {
                                                var74 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                            }
                                        }
                                    } else {
                                        if (input[4] <= 0.2977156490087509) {
                                            var74 = new double[2] {0.0, 1.0};
                                        } else {
                                            var74 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                        }
                                    }
                                } else {
                                    var74 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                }
            } else {
                var74 = new double[2] {1.0, 0.0};
            }
            double[] var75;
            if (input[2] <= -0.14371255785226822) {
                if (input[4] <= 0.5511365234851837) {
                    if (input[4] <= 0.5089722275733948) {
                        if (input[5] <= 0.9762190580368042) {
                            if (input[3] <= 0.44963687658309937) {
                                if (input[1] <= -1.461210012435913) {
                                    var75 = new double[2] {1.0, 0.0};
                                } else {
                                    var75 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= -0.2500164806842804) {
                                    var75 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                } else {
                                    var75 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.22832182049751282) {
                                var75 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= -0.22335267812013626) {
                                    var75 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[0] <= -0.5072529651224613) {
                                        var75 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var75 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        }
                    } else {
                        var75 = new double[2] {0.5085714285714286, 0.4914285714285714};
                    }
                } else {
                    var75 = new double[2] {1.0, 0.0};
                }
            } else {
                var75 = new double[2] {1.0, 0.0};
            }
            double[] var76;
            if (input[1] <= -1.461210012435913) {
                var76 = new double[2] {1.0, 0.0};
            } else {
                if (input[5] <= 1.3429402709007263) {
                    if (input[4] <= 0.5473714768886566) {
                        if (input[2] <= -0.14273687452077866) {
                            var76 = new double[2] {0.0, 1.0};
                        } else {
                            var76 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var76 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.000794529914855957) {
                        var76 = new double[2] {0.1714836223506744, 0.8285163776493256};
                    } else {
                        var76 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var77;
            if (input[2] <= -0.14371255785226822) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[1] <= -1.461210012435913) {
                        var77 = new double[2] {1.0, 0.0};
                    } else {
                        var77 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var77 = new double[2] {1.0, 0.0};
                }
            } else {
                var77 = new double[2] {1.0, 0.0};
            }
            double[] var78;
            if (input[4] <= 0.5460759997367859) {
                if (input[2] <= -0.14371255785226822) {
                    if (input[0] <= -0.5072529651224613) {
                        if (input[5] <= 0.5812026262283325) {
                            if (input[4] <= 0.321267306804657) {
                                if (input[2] <= -0.24340084940195084) {
                                    var78 = new double[2] {0.408256880733945, 0.591743119266055};
                                } else {
                                    var78 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var78 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            if (input[4] <= 0.09078074432909489) {
                                if (input[5] <= 0.9738611280918121) {
                                    var78 = new double[2] {0.0, 1.0};
                                } else {
                                    var78 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                }
                            } else {
                                var78 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= -0.9248054325580597) {
                            if (input[1] <= -1.380747377872467) {
                                var78 = new double[2] {1.0, 0.0};
                            } else {
                                var78 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var78 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var78 = new double[2] {1.0, 0.0};
                }
            } else {
                var78 = new double[2] {1.0, 0.0};
            }
            double[] var79;
            if (input[4] <= 0.5460759997367859) {
                if (input[1] <= -1.4854419827461243) {
                    var79 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.444031000137329) {
                        if (input[2] <= -0.14281043410301208) {
                            if (input[0] <= -0.5072529651224613) {
                                var79 = new double[2] {0.0, 1.0};
                            } else {
                                var79 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var79 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var79 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var79 = new double[2] {1.0, 0.0};
            }
            double[] var80;
            if (input[4] <= 0.5473714768886566) {
                if (input[4] <= -1.642245888710022) {
                    if (input[3] <= -0.9065968245267868) {
                        var80 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 1.5295761227607727) {
                            var80 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            var80 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.4487833380699158) {
                        var80 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 1.1853576302528381) {
                            if (input[2] <= -0.13955513387918472) {
                                if (input[2] <= -0.2546585351228714) {
                                    var80 = new double[2] {0.0, 1.0};
                                } else {
                                    var80 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var80 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 1.3804562091827393) {
                                if (input[1] <= 1.2642669081687927) {
                                    var80 = new double[2] {0.7212317666126418, 0.2787682333873582};
                                } else {
                                    var80 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[3] <= 1.371518075466156) {
                                    if (input[0] <= 0.7256535552442074) {
                                        var80 = new double[2] {1.0, 0.0};
                                    } else {
                                        var80 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var80 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                }
                            }
                        }
                    }
                }
            } else {
                var80 = new double[2] {1.0, 0.0};
            }
            double[] var81;
            if (input[4] <= 0.5511365234851837) {
                if (input[3] <= 1.41647607088089) {
                    if (input[1] <= -1.465869963169098) {
                        var81 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= -1.6169432401657104) {
                            if (input[4] <= -2.0359545946121216) {
                                var81 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            } else {
                                var81 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= -0.39475618302822113) {
                                if (input[2] <= -0.14291485399007797) {
                                    var81 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.8695141971111298) {
                                        var81 = new double[2] {1.0, 0.0};
                                    } else {
                                        var81 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[2] <= -0.14909211546182632) {
                                    var81 = new double[2] {0.0, 1.0};
                                } else {
                                    var81 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                }
                            }
                        }
                    }
                } else {
                    var81 = new double[2] {1.0, 0.0};
                }
            } else {
                var81 = new double[2] {1.0, 0.0};
            }
            double[] var82;
            if (input[5] <= -0.2914820909500122) {
                if (input[5] <= -0.8949897289276123) {
                    if (input[3] <= -1.1792454719543457) {
                        if (input[4] <= 0.2621806487441063) {
                            var82 = new double[2] {0.0, 1.0};
                        } else {
                            var82 = new double[2] {0.2564841498559078, 0.7435158501440922};
                        }
                    } else {
                        if (input[4] <= 0.5555087924003601) {
                            if (input[1] <= -1.2226181030273438) {
                                var82 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.130660891532898) {
                                    var82 = new double[2] {0.0, 1.0};
                                } else {
                                    var82 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[5] <= -1.529771089553833) {
                                var82 = new double[2] {1.0, 0.0};
                            } else {
                                var82 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.4343092739582062) {
                        if (input[2] <= -0.14446883648633957) {
                            if (input[2] <= -0.25204264372587204) {
                                var82 = new double[2] {0.7563739376770539, 0.24362606232294617};
                            } else {
                                if (input[4] <= 0.3277447819709778) {
                                    var82 = new double[2] {0.0, 1.0};
                                } else {
                                    var82 = new double[2] {0.1869747899159664, 0.8130252100840335};
                                }
                            }
                        } else {
                            var82 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var82 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[4] <= 0.49239397048950195) {
                    if (input[3] <= 0.985749214887619) {
                        if (input[1] <= -1.0778475403785706) {
                            if (input[0] <= 0.7256535552442074) {
                                if (input[5] <= 0.752835601568222) {
                                    var82 = new double[2] {1.0, 0.0};
                                } else {
                                    var82 = new double[2] {0.8054298642533937, 0.1945701357466063};
                                }
                            } else {
                                var82 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= 0.06773537397384644) {
                                if (input[2] <= -0.13096297159790993) {
                                    var82 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= -0.034467004239559174) {
                                        var82 = new double[2] {1.0, 0.0};
                                    } else {
                                        var82 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var82 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[3] <= 1.444031000137329) {
                            if (input[1] <= 0.4633687883615494) {
                                if (input[3] <= 1.1568797826766968) {
                                    var82 = new double[2] {1.0, 0.0};
                                } else {
                                    var82 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                }
                            } else {
                                if (input[4] <= -1.333533763885498) {
                                    var82 = new double[2] {1.0, 0.0};
                                } else {
                                    var82 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= 1.1842571049928665) {
                                var82 = new double[2] {1.0, 0.0};
                            } else {
                                var82 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var82 = new double[2] {1.0, 0.0};
                }
            }
            double[] var83;
            if (input[2] <= -0.14375081658363342) {
                if (input[1] <= -1.465869963169098) {
                    var83 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.22508741915225983) {
                        if (input[5] <= 0.2877015918493271) {
                            if (input[4] <= 0.5511365234851837) {
                                if (input[1] <= -1.299352765083313) {
                                    var83 = new double[2] {0.0, 1.0};
                                } else {
                                    var83 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var83 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.5018875002861023) {
                                var83 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.6241092383861542) {
                                    var83 = new double[2] {1.0, 0.0};
                                } else {
                                    var83 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[5] <= -0.15583868324756622) {
                            if (input[1] <= 1.374242901802063) {
                                if (input[2] <= -0.22385521233081818) {
                                    var83 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    if (input[1] <= -0.3592759966850281) {
                                        var83 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= -0.439371794462204) {
                                            if (input[4] <= 0.3495758790522814) {
                                                var83 = new double[2] {0.0, 1.0};
                                            } else {
                                                var83 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var83 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var83 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            if (input[4] <= 0.5233036279678345) {
                                var83 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.5944444537162781) {
                                    var83 = new double[2] {1.0, 0.0};
                                } else {
                                    var83 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                }
            } else {
                var83 = new double[2] {1.0, 0.0};
            }
            double[] var84;
            if (input[4] <= 0.55467888712883) {
                if (input[2] <= -0.14375081658363342) {
                    if (input[1] <= -1.461210012435913) {
                        var84 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            var84 = new double[2] {0.0, 1.0};
                        } else {
                            var84 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var84 = new double[2] {1.0, 0.0};
                }
            } else {
                var84 = new double[2] {1.0, 0.0};
            }
            double[] var85;
            if (input[3] <= 1.149628460407257) {
                if (input[3] <= 0.1460493505001068) {
                    if (input[3] <= 0.11728588491678238) {
                        if (input[2] <= -0.14335492253303528) {
                            if (input[1] <= -1.4379099607467651) {
                                var85 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= -0.5268707275390625) {
                                    if (input[3] <= -0.6576357483863831) {
                                        if (input[1] <= 0.7948499023914337) {
                                            if (input[4] <= 0.530995637178421) {
                                                var85 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[0] <= -0.5072529651224613) {
                                                    var85 = new double[2] {1.0, 0.0};
                                                } else {
                                                    var85 = new double[2] {1.0, 0.0};
                                                }
                                            }
                                        } else {
                                            if (input[2] <= -0.22685151547193527) {
                                                var85 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[4] <= 0.5077070780098438) {
                                                    var85 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var85 = new double[2] {1.0, 0.0};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[5] <= -0.7180204093456268) {
                                            var85 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var85 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.5241335332393646) {
                                        var85 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= -0.7227557599544525) {
                                            var85 = new double[2] {1.0, 0.0};
                                        } else {
                                            var85 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var85 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var85 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[4] <= 0.5475941300392151) {
                        if (input[2] <= -0.14375081658363342) {
                            if (input[1] <= -1.5450899600982666) {
                                var85 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 0.2120361253619194) {
                                    var85 = new double[2] {0.0, 1.0};
                                } else {
                                    var85 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var85 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var85 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[2] <= -0.2364112213253975) {
                    var85 = new double[2] {0.6082004555808657, 0.3917995444191344};
                } else {
                    var85 = new double[2] {1.0, 0.0};
                }
            }
            double[] var86;
            if (input[4] <= 0.5460759997367859) {
                if (input[4] <= -1.5875922441482544) {
                    if (input[4] <= -2.161455512046814) {
                        var86 = new double[2] {0.3409961685823755, 0.6590038314176245};
                    } else {
                        var86 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.14371255785226822) {
                        if (input[1] <= -1.461210012435913) {
                            var86 = new double[2] {1.0, 0.0};
                        } else {
                            var86 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var86 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var86 = new double[2] {1.0, 0.0};
            }
            double[] var87;
            if (input[5] <= -0.2914820909500122) {
                if (input[1] <= 0.5820433795452118) {
                    if (input[1] <= -1.4307646751403809) {
                        var87 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= -1.0800222158432007) {
                            if (input[5] <= -0.7856559455394745) {
                                if (input[0] <= -0.5072529651224613) {
                                    if (input[5] <= -1.273004174232483) {
                                        var87 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var87 = new double[2] {0.20554272517321018, 0.7944572748267898};
                                    }
                                } else {
                                    var87 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var87 = new double[2] {0.6082004555808657, 0.3917995444191344};
                            }
                        } else {
                            if (input[3] <= -1.1045571565628052) {
                                if (input[1] <= -0.2502320632338524) {
                                    var87 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                } else {
                                    var87 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                }
                            } else {
                                if (input[4] <= 0.6038469076156616) {
                                    if (input[2] <= -0.16106470674276352) {
                                        var87 = new double[2] {0.0, 1.0};
                                    } else {
                                        var87 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    }
                                } else {
                                    var87 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.5484240353107452) {
                        if (input[3] <= -0.920132577419281) {
                            var87 = new double[2] {0.2927631578947369, 0.7072368421052632};
                        } else {
                            var87 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[1] <= 0.6945046484470367) {
                            var87 = new double[2] {1.0, 0.0};
                        } else {
                            var87 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[5] <= 0.2603991627693176) {
                    if (input[3] <= -1.2549006938934326) {
                        if (input[4] <= -1.2640730142593384) {
                            var87 = new double[2] {0.0, 1.0};
                        } else {
                            var87 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    } else {
                        if (input[3] <= -0.4132671356201172) {
                            if (input[3] <= -0.6235546469688416) {
                                if (input[2] <= -0.225368894636631) {
                                    if (input[1] <= 0.766579270362854) {
                                        var87 = new double[2] {1.0, 0.0};
                                    } else {
                                        var87 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                    }
                                } else {
                                    var87 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                }
                            } else {
                                var87 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.4974544942378998) {
                                if (input[3] <= 0.38969284296035767) {
                                    if (input[4] <= -0.6880539357662201) {
                                        var87 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var87 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[1] <= -1.0890315473079681) {
                                        var87 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[4] <= -1.1962113976478577) {
                                            var87 = new double[2] {1.0, 0.0};
                                        } else {
                                            var87 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                        }
                                    }
                                }
                            } else {
                                if (input[1] <= -0.8737396597862244) {
                                    var87 = new double[2] {1.0, 0.0};
                                } else {
                                    var87 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.48172637820243835) {
                        if (input[2] <= -0.1803775280714035) {
                            if (input[1] <= -1.4727046489715576) {
                                var87 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= 0.2909282445907593) {
                                    var87 = new double[2] {0.0, 1.0};
                                } else {
                                    var87 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[5] <= 1.5263628959655762) {
                                var87 = new double[2] {1.0, 0.0};
                            } else {
                                var87 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            }
                        }
                    } else {
                        var87 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var88;
            if (input[5] <= 1.3825287818908691) {
                if (input[4] <= 0.5479078888893127) {
                    if (input[4] <= -1.0349021553993225) {
                        if (input[3] <= 0.24079959094524384) {
                            if (input[4] <= -1.1784388422966003) {
                                if (input[5] <= 0.1358008300885558) {
                                    var88 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= -0.346555233001709) {
                                        if (input[2] <= -0.22247356921434402) {
                                            var88 = new double[2] {0.0, 1.0};
                                        } else {
                                            var88 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    } else {
                                        var88 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                    }
                                }
                            } else {
                                var88 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            if (input[5] <= -0.2309203464537859) {
                                if (input[4] <= -1.1474583148956299) {
                                    var88 = new double[2] {0.0, 1.0};
                                } else {
                                    var88 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var88 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= 1.1588134765625) {
                            if (input[1] <= -1.4633846282958984) {
                                var88 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -0.6005170047283173) {
                                    if (input[5] <= 0.4305429011583328) {
                                        if (input[2] <= -0.18747218698263168) {
                                            var88 = new double[2] {0.0, 1.0};
                                        } else {
                                            var88 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    } else {
                                        if (input[4] <= -0.7000777423381805) {
                                            if (input[3] <= 0.6712847650051117) {
                                                var88 = new double[2] {0.0, 1.0};
                                            } else {
                                                var88 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            }
                                        } else {
                                            var88 = new double[2] {0.8054298642533937, 0.1945701357466063};
                                        }
                                    }
                                } else {
                                    if (input[2] <= -0.13497226685285568) {
                                        var88 = new double[2] {0.0, 1.0};
                                    } else {
                                        var88 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.26343565434217453) {
                                if (input[2] <= 0.9785740375518799) {
                                    var88 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                } else {
                                    var88 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var88 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var88 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= -0.21227020025253296) {
                    if (input[2] <= -0.21973472833633423) {
                        if (input[2] <= -0.23625851422548294) {
                            var88 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        } else {
                            var88 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var88 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[0] <= -0.5072529651224613) {
                        var88 = new double[2] {1.0, 0.0};
                    } else {
                        var88 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var89;
            if (input[4] <= 0.5460759997367859) {
                if (input[2] <= -0.14371255785226822) {
                    if (input[1] <= -1.4633846282958984) {
                        var89 = new double[2] {1.0, 0.0};
                    } else {
                        var89 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var89 = new double[2] {1.0, 0.0};
                }
            } else {
                var89 = new double[2] {1.0, 0.0};
            }
            double[] var90;
            if (input[2] <= -0.14371255785226822) {
                if (input[5] <= -0.3462110459804535) {
                    if (input[1] <= -1.465869963169098) {
                        var90 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= -0.24466706067323685) {
                            if (input[4] <= 0.5499725639820099) {
                                if (input[5] <= -1.6566032767295837) {
                                    var90 = new double[2] {0.0, 1.0};
                                } else {
                                    var90 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var90 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= -1.1045571565628052) {
                                if (input[4] <= 0.5363192856311798) {
                                    if (input[0] <= -0.5072529651224613) {
                                        var90 = new double[2] {0.0, 1.0};
                                    } else {
                                        var90 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var90 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[1] <= -0.3592759966850281) {
                                    var90 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= 0.5358031094074249) {
                                        var90 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[2] <= -0.2294759824872017) {
                                            var90 = new double[2] {1.0, 0.0};
                                        } else {
                                            var90 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    if (input[4] <= 0.5349428355693817) {
                        if (input[1] <= -1.388824701309204) {
                            var90 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[0] <= -0.5072529651224613) {
                                var90 = new double[2] {0.0, 1.0};
                            } else {
                                var90 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var90 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var90 = new double[2] {1.0, 0.0};
            }
            double[] var91;
            if (input[1] <= -1.465869963169098) {
                var91 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5440517663955688) {
                    if (input[3] <= 1.3439631462097168) {
                        if (input[2] <= -0.13962869346141815) {
                            if (input[3] <= -1.3984763026237488) {
                                var91 = new double[2] {0.0, 1.0};
                            } else {
                                var91 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var91 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 1.4177361726760864) {
                            var91 = new double[2] {1.0, 0.0};
                        } else {
                            var91 = new double[2] {0.8054298642533937, 0.1945701357466063};
                        }
                    }
                } else {
                    var91 = new double[2] {1.0, 0.0};
                }
            }
            double[] var92;
            if (input[1] <= -1.4587246775627136) {
                var92 = new double[2] {1.0, 0.0};
            } else {
                if (input[3] <= 1.4312204122543335) {
                    if (input[2] <= -0.14335492253303528) {
                        if (input[5] <= -1.2310577630996704) {
                            if (input[3] <= -1.0209255516529083) {
                                var92 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= 0.9896377623081207) {
                                    var92 = new double[2] {0.0, 1.0};
                                } else {
                                    var92 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                }
                            }
                        } else {
                            if (input[4] <= 0.5423109531402588) {
                                if (input[0] <= -0.5072529651224613) {
                                    var92 = new double[2] {0.0, 1.0};
                                } else {
                                    var92 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var92 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var92 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var92 = new double[2] {1.0, 0.0};
                }
            }
            double[] var93;
            if (input[4] <= 0.5440517663955688) {
                if (input[2] <= -0.14371255785226822) {
                    if (input[3] <= -1.4794490933418274) {
                        var93 = new double[2] {0.6742424242424242, 0.32575757575757575};
                    } else {
                        if (input[1] <= -1.4633846282958984) {
                            var93 = new double[2] {1.0, 0.0};
                        } else {
                            var93 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var93 = new double[2] {1.0, 0.0};
                }
            } else {
                var93 = new double[2] {1.0, 0.0};
            }
            double[] var94;
            if (input[4] <= 0.5460759997367859) {
                if (input[1] <= -1.461210012435913) {
                    var94 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.13497226685285568) {
                        if (input[3] <= -1.4407755136489868) {
                            var94 = new double[2] {0.0, 1.0};
                        } else {
                            var94 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var94 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var94 = new double[2] {1.0, 0.0};
            }
            double[] var95;
            if (input[5] <= -0.265917107462883) {
                if (input[2] <= -0.14375081658363342) {
                    if (input[3] <= 1.055361658334732) {
                        if (input[1] <= -1.4978686571121216) {
                            var95 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -1.1840797066688538) {
                                if (input[4] <= 0.27615781873464584) {
                                    var95 = new double[2] {0.0, 1.0};
                                } else {
                                    var95 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                }
                            } else {
                                if (input[2] <= -0.24464162439107895) {
                                    if (input[2] <= -0.253568172454834) {
                                        var95 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= -0.7424758970737457) {
                                            var95 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            if (input[4] <= 0.17770028114318848) {
                                                var95 = new double[2] {0.0, 1.0};
                                            } else {
                                                var95 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    }
                                } else {
                                    if (input[3] <= -1.1219602823257446) {
                                        var95 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[3] <= 0.6620998084545135) {
                                            if (input[4] <= 0.551743745803833) {
                                                var95 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[1] <= -0.02064955234527588) {
                                                    var95 = new double[2] {1.0, 0.0};
                                                } else {
                                                    var95 = new double[2] {1.0, 0.0};
                                                }
                                            }
                                        } else {
                                            if (input[3] <= 0.9258051812648773) {
                                                if (input[4] <= 0.00033909082412719727) {
                                                    var95 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var95 = new double[2] {1.0, 0.0};
                                                }
                                            } else {
                                                var95 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var95 = new double[2] {0.6742424242424242, 0.32575757575757575};
                    }
                } else {
                    var95 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.5246699750423431) {
                    if (input[4] <= -1.0350944995880127) {
                        if (input[3] <= 1.3790110349655151) {
                            if (input[2] <= -0.1429884135723114) {
                                if (input[1] <= -0.738289088010788) {
                                    var95 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var95 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var95 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var95 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 0.46045146882534027) {
                            if (input[2] <= -0.15936826169490814) {
                                if (input[3] <= 0.9954176247119904) {
                                    if (input[1] <= -1.1256901621818542) {
                                        var95 = new double[2] {0.0, 1.0};
                                    } else {
                                        var95 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var95 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                }
                            } else {
                                var95 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            if (input[1] <= -1.1673194766044617) {
                                var95 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 1.1588134765625) {
                                    if (input[2] <= 1.4930074736475945) {
                                        var95 = new double[2] {0.0, 1.0};
                                    } else {
                                        var95 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[0] <= 0.10920029878616333) {
                                        var95 = new double[2] {1.0, 0.0};
                                    } else {
                                        var95 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var95 = new double[2] {1.0, 0.0};
                }
            }
            double[] var96;
            if (input[1] <= -1.461210012435913) {
                var96 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.14339318126440048) {
                    if (input[1] <= 0.8967485129833221) {
                        if (input[3] <= 0.8496665954589844) {
                            if (input[5] <= -0.8082424998283386) {
                                if (input[1] <= 0.020669083576649427) {
                                    if (input[2] <= -0.24443994462490082) {
                                        var96 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        if (input[5] <= -1.3479617834091187) {
                                            var96 = new double[2] {0.0, 1.0};
                                        } else {
                                            var96 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= -0.24644937366247177) {
                                        if (input[3] <= -0.5926157981157303) {
                                            var96 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                        } else {
                                            var96 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[2] <= -0.22946730256080627) {
                                            if (input[1] <= 0.28722091019153595) {
                                                var96 = new double[2] {0.0, 1.0};
                                            } else {
                                                var96 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            if (input[1] <= 0.17786631733179092) {
                                                var96 = new double[2] {0.0, 1.0};
                                            } else {
                                                var96 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.0029571466147899628) {
                                    if (input[4] <= 0.44249720871448517) {
                                        var96 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[4] <= 0.5842525660991669) {
                                            var96 = new double[2] {1.0, 0.0};
                                        } else {
                                            var96 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.29470089077949524) {
                                        if (input[1] <= -0.2539600729942322) {
                                            if (input[1] <= -1.1601741909980774) {
                                                var96 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            } else {
                                                var96 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            if (input[4] <= 0.0017965137958526611) {
                                                var96 = new double[2] {0.0, 1.0};
                                            } else {
                                                var96 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    } else {
                                        if (input[1] <= -1.369563341140747) {
                                            var96 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[4] <= 0.5452055633068085) {
                                                if (input[2] <= -0.2476547807455063) {
                                                    var96 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var96 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var96 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 0.6479046642780304) {
                                if (input[1] <= 0.5630927085876465) {
                                    if (input[5] <= -1.1356233954429626) {
                                        var96 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= 0.1570516601204872) {
                                            if (input[2] <= -0.24452676624059677) {
                                                var96 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            } else {
                                                var96 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var96 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                        }
                                    }
                                } else {
                                    var96 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var96 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.2212296798825264) {
                            if (input[4] <= 0.5116239488124847) {
                                var96 = new double[2] {0.0, 1.0};
                            } else {
                                var96 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= 1.5295761227607727) {
                                var96 = new double[2] {0.0, 1.0};
                            } else {
                                var96 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            }
                        }
                    }
                } else {
                    var96 = new double[2] {1.0, 0.0};
                }
            }
            double[] var97;
            if (input[4] <= 0.5460759997367859) {
                if (input[1] <= -1.4108819961547852) {
                    var97 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.444031000137329) {
                        if (input[1] <= 1.641416072845459) {
                            if (input[2] <= -0.13955513387918472) {
                                if (input[1] <= -1.2717034220695496) {
                                    var97 = new double[2] {0.0, 1.0};
                                } else {
                                    var97 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var97 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[5] <= -0.1433043945580721) {
                                var97 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                if (input[2] <= 0.06448132218793035) {
                                    var97 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var97 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var97 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var97 = new double[2] {1.0, 0.0};
            }
            double[] var98;
            if (input[2] <= -0.14371255785226822) {
                if (input[1] <= -1.4587246775627136) {
                    var98 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.4280781745910645) {
                        if (input[0] <= 0.7256535552442074) {
                            if (input[3] <= -1.3711630702018738) {
                                var98 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= -1.3351483345031738) {
                                    var98 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[1] <= 0.6426233649253845) {
                                        if (input[1] <= 0.15922632813453674) {
                                            if (input[4] <= 0.538485199213028) {
                                                var98 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[0] <= -0.5072529651224613) {
                                                    var98 = new double[2] {1.0, 0.0};
                                                } else {
                                                    var98 = new double[2] {1.0, 0.0};
                                                }
                                            }
                                        } else {
                                            if (input[1] <= 0.5481807589530945) {
                                                if (input[4] <= 0.5336473286151886) {
                                                    var98 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var98 = new double[2] {1.0, 0.0};
                                                }
                                            } else {
                                                if (input[1] <= 0.5804900527000427) {
                                                    var98 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var98 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[5] <= -0.8849374651908875) {
                                            var98 = new double[2] {1.0, 0.0};
                                        } else {
                                            if (input[1] <= 0.74141526222229) {
                                                var98 = new double[2] {1.0, 0.0};
                                            } else {
                                                if (input[5] <= 0.14411566406488419) {
                                                    if (input[4] <= 0.47624076902866364) {
                                                        var98 = new double[2] {0.0, 1.0};
                                                    } else {
                                                        var98 = new double[2] {1.0, 0.0};
                                                    }
                                                } else {
                                                    if (input[1] <= 1.0651297569274902) {
                                                        var98 = new double[2] {0.0, 1.0};
                                                    } else {
                                                        var98 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.5570572912693024) {
                                var98 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -1.013879418373108) {
                                    var98 = new double[2] {1.0, 0.0};
                                } else {
                                    var98 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        var98 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var98 = new double[2] {1.0, 0.0};
            }
            double[] var99;
            if (input[5] <= -0.26604120433330536) {
                if (input[4] <= 0.5570573210716248) {
                    if (input[1] <= -1.4587246775627136) {
                        var99 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= -1.2599766254425049) {
                            var99 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            if (input[2] <= -0.13497226685285568) {
                                var99 = new double[2] {0.0, 1.0};
                            } else {
                                var99 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var99 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.7474233508110046) {
                    if (input[4] <= 0.5147007405757904) {
                        if (input[4] <= -1.5738377571105957) {
                            var99 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= 0.7461341023445129) {
                                if (input[2] <= -0.16335701569914818) {
                                    if (input[3] <= 0.5540555119514465) {
                                        var99 = new double[2] {0.0, 1.0};
                                    } else {
                                        var99 = new double[2] {0.408256880733945, 0.591743119266055};
                                    }
                                } else {
                                    if (input[4] <= -0.7535067498683929) {
                                        var99 = new double[2] {1.0, 0.0};
                                    } else {
                                        var99 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var99 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var99 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 1.149628460407257) {
                        if (input[2] <= -0.23105713725090027) {
                            if (input[2] <= -0.23586717247962952) {
                                var99 = new double[2] {0.7563739376770539, 0.24362606232294617};
                            } else {
                                var99 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= -0.21108126640319824) {
                                if (input[2] <= -0.22733403742313385) {
                                    var99 = new double[2] {1.0, 0.0};
                                } else {
                                    var99 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                }
                            } else {
                                if (input[5] <= 0.31053634732961655) {
                                    var99 = new double[2] {1.0, 0.0};
                                } else {
                                    var99 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            var99 = new double[2] {1.0, 0.0};
                        } else {
                            var99 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var100;
            if (input[5] <= -0.265917107462883) {
                if (input[4] <= 0.5945051908493042) {
                    if (input[1] <= -1.4332500100135803) {
                        var100 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[3] <= -1.2495830655097961) {
                            var100 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            if (input[4] <= -0.47528932988643646) {
                                if (input[4] <= -0.6048994362354279) {
                                    if (input[3] <= 0.25626902282238007) {
                                        var100 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[2] <= -0.09823532402515411) {
                                            var100 = new double[2] {0.0, 1.0};
                                        } else {
                                            var100 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var100 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                }
                            } else {
                                if (input[5] <= -1.3864333629608154) {
                                    var100 = new double[2] {0.1714836223506744, 0.8285163776493256};
                                } else {
                                    var100 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    var100 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[1] <= -1.2313167452812195) {
                    if (input[5] <= 0.0016466546803712845) {
                        var100 = new double[2] {0.8054298642533937, 0.1945701357466063};
                    } else {
                        if (input[2] <= -0.24815386533737183) {
                            var100 = new double[2] {1.0, 0.0};
                        } else {
                            var100 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= 1.3062068819999695) {
                        if (input[2] <= -0.14671464264392853) {
                            if (input[4] <= 0.5157128572463989) {
                                if (input[2] <= -0.2531912177801132) {
                                    var100 = new double[2] {0.0, 1.0};
                                } else {
                                    var100 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var100 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var100 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= -0.1511191502213478) {
                            var100 = new double[2] {0.408256880733945, 0.591743119266055};
                        } else {
                            var100 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var101;
            if (input[3] <= 0.9927587807178497) {
                if (input[2] <= -0.13959339261054993) {
                    if (input[2] <= -0.24446538090705872) {
                        if (input[4] <= 0.4533165991306305) {
                            if (input[1] <= -1.388824701309204) {
                                var101 = new double[2] {1.0, 0.0};
                            } else {
                                var101 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= -1.2416066527366638) {
                                var101 = new double[2] {1.0, 0.0};
                            } else {
                                var101 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[5] <= 0.8460361361503601) {
                            if (input[2] <= -0.22813720256090164) {
                                if (input[4] <= 0.5479078888893127) {
                                    if (input[4] <= -1.4380133152008057) {
                                        var101 = new double[2] {0.0, 1.0};
                                    } else {
                                        var101 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var101 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= -0.21606703102588654) {
                                    if (input[1] <= 1.107069730758667) {
                                        var101 = new double[2] {0.0, 1.0};
                                    } else {
                                        var101 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                } else {
                                    if (input[4] <= 0.6258804202079773) {
                                        if (input[4] <= -1.891223669052124) {
                                            var101 = new double[2] {0.0, 1.0};
                                        } else {
                                            var101 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var101 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 0.43368400633335114) {
                                if (input[5] <= 1.0429859161376953) {
                                    var101 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[0] <= -0.5072529651224613) {
                                        if (input[1] <= 0.18967164307832718) {
                                            var101 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var101 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.14027266204357147) {
                                            if (input[4] <= -1.2108262181282043) {
                                                var101 = new double[2] {0.0, 1.0};
                                            } else {
                                                var101 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var101 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[2] <= -0.24095064401626587) {
                                    var101 = new double[2] {0.0, 1.0};
                                } else {
                                    var101 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                }
                            }
                        }
                    }
                } else {
                    var101 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= -0.6886082589626312) {
                    if (input[3] <= 1.2066720128059387) {
                        var101 = new double[2] {1.0, 0.0};
                    } else {
                        var101 = new double[2] {0.0, 1.0};
                    }
                } else {
                    if (input[2] <= -0.1693693920969963) {
                        if (input[3] <= 1.0372334122657776) {
                            var101 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            if (input[2] <= -0.22378602623939514) {
                                var101 = new double[2] {1.0, 0.0};
                            } else {
                                var101 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        }
                    } else {
                        if (input[1] <= -0.7339397668838501) {
                            var101 = new double[2] {1.0, 0.0};
                        } else {
                            var101 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var102;
            if (input[0] <= -0.5072529651224613) {
                if (input[2] <= -0.14689429849386215) {
                    if (input[4] <= 0.5089722275733948) {
                        if (input[3] <= 1.3067398071289062) {
                            if (input[2] <= -0.19131969660520554) {
                                if (input[5] <= 0.9239721596240997) {
                                    var102 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -0.7820582091808319) {
                                        var102 = new double[2] {0.0, 1.0};
                                    } else {
                                        var102 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                }
                            } else {
                                var102 = new double[2] {0.2564841498559078, 0.7435158501440922};
                            }
                        } else {
                            var102 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    } else {
                        var102 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var102 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 0.011202503461390734) {
                    if (input[4] <= 0.5570573210716248) {
                        if (input[2] <= -0.14829377830028534) {
                            if (input[3] <= 1.1418938040733337) {
                                var102 = new double[2] {0.0, 1.0};
                            } else {
                                var102 = new double[2] {0.20554272517321018, 0.7944572748267898};
                            }
                        } else {
                            var102 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var102 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= 1.2145602703094482) {
                        if (input[4] <= 0.5213097929954529) {
                            if (input[2] <= 0.04295508563518524) {
                                var102 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= 0.7911728173494339) {
                                    var102 = new double[2] {1.0, 0.0};
                                } else {
                                    var102 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[0] <= 0.7256535552442074) {
                                var102 = new double[2] {1.0, 0.0};
                            } else {
                                var102 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var102 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var103;
            if (input[4] <= 0.5460759997367859) {
                if (input[3] <= 1.0372334122657776) {
                    if (input[2] <= -0.13493400812149048) {
                        if (input[2] <= -0.2574715316295624) {
                            var103 = new double[2] {0.408256880733945, 0.591743119266055};
                        } else {
                            if (input[4] <= 0.4553306847810745) {
                                if (input[4] <= -1.0702145099639893) {
                                    if (input[1] <= -1.461210012435913) {
                                        var103 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[0] <= -0.5072529651224613) {
                                            var103 = new double[2] {0.0, 1.0};
                                        } else {
                                            var103 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= -0.4794956296682358) {
                                        if (input[5] <= -0.08758262917399406) {
                                            var103 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[3] <= -0.6078435480594635) {
                                                var103 = new double[2] {0.0, 1.0};
                                            } else {
                                                var103 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            }
                                        }
                                    } else {
                                        var103 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[0] <= -0.5072529651224613) {
                                    var103 = new double[2] {0.408256880733945, 0.591743119266055};
                                } else {
                                    var103 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var103 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.17151056230068207) {
                        if (input[4] <= -0.46108950674533844) {
                            var103 = new double[2] {1.0, 0.0};
                        } else {
                            var103 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var103 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var103 = new double[2] {1.0, 0.0};
            }
            double[] var104;
            if (input[1] <= -1.465869963169098) {
                var104 = new double[2] {1.0, 0.0};
            } else {
                if (input[1] <= 1.4503561854362488) {
                    if (input[1] <= -1.4205126762390137) {
                        var104 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= -0.14335492253303528) {
                            if (input[1] <= -1.259898066520691) {
                                if (input[4] <= 0.05672343075275421) {
                                    var104 = new double[2] {0.0, 1.0};
                                } else {
                                    var104 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.5511365234851837) {
                                    if (input[5] <= -1.5523576140403748) {
                                        var104 = new double[2] {0.0, 1.0};
                                    } else {
                                        var104 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var104 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var104 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var104 = new double[2] {1.0, 0.0};
                }
            }
            double[] var105;
            if (input[5] <= 1.4218690395355225) {
                if (input[4] <= 0.5516729354858398) {
                    if (input[2] <= -0.14371255785226822) {
                        if (input[1] <= -1.461210012435913) {
                            var105 = new double[2] {1.0, 0.0};
                        } else {
                            var105 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var105 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var105 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -0.03724035806953907) {
                    if (input[1] <= 0.39440083503723145) {
                        if (input[2] <= -0.19303284585475922) {
                            var105 = new double[2] {0.0, 1.0};
                        } else {
                            var105 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    } else {
                        var105 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var105 = new double[2] {1.0, 0.0};
                }
            }
            double[] var106;
            if (input[2] <= -0.14689429849386215) {
                if (input[1] <= -1.461210012435913) {
                    var106 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= -0.5297712683677673) {
                        if (input[4] <= 0.5423109531402588) {
                            var106 = new double[2] {0.0, 1.0};
                        } else {
                            var106 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[1] <= 0.17507031187415123) {
                                if (input[4] <= 0.28682539239525795) {
                                    var106 = new double[2] {0.0, 1.0};
                                } else {
                                    var106 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            } else {
                                if (input[4] <= 0.5400033593177795) {
                                    var106 = new double[2] {0.0, 1.0};
                                } else {
                                    var106 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= 0.09770739078521729) {
                                if (input[4] <= 0.575275182723999) {
                                    var106 = new double[2] {0.0, 1.0};
                                } else {
                                    var106 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= 0.5570572912693024) {
                                    var106 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= -1.1265639662742615) {
                                        var106 = new double[2] {1.0, 0.0};
                                    } else {
                                        var106 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                var106 = new double[2] {1.0, 0.0};
            }
            double[] var107;
            if (input[2] <= -0.1394251435995102) {
                if (input[1] <= -1.3962806463241577) {
                    if (input[5] <= 0.8173685967922211) {
                        if (input[5] <= -1.2735006213188171) {
                            var107 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        } else {
                            var107 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var107 = new double[2] {0.6082004555808657, 0.39179954441913434};
                    }
                } else {
                    if (input[5] <= -0.9006984531879425) {
                        if (input[5] <= -1.0941733121871948) {
                            if (input[4] <= 0.5570573210716248) {
                                var107 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[0] <= 0.7256535552442074) {
                                    var107 = new double[2] {1.0, 0.0};
                                } else {
                                    var107 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var107 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= 0.5349428355693817) {
                            if (input[1] <= -1.3617967367172241) {
                                var107 = new double[2] {0.0, 1.0};
                            } else {
                                var107 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var107 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var107 = new double[2] {1.0, 0.0};
            }
            double[] var108;
            if (input[5] <= 1.0644555687904358) {
                if (input[4] <= 0.544588178396225) {
                    if (input[5] <= 0.9762190580368042) {
                        if (input[1] <= -1.461210012435913) {
                            var108 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= 1.6227760314941406) {
                                if (input[5] <= 0.030686505138874054) {
                                    if (input[4] <= -0.5248318463563919) {
                                        if (input[0] <= -0.5072529651224613) {
                                            var108 = new double[2] {0.0, 1.0};
                                        } else {
                                            var108 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[5] <= -1.3802282810211182) {
                                            var108 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            if (input[2] <= -0.1394251435995102) {
                                                var108 = new double[2] {0.0, 1.0};
                                            } else {
                                                var108 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    }
                                } else {
                                    if (input[1] <= -1.1141955256462097) {
                                        var108 = new double[2] {0.7212317666126418, 0.2787682333873582};
                                    } else {
                                        if (input[4] <= -0.48138220608234406) {
                                            if (input[2] <= -0.13239256665110588) {
                                                var108 = new double[2] {0.0, 1.0};
                                            } else {
                                                var108 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[2] <= -0.21676482260227203) {
                                                var108 = new double[2] {0.0, 1.0};
                                            } else {
                                                var108 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                            }
                                        }
                                    }
                                }
                            } else {
                                var108 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var108 = new double[2] {0.8380414312617702, 0.16195856873822975};
                    }
                } else {
                    var108 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= -0.16836559772491455) {
                    if (input[5] <= 1.1895502805709839) {
                        var108 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[4] <= 0.04886949621140957) {
                            var108 = new double[2] {0.0, 1.0};
                        } else {
                            var108 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= -0.28751206025481224) {
                        var108 = new double[2] {1.0, 0.0};
                    } else {
                        var108 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var109;
            if (input[3] <= 1.3439631462097168) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[0] <= -0.5072529651224613) {
                        if (input[1] <= -1.2226181030273438) {
                            if (input[4] <= -1.0667025446891785) {
                                var109 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            } else {
                                var109 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= -0.157458133995533) {
                                if (input[1] <= 0.9492511451244354) {
                                    if (input[2] <= -0.14281043410301208) {
                                        var109 = new double[2] {0.0, 1.0};
                                    } else {
                                        var109 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var109 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                }
                            } else {
                                if (input[2] <= -0.14881188422441483) {
                                    var109 = new double[2] {0.0, 1.0};
                                } else {
                                    var109 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 0.9813984334468842) {
                            if (input[0] <= 0.7256535552442074) {
                                if (input[2] <= -0.11868410184979439) {
                                    if (input[3] <= -0.45024874806404114) {
                                        if (input[3] <= -0.575212687253952) {
                                            if (input[4] <= -1.0855782628059387) {
                                                var109 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            } else {
                                                var109 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var109 = new double[2] {0.4369885433715221, 0.5630114566284778};
                                        }
                                    } else {
                                        if (input[1] <= -1.4121246933937073) {
                                            var109 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                        } else {
                                            if (input[5] <= -1.101123034954071) {
                                                var109 = new double[2] {0.0, 1.0};
                                            } else {
                                                var109 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    }
                                } else {
                                    var109 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[5] <= -0.3740098774433136) {
                                    if (input[5] <= -0.8266096115112305) {
                                        var109 = new double[2] {0.0, 1.0};
                                    } else {
                                        var109 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                } else {
                                    if (input[1] <= -1.1350101828575134) {
                                        var109 = new double[2] {0.0, 1.0};
                                    } else {
                                        var109 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[3] <= 1.2066720128059387) {
                                if (input[5] <= -0.916335254907608) {
                                    var109 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                } else {
                                    var109 = new double[2] {0.8380414312617702, 0.16195856873822975};
                                }
                            } else {
                                var109 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var109 = new double[2] {1.0, 0.0};
                }
            } else {
                var109 = new double[2] {1.0, 0.0};
            }
            double[] var110;
            if (input[4] <= 0.5460759997367859) {
                if (input[3] <= 1.0000101029872894) {
                    if (input[2] <= -0.14375081658363342) {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[5] <= 0.6349387764930725) {
                                if (input[2] <= -0.2323727160692215) {
                                    if (input[4] <= 0.02612750232219696) {
                                        if (input[2] <= -0.24300435930490494) {
                                            var110 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                        } else {
                                            var110 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var110 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= -1.5070604085922241) {
                                        var110 = new double[2] {0.0, 1.0};
                                    } else {
                                        var110 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[5] <= 1.033678263425827) {
                                    var110 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                } else {
                                    var110 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.25330398976802826) {
                                var110 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            } else {
                                if (input[0] <= 0.7256535552442074) {
                                    var110 = new double[2] {0.0, 1.0};
                                } else {
                                    var110 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var110 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[0] <= 0.7256535552442074) {
                        if (input[3] <= 1.444031000137329) {
                            if (input[0] <= -0.5072529651224613) {
                                if (input[1] <= 0.4633687883615494) {
                                    var110 = new double[2] {0.8054298642533936, 0.1945701357466063};
                                } else {
                                    var110 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var110 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var110 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= -0.04767754673957825) {
                            var110 = new double[2] {1.0, 0.0};
                        } else {
                            var110 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var110 = new double[2] {1.0, 0.0};
            }
            double[] var111;
            if (input[2] <= -0.14689429849386215) {
                if (input[1] <= -1.461210012435913) {
                    var111 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.551268070936203) {
                        if (input[2] <= -0.2545678913593292) {
                            var111 = new double[2] {0.0, 1.0};
                        } else {
                            var111 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var111 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var111 = new double[2] {1.0, 0.0};
            }
            double[] var112;
            if (input[4] <= 0.5423109531402588) {
                if (input[2] <= -0.14371255785226822) {
                    if (input[3] <= 0.5139316916465759) {
                        if (input[1] <= -1.465869963169098) {
                            var112 = new double[2] {1.0, 0.0};
                        } else {
                            var112 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[4] <= 0.39873379468917847) {
                                if (input[1] <= -0.8917583078145981) {
                                    var112 = new double[2] {1.0, 0.0};
                                } else {
                                    var112 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var112 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= -1.2499567866325378) {
                                var112 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            } else {
                                if (input[3] <= 0.6309192180633545) {
                                    var112 = new double[2] {0.0, 1.0};
                                } else {
                                    var112 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    var112 = new double[2] {1.0, 0.0};
                }
            } else {
                var112 = new double[2] {1.0, 0.0};
            }
            double[] var113;
            if (input[2] <= -0.14090070873498917) {
                if (input[3] <= 0.9927587807178497) {
                    if (input[1] <= -1.461210012435913) {
                        var113 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 0.5423109531402588) {
                            if (input[2] <= -0.2546585351228714) {
                                var113 = new double[2] {0.0, 1.0};
                            } else {
                                var113 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var113 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[4] <= 0.4982236921787262) {
                        if (input[1] <= -1.3608646988868713) {
                            var113 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[0] <= -0.5072529651224613) {
                                var113 = new double[2] {0.0, 1.0};
                            } else {
                                var113 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[1] <= -0.5876158624887466) {
                            var113 = new double[2] {1.0, 0.0};
                        } else {
                            var113 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var113 = new double[2] {1.0, 0.0};
            }
            double[] var114;
            if (input[2] <= -0.15359406918287277) {
                if (input[4] <= 0.5473714768886566) {
                    if (input[1] <= -1.4789179563522339) {
                        var114 = new double[2] {1.0, 0.0};
                    } else {
                        var114 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var114 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= -0.1465366631746292) {
                    var114 = new double[2] {0.7563739376770539, 0.24362606232294617};
                } else {
                    var114 = new double[2] {1.0, 0.0};
                }
            }
            double[] var115;
            if (input[3] <= 1.0372334122657776) {
                if (input[2] <= -0.14339318126440048) {
                    if (input[3] <= -1.3571439385414124) {
                        var115 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[5] <= -0.2476741150021553) {
                                if (input[2] <= -0.2319021299481392) {
                                    if (input[2] <= -0.2519097253680229) {
                                        var115 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= 0.4972536861896515) {
                                            if (input[1] <= -1.3388073444366455) {
                                                var115 = new double[2] {1.0, 0.0};
                                            } else {
                                                if (input[2] <= -0.23870953172445297) {
                                                    var115 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var115 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                                }
                                            }
                                        } else {
                                            if (input[3] <= 0.8827808499336243) {
                                                var115 = new double[2] {1.0, 0.0};
                                            } else {
                                                var115 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                            }
                                        }
                                    }
                                } else {
                                    if (input[2] <= -0.22033625841140747) {
                                        if (input[1] <= 0.8402072191238403) {
                                            if (input[2] <= -0.227542482316494) {
                                                var115 = new double[2] {0.0, 1.0};
                                            } else {
                                                var115 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                            }
                                        } else {
                                            var115 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        var115 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[1] <= 0.8243632316589355) {
                                    if (input[3] <= -0.47055235505104065) {
                                        if (input[4] <= 0.3208827171474695) {
                                            var115 = new double[2] {0.0, 1.0};
                                        } else {
                                            var115 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.30026890337467194) {
                                            if (input[4] <= -0.02925485372543335) {
                                                var115 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[4] <= 0.42657680064439774) {
                                                    var115 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                                } else {
                                                    var115 = new double[2] {1.0, 0.0};
                                                }
                                            }
                                        } else {
                                            var115 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var115 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[3] <= -1.3003421425819397) {
                                var115 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[1] <= -1.4708406329154968) {
                                    var115 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[4] <= 0.5460759997367859) {
                                        if (input[1] <= -1.359622061252594) {
                                            var115 = new double[2] {0.0, 1.0};
                                        } else {
                                            var115 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var115 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var115 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[0] <= 0.7256535552442074) {
                    if (input[4] <= -1.2314326763153076) {
                        var115 = new double[2] {0.408256880733945, 0.591743119266055};
                    } else {
                        if (input[2] <= -0.1693693920969963) {
                            if (input[2] <= -0.23185770213603973) {
                                var115 = new double[2] {1.0, 0.0};
                            } else {
                                var115 = new double[2] {0.20554272517321018, 0.7944572748267898};
                            }
                        } else {
                            var115 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[5] <= -0.4837159663438797) {
                        var115 = new double[2] {1.0, 0.0};
                    } else {
                        var115 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var116;
            if (input[4] <= 0.5460759997367859) {
                if (input[5] <= -0.2927231043577194) {
                    if (input[2] <= -0.1394634023308754) {
                        if (input[1] <= -1.4295219779014587) {
                            var116 = new double[2] {1.0, 0.0};
                        } else {
                            var116 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var116 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= -1.4062220454216003) {
                        var116 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= -0.13955513387918472) {
                            if (input[5] <= -0.2172691449522972) {
                                var116 = new double[2] {0.0, 1.0};
                            } else {
                                var116 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= -0.49617360532283783) {
                                var116 = new double[2] {1.0, 0.0};
                            } else {
                                var116 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                var116 = new double[2] {1.0, 0.0};
            }
            double[] var117;
            if (input[1] <= -1.461210012435913) {
                var117 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5473714768886566) {
                    if (input[5] <= -0.26604120433330536) {
                        if (input[5] <= -0.9596468508243561) {
                            if (input[5] <= -1.392390251159668) {
                                if (input[2] <= -0.1810731440782547) {
                                    if (input[2] <= -0.242315873503685) {
                                        var117 = new double[2] {0.0, 1.0};
                                    } else {
                                        var117 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var117 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                }
                            } else {
                                var117 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= -0.1390100121498108) {
                                var117 = new double[2] {0.0, 1.0};
                            } else {
                                var117 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= -0.6005170047283173) {
                            if (input[2] <= -0.14291485399007797) {
                                if (input[4] <= -1.4537211656570435) {
                                    var117 = new double[2] {0.0, 1.0};
                                } else {
                                    var117 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= -0.08879394829273224) {
                                    var117 = new double[2] {1.0, 0.0};
                                } else {
                                    var117 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[3] <= 1.444031000137329) {
                                if (input[4] <= -0.010733339935541153) {
                                    if (input[1] <= -1.1169915199279785) {
                                        var117 = new double[2] {0.0, 1.0};
                                    } else {
                                        var117 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[5] <= 0.2522084340453148) {
                                        if (input[0] <= 0.10920029878616333) {
                                            var117 = new double[2] {1.0, 0.0};
                                        } else {
                                            var117 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var117 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var117 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var117 = new double[2] {1.0, 0.0};
                }
            }
            double[] var118;
            if (input[3] <= 0.9062266945838928) {
                if (input[4] <= 0.5516729354858398) {
                    if (input[2] <= -0.14689429849386215) {
                        if (input[4] <= -1.0697388648986816) {
                            if (input[1] <= -1.461210012435913) {
                                var118 = new double[2] {1.0, 0.0};
                            } else {
                                var118 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[4] <= 0.13346119225025177) {
                                if (input[3] <= -1.4269980788230896) {
                                    var118 = new double[2] {0.0, 1.0};
                                } else {
                                    var118 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[0] <= 0.7256535552442074) {
                                    if (input[2] <= -0.2289505898952484) {
                                        if (input[3] <= -0.6165450811386108) {
                                            var118 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[2] <= -0.24087683856487274) {
                                                var118 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                            } else {
                                                var118 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    } else {
                                        if (input[2] <= -0.2253841832280159) {
                                            var118 = new double[2] {0.0, 1.0};
                                        } else {
                                            var118 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var118 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var118 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var118 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.5337789058685303) {
                    if (input[4] <= 0.1672857254743576) {
                        if (input[2] <= -0.15494853258132935) {
                            if (input[3] <= 1.2397862076759338) {
                                var118 = new double[2] {1.0, 0.0};
                            } else {
                                var118 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var118 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= -0.20309573411941528) {
                            var118 = new double[2] {0.0, 1.0};
                        } else {
                            var118 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[2] <= -0.23925146460533142) {
                        var118 = new double[2] {1.0, 0.0};
                    } else {
                        var118 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var119;
            if (input[1] <= -1.465869963169098) {
                var119 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5511365234851837) {
                    if (input[2] <= -0.14260688424110413) {
                        if (input[2] <= -0.25468702614307404) {
                            var119 = new double[2] {0.0, 1.0};
                        } else {
                            var119 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var119 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var119 = new double[2] {1.0, 0.0};
                }
            }
            double[] var120;
            if (input[1] <= -1.4587246775627136) {
                var120 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5511365234851837) {
                    if (input[1] <= 1.134097695350647) {
                        if (input[5] <= 0.43649978935718536) {
                            if (input[2] <= -0.1394251435995102) {
                                var120 = new double[2] {0.0, 1.0};
                            } else {
                                var120 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 1.3280103206634521) {
                                if (input[1] <= -1.1673194766044617) {
                                    var120 = new double[2] {0.7212317666126418, 0.2787682333873582};
                                } else {
                                    if (input[1] <= 0.9231551587581635) {
                                        if (input[5] <= 0.5805821418762207) {
                                            if (input[1] <= 0.05391039326786995) {
                                                var120 = new double[2] {0.0, 1.0};
                                            } else {
                                                var120 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            }
                                        } else {
                                            var120 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var120 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                    }
                                }
                            } else {
                                var120 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= -0.7427175939083099) {
                            var120 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.9279805719852448) {
                                var120 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[0] <= -0.5072529651224613) {
                                    var120 = new double[2] {0.4369885433715221, 0.563011456628478};
                                } else {
                                    var120 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    var120 = new double[2] {1.0, 0.0};
                }
            }
            double[] var121;
            if (input[4] <= 0.5473714768886566) {
                if (input[5] <= 1.4218690395355225) {
                    if (input[2] <= -0.14375081658363342) {
                        if (input[2] <= -0.2518240213394165) {
                            if (input[1] <= -1.3645926713943481) {
                                var121 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[5] <= -1.5605483651161194) {
                                    var121 = new double[2] {0.0, 1.0};
                                } else {
                                    var121 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[5] <= -1.3467207551002502) {
                                if (input[1] <= -1.4108819961547852) {
                                    var121 = new double[2] {1.0, 0.0};
                                } else {
                                    var121 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[1] <= -1.4487833380699158) {
                                    var121 = new double[2] {1.0, 0.0};
                                } else {
                                    var121 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var121 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 0.9813984334468842) {
                        var121 = new double[2] {0.3409961685823755, 0.6590038314176245};
                    } else {
                        var121 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var121 = new double[2] {1.0, 0.0};
            }
            double[] var122;
            if (input[4] <= 0.5460759997367859) {
                if (input[1] <= -1.465869963169098) {
                    var122 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 1.641416072845459) {
                        if (input[3] <= 1.41647607088089) {
                            if (input[4] <= -0.39480678737163544) {
                                if (input[2] <= -0.14273687452077866) {
                                    if (input[3] <= -1.2377392649650574) {
                                        var122 = new double[2] {0.0, 1.0};
                                    } else {
                                        var122 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var122 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[1] <= 1.1232243776321411) {
                                    var122 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= -0.41632863879203796) {
                                        var122 = new double[2] {0.0, 1.0};
                                    } else {
                                        var122 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                    }
                                }
                            }
                        } else {
                            var122 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= -2.161455512046814) {
                            var122 = new double[2] {0.3409961685823755, 0.6590038314176245};
                        } else {
                            var122 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var122 = new double[2] {1.0, 0.0};
            }
            double[] var123;
            if (input[4] <= 0.5423109531402588) {
                if (input[3] <= 1.41647607088089) {
                    if (input[0] <= 0.7256535552442074) {
                        if (input[4] <= 0.13346119225025177) {
                            if (input[2] <= -0.15025613456964493) {
                                if (input[1] <= -1.5394979119300842) {
                                    var123 = new double[2] {1.0, 0.0};
                                } else {
                                    var123 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var123 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.19130297005176544) {
                                var123 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.22670652717351913) {
                                    if (input[4] <= 0.4826575070619583) {
                                        var123 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var123 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var123 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= 1.4503561854362488) {
                            var123 = new double[2] {0.0, 1.0};
                        } else {
                            var123 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var123 = new double[2] {1.0, 0.0};
                }
            } else {
                var123 = new double[2] {1.0, 0.0};
            }
            double[] var124;
            if (input[3] <= 0.956985741853714) {
                if (input[2] <= -0.14689429849386215) {
                    if (input[4] <= 0.5460759997367859) {
                        if (input[2] <= -0.2295478731393814) {
                            if (input[1] <= -1.4379099607467651) {
                                var124 = new double[2] {1.0, 0.0};
                            } else {
                                var124 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var124 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var124 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var124 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= -0.21405058354139328) {
                    if (input[4] <= 0.6879831552505493) {
                        var124 = new double[2] {0.2564841498559078, 0.7435158501440922};
                    } else {
                        var124 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.1693693920969963) {
                        if (input[4] <= 0.675473541021347) {
                            var124 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            var124 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var124 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var125;
            if (input[3] <= 1.0879924893379211) {
                if (input[1] <= -1.461210012435913) {
                    var125 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 0.4327171891927719) {
                        if (input[4] <= 0.5460759997367859) {
                            if (input[5] <= -1.3791113495826721) {
                                var125 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            } else {
                                if (input[5] <= 1.4218690395355225) {
                                    if (input[4] <= -0.39480678737163544) {
                                        if (input[4] <= -0.6460920870304108) {
                                            if (input[1] <= -1.1825421452522278) {
                                                var125 = new double[2] {0.14710743801652895, 0.8528925619834711};
                                            } else {
                                                var125 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            if (input[2] <= -0.14273687452077866) {
                                                var125 = new double[2] {0.0, 1.0};
                                            } else {
                                                var125 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    } else {
                                        var125 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var125 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                }
                            }
                        } else {
                            var125 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= -0.13966695219278336) {
                            if (input[3] <= 0.4791254550218582) {
                                var125 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[0] <= -0.5072529651224613) {
                                    if (input[4] <= 0.5588183701038361) {
                                        var125 = new double[2] {0.0, 1.0};
                                    } else {
                                        var125 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 0.7942286133766174) {
                                        if (input[2] <= -0.2461184561252594) {
                                            var125 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[3] <= 0.574359118938446) {
                                                var125 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[2] <= -0.2424531951546669) {
                                                    var125 = new double[2] {1.0, 0.0};
                                                } else {
                                                    var125 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[2] <= -0.2275169938802719) {
                                            var125 = new double[2] {0.8380414312617703, 0.16195856873822975};
                                        } else {
                                            var125 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    }
                                }
                            }
                        } else {
                            var125 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[3] <= 1.4280781745910645) {
                    if (input[1] <= 0.5705487281084061) {
                        if (input[2] <= -0.23185770213603973) {
                            var125 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        } else {
                            var125 = new double[2] {0.3409961685823755, 0.6590038314176245};
                        }
                    } else {
                        if (input[3] <= 1.2745924592018127) {
                            var125 = new double[2] {1.0, 0.0};
                        } else {
                            var125 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        }
                    }
                } else {
                    var125 = new double[2] {1.0, 0.0};
                }
            }
            double[] var126;
            if (input[5] <= -0.26604120433330536) {
                if (input[1] <= -1.486995279788971) {
                    var126 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= -0.9654796421527863) {
                        if (input[2] <= -0.12197871878743172) {
                            if (input[5] <= -1.128177285194397) {
                                if (input[3] <= -1.1052823066711426) {
                                    var126 = new double[2] {0.408256880733945, 0.591743119266055};
                                } else {
                                    var126 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[4] <= 0.4980718493461609) {
                                    var126 = new double[2] {0.0, 1.0};
                                } else {
                                    var126 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var126 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= -0.8978441059589386) {
                            if (input[1] <= 0.3158022128045559) {
                                var126 = new double[2] {1.0, 0.0};
                            } else {
                                var126 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            }
                        } else {
                            if (input[3] <= 1.0077447891235352) {
                                if (input[4] <= 0.5794248282909393) {
                                    if (input[4] <= -0.39480678737163544) {
                                        if (input[5] <= -0.8532915115356445) {
                                            var126 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                        } else {
                                            if (input[4] <= -0.7932015061378479) {
                                                var126 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[2] <= -0.17074859887361526) {
                                                    var126 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var126 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[1] <= -1.1660768389701843) {
                                            var126 = new double[2] {0.0, 1.0};
                                        } else {
                                            var126 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[0] <= 0.7256535552442074) {
                                        var126 = new double[2] {1.0, 0.0};
                                    } else {
                                        var126 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var126 = new double[2] {0.7563739376770539, 0.24362606232294617};
                            }
                        }
                    }
                }
            } else {
                if (input[4] <= 0.5157128572463989) {
                    if (input[2] <= -0.13962869346141815) {
                        if (input[1] <= -1.5295565724372864) {
                            var126 = new double[2] {1.0, 0.0};
                        } else {
                            var126 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[5] <= -0.04526387108489871) {
                            var126 = new double[2] {1.0, 0.0};
                        } else {
                            var126 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var126 = new double[2] {1.0, 0.0};
                }
            }
            double[] var127;
            if (input[4] <= 0.5511365234851837) {
                if (input[5] <= -0.2914820909500122) {
                    if (input[1] <= -1.465869963169098) {
                        var127 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= -0.1390100121498108) {
                            var127 = new double[2] {0.0, 1.0};
                        } else {
                            var127 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 0.8796386122703552) {
                        if (input[4] <= -1.564242959022522) {
                            var127 = new double[2] {0.7563739376770539, 0.24362606232294617};
                        } else {
                            if (input[1] <= -1.2499567866325378) {
                                if (input[2] <= -0.22630229592323303) {
                                    var127 = new double[2] {1.0, 0.0};
                                } else {
                                    var127 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                }
                            } else {
                                if (input[1] <= 1.2145602703094482) {
                                    if (input[3] <= 0.0002983398735523224) {
                                        var127 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[5] <= 0.6323326230049133) {
                                            if (input[2] <= -0.2158263847231865) {
                                                var127 = new double[2] {0.0, 1.0};
                                            } else {
                                                var127 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            }
                                        } else {
                                            var127 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= -0.15266791358590126) {
                                        var127 = new double[2] {0.0, 1.0};
                                    } else {
                                        var127 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[3] <= 1.444031000137329) {
                            if (input[4] <= -0.5349427759647369) {
                                if (input[5] <= 0.32493215799331665) {
                                    var127 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[2] <= -0.2336980104446411) {
                                        var127 = new double[2] {0.0, 1.0};
                                    } else {
                                        var127 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var127 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            }
                        } else {
                            var127 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var127 = new double[2] {1.0, 0.0};
            }
            double[] var128;
            if (input[2] <= -0.14371255785226822) {
                if (input[4] <= 0.5423109531402588) {
                    if (input[1] <= -1.461210012435913) {
                        var128 = new double[2] {1.0, 0.0};
                    } else {
                        var128 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var128 = new double[2] {1.0, 0.0};
                }
            } else {
                var128 = new double[2] {1.0, 0.0};
            }
            double[] var129;
            if (input[1] <= -1.461210012435913) {
                var129 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.14335492253303528) {
                    if (input[2] <= -0.24466706067323685) {
                        if (input[2] <= -0.24601296335458755) {
                            if (input[3] <= -0.08768403111025691) {
                                if (input[4] <= 0.5570573210716248) {
                                    var129 = new double[2] {0.0, 1.0};
                                } else {
                                    var129 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.5557474792003632) {
                                    if (input[2] <= -0.24960143864154816) {
                                        var129 = new double[2] {0.14710743801652895, 0.8528925619834711};
                                    } else {
                                        var129 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[2] <= -0.248986154794693) {
                                        var129 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    } else {
                                        var129 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                    }
                                }
                            }
                        } else {
                            if (input[5] <= 0.8294064700603485) {
                                var129 = new double[2] {1.0, 0.0};
                            } else {
                                var129 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[3] <= 0.8496665954589844) {
                            if (input[5] <= -0.18922210484743118) {
                                if (input[5] <= -0.6910902857780457) {
                                    if (input[2] <= -0.22946730256080627) {
                                        if (input[5] <= -1.0040753483772278) {
                                            var129 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[3] <= -0.16623971331864595) {
                                                var129 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                            } else {
                                                var129 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        if (input[5] <= -0.7434612810611725) {
                                            if (input[4] <= 0.5223724842071533) {
                                                var129 = new double[2] {0.0, 1.0};
                                            } else {
                                                var129 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[4] <= 0.2139538675546646) {
                                                var129 = new double[2] {0.0, 1.0};
                                            } else {
                                                var129 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    }
                                } else {
                                    var129 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[4] <= 0.5233036279678345) {
                                    var129 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= 0.5944444537162781) {
                                        var129 = new double[2] {1.0, 0.0};
                                    } else {
                                        var129 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.47624076902866364) {
                                var129 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.7766840159893036) {
                                    var129 = new double[2] {1.0, 0.0};
                                } else {
                                    var129 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    var129 = new double[2] {1.0, 0.0};
                }
            }
            double[] var130;
            if (input[5] <= -0.26604120433330536) {
                if (input[4] <= 0.5555087924003601) {
                    if (input[2] <= -0.14375081658363342) {
                        if (input[1] <= -1.461210012435913) {
                            var130 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.25425826013088226) {
                                var130 = new double[2] {0.0, 1.0};
                            } else {
                                var130 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var130 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var130 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 1.4218690395355225) {
                    if (input[2] <= -0.13579931110143661) {
                        if (input[1] <= -1.3962806463241577) {
                            var130 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[4] <= 0.5018875002861023) {
                                if (input[2] <= -0.2525661736726761) {
                                    var130 = new double[2] {0.0, 1.0};
                                } else {
                                    var130 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var130 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var130 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= -0.6332230567932129) {
                        var130 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= 1.233260065317154) {
                            if (input[2] <= -0.2123340368270874) {
                                var130 = new double[2] {0.0, 1.0};
                            } else {
                                var130 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var130 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var131;
            if (input[3] <= 0.9927587807178497) {
                if (input[2] <= -0.14339318126440048) {
                    if (input[2] <= -0.2504676431417465) {
                        if (input[3] <= 0.4926612079143524) {
                            if (input[5] <= 0.6932666599750519) {
                                if (input[1] <= -0.06942419335246086) {
                                    if (input[4] <= -0.12084019184112549) {
                                        var131 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    } else {
                                        var131 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var131 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var131 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            var131 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[2] <= -0.2439572438597679) {
                            if (input[1] <= -1.0427422225475311) {
                                var131 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.2459516003727913) {
                                    if (input[3] <= 0.48686017096042633) {
                                        var131 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[4] <= 0.538333386182785) {
                                            var131 = new double[2] {0.0, 1.0};
                                        } else {
                                            var131 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 0.10403074324131012) {
                                        var131 = new double[2] {1.0, 0.0};
                                    } else {
                                        var131 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= -0.23991797864437103) {
                                if (input[4] <= 0.6217308044433594) {
                                    if (input[4] <= -1.3808192610740662) {
                                        var131 = new double[2] {0.0, 1.0};
                                    } else {
                                        var131 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var131 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= -0.2365684136748314) {
                                    if (input[4] <= 0.31376761198043823) {
                                        var131 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= 0.853876531124115) {
                                            var131 = new double[2] {1.0, 0.0};
                                        } else {
                                            var131 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.5438999533653259) {
                                        if (input[1] <= -1.4633846282958984) {
                                            var131 = new double[2] {1.0, 0.0};
                                        } else {
                                            var131 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var131 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var131 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= -0.22902041673660278) {
                    if (input[0] <= -0.5072529651224613) {
                        if (input[1] <= -0.8566530048847198) {
                            var131 = new double[2] {1.0, 0.0};
                        } else {
                            var131 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        }
                    } else {
                        var131 = new double[2] {0.3409961685823755, 0.6590038314176245};
                    }
                } else {
                    if (input[5] <= -0.7087127566337585) {
                        var131 = new double[2] {1.0, 0.0};
                    } else {
                        var131 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var132;
            if (input[2] <= -0.14689429849386215) {
                if (input[4] <= 0.5423109531402588) {
                    if (input[1] <= -1.4633846282958984) {
                        var132 = new double[2] {1.0, 0.0};
                    } else {
                        var132 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var132 = new double[2] {1.0, 0.0};
                }
            } else {
                var132 = new double[2] {1.0, 0.0};
            }
            double[] var133;
            if (input[2] <= -0.14375081658363342) {
                if (input[1] <= -1.461210012435913) {
                    var133 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.24999899417161942) {
                        if (input[3] <= -1.243540346622467) {
                            var133 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[3] <= 0.39501045644283295) {
                                if (input[4] <= 0.24026859551668167) {
                                    var133 = new double[2] {0.0, 1.0};
                                } else {
                                    var133 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= -0.25148648023605347) {
                                    var133 = new double[2] {0.0, 1.0};
                                } else {
                                    var133 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[1] <= -1.1101568341255188) {
                            if (input[5] <= 0.40845276415348053) {
                                var133 = new double[2] {0.0, 1.0};
                            } else {
                                var133 = new double[2] {0.20554272517321018, 0.7944572748267898};
                            }
                        } else {
                            if (input[4] <= 0.5423109531402588) {
                                if (input[1] <= -0.9980062544345856) {
                                    var133 = new double[2] {0.0, 1.0};
                                } else {
                                    var133 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var133 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                var133 = new double[2] {1.0, 0.0};
            }
            double[] var134;
            if (input[4] <= 0.5460759997367859) {
                if (input[0] <= -0.5072529651224613) {
                    if (input[2] <= -0.14375081658363342) {
                        if (input[4] <= 0.321267306804657) {
                            if (input[1] <= -1.5419832468032837) {
                                var134 = new double[2] {1.0, 0.0};
                            } else {
                                var134 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[2] <= -0.2186228632926941) {
                                var134 = new double[2] {1.0, 0.0};
                            } else {
                                var134 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            }
                        }
                    } else {
                        var134 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= 1.4503561854362488) {
                        if (input[3] <= 0.9813984334468842) {
                            if (input[2] <= -0.13955513387918472) {
                                if (input[5] <= -0.06102481670677662) {
                                    if (input[1] <= -1.4587246775627136) {
                                        var134 = new double[2] {1.0, 0.0};
                                    } else {
                                        var134 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var134 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var134 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[1] <= -0.8482650220394135) {
                                var134 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                if (input[4] <= -0.36233846098184586) {
                                    var134 = new double[2] {1.0, 0.0};
                                } else {
                                    var134 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            }
                        }
                    } else {
                        if (input[0] <= 0.7256535552442074) {
                            var134 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            if (input[2] <= 3.034950613975525) {
                                var134 = new double[2] {1.0, 0.0};
                            } else {
                                var134 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                var134 = new double[2] {1.0, 0.0};
            }
            double[] var135;
            if (input[4] <= 0.5511365234851837) {
                if (input[4] <= -1.6169432401657104) {
                    if (input[5] <= 0.2000856250524521) {
                        var135 = new double[2] {0.0, 1.0};
                    } else {
                        var135 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= -1.461210012435913) {
                        var135 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= -0.13955513387918472) {
                            if (input[3] <= -1.3271719217300415) {
                                var135 = new double[2] {0.0, 1.0};
                            } else {
                                var135 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var135 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var135 = new double[2] {1.0, 0.0};
            }
            double[] var136;
            if (input[2] <= -0.14335492253303528) {
                if (input[5] <= -0.265917107462883) {
                    if (input[1] <= -1.465869963169098) {
                        var136 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -0.466714009642601) {
                            if (input[4] <= 0.5555087924003601) {
                                if (input[1] <= -1.315507411956787) {
                                    var136 = new double[2] {0.0, 1.0};
                                } else {
                                    var136 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var136 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.3695042133331299) {
                                var136 = new double[2] {0.0, 1.0};
                            } else {
                                var136 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        }
                    }
                } else {
                    if (input[5] <= 0.19313592463731766) {
                        if (input[1] <= -0.4819892644882202) {
                            if (input[4] <= 0.5238501727581024) {
                                if (input[4] <= -0.058585651218891144) {
                                    var136 = new double[2] {0.1287988422575977, 0.8712011577424024};
                                } else {
                                    var136 = new double[2] {0.408256880733945, 0.591743119266055};
                                }
                            } else {
                                var136 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= -0.23476608842611313) {
                                var136 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.23078741878271103) {
                                    var136 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= 0.6724473536014557) {
                                        var136 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[5] <= -0.047621808887925) {
                                            var136 = new double[2] {1.0, 0.0};
                                        } else {
                                            var136 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[2] <= -0.2518213093280792) {
                            if (input[2] <= -0.2532587796449661) {
                                var136 = new double[2] {0.6082004555808657, 0.3917995444191344};
                            } else {
                                var136 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 0.048398589715361595) {
                                if (input[4] <= 0.5202976763248444) {
                                    if (input[1] <= -1.2418794631958008) {
                                        var136 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    } else {
                                        var136 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[1] <= -1.2055314779281616) {
                                        var136 = new double[2] {1.0, 0.0};
                                    } else {
                                        var136 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[2] <= -0.22151604294776917) {
                                    if (input[1] <= -0.9911715984344482) {
                                        if (input[4] <= -0.3041323348879814) {
                                            var136 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                        } else {
                                            var136 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[1] <= 0.8047912418842316) {
                                            if (input[2] <= -0.23409107327461243) {
                                                if (input[2] <= -0.24612950533628464) {
                                                    var136 = new double[2] {0.0, 1.0};
                                                } else {
                                                    if (input[5] <= 0.5171660482883453) {
                                                        var136 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                                    } else {
                                                        if (input[0] <= 0.7256535552442074) {
                                                            var136 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                                        } else {
                                                            var136 = new double[2] {0.0, 1.0};
                                                        }
                                                    }
                                                }
                                            } else {
                                                if (input[5] <= 0.6751478016376495) {
                                                    var136 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var136 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        } else {
                                            var136 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                        }
                                    }
                                } else {
                                    if (input[5] <= 1.422489583492279) {
                                        var136 = new double[2] {1.0, 0.0};
                                    } else {
                                        var136 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                var136 = new double[2] {1.0, 0.0};
            }
            double[] var137;
            if (input[4] <= 0.5460759997367859) {
                if (input[2] <= -0.14375081658363342) {
                    if (input[4] <= -0.9344204366207123) {
                        if (input[5] <= -0.5354664921760559) {
                            if (input[3] <= 0.9219378530979156) {
                                var137 = new double[2] {0.0, 1.0};
                            } else {
                                var137 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            }
                        } else {
                            if (input[1] <= -1.2061528265476227) {
                                var137 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= -0.6680292785167694) {
                                    var137 = new double[2] {0.0, 1.0};
                                } else {
                                    var137 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[4] <= 0.4553306847810745) {
                            var137 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= -1.1269362270832062) {
                                var137 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            } else {
                                var137 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var137 = new double[2] {1.0, 0.0};
                }
            } else {
                var137 = new double[2] {1.0, 0.0};
            }
            double[] var138;
            if (input[3] <= 1.0372334122657776) {
                if (input[2] <= -0.14335492253303528) {
                    if (input[3] <= -0.6373321115970612) {
                        if (input[5] <= 0.24141156673431396) {
                            if (input[2] <= -0.1935255452990532) {
                                if (input[2] <= -0.22239672392606735) {
                                    if (input[3] <= -1.2358055710792542) {
                                        if (input[0] <= 0.7256535552442074) {
                                            var138 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                        } else {
                                            if (input[5] <= -0.5138727501034737) {
                                                var138 = new double[2] {0.0, 1.0};
                                            } else {
                                                var138 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                            }
                                        }
                                    } else {
                                        if (input[3] <= -1.0825616121292114) {
                                            if (input[1] <= -1.1027008593082428) {
                                                var138 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                            } else {
                                                var138 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[3] <= -0.9452704191207886) {
                                                var138 = new double[2] {0.5798045602605864, 0.42019543973941365};
                                            } else {
                                                if (input[4] <= 0.6260221302509308) {
                                                    var138 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var138 = new double[2] {1.0, 0.0};
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    var138 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var138 = new double[2] {0.1287988422575977, 0.8712011577424023};
                            }
                        } else {
                            if (input[4] <= 0.40886497497558594) {
                                var138 = new double[2] {0.0, 1.0};
                            } else {
                                var138 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= 0.5741174221038818) {
                            if (input[1] <= -1.465869963169098) {
                                var138 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 0.11293510720133781) {
                                    if (input[1] <= -1.0769155621528625) {
                                        if (input[2] <= -0.24389497190713882) {
                                            var138 = new double[2] {1.0, 0.0};
                                        } else {
                                            var138 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[1] <= 1.2655096054077148) {
                                            if (input[4] <= 0.587552011013031) {
                                                var138 = new double[2] {0.0, 1.0};
                                            } else {
                                                var138 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var138 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                        }
                                    }
                                } else {
                                    if (input[1] <= 0.47362077236175537) {
                                        if (input[2] <= -0.21799852699041367) {
                                            if (input[3] <= 0.4167643338441849) {
                                                if (input[4] <= 0.2779694925993681) {
                                                    var138 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var138 = new double[2] {1.0, 0.0};
                                                }
                                            } else {
                                                var138 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var138 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                        }
                                    } else {
                                        if (input[3] <= 0.3865506052970886) {
                                            if (input[4] <= 0.8420153558254242) {
                                                var138 = new double[2] {0.0, 1.0};
                                            } else {
                                                var138 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var138 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.5570572912693024) {
                                if (input[1] <= -1.508120596408844) {
                                    var138 = new double[2] {1.0, 0.0};
                                } else {
                                    var138 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= -0.9683340191841125) {
                                    var138 = new double[2] {1.0, 0.0};
                                } else {
                                    var138 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    var138 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= -1.2227285504341125) {
                    if (input[1] <= -0.6721171438694) {
                        var138 = new double[2] {0.3409961685823755, 0.6590038314176245};
                    } else {
                        if (input[4] <= -1.3486242294311523) {
                            var138 = new double[2] {1.0, 0.0};
                        } else {
                            var138 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    }
                } else {
                    var138 = new double[2] {1.0, 0.0};
                }
            }
            double[] var139;
            if (input[2] <= -0.1465366631746292) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[4] <= 0.13346119225025177) {
                        if (input[1] <= -1.4894806146621704) {
                            var139 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= -1.4692972898483276) {
                                var139 = new double[2] {0.0, 1.0};
                            } else {
                                var139 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            if (input[2] <= -0.2301882579922676) {
                                if (input[4] <= 0.4826575070619583) {
                                    var139 = new double[2] {1.0, 0.0};
                                } else {
                                    var139 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                }
                            } else {
                                if (input[1] <= -0.4527866169810295) {
                                    var139 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var139 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[5] <= -0.24668129906058311) {
                                if (input[1] <= -0.2353200912475586) {
                                    var139 = new double[2] {0.0, 1.0};
                                } else {
                                    var139 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[4] <= 0.247282475233078) {
                                    var139 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                } else {
                                    var139 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    var139 = new double[2] {1.0, 0.0};
                }
            } else {
                var139 = new double[2] {1.0, 0.0};
            }
            double[] var140;
            if (input[4] <= 0.5511365234851837) {
                if (input[1] <= -1.4487833380699158) {
                    var140 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.13955513387918472) {
                        if (input[0] <= -0.5072529651224613) {
                            var140 = new double[2] {0.0, 1.0};
                        } else {
                            var140 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var140 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var140 = new double[2] {1.0, 0.0};
            }
            double[] var141;
            if (input[4] <= 0.5511365234851837) {
                if (input[5] <= 1.428570568561554) {
                    if (input[3] <= 1.0017020404338837) {
                        if (input[2] <= -0.15258119255304337) {
                            if (input[3] <= -1.4369081258773804) {
                                var141 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            } else {
                                if (input[1] <= -1.4587246775627136) {
                                    var141 = new double[2] {1.0, 0.0};
                                } else {
                                    var141 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var141 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 0.26343565434217453) {
                            if (input[5] <= -0.629908012226224) {
                                var141 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                if (input[1] <= 0.1626436412334442) {
                                    var141 = new double[2] {1.0, 0.0};
                                } else {
                                    var141 = new double[2] {0.8054298642533937, 0.1945701357466063};
                                }
                            }
                        } else {
                            var141 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    if (input[4] <= -0.03724035806953907) {
                        if (input[2] <= -0.11968303844332695) {
                            var141 = new double[2] {0.0, 1.0};
                        } else {
                            var141 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var141 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var141 = new double[2] {1.0, 0.0};
            }
            double[] var142;
            if (input[2] <= -0.14339318126440048) {
                if (input[5] <= -0.26901964843273163) {
                    if (input[1] <= -1.46711266040802) {
                        var142 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 0.5484240353107452) {
                            if (input[5] <= -1.7001630067825317) {
                                var142 = new double[2] {0.0, 1.0};
                            } else {
                                var142 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var142 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= -1.3692526817321777) {
                        if (input[1] <= -1.4664912819862366) {
                            var142 = new double[2] {1.0, 0.0};
                        } else {
                            var142 = new double[2] {0.8380414312617702, 0.16195856873822975};
                        }
                    } else {
                        if (input[3] <= -1.3503760695457458) {
                            var142 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[5] <= 0.32431165874004364) {
                                if (input[4] <= 0.41392549872398376) {
                                    var142 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= 0.6337950825691223) {
                                        var142 = new double[2] {1.0, 0.0};
                                    } else {
                                        var142 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[1] <= -0.16728413105010986) {
                                    if (input[3] <= -0.6796313524246216) {
                                        if (input[2] <= -0.23410896211862564) {
                                            var142 = new double[2] {0.0, 1.0};
                                        } else {
                                            var142 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.4993673413991928) {
                                            if (input[4] <= -1.1921427845954895) {
                                                var142 = new double[2] {0.0, 1.0};
                                            } else {
                                                var142 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var142 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= -0.21320702880620956) {
                                        if (input[5] <= 1.3223392963409424) {
                                            if (input[4] <= 0.3608405999839306) {
                                                var142 = new double[2] {0.0, 1.0};
                                            } else {
                                                var142 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var142 = new double[2] {0.408256880733945, 0.591743119266055};
                                        }
                                    } else {
                                        var142 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                var142 = new double[2] {1.0, 0.0};
            }
            double[] var143;
            if (input[4] <= 0.5089722275733948) {
                if (input[1] <= -1.461210012435913) {
                    var143 = new double[2] {1.0, 0.0};
                } else {
                    if (input[2] <= -0.13962869346141815) {
                        if (input[3] <= -1.4369081258773804) {
                            var143 = new double[2] {0.0, 1.0};
                        } else {
                            var143 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var143 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var143 = new double[2] {1.0, 0.0};
            }
            double[] var144;
            if (input[4] <= 0.5511365234851837) {
                if (input[2] <= -0.14689429849386215) {
                    if (input[3] <= 0.45495449006557465) {
                        if (input[3] <= -1.430865466594696) {
                            var144 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            if (input[1] <= -1.461210012435913) {
                                var144 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[0] <= -0.5072529651224613) {
                                    var144 = new double[2] {0.0, 1.0};
                                } else {
                                    var144 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 0.9176429510116577) {
                            if (input[3] <= 0.4723576009273529) {
                                var144 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            } else {
                                if (input[1] <= -1.4382206201553345) {
                                    var144 = new double[2] {1.0, 0.0};
                                } else {
                                    var144 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.23385804146528244) {
                                var144 = new double[2] {0.0, 1.0};
                            } else {
                                var144 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var144 = new double[2] {1.0, 0.0};
                }
            } else {
                var144 = new double[2] {1.0, 0.0};
            }
            double[] var145;
            if (input[4] <= 0.5460759997367859) {
                if (input[0] <= 0.7256535552442074) {
                    if (input[2] <= -0.1487562507390976) {
                        if (input[1] <= -1.4332500100135803) {
                            var145 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[5] <= -1.5507442951202393) {
                                var145 = new double[2] {0.0, 1.0};
                            } else {
                                var145 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var145 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 1.0452098548412323) {
                        if (input[3] <= 0.7590253949165344) {
                            var145 = new double[2] {0.0, 1.0};
                        } else {
                            var145 = new double[2] {0.2564841498559078, 0.7435158501440922};
                        }
                    } else {
                        var145 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var145 = new double[2] {1.0, 0.0};
            }
            double[] var146;
            if (input[5] <= 1.7162388563156128) {
                if (input[2] <= -0.14335492253303528) {
                    if (input[1] <= -1.465869963169098) {
                        var146 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 0.3404449075460434) {
                            if (input[4] <= 0.5555087924003601) {
                                if (input[4] <= -2.288980722427368) {
                                    var146 = new double[2] {0.0, 1.0};
                                } else {
                                    var146 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var146 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[5] <= 0.8006148338317871) {
                                if (input[4] <= 0.5645266473293304) {
                                    var146 = new double[2] {0.0, 1.0};
                                } else {
                                    var146 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[3] <= -1.2457156777381897) {
                                    var146 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[4] <= 0.5147007405757904) {
                                        var146 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[5] <= 0.8873620927333832) {
                                            var146 = new double[2] {1.0, 0.0};
                                        } else {
                                            var146 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var146 = new double[2] {1.0, 0.0};
                }
            } else {
                var146 = new double[2] {1.0, 0.0};
            }
            double[] var147;
            if (input[2] <= -0.14371255785226822) {
                if (input[4] <= 0.4553306847810745) {
                    if (input[2] <= -0.25666046142578125) {
                        var147 = new double[2] {0.6082004555808657, 0.3917995444191344};
                    } else {
                        if (input[3] <= -1.475581705570221) {
                            var147 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            if (input[1] <= -1.4789179563522339) {
                                var147 = new double[2] {1.0, 0.0};
                            } else {
                                var147 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    if (input[1] <= 0.9057578444480896) {
                        if (input[2] <= -0.21799249947071075) {
                            var147 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -0.5099492520093918) {
                                if (input[3] <= 0.13758951425552368) {
                                    var147 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var147 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                var147 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= 0.5484240353107452) {
                            var147 = new double[2] {0.0, 1.0};
                        } else {
                            var147 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var147 = new double[2] {1.0, 0.0};
            }
            double[] var148;
            if (input[5] <= -0.718640923500061) {
                if (input[5] <= -1.3446110486984253) {
                    if (input[5] <= -1.3529258370399475) {
                        if (input[5] <= -1.3652119040489197) {
                            if (input[4] <= 0.4106968641281128) {
                                if (input[3] <= 0.05395791679620743) {
                                    var148 = new double[2] {0.0, 1.0};
                                } else {
                                    var148 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                }
                            } else {
                                var148 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var148 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var148 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= -0.001077568158507347) {
                        if (input[2] <= -0.2424059882760048) {
                            if (input[4] <= 0.14207419753074646) {
                                var148 = new double[2] {0.0, 1.0};
                            } else {
                                var148 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            var148 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[5] <= -0.73340904712677) {
                            if (input[3] <= 0.6923135221004486) {
                                if (input[2] <= -0.2398189753293991) {
                                    var148 = new double[2] {0.2927631578947369, 0.7072368421052632};
                                } else {
                                    if (input[5] <= -1.1390982866287231) {
                                        var148 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var148 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[5] <= -0.9842190444469452) {
                                    var148 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var148 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var148 = new double[2] {0.0, 1.0};
                        }
                    }
                }
            } else {
                if (input[3] <= 0.955535501241684) {
                    if (input[5] <= 0.285343661904335) {
                        if (input[4] <= 0.5405397713184357) {
                            if (input[2] <= -0.11664692685008049) {
                                if (input[4] <= -1.0514400005340576) {
                                    if (input[1] <= -1.380747377872467) {
                                        var148 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[5] <= -0.6620504260063171) {
                                            var148 = new double[2] {0.0, 1.0};
                                        } else {
                                            var148 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var148 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= 0.029060833156108856) {
                                    var148 = new double[2] {1.0, 0.0};
                                } else {
                                    var148 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var148 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= -0.5285627096891403) {
                            if (input[4] <= 0.3355582430958748) {
                                if (input[1] <= -1.1514755189418793) {
                                    var148 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                } else {
                                    var148 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var148 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.5233036279678345) {
                                if (input[2] <= -0.07151877833530307) {
                                    if (input[3] <= 0.8175191879272461) {
                                        var148 = new double[2] {0.0, 1.0};
                                    } else {
                                        var148 = new double[2] {0.20554272517321018, 0.7944572748267898};
                                    }
                                } else {
                                    var148 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= -0.2423582449555397) {
                                    var148 = new double[2] {1.0, 0.0};
                                } else {
                                    var148 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[2] <= -0.24007833003997803) {
                        var148 = new double[2] {0.5085714285714286, 0.4914285714285714};
                    } else {
                        if (input[5] <= 0.17464473843574524) {
                            if (input[2] <= -0.1926325112581253) {
                                var148 = new double[2] {1.0, 0.0};
                            } else {
                                var148 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            }
                        } else {
                            var148 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var149;
            if (input[4] <= 0.5473714768886566) {
                if (input[3] <= 1.0372334122657776) {
                    if (input[1] <= -1.4953833222389221) {
                        var149 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= 1.2218167781829834) {
                            if (input[4] <= -1.568159818649292) {
                                if (input[2] <= -0.03705517575144768) {
                                    var149 = new double[2] {0.0, 1.0};
                                } else {
                                    var149 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[0] <= 0.7256535552442074) {
                                    if (input[3] <= -0.018313314765691757) {
                                        if (input[1] <= 0.16854632645845413) {
                                            var149 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[5] <= -0.7975697219371796) {
                                                if (input[3] <= -0.920132577419281) {
                                                    if (input[2] <= -0.1828468069434166) {
                                                        var149 = new double[2] {0.0, 1.0};
                                                    } else {
                                                        var149 = new double[2] {1.0, 0.0};
                                                    }
                                                } else {
                                                    var149 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var149 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        if (input[2] <= -0.08599059982225299) {
                                            var149 = new double[2] {0.0, 1.0};
                                        } else {
                                            var149 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    var149 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[0] <= -0.5072529651224613) {
                                var149 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            } else {
                                if (input[5] <= 1.2477540969848633) {
                                    var149 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                } else {
                                    var149 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[1] <= 1.0377911031246185) {
                        if (input[1] <= -1.3608646988868713) {
                            var149 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[3] <= 1.41647607088089) {
                                var149 = new double[2] {0.408256880733945, 0.591743119266055};
                            } else {
                                var149 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var149 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var149 = new double[2] {1.0, 0.0};
            }
            double[] var150;
            if (input[4] <= 0.5460759997367859) {
                if (input[2] <= -0.14375081658363342) {
                    if (input[1] <= -1.461210012435913) {
                        var150 = new double[2] {1.0, 0.0};
                    } else {
                        var150 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var150 = new double[2] {1.0, 0.0};
                }
            } else {
                var150 = new double[2] {1.0, 0.0};
            }
            double[] var151;
            if (input[3] <= 0.9751139879226685) {
                if (input[2] <= -0.1487562507390976) {
                    if (input[5] <= -0.8956102430820465) {
                        if (input[4] <= 0.5793236196041107) {
                            if (input[5] <= -1.453696608543396) {
                                var151 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                var151 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[5] <= -1.3694314360618591) {
                                var151 = new double[2] {1.0, 0.0};
                            } else {
                                var151 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= 0.530995637178421) {
                            if (input[5] <= 1.0730186104774475) {
                                if (input[1] <= -1.5419832468032837) {
                                    var151 = new double[2] {1.0, 0.0};
                                } else {
                                    var151 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var151 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var151 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var151 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 1.4312204122543335) {
                    if (input[5] <= -1.377622127532959) {
                        var151 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[1] <= 0.9057578444480896) {
                            if (input[1] <= -0.3869253247976303) {
                                var151 = new double[2] {0.8054298642533937, 0.1945701357466063};
                            } else {
                                if (input[4] <= 0.7336796820163727) {
                                    var151 = new double[2] {1.0, 0.0};
                                } else {
                                    var151 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[1] <= 1.0874977111816406) {
                                var151 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[0] <= 0.10920029878616333) {
                                    var151 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var151 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    if (input[4] <= -1.246523141860962) {
                        var151 = new double[2] {1.0, 0.0};
                    } else {
                        var151 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var152;
            if (input[2] <= -0.14335492253303528) {
                if (input[1] <= -1.465869963169098) {
                    var152 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.5423109531402588) {
                        var152 = new double[2] {0.0, 1.0};
                    } else {
                        var152 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var152 = new double[2] {1.0, 0.0};
            }
            double[] var153;
            if (input[1] <= -1.461210012435913) {
                var153 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5423109531402588) {
                    if (input[1] <= 1.9517717957496643) {
                        if (input[2] <= -0.1394251435995102) {
                            if (input[3] <= -1.4369081258773804) {
                                var153 = new double[2] {0.0, 1.0};
                            } else {
                                var153 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var153 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var153 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var153 = new double[2] {1.0, 0.0};
                }
            }
            double[] var154;
            if (input[2] <= -0.14371255785226822) {
                if (input[4] <= 0.5400033593177795) {
                    if (input[2] <= -0.2574715316295624) {
                        var154 = new double[2] {0.6742424242424242, 0.32575757575757575};
                    } else {
                        if (input[2] <= -0.24468830227851868) {
                            if (input[2] <= -0.24518388509750366) {
                                if (input[1] <= -1.5158872604370117) {
                                    var154 = new double[2] {1.0, 0.0};
                                } else {
                                    var154 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var154 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[5] <= 1.515069603919983) {
                                if (input[3] <= -1.3868741989135742) {
                                    var154 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                } else {
                                    if (input[4] <= 0.4553306847810745) {
                                        if (input[1] <= -1.4978686571121216) {
                                            var154 = new double[2] {1.0, 0.0};
                                        } else {
                                            if (input[4] <= -1.5258538722991943) {
                                                var154 = new double[2] {0.0, 1.0};
                                            } else {
                                                var154 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        if (input[3] <= -0.2418948858976364) {
                                            var154 = new double[2] {0.0, 1.0};
                                        } else {
                                            var154 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    }
                                }
                            } else {
                                var154 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        }
                    }
                } else {
                    var154 = new double[2] {1.0, 0.0};
                }
            } else {
                var154 = new double[2] {1.0, 0.0};
            }
            double[] var155;
            if (input[2] <= -0.14375081658363342) {
                if (input[3] <= 1.4280781745910645) {
                    if (input[1] <= -1.461210012435913) {
                        var155 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 0.5460759997367859) {
                            var155 = new double[2] {0.0, 1.0};
                        } else {
                            var155 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var155 = new double[2] {1.0, 0.0};
                }
            } else {
                var155 = new double[2] {1.0, 0.0};
            }
            double[] var156;
            if (input[2] <= -0.1659189984202385) {
                if (input[4] <= 0.551268070936203) {
                    if (input[1] <= -1.4789179563522339) {
                        var156 = new double[2] {1.0, 0.0};
                    } else {
                        var156 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var156 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= -0.14707227796316147) {
                    if (input[4] <= -0.2672309875488281) {
                        var156 = new double[2] {0.0, 1.0};
                    } else {
                        var156 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var156 = new double[2] {1.0, 0.0};
                }
            }
            double[] var157;
            if (input[4] <= 0.5511365234851837) {
                if (input[2] <= -0.1429884135723114) {
                    if (input[3] <= 1.231326401233673) {
                        if (input[4] <= 0.1458088681101799) {
                            if (input[2] <= -0.25666046142578125) {
                                var157 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                if (input[2] <= -0.1790308952331543) {
                                    if (input[1] <= -1.4360460042953491) {
                                        var157 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        if (input[5] <= -1.4951466917991638) {
                                            var157 = new double[2] {0.0, 1.0};
                                        } else {
                                            var157 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= -1.0458489060401917) {
                                        var157 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        if (input[3] <= -0.8674398362636566) {
                                            var157 = new double[2] {0.0, 1.0};
                                        } else {
                                            var157 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.20412633568048477) {
                                var157 = new double[2] {0.7563739376770539, 0.24362606232294617};
                            } else {
                                if (input[1] <= -1.2195114493370056) {
                                    var157 = new double[2] {0.408256880733945, 0.591743119266055};
                                } else {
                                    var157 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var157 = new double[2] {0.7563739376770539, 0.24362606232294617};
                    }
                } else {
                    var157 = new double[2] {1.0, 0.0};
                }
            } else {
                var157 = new double[2] {1.0, 0.0};
            }
            double[] var158;
            if (input[1] <= -1.461210012435913) {
                var158 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.5460759997367859) {
                    if (input[1] <= 1.4177361726760864) {
                        if (input[3] <= 1.41647607088089) {
                            if (input[1] <= -1.188755452632904) {
                                if (input[2] <= -0.15106821432709694) {
                                    var158 = new double[2] {0.0, 1.0};
                                } else {
                                    var158 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[5] <= 0.5650694072246552) {
                                    if (input[3] <= 1.0000101029872894) {
                                        if (input[5] <= 0.5028943419456482) {
                                            if (input[3] <= -0.4613673985004425) {
                                                if (input[5] <= -1.3864333629608154) {
                                                    var158 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                                } else {
                                                    if (input[4] <= -0.5266738831996918) {
                                                        var158 = new double[2] {0.0, 1.0};
                                                    } else {
                                                        if (input[4] <= -0.39480678737163544) {
                                                            var158 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                                        } else {
                                                            var158 = new double[2] {0.0, 1.0};
                                                        }
                                                    }
                                                }
                                            } else {
                                                var158 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var158 = new double[2] {0.8054298642533937, 0.1945701357466063};
                                        }
                                    } else {
                                        var158 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                } else {
                                    var158 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var158 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= -0.6236739754676819) {
                            var158 = new double[2] {1.0, 0.0};
                        } else {
                            var158 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var158 = new double[2] {1.0, 0.0};
                }
            }
            double[] var159;
            if (input[4] <= 0.5460759997367859) {
                if (input[0] <= 0.7256535552442074) {
                    if (input[3] <= 1.444031000137329) {
                        if (input[1] <= -1.4587246775627136) {
                            var159 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -1.159863531589508) {
                                if (input[2] <= -0.13978024944663048) {
                                    var159 = new double[2] {0.0, 1.0};
                                } else {
                                    var159 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= -1.612894892692566) {
                                    if (input[5] <= 0.2000856250524521) {
                                        var159 = new double[2] {0.0, 1.0};
                                    } else {
                                        var159 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= 1.15304833650589) {
                                        if (input[4] <= -0.6151925325393677) {
                                            var159 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[0] <= -0.5072529651224613) {
                                                var159 = new double[2] {0.0, 1.0};
                                            } else {
                                                if (input[5] <= 0.48576825857162476) {
                                                    if (input[2] <= -0.19409243762493134) {
                                                        var159 = new double[2] {0.0, 1.0};
                                                    } else {
                                                        var159 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                                    }
                                                } else {
                                                    var159 = new double[2] {0.2927631578947369, 0.7072368421052632};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[2] <= -0.1188993863761425) {
                                            var159 = new double[2] {0.0, 1.0};
                                        } else {
                                            var159 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var159 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= -1.3359627723693848) {
                        var159 = new double[2] {0.5085714285714286, 0.4914285714285714};
                    } else {
                        if (input[3] <= 1.2332600951194763) {
                            if (input[2] <= -0.1394251435995102) {
                                var159 = new double[2] {0.0, 1.0};
                            } else {
                                var159 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var159 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var159 = new double[2] {1.0, 0.0};
            }
            double[] var160;
            if (input[2] <= -0.14339318126440048) {
                if (input[1] <= -1.46711266040802) {
                    var160 = new double[2] {1.0, 0.0};
                } else {
                    if (input[5] <= 1.3131557703018188) {
                        if (input[4] <= 0.5511365234851837) {
                            if (input[2] <= -0.25967273116111755) {
                                var160 = new double[2] {0.0, 1.0};
                            } else {
                                var160 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var160 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[4] <= 0.25661408714950085) {
                            var160 = new double[2] {0.0, 1.0};
                        } else {
                            var160 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var160 = new double[2] {1.0, 0.0};
            }
            double[] var161;
            if (input[1] <= -1.4633846282958984) {
                var161 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.14335492253303528) {
                    if (input[5] <= 1.3824046850204468) {
                        if (input[4] <= 0.5550331175327301) {
                            var161 = new double[2] {0.0, 1.0};
                        } else {
                            var161 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[5] <= 1.6868267059326172) {
                            var161 = new double[2] {1.0, 0.0};
                        } else {
                            var161 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var161 = new double[2] {1.0, 0.0};
                }
            }
            double[] var162;
            if (input[4] <= 0.5511365234851837) {
                if (input[2] <= -0.1487562507390976) {
                    if (input[2] <= -0.25472357869148254) {
                        var162 = new double[2] {0.6330014224751067, 0.3669985775248933};
                    } else {
                        if (input[4] <= 0.4546626955270767) {
                            if (input[2] <= -0.2518213093280792) {
                                if (input[2] <= -0.2525661736726761) {
                                    var162 = new double[2] {0.0, 1.0};
                                } else {
                                    var162 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            } else {
                                if (input[2] <= -0.17866036295890808) {
                                    if (input[2] <= -0.2397749200463295) {
                                        if (input[1] <= -1.4428806900978088) {
                                            var162 = new double[2] {1.0, 0.0};
                                        } else {
                                            if (input[4] <= -1.3799792528152466) {
                                                var162 = new double[2] {0.0, 1.0};
                                            } else {
                                                var162 = new double[2] {0.0, 1.0};
                                            }
                                        }
                                    } else {
                                        var162 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[0] <= -0.5072529651224613) {
                                        var162 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var162 = new double[2] {0.0, 1.0};
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.49700915813446045) {
                                var162 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            } else {
                                var162 = new double[2] {0.0, 1.0};
                            }
                        }
                    }
                } else {
                    var162 = new double[2] {1.0, 0.0};
                }
            } else {
                var162 = new double[2] {1.0, 0.0};
            }
            double[] var163;
            if (input[3] <= 1.3439631462097168) {
                if (input[2] <= -0.13962869346141815) {
                    if (input[4] <= 0.5516729354858398) {
                        if (input[3] <= -1.475581705570221) {
                            var163 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        } else {
                            if (input[3] <= 0.8175191879272461) {
                                if (input[2] <= -0.24468830227851868) {
                                    if (input[3] <= -1.3228211402893066) {
                                        var163 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                    } else {
                                        if (input[1] <= -1.4372886419296265) {
                                            var163 = new double[2] {1.0, 0.0};
                                        } else {
                                            var163 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[2] <= -0.22962044924497604) {
                                        if (input[4] <= 0.1280059516429901) {
                                            var163 = new double[2] {0.0, 1.0};
                                        } else {
                                            if (input[1] <= -1.34564208984375) {
                                                var163 = new double[2] {1.0, 0.0};
                                            } else {
                                                if (input[3] <= -0.5191360488533974) {
                                                    var163 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var163 = new double[2] {0.0, 1.0};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[0] <= -0.5072529651224613) {
                                            var163 = new double[2] {0.0, 1.0};
                                        } else {
                                            var163 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.8540173768997192) {
                                    var163 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                } else {
                                    if (input[4] <= 0.15338953584432602) {
                                        if (input[1] <= -1.406532645225525) {
                                            var163 = new double[2] {1.0, 0.0};
                                        } else {
                                            var163 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[5] <= -0.9929061830043793) {
                                            var163 = new double[2] {0.0, 1.0};
                                        } else {
                                            var163 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var163 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var163 = new double[2] {1.0, 0.0};
                }
            } else {
                var163 = new double[2] {1.0, 0.0};
            }
            double[] var164;
            if (input[4] <= 0.5479078888893127) {
                if (input[3] <= 1.444031000137329) {
                    if (input[1] <= -1.465869963169098) {
                        var164 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[5] <= -0.43531621992588043) {
                            var164 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[2] <= -0.13962869346141815) {
                                var164 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[3] <= -0.5872982144355774) {
                                    var164 = new double[2] {1.0, 0.0};
                                } else {
                                    var164 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    var164 = new double[2] {1.0, 0.0};
                }
            } else {
                var164 = new double[2] {1.0, 0.0};
            }
            double[] var165;
            if (input[3] <= 1.4280781745910645) {
                if (input[1] <= -1.3962806463241577) {
                    if (input[2] <= -0.22551877796649933) {
                        var165 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= -1.5419832468032837) {
                            var165 = new double[2] {1.0, 0.0};
                        } else {
                            var165 = new double[2] {0.6082004555808657, 0.3917995444191344};
                        }
                    }
                } else {
                    if (input[5] <= -0.11488504707813263) {
                        if (input[3] <= 0.3698726296424866) {
                            if (input[5] <= -0.867315024137497) {
                                if (input[5] <= -0.8841928839683533) {
                                    if (input[2] <= -0.24446538090705872) {
                                        if (input[4] <= -0.20376193523406982) {
                                            var165 = new double[2] {0.0, 1.0};
                                        } else {
                                            var165 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[5] <= -1.4942779541015625) {
                                            var165 = new double[2] {1.0, 0.0};
                                        } else {
                                            if (input[3] <= -0.0023604687303304672) {
                                                if (input[1] <= -0.2023894339799881) {
                                                    if (input[3] <= -0.9583227336406708) {
                                                        var165 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                                    } else {
                                                        if (input[2] <= -0.21938171982765198) {
                                                            var165 = new double[2] {0.0, 1.0};
                                                        } else {
                                                            var165 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                                        }
                                                    }
                                                } else {
                                                    var165 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var165 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            }
                                        }
                                    }
                                } else {
                                    var165 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.007549633271992207) {
                                    if (input[2] <= -0.24380379170179367) {
                                        if (input[4] <= 0.609231318347156) {
                                            var165 = new double[2] {0.0, 1.0};
                                        } else {
                                            var165 = new double[2] {1.0, 0.0};
                                        }
                                    } else {
                                        if (input[4] <= 0.6219332218170166) {
                                            var165 = new double[2] {0.0, 1.0};
                                        } else {
                                            var165 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                } else {
                                    if (input[3] <= 0.11704417318105698) {
                                        var165 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[3] <= 0.20260944217443466) {
                                            var165 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var165 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= -0.23542900383472443) {
                                if (input[2] <= -0.25109896063804626) {
                                    var165 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[2] <= -0.24814604222774506) {
                                        var165 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[1] <= 0.8256058990955353) {
                                            if (input[3] <= 0.6981145441532135) {
                                                var165 = new double[2] {0.0, 1.0};
                                            } else {
                                                var165 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            var165 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                if (input[3] <= 0.574359118938446) {
                                    var165 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= 0.541673332452774) {
                                        if (input[5] <= -0.6399602890014648) {
                                            var165 = new double[2] {0.0, 1.0};
                                        } else {
                                            var165 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                        }
                                    } else {
                                        var165 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 0.1508171707391739) {
                            if (input[3] <= -0.3395456448197365) {
                                if (input[1] <= 0.3046182319521904) {
                                    var165 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                } else {
                                    if (input[1] <= 1.1508736610412598) {
                                        var165 = new double[2] {1.0, 0.0};
                                    } else {
                                        var165 = new double[2] {0.8380414312617703, 0.16195856873822975};
                                    }
                                }
                            } else {
                                if (input[1] <= -0.6550304889678955) {
                                    var165 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= 0.0027635726728476584) {
                                        var165 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    } else {
                                        if (input[5] <= 0.060098662972450256) {
                                            var165 = new double[2] {1.0, 0.0};
                                        } else {
                                            var165 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= -0.2157953977584839) {
                                if (input[4] <= 0.5346594452857971) {
                                    if (input[5] <= 0.23657159507274628) {
                                        var165 = new double[2] {0.0, 1.0};
                                    } else {
                                        var165 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var165 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[3] <= 0.026402998249977827) {
                                    if (input[4] <= -0.7728480696678162) {
                                        var165 = new double[2] {0.20554272517321018, 0.7944572748267898};
                                    } else {
                                        var165 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[5] <= 0.3183547556400299) {
                                        var165 = new double[2] {1.0, 0.0};
                                    } else {
                                        var165 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                }
            } else {
                var165 = new double[2] {1.0, 0.0};
            }
            double[] var166;
            if (input[4] <= 0.5423109531402588) {
                if (input[3] <= 1.1588134765625) {
                    if (input[2] <= -0.14371255785226822) {
                        if (input[1] <= -1.465869963169098) {
                            var166 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.25967273116111755) {
                                var166 = new double[2] {0.0, 1.0};
                            } else {
                                var166 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        var166 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 1.3790110349655151) {
                        var166 = new double[2] {0.6742424242424242, 0.32575757575757575};
                    } else {
                        var166 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var166 = new double[2] {1.0, 0.0};
            }
            double[] var167;
            if (input[2] <= -0.14375081658363342) {
                if (input[0] <= -0.5072529651224613) {
                    if (input[5] <= 1.2838677167892456) {
                        if (input[5] <= -1.3192942142486572) {
                            if (input[4] <= 0.38549546897411346) {
                                var167 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[2] <= -0.24312295019626617) {
                                    var167 = new double[2] {1.0, 0.0};
                                } else {
                                    var167 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.24769707769155502) {
                                if (input[1] <= -1.1098461747169495) {
                                    var167 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                } else {
                                    var167 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[1] <= -1.4789179563522339) {
                                    var167 = new double[2] {1.0, 0.0};
                                } else {
                                    if (input[3] <= 0.6768440902233124) {
                                        if (input[5] <= -0.07070476934313774) {
                                            if (input[4] <= 0.40381455421447754) {
                                                var167 = new double[2] {0.0, 1.0};
                                            } else {
                                                var167 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                            }
                                        } else {
                                            if (input[5] <= 0.10986353084445) {
                                                var167 = new double[2] {0.9118852459016393, 0.08811475409836066};
                                            } else {
                                                if (input[4] <= 0.3672168552875519) {
                                                    var167 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var167 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                                }
                                            }
                                        }
                                    } else {
                                        if (input[4] <= 0.1515778750181198) {
                                            var167 = new double[2] {0.0, 1.0};
                                        } else {
                                            var167 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        var167 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[1] <= -1.4646273255348206) {
                        var167 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= -0.24483156204223633) {
                            if (input[5] <= 0.30246971547603607) {
                                if (input[4] <= 0.5570573210716248) {
                                    var167 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[5] <= -1.3508160710334778) {
                                        var167 = new double[2] {1.0, 0.0};
                                    } else {
                                        var167 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[5] <= 1.3501381278038025) {
                                    var167 = new double[2] {0.0, 1.0};
                                } else {
                                    var167 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            }
                        } else {
                            if (input[4] <= 0.5423109531402588) {
                                if (input[5] <= -1.4359500408172607) {
                                    var167 = new double[2] {0.0, 1.0};
                                } else {
                                    var167 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var167 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            } else {
                var167 = new double[2] {1.0, 0.0};
            }
            double[] var168;
            if (input[1] <= 1.261781632900238) {
                if (input[1] <= -1.3878926634788513) {
                    if (input[2] <= -0.22006189823150635) {
                        var168 = new double[2] {1.0, 0.0};
                    } else {
                        var168 = new double[2] {0.6082004555808657, 0.3917995444191344};
                    }
                } else {
                    if (input[4] <= 0.5460759997367859) {
                        if (input[2] <= -0.13962869346141815) {
                            if (input[1] <= -1.3431567549705505) {
                                var168 = new double[2] {0.0, 1.0};
                            } else {
                                var168 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var168 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var168 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                if (input[4] <= 0.44887346774339676) {
                    if (input[3] <= -1.0629830956459045) {
                        var168 = new double[2] {0.0, 1.0};
                    } else {
                        var168 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var168 = new double[2] {1.0, 0.0};
                }
            }
            double[] var169;
            if (input[1] <= -1.461210012435913) {
                var169 = new double[2] {1.0, 0.0};
            } else {
                if (input[2] <= -0.14090070873498917) {
                    if (input[4] <= 0.5511365234851837) {
                        var169 = new double[2] {0.0, 1.0};
                    } else {
                        var169 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var169 = new double[2] {1.0, 0.0};
                }
            }
            double[] var170;
            if (input[3] <= 1.0372334122657776) {
                if (input[2] <= -0.14375081658363342) {
                    if (input[5] <= 1.2965261340141296) {
                        if (input[5] <= 0.3065650761127472) {
                            if (input[1] <= -1.4332500100135803) {
                                var170 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= 0.5878759026527405) {
                                    if (input[2] <= -0.2543030232191086) {
                                        var170 = new double[2] {0.0, 1.0};
                                    } else {
                                        var170 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var170 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= -0.1803775280714035) {
                                if (input[4] <= 0.5504381656646729) {
                                    var170 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[1] <= -1.346574068069458) {
                                        var170 = new double[2] {1.0, 0.0};
                                    } else {
                                        var170 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                var170 = new double[2] {0.7563739376770539, 0.24362606232294617};
                            }
                        }
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            var170 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[1] <= -0.6537878215312958) {
                                var170 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= -1.1359794735908508) {
                                    var170 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var170 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                }
                            }
                        }
                    }
                } else {
                    var170 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 1.4280781745910645) {
                    if (input[1] <= -1.1924834549427032) {
                        var170 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 0.8027254641056061) {
                            var170 = new double[2] {0.20554272517321018, 0.7944572748267898};
                        } else {
                            var170 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[3] <= 1.5126765966415405) {
                        var170 = new double[2] {1.0, 0.0};
                    } else {
                        var170 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var171;
            if (input[4] <= 0.5460759997367859) {
                if (input[5] <= 1.428570568561554) {
                    if (input[2] <= -0.14371255785226822) {
                        if (input[1] <= -1.4789179563522339) {
                            var171 = new double[2] {1.0, 0.0};
                        } else {
                            var171 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var171 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.14962982386350632) {
                        var171 = new double[2] {0.3409961685823755, 0.6590038314176245};
                    } else {
                        var171 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var171 = new double[2] {1.0, 0.0};
            }
            double[] var172;
            if (input[2] <= -0.14371255785226822) {
                if (input[4] <= 0.5423109531402588) {
                    if (input[5] <= -0.6810380220413208) {
                        if (input[4] <= 0.5078589022159576) {
                            var172 = new double[2] {0.0, 1.0};
                        } else {
                            var172 = new double[2] {0.3409961685823755, 0.6590038314176245};
                        }
                    } else {
                        if (input[2] <= -0.22594540566205978) {
                            if (input[1] <= -1.4083967208862305) {
                                var172 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= -1.4354223012924194) {
                                    var172 = new double[2] {0.0, 1.0};
                                } else {
                                    var172 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var172 = new double[2] {0.0, 1.0};
                        }
                    }
                } else {
                    var172 = new double[2] {1.0, 0.0};
                }
            } else {
                var172 = new double[2] {1.0, 0.0};
            }
            double[] var173;
            if (input[3] <= 0.5741174221038818) {
                if (input[5] <= 0.9919800162315369) {
                    if (input[4] <= 0.5516729354858398) {
                        if (input[0] <= 0.7256535552442074) {
                            if (input[1] <= -1.461210012435913) {
                                var173 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.1390100121498108) {
                                    var173 = new double[2] {0.0, 1.0};
                                } else {
                                    var173 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            var173 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var173 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.5692025721073151) {
                        if (input[2] <= -0.14291485399007797) {
                            if (input[4] <= -1.2688602805137634) {
                                var173 = new double[2] {0.0, 1.0};
                            } else {
                                var173 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var173 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[0] <= -0.5072529651224613) {
                            var173 = new double[2] {1.0, 0.0};
                        } else {
                            var173 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[4] <= 0.5570572912693024) {
                    if (input[1] <= -1.406532645225525) {
                        var173 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[2] <= -0.11444494500756264) {
                            var173 = new double[2] {0.0, 1.0};
                        } else {
                            if (input[1] <= -0.6721171438694) {
                                var173 = new double[2] {1.0, 0.0};
                            } else {
                                var173 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var173 = new double[2] {1.0, 0.0};
                }
            }
            double[] var174;
            if (input[2] <= -0.14371255785226822) {
                if (input[2] <= -0.2279554381966591) {
                    if (input[4] <= 0.5460759997367859) {
                        if (input[2] <= -0.22902393341064453) {
                            if (input[1] <= -1.4509579539299011) {
                                var174 = new double[2] {1.0, 0.0};
                            } else {
                                var174 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var174 = new double[2] {0.8380414312617702, 0.16195856873822975};
                        }
                    } else {
                        var174 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= 1.0372334122657776) {
                        if (input[1] <= -0.4068079739809036) {
                            if (input[3] <= -1.1052823662757874) {
                                if (input[4] <= 0.4586099088191986) {
                                    if (input[5] <= -0.33777209371328354) {
                                        var174 = new double[2] {0.0, 1.0};
                                    } else {
                                        var174 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    }
                                } else {
                                    var174 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[1] <= -1.3878926634788513) {
                                    var174 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                } else {
                                    var174 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[4] <= 0.5640813112258911) {
                                var174 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[4] <= 0.6723866164684296) {
                                    var174 = new double[2] {1.0, 0.0};
                                } else {
                                    var174 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 0.545709490776062) {
                            if (input[2] <= -0.19477368146181107) {
                                var174 = new double[2] {1.0, 0.0};
                            } else {
                                var174 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var174 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var174 = new double[2] {1.0, 0.0};
            }
            double[] var175;
            if (input[4] <= 0.48071426153182983) {
                if (input[1] <= -1.461210012435913) {
                    var175 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 0.9949342012405396) {
                        if (input[3] <= -0.9940957725048065) {
                            if (input[2] <= -0.18059523403644562) {
                                var175 = new double[2] {0.0, 1.0};
                            } else {
                                var175 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            }
                        } else {
                            if (input[1] <= 1.487636148929596) {
                                if (input[4] <= -1.6169432401657104) {
                                    var175 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    if (input[3] <= -0.9012792110443115) {
                                        var175 = new double[2] {1.0, 0.0};
                                    } else {
                                        if (input[1] <= -1.1673194766044617) {
                                            if (input[2] <= -0.15106821432709694) {
                                                var175 = new double[2] {0.0, 1.0};
                                            } else {
                                                var175 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[2] <= -0.15609879791736603) {
                                                var175 = new double[2] {0.0, 1.0};
                                            } else {
                                                var175 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                            }
                                        }
                                    }
                                }
                            } else {
                                var175 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.1877584457397461) {
                            var175 = new double[2] {0.0, 1.0};
                        } else {
                            var175 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                if (input[1] <= 0.8445565402507782) {
                    var175 = new double[2] {1.0, 0.0};
                } else {
                    if (input[4] <= 0.5945355296134949) {
                        var175 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[3] <= -1.2196110486984253) {
                            var175 = new double[2] {1.0, 0.0};
                        } else {
                            var175 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var176;
            if (input[4] <= 0.5460759997367859) {
                if (input[2] <= -0.13962869346141815) {
                    if (input[1] <= -1.4764326214790344) {
                        var176 = new double[2] {1.0, 0.0};
                    } else {
                        var176 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var176 = new double[2] {1.0, 0.0};
                }
            } else {
                var176 = new double[2] {1.0, 0.0};
            }
            double[] var177;
            if (input[1] <= 1.2655096054077148) {
                if (input[4] <= 0.538991242647171) {
                    if (input[0] <= 0.7256535552442074) {
                        if (input[4] <= -1.5875922441482544) {
                            var177 = new double[2] {1.0, 0.0};
                        } else {
                            if (input[2] <= -0.14375081658363342) {
                                if (input[1] <= -1.4587246775627136) {
                                    var177 = new double[2] {1.0, 0.0};
                                } else {
                                    var177 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                var177 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= -1.4200586080551147) {
                            var177 = new double[2] {0.5085714285714286, 0.4914285714285714};
                        } else {
                            if (input[5] <= 1.302731215953827) {
                                var177 = new double[2] {0.0, 1.0};
                            } else {
                                var177 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            }
                        }
                    }
                } else {
                    var177 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[5] <= 0.32778650522232056) {
                    if (input[2] <= -0.16440625116229057) {
                        var177 = new double[2] {0.6082004555808657, 0.3917995444191344};
                    } else {
                        var177 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[3] <= -0.29724644124507904) {
                        var177 = new double[2] {1.0, 0.0};
                    } else {
                        var177 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var178;
            if (input[3] <= 1.3439631462097168) {
                if (input[2] <= -0.14371255785226822) {
                    if (input[2] <= -0.24830525368452072) {
                        if (input[4] <= 0.5078589022159576) {
                            if (input[1] <= -1.4170953035354614) {
                                var178 = new double[2] {1.0, 0.0};
                            } else {
                                var178 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[0] <= -0.5072529651224613) {
                                var178 = new double[2] {1.0, 0.0};
                            } else {
                                var178 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[3] <= -0.019280155189335346) {
                            if (input[4] <= 0.5479078888893127) {
                                if (input[1] <= -1.4105713367462158) {
                                    var178 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                } else {
                                    if (input[4] <= -1.4456445574760437) {
                                        var178 = new double[2] {0.0, 1.0};
                                    } else {
                                        var178 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var178 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[4] <= 0.5207733809947968) {
                                if (input[5] <= 0.028949078172445297) {
                                    var178 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[2] <= -0.2294131964445114) {
                                        if (input[2] <= -0.24427209794521332) {
                                            if (input[0] <= -0.5072529651224613) {
                                                var178 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            } else {
                                                var178 = new double[2] {0.0, 1.0};
                                            }
                                        } else {
                                            var178 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[2] <= -0.2212747558951378) {
                                            var178 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var178 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            } else {
                                var178 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var178 = new double[2] {1.0, 0.0};
                }
            } else {
                var178 = new double[2] {1.0, 0.0};
            }
            double[] var179;
            if (input[4] <= 0.5511365234851837) {
                if (input[1] <= -1.461210012435913) {
                    var179 = new double[2] {1.0, 0.0};
                } else {
                    if (input[1] <= 1.4177361726760864) {
                        if (input[2] <= -0.13582827150821686) {
                            if (input[5] <= -1.5507442951202393) {
                                var179 = new double[2] {0.0, 1.0};
                            } else {
                                var179 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var179 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= -1.0344613194465637) {
                            var179 = new double[2] {0.0, 1.0};
                        } else {
                            var179 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            } else {
                var179 = new double[2] {1.0, 0.0};
            }
            double[] var180;
            if (input[4] <= 0.5460759997367859) {
                if (input[3] <= 1.444031000137329) {
                    if (input[1] <= -1.4587246775627136) {
                        var180 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= -1.6169432401657104) {
                            if (input[2] <= -0.16844171285629272) {
                                var180 = new double[2] {0.0, 1.0};
                            } else {
                                var180 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[3] <= 1.1588134765625) {
                                if (input[3] <= 0.5526052415370941) {
                                    if (input[2] <= -0.13955513387918472) {
                                        if (input[5] <= -1.5070604085922241) {
                                            var180 = new double[2] {0.0, 1.0};
                                        } else {
                                            var180 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var180 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    var180 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= 2.4514864683151245) {
                                    var180 = new double[2] {0.0, 1.0};
                                } else {
                                    var180 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    }
                } else {
                    var180 = new double[2] {1.0, 0.0};
                }
            } else {
                var180 = new double[2] {1.0, 0.0};
            }
            double[] var181;
            if (input[2] <= -0.14375081658363342) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[3] <= -1.4407755136489868) {
                        var181 = new double[2] {0.7563739376770539, 0.24362606232294617};
                    } else {
                        if (input[4] <= 0.1271962672472) {
                            if (input[1] <= -1.4894806146621704) {
                                var181 = new double[2] {1.0, 0.0};
                            } else {
                                var181 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[4] <= 0.17255879193544388) {
                                var181 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[4] <= 0.48172637820243835) {
                                    if (input[2] <= -0.23893071711063385) {
                                        if (input[0] <= -0.5072529651224613) {
                                            var181 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var181 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var181 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[3] <= 0.5052301287651062) {
                                        var181 = new double[2] {0.0, 1.0};
                                    } else {
                                        var181 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        }
                    }
                } else {
                    var181 = new double[2] {1.0, 0.0};
                }
            } else {
                var181 = new double[2] {1.0, 0.0};
            }
            double[] var182;
            if (input[4] <= 0.5460759997367859) {
                if (input[2] <= -0.14375081658363342) {
                    if (input[4] <= 0.13346119225025177) {
                        if (input[3] <= 0.7800541818141937) {
                            if (input[2] <= -0.25666046142578125) {
                                var182 = new double[2] {0.2564841498559078, 0.7435158501440922};
                            } else {
                                if (input[3] <= 0.6294689774513245) {
                                    if (input[3] <= -1.3390156626701355) {
                                        if (input[1] <= -0.7522690892219543) {
                                            var182 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var182 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var182 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var182 = new double[2] {0.1714836223506744, 0.8285163776493256};
                                }
                            }
                        } else {
                            if (input[1] <= -1.1113995015621185) {
                                var182 = new double[2] {1.0, 0.0};
                            } else {
                                var182 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[3] <= 1.231326401233673) {
                            if (input[5] <= -1.2124424576759338) {
                                var182 = new double[2] {0.5085714285714286, 0.4914285714285714};
                            } else {
                                if (input[2] <= -0.23893071711063385) {
                                    if (input[3] <= 0.4728410094976425) {
                                        var182 = new double[2] {0.6082004555808657, 0.3917995444191344};
                                    } else {
                                        var182 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var182 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var182 = new double[2] {0.8054298642533937, 0.1945701357466063};
                        }
                    }
                } else {
                    var182 = new double[2] {1.0, 0.0};
                }
            } else {
                var182 = new double[2] {1.0, 0.0};
            }
            double[] var183;
            if (input[4] <= 0.5511365234851837) {
                if (input[5] <= 1.428570568561554) {
                    if (input[2] <= -0.13955513387918472) {
                        if (input[1] <= -1.4587246775627136) {
                            var183 = new double[2] {1.0, 0.0};
                        } else {
                            var183 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var183 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.10339386388659477) {
                        var183 = new double[2] {0.5085714285714286, 0.4914285714285714};
                    } else {
                        var183 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var183 = new double[2] {1.0, 0.0};
            }
            double[] var184;
            if (input[1] <= -1.4021833539009094) {
                if (input[3] <= -1.0281769037246704) {
                    var184 = new double[2] {0.7212317666126418, 0.2787682333873582};
                } else {
                    var184 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.9598862528800964) {
                    if (input[0] <= 0.7256535552442074) {
                        if (input[4] <= 0.5423109531402588) {
                            if (input[1] <= 1.2269870042800903) {
                                if (input[2] <= -0.14273687452077866) {
                                    var184 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[4] <= -1.0258944034576416) {
                                        var184 = new double[2] {1.0, 0.0};
                                    } else {
                                        var184 = new double[2] {1.0, 0.0};
                                    }
                                }
                            } else {
                                if (input[3] <= -0.8159556686878204) {
                                    var184 = new double[2] {0.0, 1.0};
                                } else {
                                    var184 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            }
                        } else {
                            var184 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[1] <= 1.1157683730125427) {
                            if (input[1] <= -0.26390139758586884) {
                                if (input[1] <= -1.3235847353935242) {
                                    var184 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                } else {
                                    var184 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[2] <= -0.2255362868309021) {
                                    if (input[2] <= -0.23533552139997482) {
                                        if (input[3] <= 0.6318860650062561) {
                                            if (input[3] <= 0.4593052566051483) {
                                                if (input[1] <= -0.031522881996352226) {
                                                    var184 = new double[2] {0.0, 1.0};
                                                } else {
                                                    if (input[3] <= -0.43888837844133377) {
                                                        var184 = new double[2] {0.20554272517321018, 0.7944572748267898};
                                                    } else {
                                                        var184 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                                    }
                                                }
                                            } else {
                                                var184 = new double[2] {1.0, 0.0};
                                            }
                                        } else {
                                            if (input[5] <= -0.04327823966741562) {
                                                var184 = new double[2] {0.0, 1.0};
                                            } else {
                                                var184 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                            }
                                        }
                                    } else {
                                        if (input[3] <= -0.8396432399749756) {
                                            var184 = new double[2] {0.2564841498559078, 0.7435158501440922};
                                        } else {
                                            var184 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[4] <= 0.20884273946285248) {
                                        var184 = new double[2] {0.0, 1.0};
                                    } else {
                                        var184 = new double[2] {1.0, 0.0};
                                    }
                                }
                            }
                        } else {
                            if (input[1] <= 1.21145361661911) {
                                var184 = new double[2] {1.0, 0.0};
                            } else {
                                var184 = new double[2] {0.6742424242424242, 0.32575757575757575};
                            }
                        }
                    }
                } else {
                    if (input[5] <= -0.8488238155841827) {
                        var184 = new double[2] {0.0, 1.0};
                    } else {
                        if (input[2] <= -0.15622054785490036) {
                            if (input[4] <= 0.5112292170524597) {
                                var184 = new double[2] {0.0, 1.0};
                            } else {
                                var184 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var184 = new double[2] {1.0, 0.0};
                        }
                    }
                }
            }
            double[] var185;
            if (input[4] <= 0.5473714768886566) {
                if (input[3] <= 1.0000101029872894) {
                    if (input[1] <= -1.1825421452522278) {
                        if (input[3] <= -0.5940660685300827) {
                            if (input[3] <= -0.9786263704299927) {
                                var185 = new double[2] {0.7212317666126418, 0.2787682333873582};
                            } else {
                                var185 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            if (input[3] <= 0.5248086154460907) {
                                if (input[0] <= -0.5072529651224613) {
                                    var185 = new double[2] {1.0, 0.0};
                                } else {
                                    var185 = new double[2] {0.8054298642533936, 0.1945701357466063};
                                }
                            } else {
                                if (input[2] <= -0.24746949970722198) {
                                    var185 = new double[2] {0.0, 1.0};
                                } else {
                                    var185 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                }
                            }
                        }
                    } else {
                        if (input[2] <= -0.13586653023958206) {
                            if (input[5] <= -1.6925927996635437) {
                                var185 = new double[2] {0.0, 1.0};
                            } else {
                                var185 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var185 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[4] <= 0.26343565434217453) {
                        if (input[2] <= -0.22979753464460373) {
                            var185 = new double[2] {0.6082004555808657, 0.3917995444191344};
                        } else {
                            var185 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var185 = new double[2] {0.20554272517321018, 0.7944572748267898};
                    }
                }
            } else {
                var185 = new double[2] {1.0, 0.0};
            }
            double[] var186;
            if (input[2] <= -0.14375081658363342) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[1] <= -1.461210012435913) {
                        var186 = new double[2] {1.0, 0.0};
                    } else {
                        var186 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var186 = new double[2] {1.0, 0.0};
                }
            } else {
                var186 = new double[2] {1.0, 0.0};
            }
            double[] var187;
            if (input[4] <= 0.5423109531402588) {
                if (input[5] <= 1.4218690395355225) {
                    if (input[3] <= 1.0000101029872894) {
                        if (input[4] <= -0.601255863904953) {
                            if (input[5] <= -0.5354664921760559) {
                                var187 = new double[2] {0.0, 1.0};
                            } else {
                                if (input[5] <= -0.21627632528543472) {
                                    var187 = new double[2] {0.8380414312617703, 0.16195856873822978};
                                } else {
                                    if (input[2] <= -0.14291485399007797) {
                                        if (input[3] <= 0.7404137849807739) {
                                            var187 = new double[2] {0.0, 1.0};
                                        } else {
                                            var187 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                        }
                                    } else {
                                        if (input[1] <= -0.5590345300734043) {
                                            var187 = new double[2] {1.0, 0.0};
                                        } else {
                                            var187 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[2] <= -0.13497226685285568) {
                                if (input[4] <= 0.4553306847810745) {
                                    if (input[4] <= -0.288120836019516) {
                                        if (input[3] <= -1.105040580034256) {
                                            var187 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                        } else {
                                            var187 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        var187 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    if (input[5] <= -0.8550289273262024) {
                                        var187 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                    } else {
                                        var187 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var187 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[2] <= -0.15688615292310715) {
                            if (input[1] <= -1.3503020405769348) {
                                var187 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 1.1174811124801636) {
                                    var187 = new double[2] {0.0, 1.0};
                                } else {
                                    var187 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var187 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= 0.24559161067008972) {
                        var187 = new double[2] {0.6742424242424242, 0.32575757575757575};
                    } else {
                        var187 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var187 = new double[2] {1.0, 0.0};
            }
            double[] var188;
            if (input[4] <= 0.5423109531402588) {
                if (input[3] <= 1.444031000137329) {
                    if (input[3] <= 1.0372334122657776) {
                        if (input[2] <= -0.13582827150821686) {
                            if (input[1] <= -1.4587246775627136) {
                                var188 = new double[2] {1.0, 0.0};
                            } else {
                                var188 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var188 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[3] <= 1.2397862076759338) {
                            if (input[4] <= -0.46108950674533844) {
                                var188 = new double[2] {1.0, 0.0};
                            } else {
                                var188 = new double[2] {0.408256880733945, 0.591743119266055};
                            }
                        } else {
                            var188 = new double[2] {0.1287988422575977, 0.8712011577424024};
                        }
                    }
                } else {
                    var188 = new double[2] {1.0, 0.0};
                }
            } else {
                var188 = new double[2] {1.0, 0.0};
            }
            double[] var189;
            if (input[5] <= -1.51611989736557) {
                if (input[1] <= 0.9918124377727509) {
                    var189 = new double[2] {0.0, 1.0};
                } else {
                    var189 = new double[2] {0.3409961685823755, 0.6590038314176245};
                }
            } else {
                if (input[4] <= 0.5078589022159576) {
                    if (input[2] <= -0.1487562507390976) {
                        if (input[2] <= -0.25472357869148254) {
                            var189 = new double[2] {0.5798045602605864, 0.42019543973941365};
                        } else {
                            if (input[5] <= -1.3283536434173584) {
                                if (input[1] <= -0.7901704162359238) {
                                    var189 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                } else {
                                    var189 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[1] <= -1.4789179563522339) {
                                    var189 = new double[2] {1.0, 0.0};
                                } else {
                                    var189 = new double[2] {0.0, 1.0};
                                }
                            }
                        }
                    } else {
                        var189 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[4] <= 0.5516729354858398) {
                        var189 = new double[2] {0.6742424242424242, 0.32575757575757575};
                    } else {
                        var189 = new double[2] {1.0, 0.0};
                    }
                }
            }
            double[] var190;
            if (input[3] <= 1.1476948261260986) {
                if (input[2] <= -0.14375081658363342) {
                    if (input[5] <= -0.013617880875244737) {
                        if (input[3] <= 0.8496665954589844) {
                            if (input[1] <= -1.465869963169098) {
                                var190 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[2] <= -0.24965866655111313) {
                                    if (input[4] <= 0.5408636331558228) {
                                        var190 = new double[2] {0.0, 1.0};
                                    } else {
                                        var190 = new double[2] {1.0, 0.0};
                                    }
                                } else {
                                    if (input[1] <= -0.7814717292785645) {
                                        var190 = new double[2] {0.0, 1.0};
                                    } else {
                                        if (input[1] <= -0.6158865094184875) {
                                            var190 = new double[2] {0.6330014224751067, 0.3669985775248933};
                                        } else {
                                            if (input[4] <= 0.5555087924003601) {
                                                if (input[3] <= -1.4407755136489868) {
                                                    var190 = new double[2] {0.0, 1.0};
                                                } else {
                                                    var190 = new double[2] {0.0, 1.0};
                                                }
                                            } else {
                                                var190 = new double[2] {1.0, 0.0};
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if (input[4] <= 0.4616563320159912) {
                                var190 = new double[2] {0.0, 1.0};
                            } else {
                                var190 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        if (input[4] <= 0.5213097929954529) {
                            if (input[5] <= 0.1044030487537384) {
                                var190 = new double[2] {0.3409961685823755, 0.6590038314176245};
                            } else {
                                if (input[2] <= -0.22839707881212234) {
                                    if (input[4] <= 0.1271962672472) {
                                        var190 = new double[2] {0.0, 1.0};
                                    } else {
                                        var190 = new double[2] {0.14710743801652895, 0.8528925619834711};
                                    }
                                } else {
                                    if (input[2] <= -0.22585313022136688) {
                                        var190 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                    } else {
                                        if (input[2] <= -0.2237928807735443) {
                                            var190 = new double[2] {0.0, 1.0};
                                        } else {
                                            var190 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                }
                            }
                        } else {
                            var190 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var190 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[4] <= 0.26343565434217453) {
                    if (input[4] <= -1.4170526266098022) {
                        var190 = new double[2] {1.0, 0.0};
                    } else {
                        var190 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.18543940037488937) {
                        if (input[1] <= -0.6714958101511002) {
                            var190 = new double[2] {0.6082004555808657, 0.3917995444191344};
                        } else {
                            var190 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        var190 = new double[2] {0.3409961685823755, 0.6590038314176245};
                    }
                }
            }
            double[] var191;
            if (input[4] <= 0.5460759997367859) {
                if (input[3] <= 1.0372334122657776) {
                    if (input[4] <= -1.7454097270965576) {
                        var191 = new double[2] {0.7563739376770539, 0.24362606232294617};
                    } else {
                        if (input[2] <= -0.14371255785226822) {
                            if (input[5] <= 0.9299290478229523) {
                                if (input[1] <= -1.461210012435913) {
                                    var191 = new double[2] {1.0, 0.0};
                                } else {
                                    var191 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= 1.0730186104774475) {
                                    var191 = new double[2] {0.6742424242424242, 0.32575757575757575};
                                } else {
                                    var191 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var191 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    if (input[1] <= 0.6876699924468994) {
                        var191 = new double[2] {1.0, 0.0};
                    } else {
                        var191 = new double[2] {0.7836477987421384, 0.21635220125786164};
                    }
                }
            } else {
                var191 = new double[2] {1.0, 0.0};
            }
            double[] var192;
            if (input[4] <= 0.5516729354858398) {
                if (input[4] <= -1.6169432401657104) {
                    if (input[2] <= -0.16844171285629272) {
                        var192 = new double[2] {0.0, 1.0};
                    } else {
                        var192 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.14375081658363342) {
                        if (input[1] <= -1.465869963169098) {
                            var192 = new double[2] {1.0, 0.0};
                        } else {
                            var192 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var192 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var192 = new double[2] {1.0, 0.0};
            }
            double[] var193;
            if (input[5] <= -0.2914820909500122) {
                if (input[2] <= -0.1394634023308754) {
                    if (input[1] <= -1.4391526579856873) {
                        var193 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[4] <= 0.5393151044845581) {
                            if (input[4] <= -1.3984501361846924) {
                                var193 = new double[2] {0.0, 1.0};
                            } else {
                                var193 = new double[2] {0.0, 1.0};
                            }
                        } else {
                            var193 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var193 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[3] <= 0.690621554851532) {
                    if (input[4] <= 0.5349428355693817) {
                        if (input[5] <= -0.24841872602701187) {
                            var193 = new double[2] {0.8054298642533937, 0.1945701357466063};
                        } else {
                            if (input[2] <= -0.13955513387918472) {
                                if (input[1] <= -1.3835433721542358) {
                                    var193 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    if (input[5] <= -0.17308885604143143) {
                                        var193 = new double[2] {0.0, 1.0};
                                    } else {
                                        var193 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                var193 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var193 = new double[2] {1.0, 0.0};
                    }
                } else {
                    if (input[2] <= -0.23081116378307343) {
                        if (input[4] <= 0.409644290804863) {
                            var193 = new double[2] {0.0, 1.0};
                        } else {
                            var193 = new double[2] {1.0, 0.0};
                        }
                    } else {
                        if (input[2] <= -0.15622054785490036) {
                            if (input[3] <= 0.9954176247119904) {
                                var193 = new double[2] {1.0, 0.0};
                            } else {
                                if (input[3] <= 1.4280781745910645) {
                                    var193 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                } else {
                                    var193 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[5] <= 0.2615160793066025) {
                                var193 = new double[2] {1.0, 0.0};
                            } else {
                                var193 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                }
            }
            double[] var194;
            if (input[2] <= -0.14371255785226822) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[1] <= -1.461210012435913) {
                        var194 = new double[2] {1.0, 0.0};
                    } else {
                        var194 = new double[2] {0.0, 1.0};
                    }
                } else {
                    var194 = new double[2] {1.0, 0.0};
                }
            } else {
                var194 = new double[2] {1.0, 0.0};
            }
            double[] var195;
            if (input[3] <= 0.7648264467716217) {
                if (input[4] <= 0.5460759997367859) {
                    if (input[1] <= -1.4587246775627136) {
                        var195 = new double[2] {1.0, 0.0};
                    } else {
                        if (input[1] <= 1.1325443387031555) {
                            if (input[1] <= -1.1579995155334473) {
                                if (input[4] <= -0.8302950859069824) {
                                    if (input[4] <= -1.1850377321243286) {
                                        var195 = new double[2] {0.0, 1.0};
                                    } else {
                                        var195 = new double[2] {0.7563739376770539, 0.24362606232294617};
                                    }
                                } else {
                                    var195 = new double[2] {0.0, 1.0};
                                }
                            } else {
                                if (input[5] <= -0.8681837320327759) {
                                    if (input[3] <= -0.9503463208675385) {
                                        var195 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                    } else {
                                        var195 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var195 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            if (input[1] <= 1.641416072845459) {
                                if (input[3] <= -0.8159556686878204) {
                                    var195 = new double[2] {0.0, 1.0};
                                } else {
                                    if (input[3] <= -0.4410637617111206) {
                                        var195 = new double[2] {0.8787023977433005, 0.12129760225669957};
                                    } else {
                                        if (input[2] <= 0.004797428846359253) {
                                            var195 = new double[2] {0.0, 1.0};
                                        } else {
                                            var195 = new double[2] {1.0, 0.0};
                                        }
                                    }
                                }
                            } else {
                                var195 = new double[2] {1.0, 0.0};
                            }
                        }
                    }
                } else {
                    var195 = new double[2] {1.0, 0.0};
                }
            } else {
                if (input[2] <= -0.14093896746635437) {
                    if (input[4] <= 0.43719376623630524) {
                        if (input[5] <= -1.1922138333320618) {
                            var195 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        } else {
                            if (input[1] <= -1.4727046489715576) {
                                var195 = new double[2] {1.0, 0.0};
                            } else {
                                var195 = new double[2] {0.0, 1.0};
                            }
                        }
                    } else {
                        if (input[5] <= -0.9299865067005157) {
                            var195 = new double[2] {1.0, 0.0};
                        } else {
                            var195 = new double[2] {1.0, 0.0};
                        }
                    }
                } else {
                    var195 = new double[2] {1.0, 0.0};
                }
            }
            double[] var196;
            if (input[4] <= 0.5423109531402588) {
                if (input[1] <= -1.4587246775627136) {
                    var196 = new double[2] {1.0, 0.0};
                } else {
                    if (input[3] <= 1.444031000137329) {
                        if (input[1] <= 1.641416072845459) {
                            if (input[5] <= -1.3767533898353577) {
                                if (input[5] <= -1.4292485117912292) {
                                    var196 = new double[2] {0.0, 1.0};
                                } else {
                                    var196 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[2] <= -0.14260688424110413) {
                                    if (input[4] <= -1.502504587173462) {
                                        var196 = new double[2] {0.0, 1.0};
                                    } else {
                                        var196 = new double[2] {0.0, 1.0};
                                    }
                                } else {
                                    var196 = new double[2] {1.0, 0.0};
                                }
                            }
                        } else {
                            if (input[2] <= 0.06448132218793035) {
                                var196 = new double[2] {0.2564841498559078, 0.7435158501440922};
                            } else {
                                var196 = new double[2] {1.0, 0.0};
                            }
                        }
                    } else {
                        var196 = new double[2] {1.0, 0.0};
                    }
                }
            } else {
                var196 = new double[2] {1.0, 0.0};
            }
            double[] var197;
            if (input[4] <= 0.5460759997367859) {
                if (input[0] <= -0.5072529651224613) {
                    if (input[5] <= 1.1976168751716614) {
                        if (input[5] <= -1.273004174232483) {
                            if (input[4] <= -1.1148887872695923) {
                                var197 = new double[2] {0.0, 1.0};
                            } else {
                                var197 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            if (input[2] <= -0.1364184133708477) {
                                if (input[5] <= 0.9738611280918121) {
                                    if (input[3] <= -0.12055656313896179) {
                                        if (input[1] <= -0.9296596348285675) {
                                            var197 = new double[2] {0.0, 1.0};
                                        } else {
                                            var197 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[1] <= -1.4978686571121216) {
                                            var197 = new double[2] {1.0, 0.0};
                                        } else {
                                            var197 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    if (input[1] <= -1.414609968662262) {
                                        var197 = new double[2] {1.0, 0.0};
                                    } else {
                                        var197 = new double[2] {0.0, 1.0};
                                    }
                                }
                            } else {
                                if (input[5] <= -0.11426454037427902) {
                                    var197 = new double[2] {1.0, 0.0};
                                } else {
                                    var197 = new double[2] {1.0, 0.0};
                                }
                            }
                        }
                    } else {
                        if (input[5] <= 1.5010461211204529) {
                            var197 = new double[2] {1.0, 0.0};
                        } else {
                            var197 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    }
                } else {
                    if (input[1] <= 1.1853576302528381) {
                        if (input[4] <= -0.33804795145988464) {
                            if (input[0] <= 0.7256535552442074) {
                                if (input[2] <= -0.1514245793223381) {
                                    if (input[5] <= 0.23955003917217255) {
                                        if (input[4] <= -0.8283113837242126) {
                                            if (input[3] <= 0.24345840699970722) {
                                                var197 = new double[2] {0.0, 1.0};
                                            } else {
                                                var197 = new double[2] {0.5085714285714286, 0.4914285714285714};
                                            }
                                        } else {
                                            var197 = new double[2] {0.0, 1.0};
                                        }
                                    } else {
                                        if (input[4] <= -1.2422014474868774) {
                                            var197 = new double[2] {0.0, 1.0};
                                        } else {
                                            var197 = new double[2] {0.0, 1.0};
                                        }
                                    }
                                } else {
                                    var197 = new double[2] {1.0, 0.0};
                                }
                            } else {
                                if (input[4] <= -1.2951344847679138) {
                                    var197 = new double[2] {0.3409961685823755, 0.6590038314176245};
                                } else {
                                    var197 = new double[2] {0.0, 1.0};
                                }
                            }
                        } else {
                            var197 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        if (input[4] <= -0.008334653452038765) {
                            if (input[1] <= 1.9635772109031677) {
                                var197 = new double[2] {1.0, 0.0};
                            } else {
                                var197 = new double[2] {1.0, 0.0};
                            }
                        } else {
                            var197 = new double[2] {0.6742424242424242, 0.32575757575757575};
                        }
                    }
                }
            } else {
                var197 = new double[2] {1.0, 0.0};
            }
            double[] var198;
            if (input[1] <= -1.4587246775627136) {
                var198 = new double[2] {1.0, 0.0};
            } else {
                if (input[4] <= 0.55467888712883) {
                    if (input[2] <= -0.13962869346141815) {
                        if (input[1] <= -1.4105713367462158) {
                            var198 = new double[2] {0.0, 1.0};
                        } else {
                            var198 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var198 = new double[2] {1.0, 0.0};
                    }
                } else {
                    var198 = new double[2] {1.0, 0.0};
                }
            }
            double[] var199;
            if (input[4] <= 0.5460759997367859) {
                if (input[2] <= -0.14371255785226822) {
                    if (input[5] <= 1.7745667695999146) {
                        if (input[1] <= -1.4332500100135803) {
                            var199 = new double[2] {1.0, 0.0};
                        } else {
                            var199 = new double[2] {0.0, 1.0};
                        }
                    } else {
                        var199 = new double[2] {0.5798045602605864, 0.4201954397394137};
                    }
                } else {
                    var199 = new double[2] {1.0, 0.0};
                }
            } else {
                var199 = new double[2] {1.0, 0.0};
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

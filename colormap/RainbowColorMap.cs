﻿using System;
using System.Collections.Generic;

namespace System
{
	class RainbowColorMap
	{
		double [][] RB_cm
		{
			get
			{
				return new double[][]
				{
					new double[]{ 0,0.20755,0.97632 } ,
					new double[]{0,0.21857,0.96476  } ,
					new double[]{0,0.2291,0.95322   } ,
					new double[]{0,0.23923,0.94169  } ,
					new double[]{0,0.24899,0.93018  } ,
					new double[]{0,0.25842,0.91868  } ,
					new double[]{0,0.26756,0.9072   } ,
					new double[]{0,0.27649,0.89573  } ,
					new double[]{0,0.28513,0.88428  } ,
					new double[]{0,0.29358,0.87284  } ,
					new double[]{0,0.30184,0.86141  } ,
					new double[]{0,0.30994,0.85     } ,
					new double[]{0,0.31785,0.83859  } ,
					new double[]{0,0.3256,0.82721   } ,
					new double[]{0,0.33324,0.81583  } ,
					new double[]{0,0.34073,0.80447  } ,
					new double[]{0,0.3481,0.79312   } ,
					new double[]{0,0.35537,0.78178  } ,
					new double[]{0,0.3625,0.77045   } ,
					new double[]{0,0.36954,0.75913  } ,
					new double[]{0,0.37649,0.74783  } ,
					new double[]{0,0.38333,0.73654  } ,
					new double[]{0,0.39005,0.72528  } ,
					new double[]{0,0.39667,0.71405  } ,
					new double[]{0,0.40319,0.70286  } ,
					new double[]{0,0.40957,0.69171  } ,
					new double[]{0,0.4158,0.68063   } ,
					new double[]{0,0.42188,0.66965  } ,
					new double[]{0,0.4278,0.65875   } ,
					new double[]{0,0.43352,0.64799  } ,
					new double[]{0,0.43905,0.63737  } ,
					new double[]{0,0.44438,0.62689  } ,
					new double[]{0,0.4495,0.61659   } ,
					new double[]{0,0.45441,0.60644  } ,
					new double[]{0,0.45914,0.59646  } ,
					new double[]{0.0019224,0.46368,0.58662  },
					new double[]{0.027932,0.46808,0.57693   },
					new double[]{0.054843,0.47236,0.56735   },
					new double[]{0.076598,0.47653,0.55785   },
					new double[]{0.095053,0.48062,0.54844   },
					new double[]{0.11106,0.48465,0.53907    },
					new double[]{0.12523,0.48865,0.52974    },
					new double[]{0.13795,0.49262,0.52042    },
					new double[]{0.14935,0.49658,0.5111     },
					new double[]{0.15962,0.50055,0.50179    },
					new double[]{0.169,0.50452,0.49245      },
					new double[]{0.17747,0.50849,0.48309    },
					new double[]{0.18517,0.51246,0.4737     },
					new double[]{0.19217,0.51645,0.46429    },
					new double[]{0.19856,0.52046,0.45483    },
					new double[]{0.20443,0.52448,0.44531    },
					new double[]{0.20974,0.52851,0.43577    },
					new double[]{0.21461,0.53255,0.42616    },
					new double[]{0.21905,0.53661,0.41651    },
					new double[]{0.22309,0.54066,0.40679    },
					new double[]{0.22674,0.54474,0.397      },
					new double[]{0.23002,0.54883,0.38713    },
					new double[]{0.233,0.55292,0.3772       },
					new double[]{0.23568,0.55703,0.36716    },
					new double[]{0.23802,0.56114,0.35704    },
					new double[]{0.24006,0.56526,0.34678    },
					new double[]{0.24185,0.56939,0.3364     },
					new double[]{0.24334,0.57354,0.32588    },
					new double[]{0.24458,0.57769,0.31523    },
					new double[]{0.24556,0.58185,0.30439    },
					new double[]{0.2463,0.58603,0.29336     },
					new double[]{0.2468,0.59019,0.28214     },
					new double[]{0.24707,0.59438,0.27067    },
					new double[]{0.24714,0.59856,0.25895    },
					new double[]{0.24704,0.60275,0.24696    },
					new double[]{0.24679,0.60693,0.23472    },
					new double[]{0.24648,0.61109,0.22215    },
					new double[]{0.24616,0.61523,0.20933    },
					new double[]{0.24597,0.61936,0.19628    },
					new double[]{0.24602,0.62342,0.18297    },
					new double[]{0.24648,0.62742,0.1696     },
					new double[]{0.24753,0.63135,0.15615    },
					new double[]{0.24931,0.63518,0.14276    },
					new double[]{0.25204,0.63889,0.12965    },
					new double[]{0.25579,0.64249,0.11693    },
					new double[]{0.2607,0.64593,0.10484     },
					new double[]{0.26674,0.64925,0.093668   },
					new double[]{0.2739,0.65241,0.083583    },
					new double[]{0.28205,0.65544,0.074764   },
					new double[]{0.29104,0.65834,0.067449   },
					new double[]{0.30071,0.66112,0.061598   },
					new double[]{0.31093,0.66382,0.057362   },
					new double[]{0.32147,0.66641,0.054542   },
					new double[]{0.33226,0.66895,0.052918   },
					new double[]{0.34314,0.67142,0.052293   },
					new double[]{0.35402,0.67386,0.052401   },
					new double[]{0.36487,0.67627,0.05303    },
					new double[]{0.37564,0.67864,0.054018   },
					new double[]{0.38629,0.681,0.055243     },
					new double[]{0.39683,0.68335,0.05664    },
					new double[]{0.40725,0.68569,0.057955   },
					new double[]{0.41755,0.68801,0.059542   },
					new double[]{0.42772,0.69031,0.060911   },
					new double[]{0.43777,0.69262,0.062454   },
					new double[]{0.4477,0.69491,0.063883    },
					new double[]{0.45755,0.69719,0.065334   },
					new double[]{0.46731,0.69947,0.066802   },
					new double[]{0.47698,0.70173,0.068291   },
					new double[]{0.48656,0.70399,0.069758   },
					new double[]{0.49607,0.70625,0.071211   },
					new double[]{0.50551,0.70848,0.072621   },
					new double[]{0.5149,0.71071,0.074107    },
					new double[]{0.52421,0.71293,0.07551    },
					new double[]{0.53346,0.71514,0.076938   },
					new double[]{0.54268,0.71735,0.078389   },
					new double[]{0.55183,0.71954,0.079862   },
					new double[]{0.56093,0.72172,0.08136    },
					new double[]{0.56998,0.7239,0.082779    },
					new double[]{0.57901,0.72607,0.084273   },
					new double[]{0.58797,0.72822,0.08563    },
					new double[]{0.59692,0.73037,0.08717    },
					new double[]{0.60581,0.73251,0.088583   },
					new double[]{0.61468,0.73464,0.09003    },
					new double[]{0.62353,0.73676,0.091506   },
					new double[]{0.63233,0.73887,0.092872   },
					new double[]{0.6411,0.74097,0.094388    },
					new double[]{0.64986,0.74307,0.095796   },
					new double[]{0.65858,0.74515,0.097234   },
					new double[]{0.66728,0.74722,0.098697   },
					new double[]{0.67595,0.74928,0.10013    },
					new double[]{0.6846,0.75135,0.10157     },
					new double[]{0.69324,0.75339,0.10305    },
					new double[]{0.70185,0.75543,0.10444    },
					new double[]{0.71045,0.75746,0.10594    },
					new double[]{0.71902,0.75947,0.10738    },
					new double[]{0.72758,0.76149,0.10881    },
					new double[]{0.73613,0.76349,0.1103     },
					new double[]{0.74466,0.76548,0.11173    },
					new double[]{0.75317,0.76746,0.1132     },
					new double[]{0.76167,0.76943,0.11457    },
					new double[]{0.77016,0.7714,0.11608     },
					new double[]{0.77864,0.77335,0.11749    },
					new double[]{0.78711,0.7753,0.11897     },
					new double[]{0.79556,0.77724,0.12038    },
					new double[]{0.80401,0.77916,0.12182    },
					new double[]{0.81244,0.78108,0.12327    },
					new double[]{0.82086,0.78299,0.12474    },
					new double[]{0.82929,0.78489,0.12623    },
					new double[]{0.83769,0.78678,0.12766    },
					new double[]{0.84609,0.78866,0.1291     },
					new double[]{0.8545,0.79053,0.1306      },
					new double[]{0.86289,0.79238,0.13203    },
					new double[]{0.87127,0.7942,0.13346     },
					new double[]{0.87964,0.79598,0.13491    },
					new double[]{0.88799,0.79771,0.13626    },
					new double[]{0.8963,0.79937,0.13769     },
					new double[]{0.90456,0.80091,0.13896    },
					new double[]{0.91273,0.80229,0.14021    },
					new double[]{0.92077,0.80347,0.14138    },
					new double[]{0.92863,0.80438,0.14238    },
					new double[]{0.93625,0.80495,0.14322    },
					new double[]{0.94355,0.80511,0.14385    },
					new double[]{0.95044,0.80481,0.14425    },
					new double[]{0.95686,0.80399,0.14437    },
					new double[]{0.96274,0.80262,0.14419    },
					new double[]{0.96803,0.80067,0.14372    },
					new double[]{0.9727,0.79816,0.14294     },
					new double[]{0.97674,0.79512,0.14188    },
					new double[]{0.9802,0.79159,0.14055     },
					new double[]{0.9831,0.78764,0.13895     },
					new double[]{0.98551,0.78333,0.13721    },
					new double[]{0.98751,0.77872,0.13526    },
					new double[]{0.98917,0.77389,0.13319    },
					new double[]{0.99056,0.76889,0.13103    },
					new double[]{0.99175,0.76376,0.12875    },
					new double[]{0.99279,0.75855,0.12647    },
					new double[]{0.99371,0.75327,0.1241     },
					new double[]{0.99455,0.74796,0.12173    },
					new double[]{0.99534,0.74261,0.11937    },
					new double[]{0.99608,0.73724,0.11697    },
					new double[]{0.99679,0.73185,0.11453    },
					new double[]{0.99748,0.72646,0.11217    },
					new double[]{0.99814,0.72104,0.10976    },
					new double[]{0.99879,0.71563,0.1073     },
					new double[]{0.99942,0.71019,0.1048     },
					new double[]{1,0.70475,0.10238   },
					new double[]{1,0.69929,0.099908  },
					new double[]{1,0.69382,0.09745   },
					new double[]{1,0.68834,0.095     },
					new double[]{1,0.68284,0.092452  },
					new double[]{1,0.67734,0.08996   },
					new double[]{1,0.6718,0.087465   },
					new double[]{1,0.66626,0.08489   },
					new double[]{1,0.66071,0.082364  },
					new double[]{1,0.65514,0.079729  },
					new double[]{1,0.64955,0.077118  },
					new double[]{1,0.64394,0.074554  },
					new double[]{1,0.63832,0.071927  },
					new double[]{1,0.63268,0.069347  },
					new double[]{1,0.62702,0.066593  },
					new double[]{1,0.62135,0.063895  },
					new double[]{1,0.61565,0.061104  },
					new double[]{1,0.60993,0.058355  },
					new double[]{1,0.6042,0.055584   },
					new double[]{1,0.59843,0.052708  },
					new double[]{1,0.59265,0.049893  },
					new double[]{1,0.58684,0.046988  },
					new double[]{1,0.58101,0.043966  },
					new double[]{1,0.57515,0.041014  },
					new double[]{1,0.56926,0.037943  },
					new double[]{1,0.56336,0.034887  },
					new double[]{1,0.55742,0.031822  },
					new double[]{1,0.55145,0.028972  },
					new double[]{1,0.54546,0.026194  },
					new double[]{1,0.53942,0.023487  },
					new double[]{1,0.53336,0.020851  },
					new double[]{1,0.52727,0.018287  },
					new double[]{1,0.52114,0.015792  },
					new double[]{1,0.51497,0.013362  },
					new double[]{1,0.50878,0.010828  },
					new double[]{1,0.50252,0.0085264 },
					new double[]{1,0.49623,0.0063082 },
					new double[]{1,0.48991,0.0041556 },
					new double[]{1,0.48353,0.0020694 },
					new double[]{1,0.47711,0.00004915},
					new double[]{1,0.47065,0} ,
					new double[]{1,0.46413,0},
					new double[]{1,0.45754,0},
					new double[]{1,0.45092,0},
					new double[]{1,0.44423,0},
					new double[]{1,0.43748,0},
					new double[]{1,0.43065,0},
					new double[]{1,0.42375,0},
					new double[]{1,0.4168,0 },
					new double[]{1,0.40976,0},
					new double[]{1,0.40263,0},
					new double[]{1,0.39544,0},
					new double[]{1,0.38813,0},
					new double[]{1,0.38075,0},
					new double[]{1,0.37324,0},
					new double[]{1,0.36564,0},
					new double[]{1,0.35792,0},
					new double[]{1,0.35006,0},
					new double[]{1,0.34208,0},
					new double[]{1,0.33395,0},
					new double[]{1,0.32564,0},
					new double[]{1,0.31719,0},
					new double[]{1,0.30856,0},
					new double[]{1,0.29971,0},
					new double[]{1,0.29063,0},
					new double[]{1,0.28132,0},
					new double[]{1,0.27173,0},
					new double[]{1,0.26187,0},
					new double[]{1,0.25167,0},
					new double[]{1,0.24106,0},
					new double[]{1,0.23001,0},
					new double[]{1,0.21851,0},
					new double[]{1,0.20642,0},
					new double[]{1,0.19361,0},
					new double[]{1,0.17996,0},
					new double[]{1,0.16528,0}
				};

			}
		}

	}
}

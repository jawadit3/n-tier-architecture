﻿using BussinessLogic.Requests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Requests.Posts
{
	public class CreatePostRequest
	{
		public String Name { get; set; }
	}

	public class CreatePostResponse : BaseResponse { }
}

﻿using Bitbucket.Cloud.Net.Models;

namespace Bitbucket.Cloud.Net.Common.Converters
{
	public static class HookEventSubjectTypeConverter
	{
		public static string ConvertToString(HookEventSubjectTypes value) => value.ToString().ToLowerInvariant();

		public static string ConvertToString(HookEventSubjectTypes? value) => value.HasValue
			? ConvertToString(value.Value)
			: null;
	}
}

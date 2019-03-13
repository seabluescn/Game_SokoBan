using System;

namespace SokoManMap
{
	/// <summary>
	/// �û��쳣
	/// </summary>
	public class UserException : System.Exception
	{
		private string m_ErrMsg = "";
		public string ErrorMessage
		{
			get
			{
				return m_ErrMsg;
			}
		}
		public UserException(string Error_Message)
		{	
			this.m_ErrMsg = Error_Message;
		}
        private UserException()
		{				
		}
	}
	
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class REST_Endpoint_Data_Source_DataType : INotifyPropertyChanged
	{
		private string rEST_EndpointField;

		private string user_IDField;

		private string passwordField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string REST_Endpoint
		{
			get
			{
				return this.rEST_EndpointField;
			}
			set
			{
				this.rEST_EndpointField = value;
				this.RaisePropertyChanged("REST_Endpoint");
			}
		}

		[XmlElement(Order = 1)]
		public string User_ID
		{
			get
			{
				return this.user_IDField;
			}
			set
			{
				this.user_IDField = value;
				this.RaisePropertyChanged("User_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
				this.RaisePropertyChanged("Password");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

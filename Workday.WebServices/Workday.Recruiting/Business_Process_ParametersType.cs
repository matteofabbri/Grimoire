using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_Process_ParametersType : INotifyPropertyChanged
	{
		private bool auto_CompleteField;

		private bool auto_CompleteFieldSpecified;

		private bool run_NowField;

		private bool run_NowFieldSpecified;

		private Business_Process_Comment_DataType comment_DataField;

		private Business_Process_Attachment_DataType[] business_Process_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Auto_Complete
		{
			get
			{
				return this.auto_CompleteField;
			}
			set
			{
				this.auto_CompleteField = value;
				this.RaisePropertyChanged("Auto_Complete");
			}
		}

		[XmlIgnore]
		public bool Auto_CompleteSpecified
		{
			get
			{
				return this.auto_CompleteFieldSpecified;
			}
			set
			{
				this.auto_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Auto_CompleteSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Run_Now
		{
			get
			{
				return this.run_NowField;
			}
			set
			{
				this.run_NowField = value;
				this.RaisePropertyChanged("Run_Now");
			}
		}

		[XmlIgnore]
		public bool Run_NowSpecified
		{
			get
			{
				return this.run_NowFieldSpecified;
			}
			set
			{
				this.run_NowFieldSpecified = value;
				this.RaisePropertyChanged("Run_NowSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Business_Process_Comment_DataType Comment_Data
		{
			get
			{
				return this.comment_DataField;
			}
			set
			{
				this.comment_DataField = value;
				this.RaisePropertyChanged("Comment_Data");
			}
		}

		[XmlElement("Business_Process_Attachment_Data", Order = 3)]
		public Business_Process_Attachment_DataType[] Business_Process_Attachment_Data
		{
			get
			{
				return this.business_Process_Attachment_DataField;
			}
			set
			{
				this.business_Process_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Process_Attachment_Data");
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

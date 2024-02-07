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
	public class Integration_Enterprise_Event_Records_DataType : INotifyPropertyChanged
	{
		private decimal total_RecordsField;

		private bool total_RecordsFieldSpecified;

		private decimal total_Records_UploadedField;

		private bool total_Records_UploadedFieldSpecified;

		private decimal total_Failed_RecordsField;

		private bool total_Failed_RecordsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Total_Records
		{
			get
			{
				return this.total_RecordsField;
			}
			set
			{
				this.total_RecordsField = value;
				this.RaisePropertyChanged("Total_Records");
			}
		}

		[XmlIgnore]
		public bool Total_RecordsSpecified
		{
			get
			{
				return this.total_RecordsFieldSpecified;
			}
			set
			{
				this.total_RecordsFieldSpecified = value;
				this.RaisePropertyChanged("Total_RecordsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Total_Records_Uploaded
		{
			get
			{
				return this.total_Records_UploadedField;
			}
			set
			{
				this.total_Records_UploadedField = value;
				this.RaisePropertyChanged("Total_Records_Uploaded");
			}
		}

		[XmlIgnore]
		public bool Total_Records_UploadedSpecified
		{
			get
			{
				return this.total_Records_UploadedFieldSpecified;
			}
			set
			{
				this.total_Records_UploadedFieldSpecified = value;
				this.RaisePropertyChanged("Total_Records_UploadedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Total_Failed_Records
		{
			get
			{
				return this.total_Failed_RecordsField;
			}
			set
			{
				this.total_Failed_RecordsField = value;
				this.RaisePropertyChanged("Total_Failed_Records");
			}
		}

		[XmlIgnore]
		public bool Total_Failed_RecordsSpecified
		{
			get
			{
				return this.total_Failed_RecordsFieldSpecified;
			}
			set
			{
				this.total_Failed_RecordsFieldSpecified = value;
				this.RaisePropertyChanged("Total_Failed_RecordsSpecified");
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

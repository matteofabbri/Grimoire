using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Credit_Card_Transaction_FileType : INotifyPropertyChanged
	{
		private Credit_Card_Transaction_FileObjectType credit_Card_Transaction_File_ReferenceField;

		private Credit_Card_Transaction_File_DataType[] credit_Card_Transaction_File_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Credit_Card_Transaction_FileObjectType Credit_Card_Transaction_File_Reference
		{
			get
			{
				return this.credit_Card_Transaction_File_ReferenceField;
			}
			set
			{
				this.credit_Card_Transaction_File_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_File_Reference");
			}
		}

		[XmlElement("Credit_Card_Transaction_File_Data", Order = 1)]
		public Credit_Card_Transaction_File_DataType[] Credit_Card_Transaction_File_Data
		{
			get
			{
				return this.credit_Card_Transaction_File_DataField;
			}
			set
			{
				this.credit_Card_Transaction_File_DataField = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_File_Data");
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

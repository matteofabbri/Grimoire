using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Holiday_Calendar_Event_DataType : INotifyPropertyChanged
	{
		private string nameField;

		private Start_End_DataType start_End_DataField;

		private Recurrence_DataType recurrence_DataField;

		private string idField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 1)]
		public Start_End_DataType Start_End_Data
		{
			get
			{
				return this.start_End_DataField;
			}
			set
			{
				this.start_End_DataField = value;
				this.RaisePropertyChanged("Start_End_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Recurrence_DataType Recurrence_Data
		{
			get
			{
				return this.recurrence_DataField;
			}
			set
			{
				this.recurrence_DataField = value;
				this.RaisePropertyChanged("Recurrence_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
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

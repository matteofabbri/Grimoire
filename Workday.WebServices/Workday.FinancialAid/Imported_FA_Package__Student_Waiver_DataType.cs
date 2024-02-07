using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Imported_FA_Package_-_Student_Waiver_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Imported_FA_Package__Student_Waiver_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Student_Waiver_ItemObjectType student_Waiver_Item_ReferenceField;

		private decimal waiver_AmountField;

		private bool waiver_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Student_Waiver_ItemObjectType Student_Waiver_Item_Reference
		{
			get
			{
				return this.student_Waiver_Item_ReferenceField;
			}
			set
			{
				this.student_Waiver_Item_ReferenceField = value;
				this.RaisePropertyChanged("Student_Waiver_Item_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Waiver_Amount
		{
			get
			{
				return this.waiver_AmountField;
			}
			set
			{
				this.waiver_AmountField = value;
				this.RaisePropertyChanged("Waiver_Amount");
			}
		}

		[XmlIgnore]
		public bool Waiver_AmountSpecified
		{
			get
			{
				return this.waiver_AmountFieldSpecified;
			}
			set
			{
				this.waiver_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Waiver_AmountSpecified");
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
